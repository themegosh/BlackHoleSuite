namespace BlackHoleClient
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpBandwidthMonitor = new System.Windows.Forms.TabPage();
            this.panelBandwidthMonitor = new System.Windows.Forms.Panel();
            this.grpBWMPeriodUsages = new System.Windows.Forms.GroupBox();
            this.grpBWMPeriodTotal = new System.Windows.Forms.GroupBox();
            this.lblPeriodTotal = new System.Windows.Forms.Label();
            this.grpBWMPeriodUp = new System.Windows.Forms.GroupBox();
            this.lblPeriodUp = new System.Windows.Forms.Label();
            this.grpBWMPeriodDown = new System.Windows.Forms.GroupBox();
            this.lblPeriodDown = new System.Windows.Forms.Label();
            this.lbllblAnd = new System.Windows.Forms.Label();
            this.lbllblBetween = new System.Windows.Forms.Label();
            this.dtpBWMFirstTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBWMSecondTime = new System.Windows.Forms.DateTimePicker();
            this.lblBWMPeriodDate = new System.Windows.Forms.Label();
            this.lbllblUsageFor = new System.Windows.Forms.Label();
            this.lbllblSelectUsagePeriod = new System.Windows.Forms.Label();
            this.cmbBWMUsagePeriod = new System.Windows.Forms.ComboBox();
            this.grpBWMSettings = new System.Windows.Forms.GroupBox();
            this.grpBWMSettingsStatus = new System.Windows.Forms.GroupBox();
            this.chkBWMSettingsRunStartup = new System.Windows.Forms.CheckBox();
            this.btnBWMStatusStop = new System.Windows.Forms.Button();
            this.lblBWMStatusStatus = new System.Windows.Forms.Label();
            this.btnBWMStatusStart = new System.Windows.Forms.Button();
            this.lblBWMSettingsStatusServerlbl = new System.Windows.Forms.Label();
            this.grpBWMSettingsDisplay = new System.Windows.Forms.GroupBox();
            this.cmbBWMUnit = new System.Windows.Forms.ComboBox();
            this.lbllblUsageUnit = new System.Windows.Forms.Label();
            this.grpBWMSpeeds = new System.Windows.Forms.GroupBox();
            this.chkBWMCurrentSpeeds = new System.Windows.Forms.CheckBox();
            this.grpBWMCurrentUp = new System.Windows.Forms.GroupBox();
            this.lblUploadSpeed = new System.Windows.Forms.Label();
            this.grpBWMCurrentDown = new System.Windows.Forms.GroupBox();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.grpBWMDaytoDayUsage = new System.Windows.Forms.GroupBox();
            this.btnBWMUsageClearAll = new System.Windows.Forms.Button();
            this.lstvDaytoDay = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.download = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBWMUsageClearSelectedDay = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.lblAboutDeveloper = new System.Windows.Forms.Label();
            this.btnAboutVisitDMDev = new System.Windows.Forms.Button();
            this.lblAboutBlurb = new System.Windows.Forms.Label();
            this.tcTabs.SuspendLayout();
            this.tpBandwidthMonitor.SuspendLayout();
            this.panelBandwidthMonitor.SuspendLayout();
            this.grpBWMPeriodUsages.SuspendLayout();
            this.grpBWMPeriodTotal.SuspendLayout();
            this.grpBWMPeriodUp.SuspendLayout();
            this.grpBWMPeriodDown.SuspendLayout();
            this.grpBWMSettings.SuspendLayout();
            this.grpBWMSettingsStatus.SuspendLayout();
            this.grpBWMSettingsDisplay.SuspendLayout();
            this.grpBWMSpeeds.SuspendLayout();
            this.grpBWMCurrentUp.SuspendLayout();
            this.grpBWMCurrentDown.SuspendLayout();
            this.grpBWMDaytoDayUsage.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpBandwidthMonitor);
            this.tcTabs.Controls.Add(this.tpAbout);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(742, 488);
            this.tcTabs.TabIndex = 0;
            // 
            // tpBandwidthMonitor
            // 
            this.tpBandwidthMonitor.Controls.Add(this.panelBandwidthMonitor);
            this.tpBandwidthMonitor.Location = new System.Drawing.Point(4, 22);
            this.tpBandwidthMonitor.Name = "tpBandwidthMonitor";
            this.tpBandwidthMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tpBandwidthMonitor.Size = new System.Drawing.Size(734, 462);
            this.tpBandwidthMonitor.TabIndex = 1;
            this.tpBandwidthMonitor.Text = "Bandwidth Monitor";
            this.tpBandwidthMonitor.UseVisualStyleBackColor = true;
            // 
            // panelBandwidthMonitor
            // 
            this.panelBandwidthMonitor.Controls.Add(this.grpBWMPeriodUsages);
            this.panelBandwidthMonitor.Controls.Add(this.grpBWMSettings);
            this.panelBandwidthMonitor.Controls.Add(this.grpBWMSpeeds);
            this.panelBandwidthMonitor.Controls.Add(this.grpBWMDaytoDayUsage);
            this.panelBandwidthMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBandwidthMonitor.Location = new System.Drawing.Point(3, 3);
            this.panelBandwidthMonitor.Name = "panelBandwidthMonitor";
            this.panelBandwidthMonitor.Size = new System.Drawing.Size(728, 456);
            this.panelBandwidthMonitor.TabIndex = 2;
            // 
            // grpBWMPeriodUsages
            // 
            this.grpBWMPeriodUsages.Controls.Add(this.grpBWMPeriodTotal);
            this.grpBWMPeriodUsages.Controls.Add(this.grpBWMPeriodUp);
            this.grpBWMPeriodUsages.Controls.Add(this.grpBWMPeriodDown);
            this.grpBWMPeriodUsages.Controls.Add(this.lbllblAnd);
            this.grpBWMPeriodUsages.Controls.Add(this.lbllblBetween);
            this.grpBWMPeriodUsages.Controls.Add(this.dtpBWMFirstTime);
            this.grpBWMPeriodUsages.Controls.Add(this.dtpBWMSecondTime);
            this.grpBWMPeriodUsages.Controls.Add(this.lblBWMPeriodDate);
            this.grpBWMPeriodUsages.Controls.Add(this.lbllblUsageFor);
            this.grpBWMPeriodUsages.Controls.Add(this.lbllblSelectUsagePeriod);
            this.grpBWMPeriodUsages.Controls.Add(this.cmbBWMUsagePeriod);
            this.grpBWMPeriodUsages.Location = new System.Drawing.Point(379, 3);
            this.grpBWMPeriodUsages.Name = "grpBWMPeriodUsages";
            this.grpBWMPeriodUsages.Size = new System.Drawing.Size(343, 135);
            this.grpBWMPeriodUsages.TabIndex = 4;
            this.grpBWMPeriodUsages.TabStop = false;
            this.grpBWMPeriodUsages.Text = "Bandwidth Period Totals";
            // 
            // grpBWMPeriodTotal
            // 
            this.grpBWMPeriodTotal.Controls.Add(this.lblPeriodTotal);
            this.grpBWMPeriodTotal.Location = new System.Drawing.Point(229, 76);
            this.grpBWMPeriodTotal.Name = "grpBWMPeriodTotal";
            this.grpBWMPeriodTotal.Size = new System.Drawing.Size(85, 44);
            this.grpBWMPeriodTotal.TabIndex = 14;
            this.grpBWMPeriodTotal.TabStop = false;
            this.grpBWMPeriodTotal.Text = "Total";
            // 
            // lblPeriodTotal
            // 
            this.lblPeriodTotal.AutoSize = true;
            this.lblPeriodTotal.Location = new System.Drawing.Point(6, 19);
            this.lblPeriodTotal.Name = "lblPeriodTotal";
            this.lblPeriodTotal.Size = new System.Drawing.Size(32, 13);
            this.lblPeriodTotal.TabIndex = 5;
            this.lblPeriodTotal.Text = "0 MB";
            // 
            // grpBWMPeriodUp
            // 
            this.grpBWMPeriodUp.Controls.Add(this.lblPeriodUp);
            this.grpBWMPeriodUp.Location = new System.Drawing.Point(127, 76);
            this.grpBWMPeriodUp.Name = "grpBWMPeriodUp";
            this.grpBWMPeriodUp.Size = new System.Drawing.Size(85, 44);
            this.grpBWMPeriodUp.TabIndex = 13;
            this.grpBWMPeriodUp.TabStop = false;
            this.grpBWMPeriodUp.Text = "Up";
            // 
            // lblPeriodUp
            // 
            this.lblPeriodUp.AutoSize = true;
            this.lblPeriodUp.Location = new System.Drawing.Point(6, 19);
            this.lblPeriodUp.Name = "lblPeriodUp";
            this.lblPeriodUp.Size = new System.Drawing.Size(32, 13);
            this.lblPeriodUp.TabIndex = 2;
            this.lblPeriodUp.Text = "0 MB";
            // 
            // grpBWMPeriodDown
            // 
            this.grpBWMPeriodDown.Controls.Add(this.lblPeriodDown);
            this.grpBWMPeriodDown.Location = new System.Drawing.Point(30, 76);
            this.grpBWMPeriodDown.Name = "grpBWMPeriodDown";
            this.grpBWMPeriodDown.Size = new System.Drawing.Size(85, 44);
            this.grpBWMPeriodDown.TabIndex = 12;
            this.grpBWMPeriodDown.TabStop = false;
            this.grpBWMPeriodDown.Text = "Down";
            // 
            // lblPeriodDown
            // 
            this.lblPeriodDown.AutoSize = true;
            this.lblPeriodDown.Location = new System.Drawing.Point(6, 19);
            this.lblPeriodDown.Name = "lblPeriodDown";
            this.lblPeriodDown.Size = new System.Drawing.Size(32, 13);
            this.lblPeriodDown.TabIndex = 3;
            this.lblPeriodDown.Text = "0 MB";
            // 
            // lbllblAnd
            // 
            this.lbllblAnd.AutoSize = true;
            this.lbllblAnd.Location = new System.Drawing.Point(190, 49);
            this.lbllblAnd.Name = "lbllblAnd";
            this.lbllblAnd.Size = new System.Drawing.Size(25, 13);
            this.lbllblAnd.TabIndex = 11;
            this.lbllblAnd.Text = "and";
            // 
            // lbllblBetween
            // 
            this.lbllblBetween.AutoSize = true;
            this.lbllblBetween.Location = new System.Drawing.Point(30, 49);
            this.lbllblBetween.Name = "lbllblBetween";
            this.lbllblBetween.Size = new System.Drawing.Size(52, 13);
            this.lbllblBetween.TabIndex = 10;
            this.lbllblBetween.Text = "Between:";
            // 
            // dtpBWMFirstTime
            // 
            this.dtpBWMFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBWMFirstTime.Location = new System.Drawing.Point(88, 46);
            this.dtpBWMFirstTime.Name = "dtpBWMFirstTime";
            this.dtpBWMFirstTime.Size = new System.Drawing.Size(96, 20);
            this.dtpBWMFirstTime.TabIndex = 9;
            // 
            // dtpBWMSecondTime
            // 
            this.dtpBWMSecondTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBWMSecondTime.Location = new System.Drawing.Point(221, 46);
            this.dtpBWMSecondTime.Name = "dtpBWMSecondTime";
            this.dtpBWMSecondTime.Size = new System.Drawing.Size(96, 20);
            this.dtpBWMSecondTime.TabIndex = 8;
            // 
            // lblBWMPeriodDate
            // 
            this.lblBWMPeriodDate.AutoSize = true;
            this.lblBWMPeriodDate.Location = new System.Drawing.Point(179, 53);
            this.lblBWMPeriodDate.Name = "lblBWMPeriodDate";
            this.lblBWMPeriodDate.Size = new System.Drawing.Size(86, 13);
            this.lblBWMPeriodDate.TabIndex = 7;
            this.lblBWMPeriodDate.Text = "Monday, May 25";
            // 
            // lbllblUsageFor
            // 
            this.lbllblUsageFor.AutoSize = true;
            this.lbllblUsageFor.Location = new System.Drawing.Point(114, 53);
            this.lbllblUsageFor.Name = "lbllblUsageFor";
            this.lbllblUsageFor.Size = new System.Drawing.Size(59, 13);
            this.lbllblUsageFor.TabIndex = 6;
            this.lbllblUsageFor.Text = "Usage For:";
            // 
            // lbllblSelectUsagePeriod
            // 
            this.lbllblSelectUsagePeriod.AutoSize = true;
            this.lbllblSelectUsagePeriod.Location = new System.Drawing.Point(44, 22);
            this.lbllblSelectUsagePeriod.Name = "lbllblSelectUsagePeriod";
            this.lbllblSelectUsagePeriod.Size = new System.Drawing.Size(116, 13);
            this.lbllblSelectUsagePeriod.TabIndex = 1;
            this.lbllblSelectUsagePeriod.Text = "Select a Usage Period:";
            // 
            // cmbBWMUsagePeriod
            // 
            this.cmbBWMUsagePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBWMUsagePeriod.FormattingEnabled = true;
            this.cmbBWMUsagePeriod.Items.AddRange(new object[] {
            "Today",
            "This Month",
            "All Time",
            "Custom Period"});
            this.cmbBWMUsagePeriod.Location = new System.Drawing.Point(169, 19);
            this.cmbBWMUsagePeriod.Name = "cmbBWMUsagePeriod";
            this.cmbBWMUsagePeriod.Size = new System.Drawing.Size(121, 21);
            this.cmbBWMUsagePeriod.TabIndex = 0;
            // 
            // grpBWMSettings
            // 
            this.grpBWMSettings.Controls.Add(this.grpBWMSettingsStatus);
            this.grpBWMSettings.Controls.Add(this.grpBWMSettingsDisplay);
            this.grpBWMSettings.Location = new System.Drawing.Point(6, 79);
            this.grpBWMSettings.Name = "grpBWMSettings";
            this.grpBWMSettings.Size = new System.Drawing.Size(367, 228);
            this.grpBWMSettings.TabIndex = 6;
            this.grpBWMSettings.TabStop = false;
            this.grpBWMSettings.Text = "Bandwidth Monitor Settings";
            // 
            // grpBWMSettingsStatus
            // 
            this.grpBWMSettingsStatus.Controls.Add(this.chkBWMSettingsRunStartup);
            this.grpBWMSettingsStatus.Controls.Add(this.btnBWMStatusStop);
            this.grpBWMSettingsStatus.Controls.Add(this.lblBWMStatusStatus);
            this.grpBWMSettingsStatus.Controls.Add(this.btnBWMStatusStart);
            this.grpBWMSettingsStatus.Controls.Add(this.lblBWMSettingsStatusServerlbl);
            this.grpBWMSettingsStatus.Location = new System.Drawing.Point(123, 19);
            this.grpBWMSettingsStatus.Name = "grpBWMSettingsStatus";
            this.grpBWMSettingsStatus.Size = new System.Drawing.Size(238, 203);
            this.grpBWMSettingsStatus.TabIndex = 3;
            this.grpBWMSettingsStatus.TabStop = false;
            this.grpBWMSettingsStatus.Text = "Day to Day Monitoring";
            // 
            // chkBWMSettingsRunStartup
            // 
            this.chkBWMSettingsRunStartup.AutoSize = true;
            this.chkBWMSettingsRunStartup.Location = new System.Drawing.Point(57, 51);
            this.chkBWMSettingsRunStartup.Name = "chkBWMSettingsRunStartup";
            this.chkBWMSettingsRunStartup.Size = new System.Drawing.Size(114, 17);
            this.chkBWMSettingsRunStartup.TabIndex = 6;
            this.chkBWMSettingsRunStartup.Text = "Monitor on startup.";
            this.chkBWMSettingsRunStartup.UseVisualStyleBackColor = true;
            this.chkBWMSettingsRunStartup.CheckedChanged += new System.EventHandler(this.chkBWMSettingsRunStartup_CheckedChanged);
            // 
            // btnBWMStatusStop
            // 
            this.btnBWMStatusStop.Location = new System.Drawing.Point(114, 74);
            this.btnBWMStatusStop.Name = "btnBWMStatusStop";
            this.btnBWMStatusStop.Size = new System.Drawing.Size(75, 23);
            this.btnBWMStatusStop.TabIndex = 5;
            this.btnBWMStatusStop.Text = "Stop";
            this.btnBWMStatusStop.UseVisualStyleBackColor = true;
            this.btnBWMStatusStop.Click += new System.EventHandler(this.btnBWMStatusStop_Click);
            // 
            // lblBWMStatusStatus
            // 
            this.lblBWMStatusStatus.AutoSize = true;
            this.lblBWMStatusStatus.Location = new System.Drawing.Point(114, 27);
            this.lblBWMStatusStatus.Name = "lblBWMStatusStatus";
            this.lblBWMStatusStatus.Size = new System.Drawing.Size(52, 13);
            this.lblBWMStatusStatus.TabIndex = 4;
            this.lblBWMStatusStatus.Text = "Waiting...";
            // 
            // btnBWMStatusStart
            // 
            this.btnBWMStatusStart.Location = new System.Drawing.Point(33, 74);
            this.btnBWMStatusStart.Name = "btnBWMStatusStart";
            this.btnBWMStatusStart.Size = new System.Drawing.Size(75, 23);
            this.btnBWMStatusStart.TabIndex = 1;
            this.btnBWMStatusStart.Text = "Start";
            this.btnBWMStatusStart.UseVisualStyleBackColor = true;
            this.btnBWMStatusStart.Click += new System.EventHandler(this.btnBWMStatusStart_Click);
            // 
            // lblBWMSettingsStatusServerlbl
            // 
            this.lblBWMSettingsStatusServerlbl.AutoSize = true;
            this.lblBWMSettingsStatusServerlbl.Location = new System.Drawing.Point(68, 27);
            this.lblBWMSettingsStatusServerlbl.Name = "lblBWMSettingsStatusServerlbl";
            this.lblBWMSettingsStatusServerlbl.Size = new System.Drawing.Size(40, 13);
            this.lblBWMSettingsStatusServerlbl.TabIndex = 0;
            this.lblBWMSettingsStatusServerlbl.Text = "Status:";
            // 
            // grpBWMSettingsDisplay
            // 
            this.grpBWMSettingsDisplay.Controls.Add(this.cmbBWMUnit);
            this.grpBWMSettingsDisplay.Controls.Add(this.lbllblUsageUnit);
            this.grpBWMSettingsDisplay.Location = new System.Drawing.Point(7, 20);
            this.grpBWMSettingsDisplay.Name = "grpBWMSettingsDisplay";
            this.grpBWMSettingsDisplay.Size = new System.Drawing.Size(110, 202);
            this.grpBWMSettingsDisplay.TabIndex = 2;
            this.grpBWMSettingsDisplay.TabStop = false;
            this.grpBWMSettingsDisplay.Text = "Display Options";
            // 
            // cmbBWMUnit
            // 
            this.cmbBWMUnit.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBWMUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBWMUnit.FormattingEnabled = true;
            this.cmbBWMUnit.Items.AddRange(new object[] {
            "Smart",
            "B",
            "KB",
            "MB",
            "GB"});
            this.cmbBWMUnit.Location = new System.Drawing.Point(43, 23);
            this.cmbBWMUnit.Name = "cmbBWMUnit";
            this.cmbBWMUnit.Size = new System.Drawing.Size(50, 21);
            this.cmbBWMUnit.TabIndex = 0;
            // 
            // lbllblUsageUnit
            // 
            this.lbllblUsageUnit.AutoSize = true;
            this.lbllblUsageUnit.Location = new System.Drawing.Point(8, 26);
            this.lbllblUsageUnit.Name = "lbllblUsageUnit";
            this.lbllblUsageUnit.Size = new System.Drawing.Size(29, 13);
            this.lbllblUsageUnit.TabIndex = 1;
            this.lbllblUsageUnit.Text = "Unit:";
            // 
            // grpBWMSpeeds
            // 
            this.grpBWMSpeeds.Controls.Add(this.chkBWMCurrentSpeeds);
            this.grpBWMSpeeds.Controls.Add(this.grpBWMCurrentUp);
            this.grpBWMSpeeds.Controls.Add(this.grpBWMCurrentDown);
            this.grpBWMSpeeds.Location = new System.Drawing.Point(6, 3);
            this.grpBWMSpeeds.Name = "grpBWMSpeeds";
            this.grpBWMSpeeds.Size = new System.Drawing.Size(367, 70);
            this.grpBWMSpeeds.TabIndex = 0;
            this.grpBWMSpeeds.TabStop = false;
            this.grpBWMSpeeds.Text = "Current Upload and Download Speeds";
            // 
            // chkBWMCurrentSpeeds
            // 
            this.chkBWMCurrentSpeeds.AutoSize = true;
            this.chkBWMCurrentSpeeds.Location = new System.Drawing.Point(197, 38);
            this.chkBWMCurrentSpeeds.Name = "chkBWMCurrentSpeeds";
            this.chkBWMCurrentSpeeds.Size = new System.Drawing.Size(137, 17);
            this.chkBWMCurrentSpeeds.TabIndex = 6;
            this.chkBWMCurrentSpeeds.Text = "Monitor Current Speeds";
            this.chkBWMCurrentSpeeds.UseVisualStyleBackColor = true;
            this.chkBWMCurrentSpeeds.CheckedChanged += new System.EventHandler(this.chkBWMCurrentSpeeds_CheckedChanged);
            // 
            // grpBWMCurrentUp
            // 
            this.grpBWMCurrentUp.Controls.Add(this.lblUploadSpeed);
            this.grpBWMCurrentUp.Location = new System.Drawing.Point(92, 22);
            this.grpBWMCurrentUp.Name = "grpBWMCurrentUp";
            this.grpBWMCurrentUp.Size = new System.Drawing.Size(84, 40);
            this.grpBWMCurrentUp.TabIndex = 5;
            this.grpBWMCurrentUp.TabStop = false;
            this.grpBWMCurrentUp.Text = "Up";
            // 
            // lblUploadSpeed
            // 
            this.lblUploadSpeed.AutoSize = true;
            this.lblUploadSpeed.Location = new System.Drawing.Point(6, 17);
            this.lblUploadSpeed.Name = "lblUploadSpeed";
            this.lblUploadSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblUploadSpeed.TabIndex = 3;
            this.lblUploadSpeed.Text = "0 kb/s";
            // 
            // grpBWMCurrentDown
            // 
            this.grpBWMCurrentDown.Controls.Add(this.lblDownloadSpeed);
            this.grpBWMCurrentDown.Location = new System.Drawing.Point(7, 20);
            this.grpBWMCurrentDown.Name = "grpBWMCurrentDown";
            this.grpBWMCurrentDown.Size = new System.Drawing.Size(79, 42);
            this.grpBWMCurrentDown.TabIndex = 4;
            this.grpBWMCurrentDown.TabStop = false;
            this.grpBWMCurrentDown.Text = "Down";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(6, 19);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblDownloadSpeed.TabIndex = 2;
            this.lblDownloadSpeed.Text = "0 kb/s";
            // 
            // grpBWMDaytoDayUsage
            // 
            this.grpBWMDaytoDayUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBWMDaytoDayUsage.Controls.Add(this.btnBWMUsageClearAll);
            this.grpBWMDaytoDayUsage.Controls.Add(this.lstvDaytoDay);
            this.grpBWMDaytoDayUsage.Controls.Add(this.btnBWMUsageClearSelectedDay);
            this.grpBWMDaytoDayUsage.Location = new System.Drawing.Point(379, 144);
            this.grpBWMDaytoDayUsage.Name = "grpBWMDaytoDayUsage";
            this.grpBWMDaytoDayUsage.Size = new System.Drawing.Size(343, 307);
            this.grpBWMDaytoDayUsage.TabIndex = 2;
            this.grpBWMDaytoDayUsage.TabStop = false;
            this.grpBWMDaytoDayUsage.Text = "Day to Day Bandwidth Usage";
            // 
            // btnBWMUsageClearAll
            // 
            this.btnBWMUsageClearAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBWMUsageClearAll.Location = new System.Drawing.Point(184, 278);
            this.btnBWMUsageClearAll.Name = "btnBWMUsageClearAll";
            this.btnBWMUsageClearAll.Size = new System.Drawing.Size(90, 23);
            this.btnBWMUsageClearAll.TabIndex = 3;
            this.btnBWMUsageClearAll.Text = "Clear All History";
            this.btnBWMUsageClearAll.UseVisualStyleBackColor = true;
            this.btnBWMUsageClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lstvDaytoDay
            // 
            this.lstvDaytoDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDaytoDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.download,
            this.upload,
            this.total});
            this.lstvDaytoDay.FullRowSelect = true;
            this.lstvDaytoDay.GridLines = true;
            this.lstvDaytoDay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvDaytoDay.Location = new System.Drawing.Point(6, 19);
            this.lstvDaytoDay.MultiSelect = false;
            this.lstvDaytoDay.Name = "lstvDaytoDay";
            this.lstvDaytoDay.Size = new System.Drawing.Size(331, 253);
            this.lstvDaytoDay.TabIndex = 0;
            this.lstvDaytoDay.UseCompatibleStateImageBehavior = false;
            this.lstvDaytoDay.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 67;
            // 
            // download
            // 
            this.download.Text = "Download";
            this.download.Width = 80;
            // 
            // upload
            // 
            this.upload.Text = "Upload";
            this.upload.Width = 80;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 80;
            // 
            // btnBWMUsageClearSelectedDay
            // 
            this.btnBWMUsageClearSelectedDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBWMUsageClearSelectedDay.Location = new System.Drawing.Point(71, 278);
            this.btnBWMUsageClearSelectedDay.Name = "btnBWMUsageClearSelectedDay";
            this.btnBWMUsageClearSelectedDay.Size = new System.Drawing.Size(107, 23);
            this.btnBWMUsageClearSelectedDay.TabIndex = 2;
            this.btnBWMUsageClearSelectedDay.Text = "Clear Selected Day";
            this.btnBWMUsageClearSelectedDay.UseVisualStyleBackColor = true;
            this.btnBWMUsageClearSelectedDay.Click += new System.EventHandler(this.btnClearSelectedDay_Click);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblAboutDeveloper);
            this.tpAbout.Controls.Add(this.btnAboutVisitDMDev);
            this.tpAbout.Controls.Add(this.lblAboutBlurb);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(734, 462);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // lblAboutDeveloper
            // 
            this.lblAboutDeveloper.AutoSize = true;
            this.lblAboutDeveloper.Location = new System.Drawing.Point(252, 258);
            this.lblAboutDeveloper.Name = "lblAboutDeveloper";
            this.lblAboutDeveloper.Size = new System.Drawing.Size(210, 13);
            this.lblAboutDeveloper.TabIndex = 3;
            this.lblAboutDeveloper.Text = "Developed by Doug Mathew of DMDev.ca\r\n";
            // 
            // btnAboutVisitDMDev
            // 
            this.btnAboutVisitDMDev.Location = new System.Drawing.Point(297, 288);
            this.btnAboutVisitDMDev.Name = "btnAboutVisitDMDev";
            this.btnAboutVisitDMDev.Size = new System.Drawing.Size(125, 23);
            this.btnAboutVisitDMDev.TabIndex = 2;
            this.btnAboutVisitDMDev.Text = "Visit My Website";
            this.btnAboutVisitDMDev.UseVisualStyleBackColor = true;
            this.btnAboutVisitDMDev.Click += new System.EventHandler(this.btnAboutVisitDMDev_Click);
            // 
            // lblAboutBlurb
            // 
            this.lblAboutBlurb.AutoSize = true;
            this.lblAboutBlurb.Location = new System.Drawing.Point(88, 131);
            this.lblAboutBlurb.Name = "lblAboutBlurb";
            this.lblAboutBlurb.Size = new System.Drawing.Size(557, 39);
            this.lblAboutBlurb.TabIndex = 1;
            this.lblAboutBlurb.Text = "Black Hole Suite is written in C# and was primarily created to test my knowledge " +
    "and understanding of the language. \r\n\r\nIt includes a Bandwidth Monitoring tool, " +
    "and others.";
            this.lblAboutBlurb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 488);
            this.Controls.Add(this.tcTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(758, 382);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Hole";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcTabs.ResumeLayout(false);
            this.tpBandwidthMonitor.ResumeLayout(false);
            this.panelBandwidthMonitor.ResumeLayout(false);
            this.grpBWMPeriodUsages.ResumeLayout(false);
            this.grpBWMPeriodUsages.PerformLayout();
            this.grpBWMPeriodTotal.ResumeLayout(false);
            this.grpBWMPeriodTotal.PerformLayout();
            this.grpBWMPeriodUp.ResumeLayout(false);
            this.grpBWMPeriodUp.PerformLayout();
            this.grpBWMPeriodDown.ResumeLayout(false);
            this.grpBWMPeriodDown.PerformLayout();
            this.grpBWMSettings.ResumeLayout(false);
            this.grpBWMSettingsStatus.ResumeLayout(false);
            this.grpBWMSettingsStatus.PerformLayout();
            this.grpBWMSettingsDisplay.ResumeLayout(false);
            this.grpBWMSettingsDisplay.PerformLayout();
            this.grpBWMSpeeds.ResumeLayout(false);
            this.grpBWMSpeeds.PerformLayout();
            this.grpBWMCurrentUp.ResumeLayout(false);
            this.grpBWMCurrentUp.PerformLayout();
            this.grpBWMCurrentDown.ResumeLayout(false);
            this.grpBWMCurrentDown.PerformLayout();
            this.grpBWMDaytoDayUsage.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpBandwidthMonitor;
        private System.Windows.Forms.GroupBox grpBWMSpeeds;
        private System.Windows.Forms.Label lblUploadSpeed;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.Panel panelBandwidthMonitor;
        private System.Windows.Forms.GroupBox grpBWMDaytoDayUsage;
        private System.Windows.Forms.ListView lstvDaytoDay;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader download;
        private System.Windows.Forms.ColumnHeader upload;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.GroupBox grpBWMPeriodUsages;
        private System.Windows.Forms.Label lblPeriodDown;
        private System.Windows.Forms.Label lblPeriodUp;
        private System.Windows.Forms.Label lblPeriodTotal;
        private System.Windows.Forms.GroupBox grpBWMSettings;
        private System.Windows.Forms.Label lbllblUsageUnit;
        private System.Windows.Forms.ComboBox cmbBWMUnit;
        private System.Windows.Forms.Label lbllblSelectUsagePeriod;
        private System.Windows.Forms.ComboBox cmbBWMUsagePeriod;
        private System.Windows.Forms.Label lblBWMPeriodDate;
        private System.Windows.Forms.Label lbllblUsageFor;
        private System.Windows.Forms.DateTimePicker dtpBWMFirstTime;
        private System.Windows.Forms.DateTimePicker dtpBWMSecondTime;
        private System.Windows.Forms.Label lbllblAnd;
        private System.Windows.Forms.Label lbllblBetween;
        private System.Windows.Forms.Button btnBWMUsageClearSelectedDay;
        private System.Windows.Forms.Button btnBWMUsageClearAll;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Label lblAboutBlurb;
        private System.Windows.Forms.Button btnAboutVisitDMDev;
        private System.Windows.Forms.Label lblAboutDeveloper;
        private System.Windows.Forms.GroupBox grpBWMSettingsStatus;
        private System.Windows.Forms.Label lblBWMSettingsStatusServerlbl;
        private System.Windows.Forms.GroupBox grpBWMSettingsDisplay;
        private System.Windows.Forms.Label lblBWMStatusStatus;
        private System.Windows.Forms.Button btnBWMStatusStart;
        private System.Windows.Forms.Button btnBWMStatusStop;
        private System.Windows.Forms.CheckBox chkBWMSettingsRunStartup;
        private System.Windows.Forms.CheckBox chkBWMCurrentSpeeds;
        private System.Windows.Forms.GroupBox grpBWMCurrentUp;
        private System.Windows.Forms.GroupBox grpBWMCurrentDown;
        private System.Windows.Forms.GroupBox grpBWMPeriodTotal;
        private System.Windows.Forms.GroupBox grpBWMPeriodUp;
        private System.Windows.Forms.GroupBox grpBWMPeriodDown;

    }
}

