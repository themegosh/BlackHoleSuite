using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Black_Hole
{
    class NetworkTraffic
    {
        private PerformanceCounter bytesSentPerformanceCounter;
        private PerformanceCounter bytesReceivedPerformanceCounter;
        private int pid;
        private bool countersInitialized;

        public NetworkTraffic(int processID)
        {
            pid = processID;
            TryToInitializeCounters();
        }

        /*private static string GetProcessInstanceName(int pid)
        {
            PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");

            string[] instances = cat.GetInstanceNames();
            foreach (string instance in instances)
            {

                using (PerformanceCounter cnt = new PerformanceCounter("Process",
                     "ID Process", instance, true))
                {
                    int val = (int)cnt.RawValue;
                    if (val == pid)
                    {
                        return instance;
                    }
                }
            }
            throw new Exception("Could not find performance counter " +
                "instance name for current process. This is truly strange ...");
        }*/

        private void TryToInitializeCounters()
        {
            if (!countersInitialized)
            {
                bytesSentPerformanceCounter = new PerformanceCounter(".NET CLR Networking 4.0.0.0", "Bytes Sent", GetInstanceName(pid), true);

                bytesReceivedPerformanceCounter = new PerformanceCounter(".NET CLR Networking 4.0.0.0", "Bytes Received", GetInstanceName(pid), true);

                countersInitialized = true;
            }
        }

        public float GetBytesSent()
        {
            float bytesSent = 0;

            try
            {
                TryToInitializeCounters();
                bytesSent = bytesSentPerformanceCounter.RawValue;
            }
            catch { }

            return bytesSent;
        }

        public float GetBytesReceived()
        {
            float bytesSent = 0;

            try
            {
                TryToInitializeCounters();
                bytesSent = bytesReceivedPerformanceCounter.RawValue;
            }
            catch { }

            return bytesSent;
        }


        private string GetInstanceName(int processId)
        {
            string instanceName = Process.GetProcessById(processId).ProcessName;
            bool found = false;
            if (!string.IsNullOrEmpty(instanceName))
            {
                Process[] processes = Process.GetProcessesByName(instanceName);
                if (processes.Length > 0)
                {
                    int i = 0;
                    foreach (Process p in processes)
                    {
                        instanceName = FormatInstanceName(p.ProcessName, i);
                        if (PerformanceCounterCategory.CounterExists("ID Process", "Process"))
                        {
                            PerformanceCounter counter = new PerformanceCounter("Process", "ID Process", instanceName);

                            if (processId == counter.RawValue)
                            {
                                found = true;
                                break;
                            }
                        }
                        i++;
                    }
                }
            }

            if (!found)
                instanceName = string.Empty;

            return instanceName;
        }

        private string FormatInstanceName(string processName, int count)
        {
            string instanceName = string.Empty;
            if (count == 0)
                instanceName = processName;
            else
                instanceName = string.Format("{0}#{1}", processName, count);
            return instanceName;
        }
    }
}
