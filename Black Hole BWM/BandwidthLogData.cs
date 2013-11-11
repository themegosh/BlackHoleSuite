using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;

namespace BlackHoleLib
{
    public class Day
    {
        [XmlAttribute("date")]
        public string date;

        [XmlAttribute("traffic")]
        public double traffic;
    }

    [XmlRoot("Totals")]
    public class BandwidthLogData
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

        public BandwidthLogData()
        {
            date_downloads = new Hashtable();
            date_uploads = new Hashtable();
            counter_date = DateTime.Now;
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
}
