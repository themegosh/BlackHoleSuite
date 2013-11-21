using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Data.SQLite;

namespace BlackHoleLib
{
    public class BandwidthMonitor
    {
        private const int DEFAULT_BWM_REFRESH_INTERVAL = 950;
        private const int SAVE_DB_INTERVAL = 15000; // 15 sec
        private const string BWM_FILE_NAME = "BandwidthMonitorRecords.xml";
        private const string DATE_SHORT_FORMAT = "MM/dd/yyyy";
        private const string TABLE_NAME = "daily_bandwidth";
        private readonly string APP_DIR = System.Reflection.Assembly.GetExecutingAssembly().Location.Remove(System.Reflection.Assembly.GetExecutingAssembly().Location.LastIndexOf('\\') + 1);

        private Thread bgWorkerBandwidthMonitor;
        private Thread bgWorkerSaveData;
        private Thread bgWorkerSpeedMonitor;
        private NetworkMonitor networkMonitor;
        private ConcurrentDictionary<string, Day> bandwidthData;
        private bool shouldQuitThreads;
        private bool isBWMRunning;
        private bool isSpeedMonitoringRunning;
        private double speedUpload;
        private double speedDownload;
        private int refreshBWMInterval;

        public int RefreshBWMInterval
        {
            get { return refreshBWMInterval; }
        }

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
            refreshBWMInterval = DEFAULT_BWM_REFRESH_INTERVAL;
            shouldQuitThreads = false;
        }

        public void StartBandwidthLogging()
        {
            isBWMRunning = true;
            bandwidthData = new ConcurrentDictionary<string, Day>();

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

        public static ConcurrentDictionary<string, Day> getFreshBandwidthData()
        {
            ConcurrentDictionary<string, Day> daysData = new ConcurrentDictionary<string, Day>();

            SQLiteConnection conn = bandwidthDB.OpenDB();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT day, up, down FROM " + TABLE_NAME + ";";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daysData.TryAdd(reader.GetString(0), new Day(reader.GetDouble(1), reader.GetDouble(2)));
            }

            conn.Close();

            return daysData;
        }

        private void bgWorkerSpeedMonitor_DoWork()
        {
            while (!shouldQuitThreads)
            {
                //dont do anything if paused
                if (!isSpeedMonitoringRunning)
                    Thread.Sleep(refreshBWMInterval);
                else
                {
                    if (networkMonitor == null)
                        networkMonitor = new NetworkMonitor(); //start the network monitor.

                    foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                    {
                        adapter.refresh();
                    }

                    speedDownload = 0.0;
                    speedUpload = 0.0;

                    foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                    {
                        speedDownload = adapter.DownloadSpeed(refreshBWMInterval);
                        speedUpload = adapter.UploadSpeed(refreshBWMInterval);

                        if (speedDownload < 0)
                            speedDownload = 0;

                        if (speedUpload < 0)
                            speedUpload = 0;
                    }
                    Thread.Sleep(refreshBWMInterval);
                }
            }
        }

        private void bgWorkerBandwidthMonitor_DoWork()
        {
            while (!shouldQuitThreads)
            {
                SaveData();

                Thread.Sleep(refreshBWMInterval);
            }
        }

        private void SaveData()
        {
            string curDate = DateTime.Now.ToString(DATE_SHORT_FORMAT);

            if (networkMonitor == null)
                networkMonitor = new NetworkMonitor(); //start the network monitor.

            foreach (NetworkAdapter adapter in networkMonitor.Adapters)
            {
                adapter.refresh();
            }

            speedDownload = 0.0;
            speedUpload = 0.0;

            foreach (NetworkAdapter adapter in networkMonitor.Adapters)
            {
                speedDownload = adapter.DownloadSpeed(refreshBWMInterval);
                speedUpload = adapter.UploadSpeed(refreshBWMInterval);

                if (speedDownload < 0)
                    speedDownload = 0;

                if (speedUpload < 0)
                    speedUpload = 0;
            }

            if (!bandwidthData.ContainsKey(curDate))
            {
                bandwidthData.TryAdd(curDate, new Day(speedUpload / (1024 / refreshBWMInterval), speedDownload / (1024 / refreshBWMInterval)));
            }
            else
            {
                bandwidthData[curDate].totalUp += speedUpload / (1024 / refreshBWMInterval);
                bandwidthData[curDate].totalDown += speedDownload / (1024 / refreshBWMInterval);
            }
        }

        private void bgWorkerSaveData_DoWork()
        {
            while (!shouldQuitThreads)
            {
                SQLiteConnection conn = bandwidthDB.OpenDB();
                SQLiteCommand cmd = conn.CreateCommand();

                foreach (string aDay in bandwidthData.Keys)
                {
                    cmd.CommandText = 
                        "INSERT OR REPLACE INTO " + TABLE_NAME + " (day, up, down) " +
                        "VALUES ( COALESCE((SELECT day FROM " + TABLE_NAME + " WHERE day = '" + aDay + "'), '" + aDay + "' )," +
                        bandwidthData[aDay].totalUp + "," +
                        bandwidthData[aDay].totalDown + ");";

                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                Thread.Sleep(SAVE_DB_INTERVAL);
            }
        }

        private void LoadData()
        {
            SQLiteConnection conn = bandwidthDB.OpenDB();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT day, up, down FROM " + TABLE_NAME + ";";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bandwidthData.TryAdd(reader.GetString(0), new Day(reader.GetDouble(1), reader.GetDouble(2)));
            }

            conn.Close();
        }

        private void CreateDB()
        {
            SQLiteConnection conn = bandwidthDB.OpenDB();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "CREATE TABLE " + TABLE_NAME + "(day TEXT PRIMARY KEY DESC, up INTEGER, down INTEGER)";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
