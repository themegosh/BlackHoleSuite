using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BlackHoleClient
{
    public class ProcessPerformanceCounter
    {
        private PerformanceCounter counter;

        public string CounterName { get; set; }
        public string InstanceName { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }

        public ProcessPerformanceCounter(int processId, string counterName)
        {
            CounterName = counterName;
            ProcessId = processId;
            ProcessName = Process.GetProcessById(processId).ProcessName; 

            string tmpInstanceName = GetInstanceName(processId);
            counter = new PerformanceCounter(".NET CLR Networking 4.0.0.0", counterName, tmpInstanceName);
            
        }

        public float NextValue()
        {
            float nextValue = 0;
            try
            {
                nextValue = counter.NextValue();
            }
            catch
            {
                // adjust instance name based on process id
                InstanceName = GetInstanceName(ProcessId);
                counter.InstanceName = InstanceName;
                nextValue = counter.NextValue();
            }

            return nextValue;
        }

        private string GetInstanceName(int processId)
        {
            string instanceName = Process.GetProcessById(ProcessId).ProcessName;
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
                        if (PerformanceCounterCategory.CounterExists(CounterName, ".NET CLR Networking 4.0.0.0"))
                        {
                            PerformanceCounter aCounter = new PerformanceCounter(".NET CLR Networking 4.0.0.0", CounterName, instanceName);

                            if (processId == aCounter.RawValue)
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
