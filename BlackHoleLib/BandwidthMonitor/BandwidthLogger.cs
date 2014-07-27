using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SQLite;

namespace BlackHoleLib
{
    public class BandwidthLogger
    {
        private const int NETWORK_MONITOR_REFRESH = 500;
        private const int SAVE_DB_INTERVAL = 15000; // 15 sec
        private const string DATE_SHORT_FORMAT = "MM'/'dd'/'yyyy";
        private const string TABLE_NAME = "daily_bandwidth";

        private Thread bgWorkerBandwidthMonitor;
        private Thread bgWorkerSaveData;
        private NetworkMonitor networkMonitor;
        private ConcurrentDictionary<string, DayLog> bandwidthData;
        private bool shouldQuitThreads;
        private bool isBWMRunning;
        double speedDown = 0;
        double speedUp = 0;

        public BandwidthLogger()
        {
            shouldQuitThreads = false;
        }

        ~BandwidthLogger()
        {
            if (isBWMRunning)
                SaveToDB();
        }

        public void StartBandwidthLogging()
        {
            isBWMRunning = true;
            networkMonitor = new NetworkMonitor(NETWORK_MONITOR_REFRESH);
            networkMonitor.StartMonitoring();

            bandwidthData = new ConcurrentDictionary<string, DayLog>();

            CreateDB();
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

        //program is exiting
        public void Quit()
        {
            shouldQuitThreads = true;

            if (isBWMRunning)
            {
                isBWMRunning = false;
            }
        }

        public static ConcurrentDictionary<string, DayLog> getFreshBandwidthData()
        {
            ConcurrentDictionary<string, DayLog> daysData = new ConcurrentDictionary<string, DayLog>();

            try
            {
                //try creating the DB first
                SQLiteConnection conn = Database.OpenDB();
                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " (day TEXT PRIMARY KEY DESC, up INTEGER, down INTEGER)";
                cmd.ExecuteNonQuery();


                SQLiteCommand cmd2 = conn.CreateCommand();

                cmd2.CommandText = "SELECT day, up, down FROM " + TABLE_NAME + ";";
                SQLiteDataReader reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    daysData.TryAdd(reader.GetString(0), new DayLog(reader.GetDouble(1), reader.GetDouble(2)));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return daysData;
        }

        private void bgWorkerBandwidthMonitor_DoWork()
        {
            while (!shouldQuitThreads)
            {
                string curDate = DateTime.Now.ToString(DATE_SHORT_FORMAT);

                speedDown = 0;
                speedUp = 0;

                foreach (NetworkAdapter adapter in networkMonitor.Adapters)
                {
                    speedDown += adapter.DownloadSpeed;
                    speedUp += adapter.UploadSpeed;
                }

                if (!bandwidthData.ContainsKey(curDate))
                {
                    bandwidthData.TryAdd(curDate, new DayLog(speedUp / (1024 / NETWORK_MONITOR_REFRESH), speedDown / (1024 / NETWORK_MONITOR_REFRESH)));
                }
                else
                {
                    bandwidthData[curDate].totalUp += speedUp / (1024 / NETWORK_MONITOR_REFRESH);
                    bandwidthData[curDate].totalDown += speedDown / (1024 / NETWORK_MONITOR_REFRESH);
                }

                Thread.Sleep(NETWORK_MONITOR_REFRESH);
            }
        }

        private void bgWorkerSaveData_DoWork()
        {
            while (!shouldQuitThreads)
            {
                SaveToDB();

                Thread.Sleep(SAVE_DB_INTERVAL);
            }
        }

        private void SaveToDB()
        {
            try
            {
                SQLiteConnection conn = Database.OpenDB();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadData()
        {
            try
            {
                SQLiteConnection conn = Database.OpenDB();
                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT day, up, down FROM " + TABLE_NAME + ";";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bandwidthData.TryAdd(reader.GetString(0), new DayLog(reader.GetDouble(1), reader.GetDouble(2)));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateDB()
        {
            try
            {
                SQLiteConnection conn = Database.OpenDB();
                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + "(day TEXT PRIMARY KEY DESC, up INTEGER, down INTEGER)";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

    }
}
