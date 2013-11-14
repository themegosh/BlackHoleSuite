using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using BlackHoleLib;
using System.Reflection;
using System.ServiceProcess;

namespace BlackHoleClient
{
    public partial class frmMain : Form
    {
        private const string APP_NAME = "Black Hole Suite";
        private const string SHORT_DATE_FORMAT = "MM/dd/yyyy";
        private const string LONG_DATE_FORMAT = "dddd, MMMM d, yyyy";
        private const string SERVICE_NAME = "BlackHoleService";
        private const string SERVICE_FILE_NAME = "BlackHoleServer.exe";
        private readonly string APP_DIR = Assembly.GetExecutingAssembly().Location.Remove(Assembly.GetExecutingAssembly().Location.LastIndexOf('\\') + 1);

        //class vars
        private System.Windows.Forms.Timer tmrRapidRefresh; //timer for refreshing labels
        private System.Windows.Forms.Timer tmrSlowRefresh; //timer for refreshing heavy things like listviews
        private BandwidthLogData BWMLogData;
        private BandwidthMonitor bandwidthMonitor;
        private BlackHoleServiceManager BWMService;
       
        public frmMain()
        {
            InitializeComponent();
            BWMService = new BlackHoleServiceManager();

            //Timers
            tmrSlowRefresh = new System.Windows.Forms.Timer();
            tmrSlowRefresh.Interval = 10000; //10s
            tmrSlowRefresh.Tick += new EventHandler(SlowRefreshTimer_Tick);

            tmrRapidRefresh = new System.Windows.Forms.Timer();
            tmrRapidRefresh.Interval = 500; //0.5s
            tmrRapidRefresh.Tick += new EventHandler(RapidRefreshTimer_Tick);

            //fix the screen's positioning on resume/reopen
            if (!IsOnScreen(this))
                this.CenterToScreen();

            //begin processing
            tmrRapidRefresh.Start(); //do this here to prevent null exeptions of unset stuff
            tmrSlowRefresh.Start();

        }

        //this is basically OnClose()
        protected override void Dispose(bool disposing)
        {
            if (bandwidthMonitor != null)
                bandwidthMonitor.Quit();

            SaveConfig(); //save xml config

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Config

        private void LoadConfig()
        {
            try
            {
                string app_dir = Application.ExecutablePath;
                app_dir = app_dir.Remove(app_dir.LastIndexOf('\\'));

                XmlDocument xml_doc = new XmlDocument();
                xml_doc.Load(app_dir + "\\config.xml");

                Hashtable xml = new Hashtable();

                foreach (XmlNode node in xml_doc.DocumentElement.ChildNodes)
                    xml[node.Name] = node.InnerText;

                if (xml["BWMMonitorCurrentSpeeds"].ToString().ToLower() == "true")
                {
                    chkBWMCurrentSpeeds.Checked = true;
                }

                if (xml["BWMMonitorOnStart"].ToString().ToLower() == "true")
                {
                    chkBWMSettingsRunStartup.Checked = true;
                }
            }
            catch { }
        }

        private void SaveConfig()
        {
            string app_dir = Application.ExecutablePath;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\'));

            XmlTextWriter writer = new XmlTextWriter(app_dir + "\\config.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("settings");

            writer.WriteElementString("WindowIsVisible", Visible.ToString());
            writer.WriteElementString("BWMMonitorCurrentSpeeds", chkBWMCurrentSpeeds.Checked.ToString());
            writer.WriteElementString("BWMMonitorOnStart", chkBWMSettingsRunStartup.Checked.ToString());

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private void SetDefaultConfig()
        {

        }

        #endregion

        private bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Rectangle formRectangle = new Rectangle(form.Left, form.Top, form.Width, form.Height);

                if (screen.WorkingArea.Contains(formRectangle))
                {
                    return true;
                }
            }

            return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultConfig(); //set initial defaults
            LoadConfig(); //load config, if it exists

            InitializeBWMControls();

            //update the controls once before the timer refreshes
            RefreshBwmLight();
            RefreshBwmHeavy();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SlowRefreshTimer_Tick(Object sender, EventArgs e)
        {
            RefreshBwmHeavy();
        }
        
        private void RapidRefreshTimer_Tick(Object sender, EventArgs e)
        {
            RefreshBwmLight();
        }

        private void InitializeBWMControls()
        {
            //form control selections
            cmbBWMUnit.SelectedIndex = 0; //set the unit. smart = 0, bytes, kb, mb, gb
            cmbBWMUsagePeriod.SelectedIndex = 0; //set the usage period. today = 0, month, all, custom
            lbllblAnd.Visible = false;
            lbllblBetween.Visible = false;
            lbllblUsageFor.Visible = false;
            lblBWMPeriodDate.Visible = false;
            dtpBWMFirstTime.Visible = false;
            dtpBWMSecondTime.Visible = false;
            dtpBWMFirstTime.CustomFormat = SHORT_DATE_FORMAT; //format the custom time options, usage period
            dtpBWMSecondTime.CustomFormat = SHORT_DATE_FORMAT; //format the custom time options usage period
        }

        //this is run ever 0.5sec to update labels
        private void RefreshBwmLight()
        {
            string BWMServiceStatus = BWMService.GetStatus();

            if (BWMServiceStatus == "Running")
            {
                btnBWMStatusStart.Enabled = false;
                btnBWMStatusStop.Enabled = true;
            }
            else if (BWMServiceStatus == "Stopped")
            {
                btnBWMStatusStart.Enabled = true;
                btnBWMStatusStop.Enabled = false;
            }
            else
            {
                lblBWMStatusStatus.Text = "Not Installed";
                btnBWMStatusStart.Enabled = true;
                btnBWMStatusStop.Enabled = false;
            }

            if (chkBWMCurrentSpeeds.Checked)
            {
                lblDownloadSpeed.Text = BandwidthMonitor.BytesToUnit(bandwidthMonitor.SpeedDownload) + "/s";
                lblUploadSpeed.Text = BandwidthMonitor.BytesToUnit(bandwidthMonitor.SpeedUpload) + "/s";
            }
            else
            {
                lblDownloadSpeed.Text = "";
                lblUploadSpeed.Text = "";
            }
        }

        //this is ran every 2 sec to update labels/listviews
        private void RefreshBwmHeavy()
        {
            string today = DateTime.Now.ToString(SHORT_DATE_FORMAT);
            double down;
            double up;
            double total;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            BWMLogData = BandwidthMonitor.getFreshLogData();

            if (BWMLogData != null)
            {
                foreach (string date in BWMLogData.date_downloads.Keys)
                {
                    lblPeriodDown.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[date], cmbBWMUnit.Text);
                    lblPeriodUp.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[date], cmbBWMUnit.Text);
                    lblPeriodTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[date] + (double)BWMLogData.date_downloads[date], cmbBWMUnit.Text);
                    lblBWMPeriodDate.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                }

                //show Today's stats, if selected
                if (cmbBWMUsagePeriod.SelectedItem.ToString() == "Today")
                {
                    if (BWMLogData.date_downloads.ContainsKey(today))
                    {
                        lblPeriodDown.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[today], cmbBWMUnit.Text);
                        lblPeriodUp.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[today], cmbBWMUnit.Text);
                        lblPeriodTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[today] + (double)BWMLogData.date_downloads[today], cmbBWMUnit.Text);
                        lblBWMPeriodDate.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                    }
                    else
                    {
                        lblPeriodDown.Text = "Waiting...";
                        lblPeriodUp.Text = "Waiting...";
                        lblPeriodTotal.Text = "Waiting...";
                        lblBWMPeriodDate.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                    }
                }

                if (cmbBWMUsagePeriod.SelectedItem.ToString() == "This Month")
                {
                    BandwidthMonitor.PeriodToUsage(
                        BWMLogData,
                        new DateTime(year, month, 1),
                        new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                        out down,
                        out up,
                        out total);

                    lblPeriodDown.Text = BandwidthMonitor.BytesToUnit(down, "Smart");
                    lblPeriodUp.Text = BandwidthMonitor.BytesToUnit(up, "Smart");
                    lblPeriodTotal.Text = BandwidthMonitor.BytesToUnit(total, "Smart");
                    lblBWMPeriodDate.Text = DateTime.Now.ToString("MMMM, yyyy");
                }

                if (cmbBWMUsagePeriod.SelectedItem.ToString() == "All Time")
                {
                    lblPeriodDown.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_downloaded, cmbBWMUnit.Text);
                    lblPeriodUp.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_uploaded, cmbBWMUnit.Text);
                    lblPeriodTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_uploaded + (double)BWMLogData.counter_downloaded, cmbBWMUnit.Text);
                    lblBWMPeriodDate.Text = "All Time";
                }

                if (cmbBWMUsagePeriod.SelectedItem.ToString() == "Custom Period")
                {
                    dtpBWMFirstTime.Visible = true;
                    dtpBWMSecondTime.Visible = true;
                    lbllblAnd.Visible = true;
                    lbllblBetween.Visible = true;
                    lbllblUsageFor.Visible = false;
                    lblBWMPeriodDate.Visible = false;


                    BandwidthMonitor.PeriodToUsage(
                        BWMLogData,
                        dtpBWMFirstTime.Value,
                        dtpBWMSecondTime.Value,
                        out down,
                        out up,
                        out total);

                    lblPeriodDown.Text = BandwidthMonitor.BytesToUnit(down, "Smart");
                    lblPeriodUp.Text = BandwidthMonitor.BytesToUnit(up, "Smart");
                    lblPeriodTotal.Text = BandwidthMonitor.BytesToUnit(total, "Smart");
                    lblBWMPeriodDate.Text = DateTime.Now.ToString("MMMM, yyyy");
                }
                else
                {
                    dtpBWMFirstTime.Visible = false;
                    dtpBWMSecondTime.Visible = false;
                    lbllblAnd.Visible = false;
                    lbllblBetween.Visible = false;
                    lbllblUsageFor.Visible = true;
                    lblBWMPeriodDate.Visible = true;
                }

                PopulateTable(BWMLogData);
            }
        }

        private void PopulateTable(BandwidthLogData BWMLogData)
        {
            ListViewItem itemToAdd;
            ListViewItem[] tempItems;

            foreach (string period in BWMLogData.date_uploads.Keys)
            {
                tempItems = lstvDaytoDay.Items.Find(period, false);

                if (tempItems.Length != 0)
                {
                    itemToAdd = tempItems[0];
                    itemToAdd.Name = period;
                    itemToAdd.SubItems[0].Text = period;
                    itemToAdd.SubItems[1].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[period], cmbBWMUnit.Text);
                    itemToAdd.SubItems[2].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period], cmbBWMUnit.Text);
                    itemToAdd.SubItems[3].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period] + (double)BWMLogData.date_downloads[period], cmbBWMUnit.Text);
                }
                else
                {
                    itemToAdd = new ListViewItem();
                    itemToAdd.Name = period;
                    itemToAdd.Text = period;
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[period], cmbBWMUnit.Text));
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period], cmbBWMUnit.Text));
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period] + (double)BWMLogData.date_downloads[period], cmbBWMUnit.Text));

                    lstvDaytoDay.Items.Add(itemToAdd);
                }
            }

            lstvDaytoDay.Sorting = SortOrder.Descending;
            lstvDaytoDay.Sort();
            /*
            Hashtable period_up = new Hashtable();
            Hashtable period_down = new Hashtable();
            
            foreach (string day in bandwidthMonitor.LogData.date_uploads.Keys) //through the days in logdata
            {
                if (!period_up.Contains(day)) //if there isnt an entry, add a new one
                    period_up.Add(day, (double)bandwidthMonitor.LogData.date_uploads[day]);
                else //update existing entry
                    period_up[day] = (double)period_up[day] + (double)bandwidthMonitor.LogData.date_uploads[day];


                if (!period_down.Contains(day))//if there isnt an entry, add a new one
                    period_down.Add(day, (double)bandwidthMonitor.LogData.date_downloads[day]);
                else //update existing
                    period_down[day] = (double)period_down[day] + (double)bandwidthMonitor.LogData.date_downloads[day];

            }


            ListViewItem itemToAdd;
            ListViewItem[] tempItems;
            foreach (string period in period_up.Keys)
            {
                tempItems = lstvDaytoDay.Items.Find(period, false);

                if (tempItems.Length != 0)
                {
                    itemToAdd = tempItems[0];
                    itemToAdd.Name = period;
                    itemToAdd.SubItems[0].Text = period;
                    itemToAdd.SubItems[1].Text = bandwidthMonitor.BytesToUnit((double)period_down[period], cmbBWMUnit.Text);
                    itemToAdd.SubItems[2].Text = bandwidthMonitor.BytesToUnit((double)period_up[period], cmbBWMUnit.Text);
                    itemToAdd.SubItems[3].Text = bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cmbBWMUnit.Text);
                }
                else
                {
                    itemToAdd = new ListViewItem();
                    itemToAdd.Name = period;
                    itemToAdd.Text = period;
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_down[period], cmbBWMUnit.Text));
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_up[period], cmbBWMUnit.Text));
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cmbBWMUnit.Text));

                    lstvDaytoDay.Items.Add(itemToAdd);
                }
            }

            lstvDaytoDay.Sorting = SortOrder.Ascending;
            lstvDaytoDay.Sort();
            */
            /*
            lstvDaytoDay.Items.Clear();

            foreach (string period in period_up.Keys)
                lstvDaytoDay.Items.Add(new ListViewItem(new string[] { period, bandwidthMonitor.BytesToUnit((double)period_down[period], cmbBWMUnit.Text), bandwidthMonitor.BytesToUnit((double)period_up[period], cmbBWMUnit.Text), bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cmbBWMUnit.Text) }));
            */
        }

        

        private void btnClearSelectedDay_Click(object sender, EventArgs e)
        {
            /*if (lstvDaytoDay.FocusedItem == null)
            {
                MessageBox.Show("You have not selected a date to remove.\r\n\r\nSelect one from the \"Day to Day Bandwidth Usage Window\".", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string dateToRemove = lstvDaytoDay.Items[lstvDaytoDay.FocusedItem.Index].SubItems[0].Text;
                DialogResult confirmBox = MessageBox.Show("Are you sure you want to clear Data usage for " + DateTime.Parse(dateToRemove).ToString("dddd, MMMM d, yyyy") + "? This cannot be undone.", "Confirm to Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmBox == DialogResult.Yes)
                {
                    bandwidthMonitor.LogData.date_downloads.Remove(dateToRemove);
                    bandwidthMonitor.LogData.date_uploads.Remove(dateToRemove);
                    lstvDaytoDay.Items.RemoveAt(lstvDaytoDay.FocusedItem.Index);

                    //MessageBox.Show("Data records for  " + DateTime.Parse(lstvDaytoDay.Items[lstvDaytoDay.FocusedItem.Index].SubItems[0].Text).ToString("dddd, MMMM d, yyyy") + "  has been removed.");
                }
                
            }*/
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            /*DialogResult confirmBox = MessageBox.Show("Are you sure you want to clear ALL Data usage history from the beginning of time? This cannot be undone.", "Confirm to Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmBox == DialogResult.Yes)
            {
                bandwidthMonitor.LogData.date_downloads.Clear();
                bandwidthMonitor.LogData.date_uploads.Clear();
                bandwidthMonitor.LogData.counter_downloaded = 0;
                bandwidthMonitor.LogData.counter_uploaded = 0;
                lstvDaytoDay.Items.Clear();
            }*/
        }

        private void btnAboutVisitDMDev_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.dmdev.ca");
        }

        private void btnBWMStatusStart_Click(object sender, EventArgs e)
        {
            BWMService.Start();
        }

        
        private void btnBWMStatusStop_Click(object sender, EventArgs e)
        {
            BWMService.Stop();
        }

        private void chkBWMSettingsRunStartup_CheckedChanged(object sender, EventArgs e)
        {
            //set run on startup
            if (chkBWMSettingsRunStartup.Checked == true)
            {
                BWMService.SetAutomatic();
            }
            else
            {
                BWMService.SetManual();
            }
        }

        private void chkBWMCurrentSpeeds_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBWMCurrentSpeeds.Checked)
            {
                if (bandwidthMonitor == null)
                {
                    bandwidthMonitor = new BandwidthMonitor();
                    bandwidthMonitor.StartSpeedMonitoring();
                }
                else
                    bandwidthMonitor.ResumeSpeedMonitoring();
            }
            else
            {
                if (bandwidthMonitor != null)
                {
                    bandwidthMonitor.PauseSpeedMonitoring();
                }
            }
        }

        
    }
}
