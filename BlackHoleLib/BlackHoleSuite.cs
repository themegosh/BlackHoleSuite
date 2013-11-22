using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using MetroFramework.Forms;

namespace BlackHoleLib
{
    public static class BlackHoleSuite
    {
        private static bool isBWMAutoStart;
        private static bool isBWMSpeed;
        private static bool isBWMDailyUsage;
        private static MetroFramework.MetroColorStyle formColour;

        public static bool IsBWMAutoStart
        {
            get
            {
                return isBWMAutoStart;
            }
            set
            {
                isBWMAutoStart = value;
            }
        }
        public static bool IsBWMSpeed
        {
            get
            {
                return isBWMSpeed;
            }
            set
            {
                isBWMSpeed = value;
            }
        }
        public static bool IsBWMDailyUsage
        {
            get
            {
                return isBWMDailyUsage;
            }
            set
            {
                isBWMDailyUsage = value;
            }
        }
        public static MetroFramework.MetroColorStyle FormColour
        {
            get
            {
                return formColour;
            }
            set
            {
                formColour = value;
            }
        }
        public static string APP_DIR
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().Location.Remove(System.Reflection.Assembly.GetExecutingAssembly().Location.LastIndexOf('\\'));
            }
        }

        public static void SetDefaultConfig()
        {
            isBWMSpeed = false;
            isBWMAutoStart = false;
            isBWMDailyUsage = false;
            formColour = MetroFramework.MetroColorStyle.Blue;
        }

        public static void LoadConfig()
        {
            try
            {
                SetDefaultConfig();

                XmlDocument xml_doc = new XmlDocument();
                xml_doc.Load(APP_DIR + "\\config.xml");

                Hashtable xml = new Hashtable();

                foreach (XmlNode node in xml_doc.DocumentElement.ChildNodes)
                    xml[node.Name] = node.InnerText;

                bool.TryParse(xml["isBWMSpeed"].ToString().ToLower(), out isBWMSpeed);
                bool.TryParse(xml["isBWMAutoStart"].ToString().ToLower(), out isBWMAutoStart);
                bool.TryParse(xml["isBWMDailyUsage"].ToString().ToLower(), out isBWMDailyUsage);
                Enum.TryParse<MetroFramework.MetroColorStyle>(xml["formColour"].ToString(), out formColour);
            }
            catch { }
        }

        public static void SaveConfig()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(APP_DIR + "\\config.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("settings");

                writer.WriteElementString("isBWMSpeed", isBWMSpeed.ToString());
                writer.WriteElementString("isBWMAutoStart", isBWMAutoStart.ToString());
                writer.WriteElementString("isBWMDailyUsage", isBWMDailyUsage.ToString());
                writer.WriteElementString("formColour", formColour.ToString());

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch { }
        }
    }
}
