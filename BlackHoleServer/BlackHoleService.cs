using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using BlackHoleLib;

namespace BlackHoleServer
{
    public partial class BlackHoleService : ServiceBase
    {
        private BandwidthMonitor bandwidthMontior;

        public BlackHoleService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("BlackHoleServiceAlerts"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "BlackHoleServiceAlerts", "Black Hole Service Log");
            }
            eventLog.Source = "BlackHoleServiceAlerts";
            eventLog.Log = "Black Hole Service Log";
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                bandwidthMontior = new BandwidthMonitor();
                bandwidthMontior.StartBandwidthLogging();
            }
            catch (Exception ex)
            {
                eventLog.WriteEntry("BWM Exeption: \n\n " + ex.Message, EventLogEntryType.Error);
                Stop();
            }
        }

        protected override void OnStop()
        {
            bandwidthMontior.Quit();
        }

        public void recordEvent(string aMessage, EventLogEntryType entryType = EventLogEntryType.Information)
        {
            eventLog.WriteEntry(aMessage, entryType);
        }
    }
}
