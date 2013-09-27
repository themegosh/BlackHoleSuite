using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Black_Hole
{
    public partial class BandwidthMonitor
    {
        enum TimeSpan { Day = 0, Week = 1, Month = 2, Year = 3 };
        enum DownloadDirection { Upload, Download, Both };

        public class Day
        {
            [XmlAttribute("date")]
            public string date;

            [XmlAttribute("traffic")]
            public double traffic;
        }

        [XmlRoot("Totals")]
        public class Totals_LogData
        {
            [XmlIgnore]
            public Hashtable date_downloads;

            [XmlArray("downloads")]
            public Day[] TotalDownloads
            {
                get { return SerializeHash(date_downloads); }
                set { date_downloads = DeSerializeHash(value); }
            }

            [XmlIgnore]
            public Hashtable date_uploads;

            [XmlArray("uploads")]
            public Day[] TotalUploads
            {
                get { return SerializeHash(date_uploads); }
                set { date_uploads = DeSerializeHash(value); }
            }

            [XmlElement("counter_start_date")]
            public DateTime counter_date;

            [XmlElement("counter_uploaded")]
            public double counter_uploaded;

            [XmlElement("counter_downloaded")]
            public double counter_downloaded;

            public Totals_LogData()
            {
                date_downloads = new Hashtable();
                date_uploads = new Hashtable();
            }

            public Day[] SerializeHash(Hashtable hash)
            {
                Day[] serialized = new Day[hash.Count];

                int pos = 0;
                foreach (string key in hash.Keys)
                {
                    serialized[pos] = new Day();
                    serialized[pos].date = key;
                    serialized[pos].traffic = (double)hash[key];
                    pos++;
                }

                return serialized;
            }

            public Hashtable DeSerializeHash(Day[] hash)
            {
                Hashtable deserialized = new Hashtable();

                for (int i = 0; i < hash.Length; i++)
                    deserialized[hash[i].date] = (double)hash[i].traffic;

                return deserialized;
            }


        }

        public void SaveData()
        {
            string app_dir = Application.ExecutablePath;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\') + 1);

            XmlSerializer s = new XmlSerializer(typeof(Totals_LogData));
            TextWriter w = new StreamWriter(app_dir + "totals.xml");
            s.Serialize(w, LogData);
            w.Close();
        }

        private void LoadData()
        {
            string app_dir = Application.ExecutablePath;
            app_dir = app_dir.Remove(app_dir.LastIndexOf('\\') + 1);

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(Totals_LogData));
                TextReader r = new StreamReader(app_dir + "totals.xml");
                LogData = (Totals_LogData)s.Deserialize(r);
                r.Close();
            }
            catch
            {
                LogData = new Totals_LogData();
            }
            
        }

        

        public string BytesToUnit(double value, string unit, bool perSec = false)
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

            return string_value.Replace(',', '.') + " " + unit + (perSec ? "/s" : "");
        }

    }
}
