namespace Black_Hole
{
    partial class AppSpecificBandwidthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefreshProcesses = new System.Windows.Forms.Button();
            this.grpProcessesList = new System.Windows.Forms.GroupBox();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnEnableAll = new System.Windows.Forms.Button();
            this.lstvProcessTraffic = new System.Windows.Forms.ListView();
            this.colProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUpSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUpBandwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownBandwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalBandwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpUsage = new System.Windows.Forms.GroupBox();
            this.chkListProcesses = new System.Windows.Forms.ListView();
            this.colPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblNumTracked = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpProcessesList.SuspendLayout();
            this.grpUsage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefreshProcesses
            // 
            this.btnRefreshProcesses.Location = new System.Drawing.Point(6, 19);
            this.btnRefreshProcesses.Name = "btnRefreshProcesses";
            this.btnRefreshProcesses.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshProcesses.TabIndex = 1;
            this.btnRefreshProcesses.Text = "Refresh";
            this.btnRefreshProcesses.UseVisualStyleBackColor = true;
            this.btnRefreshProcesses.Click += new System.EventHandler(this.btnRefreshProcesses_Click);
            // 
            // grpProcessesList
            // 
            this.grpProcessesList.Controls.Add(this.chkListProcesses);
            this.grpProcessesList.Controls.Add(this.btnDisableAll);
            this.grpProcessesList.Controls.Add(this.btnEnableAll);
            this.grpProcessesList.Controls.Add(this.btnRefreshProcesses);
            this.grpProcessesList.Location = new System.Drawing.Point(12, 12);
            this.grpProcessesList.Name = "grpProcessesList";
            this.grpProcessesList.Size = new System.Drawing.Size(249, 748);
            this.grpProcessesList.TabIndex = 2;
            this.grpProcessesList.TabStop = false;
            this.grpProcessesList.Text = "Select Processes to Monitor";
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.Location = new System.Drawing.Point(168, 19);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisableAll.TabIndex = 3;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.UseVisualStyleBackColor = true;
            // 
            // btnEnableAll
            // 
            this.btnEnableAll.Location = new System.Drawing.Point(87, 19);
            this.btnEnableAll.Name = "btnEnableAll";
            this.btnEnableAll.Size = new System.Drawing.Size(75, 23);
            this.btnEnableAll.TabIndex = 2;
            this.btnEnableAll.Text = "Enable All";
            this.btnEnableAll.UseVisualStyleBackColor = true;
            // 
            // lstvProcessTraffic
            // 
            this.lstvProcessTraffic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProcessID,
            this.colProcessName,
            this.colUpSpeed,
            this.colDownSpeed,
            this.colTotalSpeed,
            this.colUpBandwidth,
            this.colDownBandwidth,
            this.colTotalBandwidth});
            this.lstvProcessTraffic.FullRowSelect = true;
            this.lstvProcessTraffic.GridLines = true;
            this.lstvProcessTraffic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvProcessTraffic.Location = new System.Drawing.Point(6, 19);
            this.lstvProcessTraffic.MultiSelect = false;
            this.lstvProcessTraffic.Name = "lstvProcessTraffic";
            this.lstvProcessTraffic.Size = new System.Drawing.Size(919, 722);
            this.lstvProcessTraffic.TabIndex = 3;
            this.lstvProcessTraffic.UseCompatibleStateImageBehavior = false;
            this.lstvProcessTraffic.View = System.Windows.Forms.View.Details;
            // 
            // colProcessID
            // 
            this.colProcessID.Text = "ID";
            // 
            // colProcessName
            // 
            this.colProcessName.Text = "Process Name";
            this.colProcessName.Width = 200;
            // 
            // colUpSpeed
            // 
            this.colUpSpeed.Text = "Upload Speed";
            this.colUpSpeed.Width = 95;
            // 
            // colDownSpeed
            // 
            this.colDownSpeed.Text = "Download Speed";
            this.colDownSpeed.Width = 95;
            // 
            // colTotalSpeed
            // 
            this.colTotalSpeed.Text = "Total Speed";
            this.colTotalSpeed.Width = 95;
            // 
            // colUpBandwidth
            // 
            this.colUpBandwidth.Text = "Total Upload";
            this.colUpBandwidth.Width = 95;
            // 
            // colDownBandwidth
            // 
            this.colDownBandwidth.Text = "Total Down";
            this.colDownBandwidth.Width = 95;
            // 
            // colTotalBandwidth
            // 
            this.colTotalBandwidth.Text = "Total Bandwidth";
            this.colTotalBandwidth.Width = 95;
            // 
            // grpUsage
            // 
            this.grpUsage.Controls.Add(this.lstvProcessTraffic);
            this.grpUsage.Location = new System.Drawing.Point(268, 13);
            this.grpUsage.Name = "grpUsage";
            this.grpUsage.Size = new System.Drawing.Size(931, 747);
            this.grpUsage.TabIndex = 4;
            this.grpUsage.TabStop = false;
            this.grpUsage.Text = "Usage and Speeds";
            // 
            // chkListProcesses
            // 
            this.chkListProcesses.CheckBoxes = true;
            this.chkListProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPName,
            this.colPID});
            this.chkListProcesses.GridLines = true;
            this.chkListProcesses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.chkListProcesses.Location = new System.Drawing.Point(7, 49);
            this.chkListProcesses.Name = "chkListProcesses";
            this.chkListProcesses.Size = new System.Drawing.Size(236, 693);
            this.chkListProcesses.TabIndex = 4;
            this.chkListProcesses.UseCompatibleStateImageBehavior = false;
            this.chkListProcesses.View = System.Windows.Forms.View.Details;
            this.chkListProcesses.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.chkListProcesses_ItemCheck);
            // 
            // colPName
            // 
            this.colPName.Text = "Process Name";
            this.colPName.Width = 150;
            // 
            // colPID
            // 
            this.colPID.Text = "PID";
            this.colPID.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus,
            this.tsslblNumTracked});
            this.statusStrip1.Location = new System.Drawing.Point(0, 798);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1211, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslblStatus.Text = "Status";
            // 
            // tsslblNumTracked
            // 
            this.tsslblNumTracked.Name = "tsslblNumTracked";
            this.tsslblNumTracked.Size = new System.Drawing.Size(119, 17);
            this.tsslblNumTracked.Text = "Tracking: 0 processes";
            // 
            // AppSpecificBandwidthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 820);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpUsage);
            this.Controls.Add(this.grpProcessesList);
            this.Name = "AppSpecificBandwidthForm";
            this.Text = "AppSpecificBandwidthForm";
            this.Load += new System.EventHandler(this.AppSpecificBandwidthForm_Load);
            this.grpProcessesList.ResumeLayout(false);
            this.grpUsage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshProcesses;
        private System.Windows.Forms.GroupBox grpProcessesList;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnEnableAll;
        private System.Windows.Forms.ListView lstvProcessTraffic;
        private System.Windows.Forms.ColumnHeader colProcessName;
        private System.Windows.Forms.ColumnHeader colProcessID;
        private System.Windows.Forms.ColumnHeader colUpSpeed;
        private System.Windows.Forms.ColumnHeader colDownSpeed;
        private System.Windows.Forms.ColumnHeader colTotalSpeed;
        private System.Windows.Forms.ColumnHeader colUpBandwidth;
        private System.Windows.Forms.ColumnHeader colDownBandwidth;
        private System.Windows.Forms.ColumnHeader colTotalBandwidth;
        private System.Windows.Forms.GroupBox grpUsage;
        private System.Windows.Forms.ListView chkListProcesses;
        private System.Windows.Forms.ColumnHeader colPName;
        private System.Windows.Forms.ColumnHeader colPID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslblNumTracked;
    }
}