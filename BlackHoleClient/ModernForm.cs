using System;
using System.Collections;
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
        private BandwidthLogData BWMLogData;
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
            //stop the service if its not supposed to run on startup
            if (!BlackHole.IsBWMAutoStart)
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
            cboSettingsBWMUnit.SelectedIndex = 0;
            cboBWMUsagePeriod.SelectedIndex = 0;

            //load settings from config
            togSettingsBWMDaily.Checked = BlackHole.IsBWMDailyUsage;
            togSettingsBWMOnStart.Checked = BlackHole.IsBWMAutoStart;
            togSettingsBWMSpeed.Checked = BlackHole.IsBWMSpeed;

            
            /*lbllblAnd.Visible = false;
            lbllblBetween.Visible = false;
            lbllblUsageFor.Visible = false;
            lblBWMUsagePeriod.Visible = false;
            dtpBWMFirstTime.Visible = false;
            dtpBWMSecondTime.Visible = false;
            dtpBWMFirstTime.CustomFormat = SHORT_DATE_FORMAT; //format the custom time options, usage period
            dtpBWMSecondTime.CustomFormat = SHORT_DATE_FORMAT; //format the custom time options usage period*/
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
                lblBWMSpeedDown.Text = BandwidthMonitor.BytesToUnit(bandwidthMonitor.SpeedDownload) + "/s";
                lblBWMSpeedUp.Text = BandwidthMonitor.BytesToUnit(bandwidthMonitor.SpeedUpload) + "/s";
            }
            else
            {
                lblBWMSpeedDown.Text = "";
                lblBWMSpeedUp.Text = "";
            }
        }

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
                    lblBWMUsageDownloaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[date], cboSettingsBWMUnit.Text);
                    lblBWMUsageUploaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[date], cboSettingsBWMUnit.Text);
                    lblBWMUsageTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[date] + (double)BWMLogData.date_downloads[date], cboSettingsBWMUnit.Text);
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString(LONG_DATE_FORMAT);
                }

                //show Today's stats, if selected
                if (cboBWMUsagePeriod.SelectedItem.ToString() == "Today")
                {
                    if (BWMLogData.date_downloads.ContainsKey(today))
                    {
                        lblBWMUsageDownloaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[today], cboSettingsBWMUnit.Text);
                        lblBWMUsageUploaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[today], cboSettingsBWMUnit.Text);
                        lblBWMUsageTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[today] + (double)BWMLogData.date_downloads[today], cboSettingsBWMUnit.Text);
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
                    BandwidthMonitor.PeriodToUsage(
                        BWMLogData,
                        new DateTime(year, month, 1),
                        new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                        out down,
                        out up,
                        out total);

                    lblBWMUsageDownloaded.Text = BandwidthMonitor.BytesToUnit(down);
                    lblBWMUsageUploaded.Text = BandwidthMonitor.BytesToUnit(up);
                    lblBWMUsageTotal.Text = BandwidthMonitor.BytesToUnit(total);
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }

                if (cboBWMUsagePeriod.SelectedItem.ToString() == "All Time")
                {
                    lblBWMUsageDownloaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_downloaded, cboSettingsBWMUnit.Text);
                    lblBWMUsageUploaded.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_uploaded, cboSettingsBWMUnit.Text);
                    lblBWMUsageTotal.Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.counter_uploaded + (double)BWMLogData.counter_downloaded, cboSettingsBWMUnit.Text);
                    lblBWMUsagePeriod.Text = "All Time";
                }

                if (cboBWMUsagePeriod.SelectedItem.ToString() == "Custom Period")
                {
                    dtpBWMUsageFrom.Visible = true;
                    dtpBWMUsageTo.Visible = true;
                    lblBWMUsageFromTitle.Visible = true;
                    lblBWMUsageToTitle.Visible = true;
                    lblBWMUsagePeriod.Visible = false;


                    BandwidthMonitor.PeriodToUsage(
                        BWMLogData,
                        dtpBWMUsageFrom.Value,
                        dtpBWMUsageTo.Value,
                        out down,
                        out up,
                        out total);

                    lblBWMUsageDownloaded.Text = BandwidthMonitor.BytesToUnit(down, "Smart");
                    lblBWMUsageUploaded.Text = BandwidthMonitor.BytesToUnit(up, "Smart");
                    lblBWMUsageTotal.Text = BandwidthMonitor.BytesToUnit(total, "Smart");
                    lblBWMUsagePeriod.Text = DateTime.Now.ToString("MMMM, yyyy");
                }
                else
                {
                    dtpBWMUsageFrom.Visible = false;
                    dtpBWMUsageTo.Visible = false;
                    lblBWMUsageFromTitle.Visible = false;
                    lblBWMUsageToTitle.Visible = false;
                    lblBWMUsagePeriod.Visible = true;
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
                tempItems = lstvBWMUsage.Items.Find(period, false);

                if (tempItems.Length != 0)
                {
                    itemToAdd = tempItems[0];
                    itemToAdd.Name = period;
                    itemToAdd.SubItems[0].Text = period;
                    itemToAdd.SubItems[1].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[period], cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[2].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period], cboSettingsBWMUnit.Text);
                    itemToAdd.SubItems[3].Text = BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period] + (double)BWMLogData.date_downloads[period], cboSettingsBWMUnit.Text);
                }
                else
                {
                    itemToAdd = new ListViewItem();
                    itemToAdd.Name = period;
                    itemToAdd.Text = period;
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_downloads[period], cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period], cboSettingsBWMUnit.Text));
                    itemToAdd.SubItems.Add(BandwidthMonitor.BytesToUnit((double)BWMLogData.date_uploads[period] + (double)BWMLogData.date_downloads[period], cboSettingsBWMUnit.Text));

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
            BlackHole.IsBWMSpeed = togSettingsBWMSpeed.Checked;

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
            BlackHole.IsBWMDailyUsage = togSettingsBWMDaily.Checked;

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
            BlackHole.IsBWMAutoStart = togSettingsBWMOnStart.Checked;

            if (togSettingsBWMOnStart.Checked == true) //run on start
                BWMService.SetAutomatic();
            else //do not run on start
                BWMService.SetManual();
        }

        delegate void derpp();

        private void btnSettingsBWMUninstallService_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(new Action(BWMService.UninstallService));
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

        
    }
}
