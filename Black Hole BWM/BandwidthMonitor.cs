using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;

namespace BlackHoleLib
{
    public class BandwidthMonitor
    {

        private const int REFRESH_BANDWIDTH_INTERVAL = 1000; // 1 sec
        private const int SAVE_FILE_INTERVAL = 20000; // 20 sec
        private const string BWM_FILE_NAME = "BandwidthMonitorRecords.xml";
        private readonly string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        private Thread bgWorkerBandwidthMonitor;
        private Thread bgWorkerSaveData;
        private Thread bgWorkerSpeedMonitor;
        private NetworkMonitor networkMonitor;
        private BandwidthLogData logData;
        private bool shouldQuitThreads;
        private bool isBWMRunning;
        private bool isSpeedMonitoringRunning;
        private double speedUpload;
        private double speedDownload;

        public double SpeedUpload
        {
            get { return speedUpload; }
        }

        public double SpeedDownload
        {
            get { return speedDownload; }
        }
        
        public BandwidthMonitor()
        {
            shouldQuitThreads = false;
            
            //nothing happens until we StartMonitoring/Logging
        }

        public void StartBandwidthLogging()
        {
            isBWMRunning = true;

            LoadData();

            bgWorkerBandwidthMonitor = new Thread(new ThreadStart(bgWorkerBandwidthMonitor_DoWork));
            bgWorkerBandwidthMonitor.IsBackground = false;
            bgWorkerBandwidthMonitor.Priority = ThreadPriority.AboveNormal;
            bgWorkerBandwidthMonitor.Start();

            bgWorkerSaveData = new Thread(new ThreadStart(bgWorkerSaveData_DoWork));
            bgWorkerSaveData.IsBackground = true;
            bgWorkerSaveData.Priority = ThreadPriority.Normal;
            bgWorkerSaveData.Start();
        }

        public void StartSpeedMonitoring()
        {
            isSpeedMonitoringRunning = true;

            bgWorkerSpeedMonitor = new Thread(new ThreadStart(bgWorkerSpeedMonitor_DoWork));
            bgWorkerSpeedMonitor.IsBackground = false;
            bgWorkerSpeedMonitor.Priority = ThreadPriority.AboveNormal;
            bgWorkerSpeedMonitor.Start();
        }

        public void PauseSpeedMonitoring()
        {
            isSpeedMonitoringRunning = false;
        }

        public void ResumeSpeedMonitoring()
        {
            isSpeedMonitoringRunning = true;
        }

        //program is exiting
        public void Quit()
        {
            shouldQuitThreads = true;

            if (isBWMRunning)
            {
                isBWMRunning = false;
                SaveData();
            }

            if (isSpeedMonitoringRunning)
                isSpeedMonitoringRunning = false;
        }

        public static BandwidthLogData getFreshLogData()
        {
            BandwidthLogData freshLog = new BandwidthLogData();

            string app_dir = System.Reflection.Assembly.GetExecutingAssembly().Location;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\') + 1);

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(BandwidthLogData));
                TextReader r = new StreamReader(app_dir + BWM_FILE_NAME);
                freshLog = (BandwidthLogData)s.Deserialize(r);
                r.Close();
            }
            catch { }

            return freshLog;
        }

        public static string BytesToUnit(double value, string unit = "Smart")
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


            String string_value = (value / div).ToString("0.00");

            return string_value.Replace(',', '.') + " " + unit;
        }


        public static void PeriodToUsage(BandwidthLogData tmpData, DateTime firstPeriod, DateTime secondPeriod, out double down, out double up, out double total)
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

            foreach (string day in tmpData.date_uploads.Keys) //through the days in logdata
            {
                if (DateTime.Parse(day).Date <= secondPeriod.Date && DateTime.Parse(day).Date >= firstPeriod.Date)
                {
                    up += (double)tmpData.date_uploads[day];
                    down += (double)tmpData.date_downloads[day];
                }
            }
            total = up + down;
        }

        private void bgWorkerSpeedMonitor_DoWork()
        {
            while (!shouldQuitThreads)
            {
                //dont do anything if paused
                if (!isSpeedMonitoringRunning)
                    Thread.Sleep(REFRESH_BANDWIDTH_INTERVAL);
                else
                {
                    if (networkMonitor == null)
                        networkMonitor = new NetworkMonitor(); //start the network monitor.

                    speedDownload = 0.0;
                    speedUpload = 0.0;

                    foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                    {
                        if (adapter.Enabled)
                            adapter.refresh();
                    }

                    foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                    {
                        if (adapter.Enabled)
                        {
                            speedDownload += adapter.DownloadSpeed(REFRESH_BANDWIDTH_INTERVAL);
                            speedUpload += adapter.UploadSpeed(REFRESH_BANDWIDTH_INTERVAL);

                            if (speedDownload < 0)
                                speedDownload = 0;

                            if (speedUpload < 0)
                                speedUpload = 0;
                        }
                    }
                    Thread.Sleep(REFRESH_BANDWIDTH_INTERVAL);
                }
            }
        }

        private void bgWorkerBandwidthMonitor_DoWork()
        {
            while (!shouldQuitThreads)
            {
                if (networkMonitor == null)
                    networkMonitor = new NetworkMonitor(); //start the network monitor.

                speedDownload = 0.0;
                speedUpload = 0.0;

                foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                {
                    if (adapter.Enabled)
                        adapter.refresh();
                }

                foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                {
                    if (adapter.Enabled)
                    {
                        speedDownload += adapter.DownloadSpeed(REFRESH_BANDWIDTH_INTERVAL);
                        speedUpload += adapter.UploadSpeed(REFRESH_BANDWIDTH_INTERVAL);

                        if (speedDownload < 0)
                            speedDownload = 0;

                        if (speedUpload < 0)
                            speedUpload = 0;
                    }
                }

                UpdateData(speedUpload / (1024 / REFRESH_BANDWIDTH_INTERVAL), speedDownload / (1024 / REFRESH_BANDWIDTH_INTERVAL));

                Thread.Sleep(REFRESH_BANDWIDTH_INTERVAL);
            }
        }

        private void UpdateData(double up, double down)
        {
            lock (logData.date_uploads.SyncRoot)
            {
                lock (logData.date_downloads.SyncRoot)
                {
                    string today = DateTime.Now.ToString("MM/dd/yyyy");

                    if (!logData.date_downloads.Contains(today))
                    {
                        logData.date_downloads.Add(today, 0.0);
                        logData.date_uploads.Add(today, 0.0);
                    }

                    logData.date_uploads[today] = (double)logData.date_uploads[today] + up;
                    logData.date_downloads[today] = (double)logData.date_downloads[today] + down;
                    logData.counter_uploaded += up;
                    logData.counter_downloaded += down;
                }
            }
        }

        private void bgWorkerSaveData_DoWork()
        {
            while (!shouldQuitThreads)
            {
                SaveData();
                Thread.Sleep(SAVE_FILE_INTERVAL);
            }
        }

        //this needs to be made thread safe.
        private void SaveData()
        {
            string app_dir = exePath;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\') + 1);

            XmlSerializer s = new XmlSerializer(typeof(BandwidthLogData));
            TextWriter w = new StreamWriter(app_dir + BWM_FILE_NAME);
            s.Serialize(w, logData);
            w.Close();
        }

        private void LoadData()
        {
            string app_dir = exePath;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\') + 1);

            if (logData == null)
                logData = new BandwidthLogData();

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(BandwidthLogData));
                TextReader r = new StreamReader(app_dir + BWM_FILE_NAME);
                logData = (BandwidthLogData)s.Deserialize(r);
                r.Close();
            }
            catch
            {
                logData = new BandwidthLogData();
            }

        }

        
    }
}
