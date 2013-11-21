using System;
using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Reflection;
using BlackHoleLib;
using System.Xml;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace BlackHoleClient
{
    public partial class frmModern : MetroForm
    {
        private const string APP_NAME = "Black Hole Suite";
        private const string SHORT_DATE_FORMAT = "MM/dd/yyyy";
        private const string LONG_DATE_FORMAT = "dddd, MMMM d, yyyy";

        private System.Windows.Forms.Timer tmrRapidRefresh; //timer for refreshing labels
        private System.Windows.Forms.Timer tmrSlowRefresh; //timer for refreshing heavy things like listviews
        private BandwidthMonitor bandwidthMonitor;
        private BlackHoleServiceManager BWMService;

        public frmModern()
        {
            InitializeComponent();

            BWMService = new BlackHoleServiceManager();
            InitializeBWMControls();

            //Timers
            tmrSlowRefresh = new System.Windows.Forms.Timer();
            tmrSlowRefresh.Interval = 10000; //10s
            tmrSlowRefresh.Tick += new EventHandler(SlowRefreshTimer_Tick);
            tmrSlowRefresh.Start();

            tmrRapidRefresh = new System.Windows.Forms.Timer();
            tmrRapidRefresh.Interval = 500; //0.5s
            tmrRapidRefresh.Tick += new EventHandler(RapidRefreshTimer_Tick);
            tmrRapidRefresh.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (!BlackHoleSuite.IsBWMAutoStart)
                BWMService.Stop();

            if (bandwidthMonitor != null)
                bandwidthMonitor.Quit();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeBWMControls()
        {
            tcMainTabs.SelectedIndex = 0;
            tcSettings.SelectedIndex = 0;
            cboSettingsBWMUnit.SelectedIndex = 0;
            cboBWMUsagePeriod.SelectedIndex = 0;

            //load settings from config
            togSettingsBWMDaily.Checked = BlackHoleSuite.IsBWMDailyUsage;
            togSettingsBWMOnStart.Checked = BlackHoleSuite.IsBWMAutoStart;
            togSettingsBWMSpeed.Checked = BlackHoleSuite.IsBWMSpeed;
            dtpBWMUsageFrom.CustomFormat = SHORT_DATE_FORMAT;
            dtpBWMUsageTo.CustomFormat = SHORT_DATE_FORMAT;

            if (!BWMService.IsInstalled)
                btnSettingsBWMUninstallService.Enabled = false;
        }

        private void SlowRefreshTimer_Tick(Object sender, EventArgs e)
        {
            RefreshBwmHeavy();
        }

        private void RapidRefreshTimer_Tick(Object sender, EventArgs e)
        {
            RefreshBwmLight();
        }

        private void RefreshBwmLight()
        {
            if (togSettingsBWMSpeed.Checked)
            {
                lblBWMSpeedDown.Text = BytesToUnit(bandwidthMonitor.SpeedDownload) + "/s";
                lblBWMSpeedUp.Text = BytesToUnit(bandwidthMonitor.SpeedUpload) + "/s";
            }
            else
            {
                lblBWMSpeedDown.Text = "";
                lblBWMSpeedUp.Text = "";
            }
        }

        private void RefreshBwmHeavy()
        {
            //test service uninstall (this is pretty heavy)
            if (!btnSettingsBWMUninstallService.Enabled)
                if (BWMService.IsInstalled)
                    btnSettingsBWMUninstallService.Enabled = true;

            string today = DateTime.Now.ToString(SHORT_DATE_FORMAT);
            double down = 0;
            double up = 0;
            double total = 0;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            ConcurrentDictionary<string, BlackHoleLib.Day> daysData = BandwidthMonitor.getFreshBandwidthData();

            if (daysData.Count > 0)
            {
                foreach (string date in daysData.Keys)
                {
                    lblBWMUsageDownloaded.Text = BytesToUnit(daysData[date].totalDown, cboSettingsBWMUnit.Text);
                    lblBWMUsageUploaded.Text = BytesToUnit(daysData[date].totalUp, cboSettingsBWMUnit.Text);
                    lblBWMUsageTotal.Text = BytesToUnit(daysData[date].totalDown + daysData[date].totalUp, cboSettingsBWMUnit.Text);
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                }

                //show Today's stats, if selected
                if (cboBWMUsagePeriod.SelectedItem.ToString() == "Today")
                {
                    if (daysData.ContainsKey(today))
                    {
                        lblBWMUsageDownloaded.Text = BytesToUnit(daysData[today].totalDown, cboSettingsBWMUnit.Text);
                        lblBWMUsageUploaded.Text = BytesToUnit(daysData[today].totalUp, cboSettingsBWMUnit.Text);
                        lblBWMUsageTotal.Text = BytesToUnit(daysData[today].totalDown + daysData[today].totalUp, cboSettingsBWMUnit.Text);
                        lblBWMUsagePeriod.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                    }
                    else
                    {
                        lblBWMUsageDownloaded.Text = "No Data";
                        lblBWMUsageUploaded.Text = "No Data";
                        lblBWMUsageTotal.Text = "No Data";
                        lblBWMUsagePeriod.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                    }
                }

                if (cboBWMUsagePeriod.SelectedItem.ToString() == "This Month")
                {
                    PeriodToUsage(
                        daysData,
                        new DateTime(year, month, 1),
                        new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                        out down,
                        out up,
                        out total);

                    lblBWMUsageDownloaded.Text = BytesToUnit(down, cboSettingsBWMUnit.Text);
                    lblBWMUsageUploaded.Text = BytesToUnit(up, cboSettingsBWMUnit.Text);
                    lblBWMUsageTotal.Text = BytesToUnit(total, cboSettingsBWMUnit.Text);
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }

                if (cboBWMUsagePeriod.SelectedItem.ToString() == "All Time")
                {

                    foreach (string day in daysData.Keys)
                    {
                        down += daysData[day].totalDown;
                        up += daysData[day].totalUp;
                        total += daysData[day].totalDown + daysData[day].totalUp;
                    }

                    lblBWMUsageDownloaded.Text = BytesToUnit(down, cboSettingsBWMUnit.Text);
                    lblBWMUsageUploaded.Text = BytesToUnit(up, cboSettingsBWMUnit.Text);
                    lblBWMUsageTotal.Text = BytesToUnit(total, cboSettingsBWMUnit.Text);
                    lblBWMUsagePeriod.Text = "All Time";
                }

                if (cboBWMUsagePeriod.SelectedItem.ToString() == "Custom Period")
                {
                    dtpBWMUsageFrom.Visible = true;
                    dtpBWMUsageTo.Visible = true;
                    lblBWMUsageToTitle.Visible = true;
                    lblBWMUsagePeriod.Visible = false;


                    PeriodToUsage(
                        daysData,
                        dtpBWMUsageFrom.Value,
                        dtpBWMUsageTo.Value,
                        out down,
                        out up,
                        out total);

                    lblBWMUsageDownloaded.Text = BytesToUnit(down, "Smart");
                    lblBWMUsageUploaded.Text = BytesToUnit(up, "Smart");
                    lblBWMUsageTotal.Text = BytesToUnit(total, "Smart");
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }
                else
                {
                    dtpBWMUsageFrom.Visible = false;
                    dtpBWMUsageTo.Visible = false;
                    lblBWMUsageToTitle.Visible = false;
                    lblBWMUsagePeriod.Visible = true;
                }

                PopulateTable(daysData);
            }
        }

        private void PopulateTable(ConcurrentDictionary<string, BlackHoleLib.Day> daysData)
        {
            ListViewItem itemToAdd;
            ListViewItem[] tempItems;

            foreach (string period in daysData.Keys)
            {
                tempItems = lstvBWMUsage.Items.Find(period, false);

                if (tempItems.Length != 0)
                {
                    itemToAdd = tempItems[0];
                    itemToAdd.Name = period;
                    itemToAdd.SubItems[0].Text = period;
                    itemToAdd.SubItems[1].Text = BytesToUnit(daysData[period].totalDown, cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[2].Text = BytesToUnit(daysData[period].totalUp, cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[3].Text = BytesToUnit(daysData[period].totalDown + daysData[period].totalUp, cboSettingsBWMUnit.Text);
                }
                else
                {
                    itemToAdd = new ListViewItem();
                    itemToAdd.Name = period;
                    itemToAdd.Text = period;
                    itemToAdd.SubItems.Add(BytesToUnit(daysData[period].totalDown, cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(BytesToUnit(daysData[period].totalUp, cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(BytesToUnit(daysData[period].totalDown + daysData[period].totalUp, cboSettingsBWMUnit.Text));

                    lstvBWMUsage.Items.Add(itemToAdd);
                }
            }

            lstvBWMUsage.Sorting = SortOrder.Descending;
            lstvBWMUsage.Sort();
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
                tempItems = lstvBWMUsage.Items.Find(period, false);

                if (tempItems.Length != 0)
                {
                    itemToAdd = tempItems[0];
                    itemToAdd.Name = period;
                    itemToAdd.SubItems[0].Text = period;
                    itemToAdd.SubItems[1].Text = bandwidthMonitor.BytesToUnit((double)period_down[period], cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[2].Text = bandwidthMonitor.BytesToUnit((double)period_up[period], cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[3].Text = bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cboSettingsBWMUnit.Text);
                }
                else
                {
                    itemToAdd = new ListViewItem();
                    itemToAdd.Name = period;
                    itemToAdd.Text = period;
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_down[period], cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_up[period], cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cboSettingsBWMUnit.Text));

                    lstvBWMUsage.Items.Add(itemToAdd);
                }
            }

            lstvBWMUsage.Sorting = SortOrder.Ascending;
            lstvBWMUsage.Sort();
            */
            /*
            lstvBWMUsage.Items.Clear();

            foreach (string period in period_up.Keys)
                lstvBWMUsage.Items.Add(new ListViewItem(new string[] { period, bandwidthMonitor.BytesToUnit((double)period_down[period], cboSettingsBWMUnit.Text), bandwidthMonitor.BytesToUnit((double)period_up[period], cboSettingsBWMUnit.Text), bandwidthMonitor.BytesToUnit((double)period_up[period] + (double)period_down[period], cboSettingsBWMUnit.Text) }));
            */
        }

        private void frmModern_Load(object sender, EventArgs e)
        {
            //update the controls once before the timer refreshes
            RefreshBwmLight();
            RefreshBwmHeavy();
        }

        private void btnAboutDeveloperSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.dmdev.ca/work.php#blackhole");
        }

        private void btnAboutGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/themegosh/BlackHoleSuite");
        }

        private void togSettingsBWMSpeed_CheckedChanged(object sender, EventArgs e)
        {
            BlackHoleSuite.IsBWMSpeed = togSettingsBWMSpeed.Checked;

            if (togSettingsBWMSpeed.Checked)
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
            RefreshBwmLight();
        }

        private void togSettingsBWMDaily_CheckedChanged(object sender, EventArgs e)
        {
            BlackHoleSuite.IsBWMDailyUsage = togSettingsBWMDaily.Checked;

            if (togSettingsBWMDaily.Checked)
            {
                BWMService.Start();

                if (togSettingsBWMOnStart.Checked == true) //run on start
                {
                    BWMService.SetAutomatic();
                }
                else //do not run on start
                {
                    BWMService.SetManual();
                }
            }
            else
                BWMService.Stop();
        }

        private void togSettingsBWMOnStart_CheckedChanged(object sender, EventArgs e)
        {
            BlackHoleSuite.IsBWMAutoStart = togSettingsBWMOnStart.Checked;

            if (togSettingsBWMOnStart.Checked == true) //run on start
                BWMService.SetAutomatic();
            else //do not run on start
                BWMService.SetManual();
        }

        private void cboSettingsBWMUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshBwmLight();
        }

        private void cboBWMUsagePeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshBwmHeavy();
        }

        private void dtpBWMUsageFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshBwmHeavy();
        }

        public string BytesToUnit(double value, string unit = "Smart")
        {
            double div = 1;

            if (unit == "Smart")
            {
                if (value < 1024)
                    unit = " B";
                else if (value < 1024 * 1024)
                    unit = "KB";
                else if (value < 1024 * 1024 * 1024)
                    unit = "MB";
                else
                    unit = "GB";
            }

            if (unit == " B")
                div = 1;
            else if (unit == "KB")
                div = 1024;
            else if (unit == "MB")
                div = 1024 * 1024;
            else if (unit == "GB")
                div = 1024 * 1024 * 1024;


            String string_value = (value / div).ToString("0.##");

            return string_value.Replace(',', '.') + " " + unit;
        }

        public void PeriodToUsage(ConcurrentDictionary<string, BlackHoleLib.Day> tmpData, DateTime firstPeriod, DateTime secondPeriod, out double down, out double up, out double total)
        {
            down = 0;
            up = 0;
            total = 0;

            if (firstPeriod.Date > secondPeriod.Date) //firstdate should be smaller. If not, swap them so it is
            {
                DateTime tempDate = firstPeriod;

                firstPeriod = secondPeriod;
                secondPeriod = tempDate;
            }

            foreach (string day in tmpData.Keys) //through the days in logdata
            {
                if (DateTime.Parse(day).Date <= secondPeriod.Date && DateTime.Parse(day).Date >= firstPeriod.Date)
                {
                    up += tmpData[day].totalUp;
                    down += tmpData[day].totalDown;
                }
            }
            total = up + down;
        }

        private void btnSettingsBWMUninstallService_Click_1(object sender, EventArgs e)
        {
            Task.Factory.StartNew(new Action(BWMService.UninstallService));
            btnSettingsBWMUninstallService.Enabled = false;
            togSettingsBWMDaily.Checked = false;
            togSettingsBWMOnStart.Checked = false;
        }
    }
}
