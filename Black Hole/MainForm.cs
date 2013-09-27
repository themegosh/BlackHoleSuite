using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using System.Diagnostics;

namespace Black_Hole
{
    public partial class frmMain : Form
    {
        //class vars
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private MenuItem trayMenuHiddenToggle;
        private System.Windows.Forms.Timer tmrformRefresh = new System.Windows.Forms.Timer(); //timer for refreshing labels
        private BandwidthMonitor bandwidthMonitor; //bandwidth monitor

        public frmMain()
        {
            InitializeComponent();

            bandwidthMonitor = new BandwidthMonitor(); //create the bandwidth monitor. not enabled until .start()

            CreateTrayIcon(); //create the tray icon
            SetDefaultConfig(); //set initial defaults
            LoadConfig(); //load config, if it exists

            if (!IsOnScreen(this))
                this.CenterToScreen();

            tmrformRefresh.Interval = 500; //ms
            tmrformRefresh.Tick += new EventHandler(RefreshTimer_Tick);

            cmbBWMUnit.SelectedIndex = 0; //set the unit. smart = 0, bytes, kb, mb, gb
            cmbUsagePeriod.SelectedIndex = 0; //set the usage period. today = 0, month, all, custom

            dtpFirstTime.CustomFormat = "MM/dd/yyyy"; //format the custom time options, usage period
            dtpSecondTime.CustomFormat = "MM/dd/yyyy"; //format the custom time options usage period

        }

        //this is basically OnClose()
        protected override void Dispose(bool disposing)
        {
            SaveConfig(); //save xml config

            bandwidthMonitor.Exit(); //pause/end threads, save totals

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tmrformRefresh.Start(); //do this here to prevent null exeptions of unset stuff

            //AppSpecificBandwidthForm frmAppSpecificBandwidth = new AppSpecificBandwidthForm();
            //frmAppSpecificBandwidth.Show();

            //enable the logger if we want...
            //ActivityLogger logger = new ActivityLogger();
            //logger.Start();
        }

        public bool IsOnScreen(Form form)
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

        private void OnExit(object sender, EventArgs e)
        {
            trayIcon.Visible = false; //fix dirty icon
            Environment.Exit(0);
        }

        private void CreateTrayIcon()
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayIcon = new NotifyIcon();

            trayMenuHiddenToggle = new MenuItem("Hidden", TrayWindowVisibility_Click);
            trayMenuHiddenToggle.Checked = mnuFileWindowHidden.Checked;
            trayMenu.MenuItems.Add(trayMenuHiddenToggle);
            trayMenu.MenuItems.Add("Exit", OnExit);

            //icon properties
            trayIcon.Text = "Black Hole Suite";
            trayIcon.Icon = new Icon(Properties.Resources.Blackhole_Icon, 40, 40);
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);
        }

        private void SetFormVisibility(bool isVisible)
        {
            if (isVisible)
            {
                mnuFileWindowHidden.Checked = false;
                trayMenuHiddenToggle.Checked = false;
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                Show();
            }
            else
            {
                mnuFileWindowHidden.Checked = true;
                trayMenuHiddenToggle.Checked = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Hide();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            SetFormVisibility(true);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveConfig();
            trayIcon.Visible = false; //fix dirty icon
        }

        private void mnuFileWindowHidden_Click(object sender, EventArgs e)
        {
            if (mnuFileWindowHidden.Checked)
                SetFormVisibility(false);
            else
                SetFormVisibility(true);
        }

        private void TrayWindowVisibility_Click(object sender, EventArgs e)
        {
            if (trayMenuHiddenToggle.Checked)
                SetFormVisibility(true);
            else
                SetFormVisibility(false);
        }

        private void RefreshTimer_Tick(Object sender, EventArgs e)
        {
            RefreshBWMVisuals();

            
        }

        private void RefreshBWMVisuals()
        {
            trayIcon.Text = "Black Hole Suite";

            string today = DateTime.Now.ToShortDateString();
            double down;
            double up;
            double total;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            if (cbEnableBandwidthMonitor.Checked)
            {
                if (!bandwidthMonitor.IsRunning)
                    bandwidthMonitor.Resume();

                lblDownloadSpeed.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.CurrentDown, "Smart", true);
                lblUploadSpeed.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.CurrentUp, "Smart", true);

                if (cmbUsagePeriod.SelectedItem.ToString() == "Today")
                {
                    lblPeriodDown.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetTodaysUp(), cmbBWMUnit.Text);
                    lblPeriodUp.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetTodaysDown(), cmbBWMUnit.Text);
                    lblPeriodTotal.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetTodaysUp() + bandwidthMonitor.GetTodaysDown(), cmbBWMUnit.Text);
                    lblActivePeriod.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
                }

                if (cmbUsagePeriod.SelectedItem.ToString() == "This Month")
                {
                    bandwidthMonitor.PeriodToUsage(
                        new DateTime(year, month, 1),
                        new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                        out down,
                        out up,
                        out total);

                    lblPeriodDown.Text = bandwidthMonitor.BytesToUnit(down, "Smart");
                    lblPeriodUp.Text = bandwidthMonitor.BytesToUnit(up, "Smart");
                    lblPeriodTotal.Text = bandwidthMonitor.BytesToUnit(total, "Smart");
                    lblActivePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }

                if (cmbUsagePeriod.SelectedItem.ToString() == "All Time")
                {
                    lblPeriodDown.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetAllTimeDown(), cmbBWMUnit.Text);
                    lblPeriodUp.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetAllTimeUp(), cmbBWMUnit.Text);
                    lblPeriodTotal.Text = bandwidthMonitor.BytesToUnit(bandwidthMonitor.GetAllTimeUp() + bandwidthMonitor.GetAllTimeDown(), cmbBWMUnit.Text);
                    lblActivePeriod.Text = "All Time";
                }

                if (cmbUsagePeriod.SelectedItem.ToString() == "Custom Period")
                {
                    dtpFirstTime.Visible = true;
                    dtpSecondTime.Visible = true;
                    lbllblAnd.Visible = true;
                    lbllblBetween.Visible = true;
                    lbllblUsageFor.Visible = false;
                    lblActivePeriod.Visible = false;


                    bandwidthMonitor.PeriodToUsage(
                        dtpFirstTime.Value,
                        dtpSecondTime.Value,
                        out down,
                        out up,
                        out total);

                    lblPeriodDown.Text = bandwidthMonitor.BytesToUnit(down, "Smart");
                    lblPeriodUp.Text = bandwidthMonitor.BytesToUnit(up, "Smart");
                    lblPeriodTotal.Text = bandwidthMonitor.BytesToUnit(total, "Smart");
                    lblActivePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }
                else
                {
                    dtpFirstTime.Visible = false;
                    dtpSecondTime.Visible = false;
                    lbllblAnd.Visible = false;
                    lbllblBetween.Visible = false;
                    lbllblUsageFor.Visible = true;
                    lblActivePeriod.Visible = true;
                }

                trayIcon.Text += "\r\nDown: " + bandwidthMonitor.BytesToUnit(bandwidthMonitor.CurrentDown, "Smart", true);
                trayIcon.Text += "\r\nUp: " + bandwidthMonitor.BytesToUnit(bandwidthMonitor.CurrentUp, "Smart", true);

                PopulateTable();
            }

            if (bandwidthMonitor.IsRunning)
                lblBandwidthStatus.Text = "Running";
            else
                lblBandwidthStatus.Text = "Stopped";
        }

        private void PopulateTable()
        {
            ListViewItem itemToAdd;
            ListViewItem[] tempItems;

            lock (bandwidthMonitor.LogData.date_uploads.SyncRoot)
            {
                lock (bandwidthMonitor.LogData.date_downloads.SyncRoot)
                {
                    foreach (string period in bandwidthMonitor.LogData.date_uploads.Keys)
                    {
                        tempItems = lstvDaytoDay.Items.Find(period, false);

                        if (tempItems.Length != 0)
                        {
                            itemToAdd = tempItems[0];
                            itemToAdd.Name = period;
                            itemToAdd.SubItems[0].Text = period;
                            itemToAdd.SubItems[1].Text = bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_downloads[period], cmbBWMUnit.Text);
                            itemToAdd.SubItems[2].Text = bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_uploads[period], cmbBWMUnit.Text);
                            itemToAdd.SubItems[3].Text = bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_uploads[period] + (double)bandwidthMonitor.LogData.date_downloads[period], cmbBWMUnit.Text);
                        }
                        else
                        {
                            itemToAdd = new ListViewItem();
                            itemToAdd.Name = period;
                            itemToAdd.Text = period;
                            itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_downloads[period], cmbBWMUnit.Text));
                            itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_uploads[period], cmbBWMUnit.Text));
                            itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)bandwidthMonitor.LogData.date_uploads[period] + (double)bandwidthMonitor.LogData.date_downloads[period], cmbBWMUnit.Text));

                            lstvDaytoDay.Items.Add(itemToAdd);
                        }
                    }
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

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            (new frmAbout()).ShowDialog();
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

                if (xml["BandwidthMonitorEnabled"].ToString().ToLower() == "true")
                {
                    cbEnableBandwidthMonitor.Checked = true;
                    panelBandwidthMonitor.Enabled = true;
                    bandwidthMonitor.Resume();
                }
                else
                {
                    cbEnableBandwidthMonitor.Checked = false;
                    panelBandwidthMonitor.Enabled = false;
                    bandwidthMonitor.Pause();
                }

                cbRunOnStartup.Checked = bool.Parse(xml["RunOnStartup"].ToString());
                SetRunOnStartup();

                if (xml["WindowIsVisible"].ToString().ToLower() == "false")
                {
                    //CenterToScreen();
                    mnuFileWindowHidden.Checked = true;
                    trayMenuHiddenToggle.Checked = true;
                    ShowInTaskbar = false;
                    WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
                else
                {
                    this.Show();
                    CenterToScreen();
                    mnuFileWindowHidden.Checked = false;
                    trayMenuHiddenToggle.Checked = false;
                    //MessageBox.Show("Showing Form...");
                }
            }
            catch
            {
            }
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
            writer.WriteElementString("BandwidthMonitorEnabled", cbEnableBandwidthMonitor.Checked.ToString());
            writer.WriteElementString("RunOnStartup", cbRunOnStartup.Checked.ToString());
            SetRunOnStartup();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        } 

        private void SetDefaultConfig()
        {
            mnuFileWindowHidden.Checked = false;
            trayMenuHiddenToggle.Checked = false;
            cbRunOnStartup.Checked = false;

            //BWM
            cbEnableBandwidthMonitor.Checked = false;
            panelBandwidthMonitor.Enabled = false;
        }

        private void SetRunOnStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (cbRunOnStartup.Checked)
                rk.SetValue("Black Hole", "\""+Application.ExecutablePath.ToString()+"\"");
            else
                rk.DeleteValue("Black Hole", false);
        }

        #endregion

        #region Bandwidth Monitor

        private void cbEnableBandwidthMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableBandwidthMonitor.Checked)
            {
                panelBandwidthMonitor.Enabled = true;
                bandwidthMonitor.Resume();
            }
            else
            {
                panelBandwidthMonitor.Enabled = false;
                bandwidthMonitor.Pause();
            }
        }

        #endregion

        private void cbRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            SetRunOnStartup();
        }

        private void btnClearSelectedDay_Click(object sender, EventArgs e)
        {
            if (lstvDaytoDay.FocusedItem == null)
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
                
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult confirmBox = MessageBox.Show("Are you sure you want to clear ALL Data usage history from the beginning of time? This cannot be undone.", "Confirm to Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmBox == DialogResult.Yes)
            {
                bandwidthMonitor.LogData.date_downloads.Clear();
                bandwidthMonitor.LogData.date_uploads.Clear();
                bandwidthMonitor.LogData.counter_downloaded = 0;
                bandwidthMonitor.LogData.counter_uploaded = 0;
                lstvDaytoDay.Items.Clear();
            }
        }
    }
}
