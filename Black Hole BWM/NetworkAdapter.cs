﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BlackHoleLib
{
    // Represents a network adapter installed on the machine.
    // Properties of this class can be used to obtain current network speed.
    public class NetworkAdapter
    {
        private long dlSpeed, ulSpeed;
        private long dlValue, ulValue;
        private long dlValueOld, ulValueOld;

        internal string name;
        internal PerformanceCounter dlCounter, ulCounter;
        internal bool Enabled;

        // Instances of this class are supposed to be created only in a NetworkMonitor.
        internal NetworkAdapter(string name)
        {
            this.name = name;
        }

        internal void init()
        {
            this.dlValueOld = this.dlCounter.NextSample().RawValue;
            this.ulValueOld = this.ulCounter.NextSample().RawValue;
            this.Enabled = true;
        }

        // Obtain new sample from performance counters, and refresh the values saved in dlSpeed, ulSpeed, etc.
        // This method is supposed to be called only in NetworkMonitor, one time every second.
        internal void refresh()
        {
            try //fix a crash
            {
                this.dlValue = this.dlCounter.NextSample().RawValue;
                this.ulValue = this.ulCounter.NextSample().RawValue;
            }
            catch
            {
                this.dlValue = 0;
                this.ulValue = 0;
            }

            // Calculates download and upload speed.
            this.dlSpeed = this.dlValue - this.dlValueOld;
            this.ulSpeed = this.ulValue - this.ulValueOld;
            this.dlValueOld = this.dlValue;
            this.ulValueOld = this.ulValue;
        }

        // Overrides method to return the name of the adapter.
        public override string ToString()
        {
            return this.name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        // Current download speed in bytes per second.
        public long DownloadSpeed(int Interval)
        {
            return this.dlSpeed * 1000 / Interval;
        }
        // Current upload speed in bytes per second.
        public long UploadSpeed(int Interval)
        {
            return this.ulSpeed * 1000 / Interval;
        }
    }
}
