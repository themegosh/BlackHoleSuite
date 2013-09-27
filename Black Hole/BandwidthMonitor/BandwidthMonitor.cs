using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Black_Hole
{
    public partial class BandwidthMonitor
    {

        //Definitions
        private Thread bgWorkerBandwidthMonitor;
        private NetworkMonitor monitor = new NetworkMonitor();
        private double downspeed = 0.0;
        private double upspeed = 0.0;
        private double totalDown = 0.0;
        private double totalUp = 0.0;
        private System.Windows.Forms.Timer tmrBandwidthTimer = new System.Windows.Forms.Timer();
        private bool appClosing = false;
        private int timerInterval = 1000;

        #region Properties

        public bool IsRunning
        {
            get;
            private set;
        }
        
        public double CurrentDown
        {
            get;
            private set;
        }
        public double CurrentUp
        {
            get;
            private set;
        }

        public Totals_LogData LogData
        {
            get;
            private set;
        }

        #endregion

        public BandwidthMonitor()
        {
            //if were going to monitor the bandwidth, we need adapters to watch
            if (monitor.Adapters.Length == 0)
            {
                MessageBox.Show("Can't find any network adapters on this computer.", "Bandwidth Meter Failed.");
                return;
            }

            LoadData();

            bgWorkerBandwidthMonitor = new Thread(new ThreadStart(bgWorkerBandwidthMonitor_DoWork));
            bgWorkerBandwidthMonitor.IsBackground = false;
            bgWorkerBandwidthMonitor.Priority = ThreadPriority.AboveNormal;
            bgWorkerBandwidthMonitor.Start();
            Pause();
        }

        #region <Private functions>

        private void ElapsedTimer()
        {
            foreach (NetworkAdapter adapter in monitor.Adapters)
            {
                if (adapter.Enabled)
                    adapter.refresh();
            }

            downspeed = 0.0;
            upspeed = 0.0;
            foreach (NetworkAdapter adapter in monitor.Adapters)
            {
                if (adapter.Enabled)
                {
                    downspeed += adapter.DownloadSpeed(timerInterval);
                    upspeed += adapter.UploadSpeed(timerInterval);

                    if (downspeed < 0)
                        downspeed = 0;

                    if (upspeed < 0)
                        upspeed = 0;
                }
            }

            UpdateData(upspeed / (1024 / timerInterval), downspeed / (1024 / timerInterval));

            totalDown += downspeed / (1024 / timerInterval);
            totalUp += upspeed / (1024 / timerInterval);
        }

        private void UpdateData(double up, double down)
        {
            lock (LogData.date_uploads.SyncRoot)
            {
                lock (LogData.date_downloads.SyncRoot)
                {
                    string today = DateTime.Now.ToShortDateString();

                    if (!LogData.date_downloads.Contains(today))
                    {
                        LogData.date_downloads.Add(today, 0.0);
                        LogData.date_uploads.Add(today, 0.0);
                    }

                    LogData.date_uploads[today] = (double)LogData.date_uploads[today] + up;
                    LogData.date_downloads[today] = (double)LogData.date_downloads[today] + down;
                    LogData.counter_uploaded += up;
                    LogData.counter_downloaded += down;

                    CurrentDown = downspeed;
                    CurrentUp = upspeed;
                }
            }
        }

        private void bgWorkerBandwidthMonitor_DoWork()
        {
            while (!appClosing)
            {
                if (!IsRunning)
                    Thread.Sleep(timerInterval);

                ElapsedTimer();
                Thread.Sleep(timerInterval);
            }
        }

        #endregion

        #region <Public functions>

        public void PeriodToUsage(DateTime firstPeriod, DateTime secondPeriod, out double down, out double up, out double total)
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

            lock (LogData.date_uploads.SyncRoot)
            {
                lock (LogData.date_downloads.SyncRoot)
                {

                    foreach (string day in LogData.date_uploads.Keys) //through the days in logdata
                    {
                        if (DateTime.Parse(day).Date <= secondPeriod.Date && DateTime.Parse(day).Date >= firstPeriod.Date)
                        {
                            up += (double)LogData.date_uploads[day];
                            down += (double)LogData.date_downloads[day];
                        }
                    }
                    total = up + down;
                }
            }
        }

        public double GetTodaysUp()
        {
            lock (LogData.date_uploads.SyncRoot)
            {
                return (double)LogData.date_uploads[DateTime.Now.ToShortDateString()];
            }
        }
        public double GetTodaysDown()
        {
            lock (LogData.date_downloads.SyncRoot)
            {
                return (double)LogData.date_downloads[DateTime.Now.ToShortDateString()];
            }
        }

        public double GetAllTimeUp()
        {
            lock (LogData.date_uploads.SyncRoot)
            {
                return (double)LogData.counter_uploaded;
            }
        }

        public double GetAllTimeDown()
        {
            lock (LogData.date_downloads.SyncRoot)
            {
                return (double)LogData.counter_downloaded;
            }
        }

        public void Pause()
        {
            IsRunning = false;
            tmrBandwidthTimer.Stop();
        }

        public void Resume()
        {
            IsRunning = true;
            tmrBandwidthTimer.Start();
        }

        public void Exit()
        {
            appClosing = true;
            SaveData();
        }

        #endregion
    }
}
