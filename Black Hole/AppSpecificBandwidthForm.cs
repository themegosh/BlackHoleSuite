using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Black_Hole
{
    public partial class AppSpecificBandwidthForm : Form
    {
        Timer bandwidthCalcTimer = new Timer();

        List<ProcessPerformanceCounter> arrBytesRecieved = new List<ProcessPerformanceCounter>();
        List<ProcessPerformanceCounter> arrBytesSent = new List<ProcessPerformanceCounter>();

        //List<TrackedProcess> arrTrackedProcesses = new List<TrackedProcess>();
        //List<NetworkTraffic> arrNetworkTraffic = new List<NetworkTraffic>();

        public AppSpecificBandwidthForm()
        {
            InitializeComponent();

            bandwidthCalcTimer.Interval = 5000;
            bandwidthCalcTimer.Tick += new EventHandler(bandwidthCalcTimer_Tick);
            bandwidthCalcTimer.Enabled = true;

            /*Process[] processlist = Process.GetProcesses();
            for (int curProcess = 0; curProcess < processlist.Length; curProcess++)
            {
                arrNetworkTraffic.Add(new NetworkTraffic(processlist[curProcess].Id));
                //arrTrackedProcesses.Add(new TrackedProcess(Process.GetProcessById(processlist[curProcess].Id)));
            }*/

            refreshProcessList();
        }

        void bandwidthCalcTimer_Tick(object sender, EventArgs e)
        {
            /*float currentAmountOfBytesReceived = trafficMonitor.GetBytesReceived();
            totalBandwidthConsumptionLabel.Text = string.Format("Total Bandwidth Consumption: {0} kb", currentAmountOfBytesReceived / 1024);
            currentBandwidthConsumptionLabel.Text = string.Format("Current Bandwidth Consumption: {0} kb/sec", (currentAmountOfBytesReceived - lastAmountOfBytesReceived) / 1024);
            lastAmountOfBytesReceived = currentAmountOfBytesReceived;*/

            //lstvProcessTraffic.Clear();

            /*ListViewItem itemToAdd;

            for (int curProcess = 0; curProcess < arrTrackedProcesses.Count; curProcess++)
            {
                float recieved = arrNetworkTraffic[curProcess].GetBytesReceived();

                itemToAdd = new ListViewItem();
                itemToAdd.Name = arrTrackedProcesses[curProcess].processID.ToString();

                itemToAdd.Text = arrTrackedProcesses[curProcess].processID.ToString(); //id
                itemToAdd.SubItems.Add(arrTrackedProcesses[curProcess].processName); //process name
                itemToAdd.SubItems.Add("?"); //up speed
                itemToAdd.SubItems.Add(recieved.ToString()); //down speed
                itemToAdd.SubItems.Add("?"); //total speed
                itemToAdd.SubItems.Add("?"); //up total
                itemToAdd.SubItems.Add("?"); //down total
                itemToAdd.SubItems.Add("?"); //both total

                lstvProcessTraffic.Items.Add(itemToAdd);
            }*/

            ListViewItem itemToAdd;

            lstvProcessTraffic.Items.Clear();

            for (int curProcess = 0; curProcess < arrBytesRecieved.Count; curProcess++)
            {
                itemToAdd = new ListViewItem();
                //itemToAdd.Name = arrTrackedProcesses[curProcess].processID.ToString();

                itemToAdd.Text = arrBytesRecieved[curProcess].ProcessId.ToString(); //id
                itemToAdd.SubItems.Add(arrBytesRecieved[curProcess].ProcessName); //process name
                itemToAdd.SubItems.Add(arrBytesRecieved[curProcess].NextValue().ToString()); //up speed
                itemToAdd.SubItems.Add(arrBytesRecieved[curProcess].NextValue().ToString()); //down speed
                itemToAdd.SubItems.Add("?"); //total speed
                itemToAdd.SubItems.Add("?"); //up total
                itemToAdd.SubItems.Add("?"); //down total
                itemToAdd.SubItems.Add("?"); //both total

                lstvProcessTraffic.Items.Add(itemToAdd);
            }
        }

        void refreshProcessList()
        {
            chkListProcesses.Items.Clear();

            ListViewItem itemToAdd;

            Process[] processlist = Process.GetProcesses();
            foreach (Process aProcess in processlist)
            {
                itemToAdd = new ListViewItem();
                //itemToAdd.Name = aProcess.ProcessName.ToString();

                itemToAdd.Text = aProcess.ProcessName.ToString(); //id
                itemToAdd.SubItems.Add(aProcess.Id.ToString()); //process name


                chkListProcesses.Items.Add(itemToAdd); 
                //chkListProcesses.Items.Add("Process: " + theprocess.ProcessName + " ID: " + theprocess.Id, false);
                //chkListProcesses.Items.Add(theprocess.Id, false);
            }
        }

        private void AppSpecificBandwidthForm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnRefreshProcesses_Click(object sender, EventArgs e)
        {
            refreshProcessList();
        }
        
        private void chkListProcesses_ItemCheck(object sender, ItemCheckedEventArgs e)
        {
            
            if (e.Item.Checked == true)
            {
                arrBytesSent.Add(new ProcessPerformanceCounter(int.Parse(chkListProcesses.Items[e.Item.Index].SubItems[1].Text), "Bytes Sent"));
                arrBytesRecieved.Add(new ProcessPerformanceCounter(int.Parse(chkListProcesses.Items[e.Item.Index].SubItems[1].Text), "Bytes Received"));

                //arrTrackedProcesses.Add(new TrackedProcess(Process.GetProcessById(int.Parse(chkListProcesses.Items[e.Item.Index].SubItems[1].Text))));
                //arrNetworkTraffic.Add(new NetworkTraffic(int.Parse(chkListProcesses.Items[e.Item.Index].SubItems[1].Text)));
            }
        }
    }
}
