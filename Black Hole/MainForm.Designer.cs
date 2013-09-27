namespace Black_Hole
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
            this.grpPeriodUsages = new System.Windows.Forms.GroupBox();
            this.lbllblAnd = new System.Windows.Forms.Label();
            this.lbllblBetween = new System.Windows.Forms.Label();
            this.dtpFirstTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSecondTime = new System.Windows.Forms.DateTimePicker();
            this.lblActivePeriod = new System.Windows.Forms.Label();
            this.lbllblUsageFor = new System.Windows.Forms.Label();
            this.lblPeriodDown = new System.Windows.Forms.Label();
            this.lblPeriodTotal = new System.Windows.Forms.Label();
            this.lbllblSelectUsagePeriod = new System.Windows.Forms.Label();
            this.lbllblPeriodTotal = new System.Windows.Forms.Label();
            this.cmbUsagePeriod = new System.Windows.Forms.ComboBox();
            this.lbllblPeriodDown = new System.Windows.Forms.Label();
            this.lbllblPeriodUp = new System.Windows.Forms.Label();
            this.lblPeriodUp = new System.Windows.Forms.Label();
            this.grpBWMSettings = new System.Windows.Forms.GroupBox();
            this.lbllblUsageUnit = new System.Windows.Forms.Label();
            this.cmbBWMUnit = new System.Windows.Forms.ComboBox();
            this.grpUsage = new System.Windows.Forms.GroupBox();
            this.lblUploadSpeed = new System.Windows.Forms.Label();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.lbllblUploadSpeed = new System.Windows.Forms.Label();
            this.lbllblDownloadSpeed = new System.Windows.Forms.Label();
            this.grpDaytoDayUsage = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lstvDaytoDay = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.download = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearSelectedDay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpOptionsStatus = new System.Windows.Forms.TabPage();
            this.grpGeneralOptions = new System.Windows.Forms.GroupBox();
            this.cbEnableBandwidthMonitor = new System.Windows.Forms.CheckBox();
            this.cbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lbllblBandwidthStatus = new System.Windows.Forms.Label();
            this.lblBandwidthStatus = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSplitter1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsLogger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileWindowHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.tcTabs.SuspendLayout();
            this.tpBandwidthMonitor.SuspendLayout();
            this.panelBandwidthMonitor.SuspendLayout();
            this.grpPeriodUsages.SuspendLayout();
            this.grpBWMSettings.SuspendLayout();
            this.grpUsage.SuspendLayout();
            this.grpDaytoDayUsage.SuspendLayout();
            this.tpOptionsStatus.SuspendLayout();
            this.grpGeneralOptions.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpBandwidthMonitor);
            this.tcTabs.Controls.Add(this.tpOptionsStatus);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 24);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(742, 496);
            this.tcTabs.TabIndex = 0;
            // 
            // tpBandwidthMonitor
            // 
            this.tpBandwidthMonitor.Controls.Add(this.panelBandwidthMonitor);
            this.tpBandwidthMonitor.Location = new System.Drawing.Point(4, 22);
            this.tpBandwidthMonitor.Name = "tpBandwidthMonitor";
            this.tpBandwidthMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tpBandwidthMonitor.Size = new System.Drawing.Size(734, 470);
            this.tpBandwidthMonitor.TabIndex = 1;
            this.tpBandwidthMonitor.Text = "Bandwidth Monitor";
            this.tpBandwidthMonitor.UseVisualStyleBackColor = true;
            // 
            // panelBandwidthMonitor
            // 
            this.panelBandwidthMonitor.Controls.Add(this.grpPeriodUsages);
            this.panelBandwidthMonitor.Controls.Add(this.grpBWMSettings);
            this.panelBandwidthMonitor.Controls.Add(this.grpUsage);
            this.panelBandwidthMonitor.Controls.Add(this.grpDaytoDayUsage);
            this.panelBandwidthMonitor.Controls.Add(this.label1);
            this.panelBandwidthMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBandwidthMonitor.Location = new System.Drawing.Point(3, 3);
            this.panelBandwidthMonitor.Name = "panelBandwidthMonitor";
            this.panelBandwidthMonitor.Size = new System.Drawing.Size(728, 464);
            this.panelBandwidthMonitor.TabIndex = 2;
            // 
            // grpPeriodUsages
            // 
            this.grpPeriodUsages.Controls.Add(this.lbllblAnd);
            this.grpPeriodUsages.Controls.Add(this.lbllblBetween);
            this.grpPeriodUsages.Controls.Add(this.dtpFirstTime);
            this.grpPeriodUsages.Controls.Add(this.dtpSecondTime);
            this.grpPeriodUsages.Controls.Add(this.lblActivePeriod);
            this.grpPeriodUsages.Controls.Add(this.lbllblUsageFor);
            this.grpPeriodUsages.Controls.Add(this.lblPeriodDown);
            this.grpPeriodUsages.Controls.Add(this.lblPeriodTotal);
            this.grpPeriodUsages.Controls.Add(this.lbllblSelectUsagePeriod);
            this.grpPeriodUsages.Controls.Add(this.lbllblPeriodTotal);
            this.grpPeriodUsages.Controls.Add(this.cmbUsagePeriod);
            this.grpPeriodUsages.Controls.Add(this.lbllblPeriodDown);
            this.grpPeriodUsages.Controls.Add(this.lbllblPeriodUp);
            this.grpPeriodUsages.Controls.Add(this.lblPeriodUp);
            this.grpPeriodUsages.Location = new System.Drawing.Point(6, 67);
            this.grpPeriodUsages.Name = "grpPeriodUsages";
            this.grpPeriodUsages.Size = new System.Drawing.Size(367, 175);
            this.grpPeriodUsages.TabIndex = 4;
            this.grpPeriodUsages.TabStop = false;
            this.grpPeriodUsages.Text = "Bandwidth Period Totals";
            // 
            // lbllblAnd
            // 
            this.lbllblAnd.AutoSize = true;
            this.lbllblAnd.Location = new System.Drawing.Point(190, 58);
            this.lbllblAnd.Name = "lbllblAnd";
            this.lbllblAnd.Size = new System.Drawing.Size(25, 13);
            this.lbllblAnd.TabIndex = 11;
            this.lbllblAnd.Text = "and";
            // 
            // lbllblBetween
            // 
            this.lbllblBetween.AutoSize = true;
            this.lbllblBetween.Location = new System.Drawing.Point(30, 58);
            this.lbllblBetween.Name = "lbllblBetween";
            this.lbllblBetween.Size = new System.Drawing.Size(52, 13);
            this.lbllblBetween.TabIndex = 10;
            this.lbllblBetween.Text = "Between:";
            // 
            // dtpFirstTime
            // 
            this.dtpFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFirstTime.Location = new System.Drawing.Point(88, 55);
            this.dtpFirstTime.Name = "dtpFirstTime";
            this.dtpFirstTime.Size = new System.Drawing.Size(96, 20);
            this.dtpFirstTime.TabIndex = 9;
            // 
            // dtpSecondTime
            // 
            this.dtpSecondTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSecondTime.Location = new System.Drawing.Point(221, 55);
            this.dtpSecondTime.Name = "dtpSecondTime";
            this.dtpSecondTime.Size = new System.Drawing.Size(96, 20);
            this.dtpSecondTime.TabIndex = 8;
            // 
            // lblActivePeriod
            // 
            this.lblActivePeriod.AutoSize = true;
            this.lblActivePeriod.Location = new System.Drawing.Point(179, 62);
            this.lblActivePeriod.Name = "lblActivePeriod";
            this.lblActivePeriod.Size = new System.Drawing.Size(86, 13);
            this.lblActivePeriod.TabIndex = 7;
            this.lblActivePeriod.Text = "Monday, May 25";
            // 
            // lbllblUsageFor
            // 
            this.lbllblUsageFor.AutoSize = true;
            this.lbllblUsageFor.Location = new System.Drawing.Point(114, 62);
            this.lbllblUsageFor.Name = "lbllblUsageFor";
            this.lbllblUsageFor.Size = new System.Drawing.Size(59, 13);
            this.lbllblUsageFor.TabIndex = 6;
            this.lbllblUsageFor.Text = "Usage For:";
            // 
            // lblPeriodDown
            // 
            this.lblPeriodDown.AutoSize = true;
            this.lblPeriodDown.Location = new System.Drawing.Point(162, 98);
            this.lblPeriodDown.Name = "lblPeriodDown";
            this.lblPeriodDown.Size = new System.Drawing.Size(60, 13);
            this.lblPeriodDown.TabIndex = 3;
            this.lblPeriodDown.Text = "100000 mb";
            // 
            // lblPeriodTotal
            // 
            this.lblPeriodTotal.AutoSize = true;
            this.lblPeriodTotal.Location = new System.Drawing.Point(162, 149);
            this.lblPeriodTotal.Name = "lblPeriodTotal";
            this.lblPeriodTotal.Size = new System.Drawing.Size(60, 13);
            this.lblPeriodTotal.TabIndex = 5;
            this.lblPeriodTotal.Text = "100000 mb";
            // 
            // lbllblSelectUsagePeriod
            // 
            this.lbllblSelectUsagePeriod.AutoSize = true;
            this.lbllblSelectUsagePeriod.Location = new System.Drawing.Point(17, 22);
            this.lbllblSelectUsagePeriod.Name = "lbllblSelectUsagePeriod";
            this.lbllblSelectUsagePeriod.Size = new System.Drawing.Size(116, 13);
            this.lbllblSelectUsagePeriod.TabIndex = 1;
            this.lbllblSelectUsagePeriod.Text = "Select a Usage Period:";
            // 
            // lbllblPeriodTotal
            // 
            this.lbllblPeriodTotal.AutoSize = true;
            this.lbllblPeriodTotal.Location = new System.Drawing.Point(122, 149);
            this.lbllblPeriodTotal.Name = "lbllblPeriodTotal";
            this.lbllblPeriodTotal.Size = new System.Drawing.Size(34, 13);
            this.lbllblPeriodTotal.TabIndex = 4;
            this.lbllblPeriodTotal.Text = "Total:";
            // 
            // cmbUsagePeriod
            // 
            this.cmbUsagePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsagePeriod.FormattingEnabled = true;
            this.cmbUsagePeriod.Items.AddRange(new object[] {
            "Today",
            "This Month",
            "All Time",
            "Custom Period"});
            this.cmbUsagePeriod.Location = new System.Drawing.Point(139, 19);
            this.cmbUsagePeriod.Name = "cmbUsagePeriod";
            this.cmbUsagePeriod.Size = new System.Drawing.Size(121, 21);
            this.cmbUsagePeriod.TabIndex = 0;
            // 
            // lbllblPeriodDown
            // 
            this.lbllblPeriodDown.AutoSize = true;
            this.lbllblPeriodDown.Location = new System.Drawing.Point(118, 98);
            this.lbllblPeriodDown.Name = "lbllblPeriodDown";
            this.lbllblPeriodDown.Size = new System.Drawing.Size(38, 13);
            this.lbllblPeriodDown.TabIndex = 1;
            this.lbllblPeriodDown.Text = "Down:";
            // 
            // lbllblPeriodUp
            // 
            this.lbllblPeriodUp.AutoSize = true;
            this.lbllblPeriodUp.Location = new System.Drawing.Point(132, 123);
            this.lbllblPeriodUp.Name = "lbllblPeriodUp";
            this.lbllblPeriodUp.Size = new System.Drawing.Size(24, 13);
            this.lbllblPeriodUp.TabIndex = 0;
            this.lbllblPeriodUp.Text = "Up:";
            // 
            // lblPeriodUp
            // 
            this.lblPeriodUp.AutoSize = true;
            this.lblPeriodUp.Location = new System.Drawing.Point(162, 123);
            this.lblPeriodUp.Name = "lblPeriodUp";
            this.lblPeriodUp.Size = new System.Drawing.Size(60, 13);
            this.lblPeriodUp.TabIndex = 2;
            this.lblPeriodUp.Text = "100000 mb";
            // 
            // grpBWMSettings
            // 
            this.grpBWMSettings.Controls.Add(this.lbllblUsageUnit);
            this.grpBWMSettings.Controls.Add(this.cmbBWMUnit);
            this.grpBWMSettings.Location = new System.Drawing.Point(6, 248);
            this.grpBWMSettings.Name = "grpBWMSettings";
            this.grpBWMSettings.Size = new System.Drawing.Size(367, 198);
            this.grpBWMSettings.TabIndex = 6;
            this.grpBWMSettings.TabStop = false;
            this.grpBWMSettings.Text = "Bandwidth Monitor Settings";
            // 
            // lbllblUsageUnit
            // 
            this.lbllblUsageUnit.AutoSize = true;
            this.lbllblUsageUnit.Location = new System.Drawing.Point(17, 34);
            this.lbllblUsageUnit.Name = "lbllblUsageUnit";
            this.lbllblUsageUnit.Size = new System.Drawing.Size(29, 13);
            this.lbllblUsageUnit.TabIndex = 1;
            this.lbllblUsageUnit.Text = "Unit:";
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
            this.cmbBWMUnit.Location = new System.Drawing.Point(52, 31);
            this.cmbBWMUnit.Name = "cmbBWMUnit";
            this.cmbBWMUnit.Size = new System.Drawing.Size(50, 21);
            this.cmbBWMUnit.TabIndex = 0;
            // 
            // grpUsage
            // 
            this.grpUsage.Controls.Add(this.lblUploadSpeed);
            this.grpUsage.Controls.Add(this.lblDownloadSpeed);
            this.grpUsage.Controls.Add(this.lbllblUploadSpeed);
            this.grpUsage.Controls.Add(this.lbllblDownloadSpeed);
            this.grpUsage.Location = new System.Drawing.Point(6, 3);
            this.grpUsage.Name = "grpUsage";
            this.grpUsage.Size = new System.Drawing.Size(367, 58);
            this.grpUsage.TabIndex = 0;
            this.grpUsage.TabStop = false;
            this.grpUsage.Text = "Active Upload and Download Speeds";
            // 
            // lblUploadSpeed
            // 
            this.lblUploadSpeed.AutoSize = true;
            this.lblUploadSpeed.Location = new System.Drawing.Point(192, 27);
            this.lblUploadSpeed.Name = "lblUploadSpeed";
            this.lblUploadSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblUploadSpeed.TabIndex = 3;
            this.lblUploadSpeed.Text = "0 kb/s";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(88, 27);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblDownloadSpeed.TabIndex = 2;
            this.lblDownloadSpeed.Text = "0 kb/s";
            // 
            // lbllblUploadSpeed
            // 
            this.lbllblUploadSpeed.AutoSize = true;
            this.lbllblUploadSpeed.Location = new System.Drawing.Point(162, 27);
            this.lbllblUploadSpeed.Name = "lbllblUploadSpeed";
            this.lbllblUploadSpeed.Size = new System.Drawing.Size(24, 13);
            this.lbllblUploadSpeed.TabIndex = 1;
            this.lbllblUploadSpeed.Text = "Up:";
            // 
            // lbllblDownloadSpeed
            // 
            this.lbllblDownloadSpeed.AutoSize = true;
            this.lbllblDownloadSpeed.Location = new System.Drawing.Point(44, 27);
            this.lbllblDownloadSpeed.Name = "lbllblDownloadSpeed";
            this.lbllblDownloadSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbllblDownloadSpeed.TabIndex = 0;
            this.lbllblDownloadSpeed.Text = "Down:";
            // 
            // grpDaytoDayUsage
            // 
            this.grpDaytoDayUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDaytoDayUsage.Controls.Add(this.btnClearAll);
            this.grpDaytoDayUsage.Controls.Add(this.lstvDaytoDay);
            this.grpDaytoDayUsage.Controls.Add(this.btnClearSelectedDay);
            this.grpDaytoDayUsage.Location = new System.Drawing.Point(379, 3);
            this.grpDaytoDayUsage.Name = "grpDaytoDayUsage";
            this.grpDaytoDayUsage.Size = new System.Drawing.Size(343, 443);
            this.grpDaytoDayUsage.TabIndex = 2;
            this.grpDaytoDayUsage.TabStop = false;
            this.grpDaytoDayUsage.Text = "Day to Day Bandwidth Usage";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearAll.Location = new System.Drawing.Point(184, 414);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All History";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
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
            this.lstvDaytoDay.Size = new System.Drawing.Size(331, 389);
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
            // btnClearSelectedDay
            // 
            this.btnClearSelectedDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearSelectedDay.Location = new System.Drawing.Point(71, 414);
            this.btnClearSelectedDay.Name = "btnClearSelectedDay";
            this.btnClearSelectedDay.Size = new System.Drawing.Size(107, 23);
            this.btnClearSelectedDay.TabIndex = 2;
            this.btnClearSelectedDay.Text = "Clear Selected Day";
            this.btnClearSelectedDay.UseVisualStyleBackColor = true;
            this.btnClearSelectedDay.Click += new System.EventHandler(this.btnClearSelectedDay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multithreaded Bandwidth Monitor totals internet usage per day and displays it in " +
    "a convenient format.";
            // 
            // tpOptionsStatus
            // 
            this.tpOptionsStatus.Controls.Add(this.grpGeneralOptions);
            this.tpOptionsStatus.Controls.Add(this.grpStatus);
            this.tpOptionsStatus.Location = new System.Drawing.Point(4, 22);
            this.tpOptionsStatus.Name = "tpOptionsStatus";
            this.tpOptionsStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptionsStatus.Size = new System.Drawing.Size(734, 470);
            this.tpOptionsStatus.TabIndex = 0;
            this.tpOptionsStatus.Text = "Options and Status";
            this.tpOptionsStatus.UseVisualStyleBackColor = true;
            // 
            // grpGeneralOptions
            // 
            this.grpGeneralOptions.Controls.Add(this.cbEnableBandwidthMonitor);
            this.grpGeneralOptions.Controls.Add(this.cbRunOnStartup);
            this.grpGeneralOptions.Location = new System.Drawing.Point(23, 19);
            this.grpGeneralOptions.Name = "grpGeneralOptions";
            this.grpGeneralOptions.Size = new System.Drawing.Size(240, 402);
            this.grpGeneralOptions.TabIndex = 3;
            this.grpGeneralOptions.TabStop = false;
            this.grpGeneralOptions.Text = "General Options";
            // 
            // cbEnableBandwidthMonitor
            // 
            this.cbEnableBandwidthMonitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEnableBandwidthMonitor.AutoSize = true;
            this.cbEnableBandwidthMonitor.Location = new System.Drawing.Point(22, 51);
            this.cbEnableBandwidthMonitor.Name = "cbEnableBandwidthMonitor";
            this.cbEnableBandwidthMonitor.Size = new System.Drawing.Size(164, 17);
            this.cbEnableBandwidthMonitor.TabIndex = 3;
            this.cbEnableBandwidthMonitor.Text = "Enable Bandwidth Monitoring";
            this.cbEnableBandwidthMonitor.UseVisualStyleBackColor = true;
            this.cbEnableBandwidthMonitor.CheckedChanged += new System.EventHandler(this.cbEnableBandwidthMonitor_CheckedChanged);
            // 
            // cbRunOnStartup
            // 
            this.cbRunOnStartup.AutoSize = true;
            this.cbRunOnStartup.Location = new System.Drawing.Point(22, 28);
            this.cbRunOnStartup.Name = "cbRunOnStartup";
            this.cbRunOnStartup.Size = new System.Drawing.Size(98, 17);
            this.cbRunOnStartup.TabIndex = 2;
            this.cbRunOnStartup.Text = "Run on Startup";
            this.cbRunOnStartup.UseVisualStyleBackColor = true;
            this.cbRunOnStartup.CheckedChanged += new System.EventHandler(this.cbRunOnStartup_CheckedChanged);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lbllblBandwidthStatus);
            this.grpStatus.Controls.Add(this.lblBandwidthStatus);
            this.grpStatus.Location = new System.Drawing.Point(269, 19);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(200, 402);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Modules Status";
            // 
            // lbllblBandwidthStatus
            // 
            this.lbllblBandwidthStatus.AutoSize = true;
            this.lbllblBandwidthStatus.Location = new System.Drawing.Point(20, 32);
            this.lbllblBandwidthStatus.Name = "lbllblBandwidthStatus";
            this.lbllblBandwidthStatus.Size = new System.Drawing.Size(90, 13);
            this.lbllblBandwidthStatus.TabIndex = 0;
            this.lbllblBandwidthStatus.Text = "Bandwidth Meter:";
            // 
            // lblBandwidthStatus
            // 
            this.lblBandwidthStatus.AutoSize = true;
            this.lblBandwidthStatus.Location = new System.Drawing.Point(117, 32);
            this.lblBandwidthStatus.Name = "lblBandwidthStatus";
            this.lblBandwidthStatus.Size = new System.Drawing.Size(44, 13);
            this.lblBandwidthStatus.TabIndex = 1;
            this.lblBandwidthStatus.Text = "status...";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuAbout,
            this.mnuFileWindowHidden});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(742, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSplitter1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuSplitter1
            // 
            this.mnuSplitter1.Name = "mnuSplitter1";
            this.mnuSplitter1.Size = new System.Drawing.Size(89, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsLogger});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "Tools";
            // 
            // mnuToolsLogger
            // 
            this.mnuToolsLogger.Name = "mnuToolsLogger";
            this.mnuToolsLogger.Size = new System.Drawing.Size(111, 22);
            this.mnuToolsLogger.Text = "Logger";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuFileWindowHidden
            // 
            this.mnuFileWindowHidden.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuFileWindowHidden.CheckOnClick = true;
            this.mnuFileWindowHidden.Name = "mnuFileWindowHidden";
            this.mnuFileWindowHidden.Size = new System.Drawing.Size(91, 20);
            this.mnuFileWindowHidden.Text = "Hide Window";
            this.mnuFileWindowHidden.Click += new System.EventHandler(this.mnuFileWindowHidden_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 520);
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(758, 558);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Hole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcTabs.ResumeLayout(false);
            this.tpBandwidthMonitor.ResumeLayout(false);
            this.panelBandwidthMonitor.ResumeLayout(false);
            this.panelBandwidthMonitor.PerformLayout();
            this.grpPeriodUsages.ResumeLayout(false);
            this.grpPeriodUsages.PerformLayout();
            this.grpBWMSettings.ResumeLayout(false);
            this.grpBWMSettings.PerformLayout();
            this.grpUsage.ResumeLayout(false);
            this.grpUsage.PerformLayout();
            this.grpDaytoDayUsage.ResumeLayout(false);
            this.tpOptionsStatus.ResumeLayout(false);
            this.grpGeneralOptions.ResumeLayout(false);
            this.grpGeneralOptions.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpOptionsStatus;
        private System.Windows.Forms.TabPage tpBandwidthMonitor;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripSeparator mnuSplitter1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsLogger;
        private System.Windows.Forms.GroupBox grpUsage;
        private System.Windows.Forms.Label lbllblUploadSpeed;
        private System.Windows.Forms.Label lbllblDownloadSpeed;
        private System.Windows.Forms.Label lblUploadSpeed;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.Panel panelBandwidthMonitor;
        private System.Windows.Forms.Label lblBandwidthStatus;
        private System.Windows.Forms.Label lbllblBandwidthStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileWindowHidden;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.GroupBox grpDaytoDayUsage;
        private System.Windows.Forms.ListView lstvDaytoDay;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader download;
        private System.Windows.Forms.ColumnHeader upload;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.GroupBox grpPeriodUsages;
        private System.Windows.Forms.Label lblPeriodDown;
        private System.Windows.Forms.Label lblPeriodUp;
        private System.Windows.Forms.Label lbllblPeriodDown;
        private System.Windows.Forms.Label lbllblPeriodUp;
        private System.Windows.Forms.Label lblPeriodTotal;
        private System.Windows.Forms.Label lbllblPeriodTotal;
        private System.Windows.Forms.GroupBox grpBWMSettings;
        private System.Windows.Forms.Label lbllblUsageUnit;
        private System.Windows.Forms.ComboBox cmbBWMUnit;
        private System.Windows.Forms.GroupBox grpGeneralOptions;
        private System.Windows.Forms.CheckBox cbRunOnStartup;
        private System.Windows.Forms.Label lbllblSelectUsagePeriod;
        private System.Windows.Forms.ComboBox cmbUsagePeriod;
        private System.Windows.Forms.Label lblActivePeriod;
        private System.Windows.Forms.Label lbllblUsageFor;
        private System.Windows.Forms.DateTimePicker dtpFirstTime;
        private System.Windows.Forms.DateTimePicker dtpSecondTime;
        private System.Windows.Forms.Label lbllblAnd;
        private System.Windows.Forms.Label lbllblBetween;
        private System.Windows.Forms.Button btnClearSelectedDay;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.CheckBox cbEnableBandwidthMonitor;

    }
}

