namespace BlackHoleClient
{
    partial class frmModern
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
            this.tcMainTabs = new MetroFramework.Controls.MetroTabControl();
            this.tpBWM = new MetroFramework.Controls.MetroTabPage();
            this.lstvBWMUsage = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.download = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBWMUsageTotalTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageTotal = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageUploadedTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageUploaded = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageDownloadedTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageDownloaded = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsagePeriod = new MetroFramework.Controls.MetroLabel();
            this.lblBWMPeriodUsageTitle = new MetroFramework.Controls.MetroLabel();
            this.cboBWMUsagePeriod = new MetroFramework.Controls.MetroComboBox();
            this.lblBWMUsagePeriodCmbTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUpTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMSpeedUp = new MetroFramework.Controls.MetroLabel();
            this.lblBWMSpeedsTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMDownTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMSpeedDown = new MetroFramework.Controls.MetroLabel();
            this.tpSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpSettingsBWM = new MetroFramework.Controls.MetroTabPage();
            this.lblSettingsBWMUnit = new MetroFramework.Controls.MetroLabel();
            this.lblSettingsBWMSpeed = new MetroFramework.Controls.MetroLabel();
            this.lblSettingsBWMDaily = new MetroFramework.Controls.MetroLabel();
            this.lblSettingsBWMAdvanced = new MetroFramework.Controls.MetroLabel();
            this.lblSettingsBWMAutoStart = new MetroFramework.Controls.MetroLabel();
            this.cboSettingsBWMUnit = new MetroFramework.Controls.MetroComboBox();
            this.btnSettingsBWMUninstallService = new MetroFramework.Controls.MetroButton();
            this.togSettingsBWMOnStart = new MetroFramework.Controls.MetroToggle();
            this.togSettingsBWMSpeed = new MetroFramework.Controls.MetroToggle();
            this.togSettingsBWMDaily = new MetroFramework.Controls.MetroToggle();
            this.tpAbout = new MetroFramework.Controls.MetroTabPage();
            this.lblAboutBlurb = new MetroFramework.Controls.MetroLabel();
            this.btnAboutDeveloperSite = new MetroFramework.Controls.MetroButton();
            this.btnAboutGithub = new MetroFramework.Controls.MetroButton();
            this.lblAboutDeveloper = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageTitle = new MetroFramework.Controls.MetroLabel();
            this.dtpBWMUsageFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpBWMUsageTo = new System.Windows.Forms.DateTimePicker();
            this.lblBWMUsageFromTitle = new MetroFramework.Controls.MetroLabel();
            this.lblBWMUsageToTitle = new MetroFramework.Controls.MetroLabel();
            this.tcMainTabs.SuspendLayout();
            this.tpBWM.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tpSettingsBWM.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainTabs
            // 
            this.tcMainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainTabs.Controls.Add(this.tpBWM);
            this.tcMainTabs.Controls.Add(this.tpSettings);
            this.tcMainTabs.Controls.Add(this.tpAbout);
            this.tcMainTabs.CustomBackground = false;
            this.tcMainTabs.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tcMainTabs.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.tcMainTabs.Location = new System.Drawing.Point(23, 63);
            this.tcMainTabs.Name = "tcMainTabs";
            this.tcMainTabs.SelectedIndex = 0;
            this.tcMainTabs.Size = new System.Drawing.Size(821, 402);
            this.tcMainTabs.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcMainTabs.StyleManager = null;
            this.tcMainTabs.TabIndex = 0;
            this.tcMainTabs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcMainTabs.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tcMainTabs.UseStyleColors = false;
            // 
            // tpBWM
            // 
            this.tpBWM.Controls.Add(this.lblBWMUsageToTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageFromTitle);
            this.tpBWM.Controls.Add(this.dtpBWMUsageTo);
            this.tpBWM.Controls.Add(this.dtpBWMUsageFrom);
            this.tpBWM.Controls.Add(this.lstvBWMUsage);
            this.tpBWM.Controls.Add(this.lblBWMUsageTitle);
            this.tpBWM.Controls.Add(this.lblBWMPeriodUsageTitle);
            this.tpBWM.Controls.Add(this.lblBWMSpeedsTitle);
            this.tpBWM.Controls.Add(this.lblBWMDownTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageTotal);
            this.tpBWM.Controls.Add(this.lblBWMUpTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageTotalTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageUploadedTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageUploaded);
            this.tpBWM.Controls.Add(this.lblBWMUsageDownloadedTitle);
            this.tpBWM.Controls.Add(this.lblBWMUsageDownloaded);
            this.tpBWM.Controls.Add(this.lblBWMSpeedUp);
            this.tpBWM.Controls.Add(this.lblBWMSpeedDown);
            this.tpBWM.Controls.Add(this.cboBWMUsagePeriod);
            this.tpBWM.Controls.Add(this.lblBWMUsagePeriod);
            this.tpBWM.Controls.Add(this.lblBWMUsagePeriodCmbTitle);
            this.tpBWM.CustomBackground = false;
            this.tpBWM.HorizontalScrollbar = false;
            this.tpBWM.HorizontalScrollbarBarColor = true;
            this.tpBWM.HorizontalScrollbarHighlightOnWheel = false;
            this.tpBWM.HorizontalScrollbarSize = 10;
            this.tpBWM.Location = new System.Drawing.Point(4, 35);
            this.tpBWM.Name = "tpBWM";
            this.tpBWM.Size = new System.Drawing.Size(813, 363);
            this.tpBWM.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpBWM.StyleManager = null;
            this.tpBWM.TabIndex = 0;
            this.tpBWM.Text = "Bandwidth Monitor";
            this.tpBWM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpBWM.VerticalScrollbar = false;
            this.tpBWM.VerticalScrollbarBarColor = true;
            this.tpBWM.VerticalScrollbarHighlightOnWheel = false;
            this.tpBWM.VerticalScrollbarSize = 10;
            // 
            // lstvBWMUsage
            // 
            this.lstvBWMUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvBWMUsage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.download,
            this.upload,
            this.total});
            this.lstvBWMUsage.FullRowSelect = true;
            this.lstvBWMUsage.GridLines = true;
            this.lstvBWMUsage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvBWMUsage.Location = new System.Drawing.Point(260, 52);
            this.lstvBWMUsage.MultiSelect = false;
            this.lstvBWMUsage.Name = "lstvBWMUsage";
            this.lstvBWMUsage.Size = new System.Drawing.Size(553, 311);
            this.lstvBWMUsage.TabIndex = 18;
            this.lstvBWMUsage.UseCompatibleStateImageBehavior = false;
            this.lstvBWMUsage.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 73;
            // 
            // download
            // 
            this.download.Text = "Download";
            this.download.Width = 92;
            // 
            // upload
            // 
            this.upload.Text = "Upload";
            this.upload.Width = 91;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 92;
            // 
            // lblBWMUsageTotalTitle
            // 
            this.lblBWMUsageTotalTitle.AutoSize = true;
            this.lblBWMUsageTotalTitle.CustomBackground = false;
            this.lblBWMUsageTotalTitle.CustomForeColor = false;
            this.lblBWMUsageTotalTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBWMUsageTotalTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageTotalTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageTotalTitle.Location = new System.Drawing.Point(60, 253);
            this.lblBWMUsageTotalTitle.Name = "lblBWMUsageTotalTitle";
            this.lblBWMUsageTotalTitle.Size = new System.Drawing.Size(32, 15);
            this.lblBWMUsageTotalTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageTotalTitle.StyleManager = null;
            this.lblBWMUsageTotalTitle.TabIndex = 16;
            this.lblBWMUsageTotalTitle.Text = "Total";
            this.lblBWMUsageTotalTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageTotalTitle.UseStyleColors = false;
            // 
            // lblBWMUsageTotal
            // 
            this.lblBWMUsageTotal.AutoSize = true;
            this.lblBWMUsageTotal.CustomBackground = false;
            this.lblBWMUsageTotal.CustomForeColor = false;
            this.lblBWMUsageTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMUsageTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBWMUsageTotal.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageTotal.Location = new System.Drawing.Point(60, 228);
            this.lblBWMUsageTotal.Name = "lblBWMUsageTotal";
            this.lblBWMUsageTotal.Size = new System.Drawing.Size(106, 25);
            this.lblBWMUsageTotal.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageTotal.StyleManager = null;
            this.lblBWMUsageTotal.TabIndex = 17;
            this.lblBWMUsageTotal.Text = "000.00 KB/s";
            this.lblBWMUsageTotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageTotal.UseStyleColors = false;
            // 
            // lblBWMUsageUploadedTitle
            // 
            this.lblBWMUsageUploadedTitle.AutoSize = true;
            this.lblBWMUsageUploadedTitle.CustomBackground = false;
            this.lblBWMUsageUploadedTitle.CustomForeColor = false;
            this.lblBWMUsageUploadedTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBWMUsageUploadedTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageUploadedTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageUploadedTitle.Location = new System.Drawing.Point(122, 202);
            this.lblBWMUsageUploadedTitle.Name = "lblBWMUsageUploadedTitle";
            this.lblBWMUsageUploadedTitle.Size = new System.Drawing.Size(57, 15);
            this.lblBWMUsageUploadedTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageUploadedTitle.StyleManager = null;
            this.lblBWMUsageUploadedTitle.TabIndex = 14;
            this.lblBWMUsageUploadedTitle.Text = "Uploaded";
            this.lblBWMUsageUploadedTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageUploadedTitle.UseStyleColors = false;
            // 
            // lblBWMUsageUploaded
            // 
            this.lblBWMUsageUploaded.AutoSize = true;
            this.lblBWMUsageUploaded.CustomBackground = false;
            this.lblBWMUsageUploaded.CustomForeColor = false;
            this.lblBWMUsageUploaded.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMUsageUploaded.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBWMUsageUploaded.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageUploaded.Location = new System.Drawing.Point(122, 177);
            this.lblBWMUsageUploaded.Name = "lblBWMUsageUploaded";
            this.lblBWMUsageUploaded.Size = new System.Drawing.Size(106, 25);
            this.lblBWMUsageUploaded.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageUploaded.StyleManager = null;
            this.lblBWMUsageUploaded.TabIndex = 15;
            this.lblBWMUsageUploaded.Text = "000.00 KB/s";
            this.lblBWMUsageUploaded.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageUploaded.UseStyleColors = false;
            // 
            // lblBWMUsageDownloadedTitle
            // 
            this.lblBWMUsageDownloadedTitle.AutoSize = true;
            this.lblBWMUsageDownloadedTitle.CustomBackground = false;
            this.lblBWMUsageDownloadedTitle.CustomForeColor = false;
            this.lblBWMUsageDownloadedTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBWMUsageDownloadedTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageDownloadedTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageDownloadedTitle.Location = new System.Drawing.Point(14, 202);
            this.lblBWMUsageDownloadedTitle.Name = "lblBWMUsageDownloadedTitle";
            this.lblBWMUsageDownloadedTitle.Size = new System.Drawing.Size(71, 15);
            this.lblBWMUsageDownloadedTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageDownloadedTitle.StyleManager = null;
            this.lblBWMUsageDownloadedTitle.TabIndex = 12;
            this.lblBWMUsageDownloadedTitle.Text = "Downloaded";
            this.lblBWMUsageDownloadedTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageDownloadedTitle.UseStyleColors = false;
            // 
            // lblBWMUsageDownloaded
            // 
            this.lblBWMUsageDownloaded.AutoSize = true;
            this.lblBWMUsageDownloaded.CustomBackground = false;
            this.lblBWMUsageDownloaded.CustomForeColor = false;
            this.lblBWMUsageDownloaded.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMUsageDownloaded.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBWMUsageDownloaded.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageDownloaded.Location = new System.Drawing.Point(14, 177);
            this.lblBWMUsageDownloaded.Name = "lblBWMUsageDownloaded";
            this.lblBWMUsageDownloaded.Size = new System.Drawing.Size(106, 25);
            this.lblBWMUsageDownloaded.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageDownloaded.StyleManager = null;
            this.lblBWMUsageDownloaded.TabIndex = 13;
            this.lblBWMUsageDownloaded.Text = "000.00 KB/s";
            this.lblBWMUsageDownloaded.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageDownloaded.UseStyleColors = false;
            // 
            // lblBWMUsagePeriod
            // 
            this.lblBWMUsagePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBWMUsagePeriod.AutoSize = true;
            this.lblBWMUsagePeriod.CustomBackground = false;
            this.lblBWMUsagePeriod.CustomForeColor = false;
            this.lblBWMUsagePeriod.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBWMUsagePeriod.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsagePeriod.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsagePeriod.Location = new System.Drawing.Point(519, 21);
            this.lblBWMUsagePeriod.Name = "lblBWMUsagePeriod";
            this.lblBWMUsagePeriod.Size = new System.Drawing.Size(58, 19);
            this.lblBWMUsagePeriod.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsagePeriod.StyleManager = null;
            this.lblBWMUsagePeriod.TabIndex = 11;
            this.lblBWMUsagePeriod.Text = "A Date...";
            this.lblBWMUsagePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBWMUsagePeriod.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsagePeriod.UseStyleColors = false;
            // 
            // lblBWMPeriodUsageTitle
            // 
            this.lblBWMPeriodUsageTitle.AutoSize = true;
            this.lblBWMPeriodUsageTitle.CustomBackground = false;
            this.lblBWMPeriodUsageTitle.CustomForeColor = false;
            this.lblBWMPeriodUsageTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMPeriodUsageTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMPeriodUsageTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMPeriodUsageTitle.Location = new System.Drawing.Point(14, 139);
            this.lblBWMPeriodUsageTitle.Name = "lblBWMPeriodUsageTitle";
            this.lblBWMPeriodUsageTitle.Size = new System.Drawing.Size(144, 25);
            this.lblBWMPeriodUsageTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMPeriodUsageTitle.StyleManager = null;
            this.lblBWMPeriodUsageTitle.TabIndex = 10;
            this.lblBWMPeriodUsageTitle.Text = "Bandwidth Usage";
            this.lblBWMPeriodUsageTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMPeriodUsageTitle.UseStyleColors = false;
            // 
            // cboBWMUsagePeriod
            // 
            this.cboBWMUsagePeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBWMUsagePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBWMUsagePeriod.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cboBWMUsagePeriod.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cboBWMUsagePeriod.FormattingEnabled = true;
            this.cboBWMUsagePeriod.ItemHeight = 23;
            this.cboBWMUsagePeriod.Items.AddRange(new object[] {
            "Today",
            "This Month",
            "All Time",
            "Custom Period"});
            this.cboBWMUsagePeriod.Location = new System.Drawing.Point(392, 16);
            this.cboBWMUsagePeriod.Name = "cboBWMUsagePeriod";
            this.cboBWMUsagePeriod.Size = new System.Drawing.Size(121, 29);
            this.cboBWMUsagePeriod.Style = MetroFramework.MetroColorStyle.Blue;
            this.cboBWMUsagePeriod.StyleManager = null;
            this.cboBWMUsagePeriod.TabIndex = 9;
            this.cboBWMUsagePeriod.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cboBWMUsagePeriod.SelectionChangeCommitted += new System.EventHandler(this.cboBWMUsagePeriod_SelectionChangeCommitted);
            // 
            // lblBWMUsagePeriodCmbTitle
            // 
            this.lblBWMUsagePeriodCmbTitle.AutoSize = true;
            this.lblBWMUsagePeriodCmbTitle.CustomBackground = false;
            this.lblBWMUsagePeriodCmbTitle.CustomForeColor = false;
            this.lblBWMUsagePeriodCmbTitle.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBWMUsagePeriodCmbTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsagePeriodCmbTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsagePeriodCmbTitle.Location = new System.Drawing.Point(338, 21);
            this.lblBWMUsagePeriodCmbTitle.Name = "lblBWMUsagePeriodCmbTitle";
            this.lblBWMUsagePeriodCmbTitle.Size = new System.Drawing.Size(51, 19);
            this.lblBWMUsagePeriodCmbTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsagePeriodCmbTitle.StyleManager = null;
            this.lblBWMUsagePeriodCmbTitle.TabIndex = 8;
            this.lblBWMUsagePeriodCmbTitle.Text = "Period:";
            this.lblBWMUsagePeriodCmbTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsagePeriodCmbTitle.UseStyleColors = false;
            // 
            // lblBWMUpTitle
            // 
            this.lblBWMUpTitle.AutoSize = true;
            this.lblBWMUpTitle.CustomBackground = false;
            this.lblBWMUpTitle.CustomForeColor = false;
            this.lblBWMUpTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBWMUpTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUpTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUpTitle.Location = new System.Drawing.Point(122, 81);
            this.lblBWMUpTitle.Name = "lblBWMUpTitle";
            this.lblBWMUpTitle.Size = new System.Drawing.Size(44, 15);
            this.lblBWMUpTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUpTitle.StyleManager = null;
            this.lblBWMUpTitle.TabIndex = 6;
            this.lblBWMUpTitle.Text = "Upload";
            this.lblBWMUpTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUpTitle.UseStyleColors = false;
            // 
            // lblBWMSpeedUp
            // 
            this.lblBWMSpeedUp.AutoSize = true;
            this.lblBWMSpeedUp.CustomBackground = false;
            this.lblBWMSpeedUp.CustomForeColor = false;
            this.lblBWMSpeedUp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMSpeedUp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBWMSpeedUp.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMSpeedUp.Location = new System.Drawing.Point(122, 56);
            this.lblBWMSpeedUp.Name = "lblBWMSpeedUp";
            this.lblBWMSpeedUp.Size = new System.Drawing.Size(106, 25);
            this.lblBWMSpeedUp.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMSpeedUp.StyleManager = null;
            this.lblBWMSpeedUp.TabIndex = 7;
            this.lblBWMSpeedUp.Text = "000.00 KB/s";
            this.lblBWMSpeedUp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMSpeedUp.UseStyleColors = false;
            // 
            // lblBWMSpeedsTitle
            // 
            this.lblBWMSpeedsTitle.AutoSize = true;
            this.lblBWMSpeedsTitle.CustomBackground = false;
            this.lblBWMSpeedsTitle.CustomForeColor = false;
            this.lblBWMSpeedsTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMSpeedsTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMSpeedsTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMSpeedsTitle.Location = new System.Drawing.Point(14, 17);
            this.lblBWMSpeedsTitle.Name = "lblBWMSpeedsTitle";
            this.lblBWMSpeedsTitle.Size = new System.Drawing.Size(121, 25);
            this.lblBWMSpeedsTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMSpeedsTitle.StyleManager = null;
            this.lblBWMSpeedsTitle.TabIndex = 2;
            this.lblBWMSpeedsTitle.Text = "Current Speed";
            this.lblBWMSpeedsTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMSpeedsTitle.UseStyleColors = false;
            // 
            // lblBWMDownTitle
            // 
            this.lblBWMDownTitle.AutoSize = true;
            this.lblBWMDownTitle.CustomBackground = false;
            this.lblBWMDownTitle.CustomForeColor = false;
            this.lblBWMDownTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBWMDownTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMDownTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMDownTitle.Location = new System.Drawing.Point(14, 81);
            this.lblBWMDownTitle.Name = "lblBWMDownTitle";
            this.lblBWMDownTitle.Size = new System.Drawing.Size(58, 15);
            this.lblBWMDownTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMDownTitle.StyleManager = null;
            this.lblBWMDownTitle.TabIndex = 3;
            this.lblBWMDownTitle.Text = "Download";
            this.lblBWMDownTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMDownTitle.UseStyleColors = false;
            // 
            // lblBWMSpeedDown
            // 
            this.lblBWMSpeedDown.AutoSize = true;
            this.lblBWMSpeedDown.CustomBackground = false;
            this.lblBWMSpeedDown.CustomForeColor = false;
            this.lblBWMSpeedDown.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMSpeedDown.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBWMSpeedDown.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMSpeedDown.Location = new System.Drawing.Point(14, 56);
            this.lblBWMSpeedDown.Name = "lblBWMSpeedDown";
            this.lblBWMSpeedDown.Size = new System.Drawing.Size(106, 25);
            this.lblBWMSpeedDown.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMSpeedDown.StyleManager = null;
            this.lblBWMSpeedDown.TabIndex = 4;
            this.lblBWMSpeedDown.Text = "000.00 KB/s";
            this.lblBWMSpeedDown.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMSpeedDown.UseStyleColors = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.metroTabControl1);
            this.tpSettings.CustomBackground = false;
            this.tpSettings.HorizontalScrollbar = false;
            this.tpSettings.HorizontalScrollbarBarColor = true;
            this.tpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettings.HorizontalScrollbarSize = 10;
            this.tpSettings.Location = new System.Drawing.Point(4, 35);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(813, 363);
            this.tpSettings.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpSettings.StyleManager = null;
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpSettings.VerticalScrollbar = false;
            this.tpSettings.VerticalScrollbarBarColor = true;
            this.tpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettings.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tpSettingsBWM);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(806, 363);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 11;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            // 
            // tpSettingsBWM
            // 
            this.tpSettingsBWM.Controls.Add(this.lblSettingsBWMUnit);
            this.tpSettingsBWM.Controls.Add(this.lblSettingsBWMSpeed);
            this.tpSettingsBWM.Controls.Add(this.lblSettingsBWMDaily);
            this.tpSettingsBWM.Controls.Add(this.lblSettingsBWMAdvanced);
            this.tpSettingsBWM.Controls.Add(this.lblSettingsBWMAutoStart);
            this.tpSettingsBWM.Controls.Add(this.cboSettingsBWMUnit);
            this.tpSettingsBWM.Controls.Add(this.togSettingsBWMOnStart);
            this.tpSettingsBWM.Controls.Add(this.togSettingsBWMSpeed);
            this.tpSettingsBWM.Controls.Add(this.togSettingsBWMDaily);
            this.tpSettingsBWM.Controls.Add(this.btnSettingsBWMUninstallService);
            this.tpSettingsBWM.Controls.Add(this.metroLabel1);
            this.tpSettingsBWM.CustomBackground = false;
            this.tpSettingsBWM.HorizontalScrollbar = false;
            this.tpSettingsBWM.HorizontalScrollbarBarColor = true;
            this.tpSettingsBWM.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettingsBWM.HorizontalScrollbarSize = 10;
            this.tpSettingsBWM.Location = new System.Drawing.Point(4, 35);
            this.tpSettingsBWM.Name = "tpSettingsBWM";
            this.tpSettingsBWM.Size = new System.Drawing.Size(798, 324);
            this.tpSettingsBWM.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpSettingsBWM.StyleManager = null;
            this.tpSettingsBWM.TabIndex = 0;
            this.tpSettingsBWM.Text = "Bandwidth Monitor";
            this.tpSettingsBWM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpSettingsBWM.VerticalScrollbar = false;
            this.tpSettingsBWM.VerticalScrollbarBarColor = true;
            this.tpSettingsBWM.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettingsBWM.VerticalScrollbarSize = 10;
            // 
            // lblSettingsBWMUnit
            // 
            this.lblSettingsBWMUnit.AutoSize = true;
            this.lblSettingsBWMUnit.CustomBackground = false;
            this.lblSettingsBWMUnit.CustomForeColor = false;
            this.lblSettingsBWMUnit.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSettingsBWMUnit.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSettingsBWMUnit.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSettingsBWMUnit.Location = new System.Drawing.Point(13, 130);
            this.lblSettingsBWMUnit.Name = "lblSettingsBWMUnit";
            this.lblSettingsBWMUnit.Size = new System.Drawing.Size(132, 19);
            this.lblSettingsBWMUnit.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSettingsBWMUnit.StyleManager = null;
            this.lblSettingsBWMUnit.TabIndex = 12;
            this.lblSettingsBWMUnit.Text = "Unit of Measurement";
            this.lblSettingsBWMUnit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSettingsBWMUnit.UseStyleColors = false;
            // 
            // lblSettingsBWMSpeed
            // 
            this.lblSettingsBWMSpeed.AutoSize = true;
            this.lblSettingsBWMSpeed.CustomBackground = false;
            this.lblSettingsBWMSpeed.CustomForeColor = false;
            this.lblSettingsBWMSpeed.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSettingsBWMSpeed.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSettingsBWMSpeed.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSettingsBWMSpeed.Location = new System.Drawing.Point(13, 21);
            this.lblSettingsBWMSpeed.Name = "lblSettingsBWMSpeed";
            this.lblSettingsBWMSpeed.Size = new System.Drawing.Size(115, 19);
            this.lblSettingsBWMSpeed.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSettingsBWMSpeed.StyleManager = null;
            this.lblSettingsBWMSpeed.TabIndex = 4;
            this.lblSettingsBWMSpeed.Text = "Speed Monitoring";
            this.lblSettingsBWMSpeed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSettingsBWMSpeed.UseStyleColors = false;
            // 
            // lblSettingsBWMDaily
            // 
            this.lblSettingsBWMDaily.AutoSize = true;
            this.lblSettingsBWMDaily.CustomBackground = false;
            this.lblSettingsBWMDaily.CustomForeColor = false;
            this.lblSettingsBWMDaily.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSettingsBWMDaily.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSettingsBWMDaily.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSettingsBWMDaily.Location = new System.Drawing.Point(13, 44);
            this.lblSettingsBWMDaily.Name = "lblSettingsBWMDaily";
            this.lblSettingsBWMDaily.Size = new System.Drawing.Size(128, 19);
            this.lblSettingsBWMDaily.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSettingsBWMDaily.StyleManager = null;
            this.lblSettingsBWMDaily.TabIndex = 5;
            this.lblSettingsBWMDaily.Text = "Monitor Daily Usage";
            this.lblSettingsBWMDaily.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSettingsBWMDaily.UseStyleColors = false;
            // 
            // lblSettingsBWMAdvanced
            // 
            this.lblSettingsBWMAdvanced.AutoSize = true;
            this.lblSettingsBWMAdvanced.CustomBackground = false;
            this.lblSettingsBWMAdvanced.CustomForeColor = false;
            this.lblSettingsBWMAdvanced.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSettingsBWMAdvanced.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSettingsBWMAdvanced.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSettingsBWMAdvanced.Location = new System.Drawing.Point(311, 15);
            this.lblSettingsBWMAdvanced.Name = "lblSettingsBWMAdvanced";
            this.lblSettingsBWMAdvanced.Size = new System.Drawing.Size(87, 25);
            this.lblSettingsBWMAdvanced.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSettingsBWMAdvanced.StyleManager = null;
            this.lblSettingsBWMAdvanced.TabIndex = 7;
            this.lblSettingsBWMAdvanced.Text = "Advanced";
            this.lblSettingsBWMAdvanced.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSettingsBWMAdvanced.UseStyleColors = false;
            // 
            // lblSettingsBWMAutoStart
            // 
            this.lblSettingsBWMAutoStart.AutoSize = true;
            this.lblSettingsBWMAutoStart.CustomBackground = false;
            this.lblSettingsBWMAutoStart.CustomForeColor = false;
            this.lblSettingsBWMAutoStart.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSettingsBWMAutoStart.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSettingsBWMAutoStart.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSettingsBWMAutoStart.Location = new System.Drawing.Point(13, 68);
            this.lblSettingsBWMAutoStart.Name = "lblSettingsBWMAutoStart";
            this.lblSettingsBWMAutoStart.Size = new System.Drawing.Size(98, 19);
            this.lblSettingsBWMAutoStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSettingsBWMAutoStart.StyleManager = null;
            this.lblSettingsBWMAutoStart.TabIndex = 9;
            this.lblSettingsBWMAutoStart.Text = "Run at PC Start";
            this.lblSettingsBWMAutoStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSettingsBWMAutoStart.UseStyleColors = false;
            // 
            // cboSettingsBWMUnit
            // 
            this.cboSettingsBWMUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSettingsBWMUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSettingsBWMUnit.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cboSettingsBWMUnit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cboSettingsBWMUnit.FormattingEnabled = true;
            this.cboSettingsBWMUnit.ItemHeight = 23;
            this.cboSettingsBWMUnit.Items.AddRange(new object[] {
            "Smart",
            "B",
            "KB",
            "MB",
            "GB"});
            this.cboSettingsBWMUnit.Location = new System.Drawing.Point(158, 125);
            this.cboSettingsBWMUnit.Name = "cboSettingsBWMUnit";
            this.cboSettingsBWMUnit.Size = new System.Drawing.Size(79, 29);
            this.cboSettingsBWMUnit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cboSettingsBWMUnit.StyleManager = null;
            this.cboSettingsBWMUnit.TabIndex = 11;
            this.cboSettingsBWMUnit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cboSettingsBWMUnit.SelectionChangeCommitted += new System.EventHandler(this.cboSettingsBWMUnit_SelectionChangeCommitted);
            // 
            // btnSettingsBWMUninstallService
            // 
            this.btnSettingsBWMUninstallService.Highlight = false;
            this.btnSettingsBWMUninstallService.Location = new System.Drawing.Point(311, 59);
            this.btnSettingsBWMUninstallService.Name = "btnSettingsBWMUninstallService";
            this.btnSettingsBWMUninstallService.Size = new System.Drawing.Size(111, 28);
            this.btnSettingsBWMUninstallService.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSettingsBWMUninstallService.StyleManager = null;
            this.btnSettingsBWMUninstallService.TabIndex = 8;
            this.btnSettingsBWMUninstallService.Text = "Uninstall Service";
            this.btnSettingsBWMUninstallService.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSettingsBWMUninstallService.Click += new System.EventHandler(this.btnSettingsBWMUninstallService_Click);
            // 
            // togSettingsBWMOnStart
            // 
            this.togSettingsBWMOnStart.AutoSize = true;
            this.togSettingsBWMOnStart.CustomBackground = false;
            this.togSettingsBWMOnStart.DisplayStatus = true;
            this.togSettingsBWMOnStart.FontSize = MetroFramework.MetroLinkSize.Small;
            this.togSettingsBWMOnStart.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.togSettingsBWMOnStart.Location = new System.Drawing.Point(157, 70);
            this.togSettingsBWMOnStart.Name = "togSettingsBWMOnStart";
            this.togSettingsBWMOnStart.Size = new System.Drawing.Size(80, 17);
            this.togSettingsBWMOnStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.togSettingsBWMOnStart.StyleManager = null;
            this.togSettingsBWMOnStart.TabIndex = 10;
            this.togSettingsBWMOnStart.Text = "Off";
            this.togSettingsBWMOnStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.togSettingsBWMOnStart.UseStyleColors = false;
            this.togSettingsBWMOnStart.UseVisualStyleBackColor = true;
            this.togSettingsBWMOnStart.CheckedChanged += new System.EventHandler(this.togSettingsBWMOnStart_CheckedChanged);
            // 
            // togSettingsBWMSpeed
            // 
            this.togSettingsBWMSpeed.AutoSize = true;
            this.togSettingsBWMSpeed.CustomBackground = false;
            this.togSettingsBWMSpeed.DisplayStatus = true;
            this.togSettingsBWMSpeed.FontSize = MetroFramework.MetroLinkSize.Small;
            this.togSettingsBWMSpeed.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.togSettingsBWMSpeed.Location = new System.Drawing.Point(157, 23);
            this.togSettingsBWMSpeed.Name = "togSettingsBWMSpeed";
            this.togSettingsBWMSpeed.Size = new System.Drawing.Size(80, 17);
            this.togSettingsBWMSpeed.Style = MetroFramework.MetroColorStyle.Blue;
            this.togSettingsBWMSpeed.StyleManager = null;
            this.togSettingsBWMSpeed.TabIndex = 2;
            this.togSettingsBWMSpeed.Text = "Off";
            this.togSettingsBWMSpeed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.togSettingsBWMSpeed.UseStyleColors = false;
            this.togSettingsBWMSpeed.UseVisualStyleBackColor = true;
            this.togSettingsBWMSpeed.CheckedChanged += new System.EventHandler(this.togSettingsBWMSpeed_CheckedChanged);
            // 
            // togSettingsBWMDaily
            // 
            this.togSettingsBWMDaily.AutoSize = true;
            this.togSettingsBWMDaily.CustomBackground = false;
            this.togSettingsBWMDaily.DisplayStatus = true;
            this.togSettingsBWMDaily.FontSize = MetroFramework.MetroLinkSize.Small;
            this.togSettingsBWMDaily.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.togSettingsBWMDaily.Location = new System.Drawing.Point(157, 46);
            this.togSettingsBWMDaily.Name = "togSettingsBWMDaily";
            this.togSettingsBWMDaily.Size = new System.Drawing.Size(80, 17);
            this.togSettingsBWMDaily.Style = MetroFramework.MetroColorStyle.Blue;
            this.togSettingsBWMDaily.StyleManager = null;
            this.togSettingsBWMDaily.TabIndex = 6;
            this.togSettingsBWMDaily.Text = "Off";
            this.togSettingsBWMDaily.Theme = MetroFramework.MetroThemeStyle.Light;
            this.togSettingsBWMDaily.UseStyleColors = false;
            this.togSettingsBWMDaily.UseVisualStyleBackColor = true;
            this.togSettingsBWMDaily.CheckedChanged += new System.EventHandler(this.togSettingsBWMDaily_CheckedChanged);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblAboutBlurb);
            this.tpAbout.Controls.Add(this.btnAboutDeveloperSite);
            this.tpAbout.Controls.Add(this.btnAboutGithub);
            this.tpAbout.Controls.Add(this.lblAboutDeveloper);
            this.tpAbout.CustomBackground = false;
            this.tpAbout.HorizontalScrollbar = false;
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            this.tpAbout.Location = new System.Drawing.Point(4, 35);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(813, 363);
            this.tpAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpAbout.StyleManager = null;
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpAbout.VerticalScrollbar = false;
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            // 
            // lblAboutBlurb
            // 
            this.lblAboutBlurb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAboutBlurb.AutoSize = true;
            this.lblAboutBlurb.CustomBackground = false;
            this.lblAboutBlurb.CustomForeColor = false;
            this.lblAboutBlurb.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblAboutBlurb.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAboutBlurb.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAboutBlurb.Location = new System.Drawing.Point(222, 77);
            this.lblAboutBlurb.Name = "lblAboutBlurb";
            this.lblAboutBlurb.Size = new System.Drawing.Size(363, 95);
            this.lblAboutBlurb.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAboutBlurb.StyleManager = null;
            this.lblAboutBlurb.TabIndex = 2;
            this.lblAboutBlurb.Text = "Black Hole Suite is written in C# and was primarily created to\r\n test my knowledg" +
    "e and understanding of the language. \r\n\r\nIt includes a Bandwidth Monitoring tool" +
    ", and others.\r\n";
            this.lblAboutBlurb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutBlurb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAboutBlurb.UseStyleColors = false;
            // 
            // btnAboutDeveloperSite
            // 
            this.btnAboutDeveloperSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAboutDeveloperSite.Highlight = false;
            this.btnAboutDeveloperSite.Location = new System.Drawing.Point(281, 207);
            this.btnAboutDeveloperSite.Name = "btnAboutDeveloperSite";
            this.btnAboutDeveloperSite.Size = new System.Drawing.Size(125, 31);
            this.btnAboutDeveloperSite.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAboutDeveloperSite.StyleManager = null;
            this.btnAboutDeveloperSite.TabIndex = 5;
            this.btnAboutDeveloperSite.Text = "See it on DMDev.ca";
            this.btnAboutDeveloperSite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAboutDeveloperSite.Click += new System.EventHandler(this.btnAboutDeveloperSite_Click);
            // 
            // btnAboutGithub
            // 
            this.btnAboutGithub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAboutGithub.Highlight = false;
            this.btnAboutGithub.Location = new System.Drawing.Point(424, 207);
            this.btnAboutGithub.Name = "btnAboutGithub";
            this.btnAboutGithub.Size = new System.Drawing.Size(125, 31);
            this.btnAboutGithub.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAboutGithub.StyleManager = null;
            this.btnAboutGithub.TabIndex = 4;
            this.btnAboutGithub.Text = "See it on GitHub";
            this.btnAboutGithub.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAboutGithub.Click += new System.EventHandler(this.btnAboutGithub_Click);
            // 
            // lblAboutDeveloper
            // 
            this.lblAboutDeveloper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAboutDeveloper.AutoSize = true;
            this.lblAboutDeveloper.CustomBackground = false;
            this.lblAboutDeveloper.CustomForeColor = false;
            this.lblAboutDeveloper.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblAboutDeveloper.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAboutDeveloper.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAboutDeveloper.Location = new System.Drawing.Point(309, 172);
            this.lblAboutDeveloper.Name = "lblAboutDeveloper";
            this.lblAboutDeveloper.Size = new System.Drawing.Size(179, 19);
            this.lblAboutDeveloper.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblAboutDeveloper.StyleManager = null;
            this.lblAboutDeveloper.TabIndex = 3;
            this.lblAboutDeveloper.Text = "Developed by: Doug Mathew";
            this.lblAboutDeveloper.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAboutDeveloper.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(311, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "* For advanced users.";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // lblBWMUsageTitle
            // 
            this.lblBWMUsageTitle.AutoSize = true;
            this.lblBWMUsageTitle.CustomBackground = false;
            this.lblBWMUsageTitle.CustomForeColor = false;
            this.lblBWMUsageTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBWMUsageTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageTitle.Location = new System.Drawing.Point(260, 17);
            this.lblBWMUsageTitle.Name = "lblBWMUsageTitle";
            this.lblBWMUsageTitle.Size = new System.Drawing.Size(59, 25);
            this.lblBWMUsageTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageTitle.StyleManager = null;
            this.lblBWMUsageTitle.TabIndex = 19;
            this.lblBWMUsageTitle.Text = "Usage";
            this.lblBWMUsageTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageTitle.UseStyleColors = false;
            // 
            // dtpBWMUsageFrom
            // 
            this.dtpBWMUsageFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBWMUsageFrom.Location = new System.Drawing.Point(571, 21);
            this.dtpBWMUsageFrom.Name = "dtpBWMUsageFrom";
            this.dtpBWMUsageFrom.Size = new System.Drawing.Size(96, 20);
            this.dtpBWMUsageFrom.TabIndex = 20;
            this.dtpBWMUsageFrom.ValueChanged += new System.EventHandler(this.dtpBWMUsageFrom_ValueChanged);
            // 
            // dtpBWMUsageTo
            // 
            this.dtpBWMUsageTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBWMUsageTo.Location = new System.Drawing.Point(700, 21);
            this.dtpBWMUsageTo.Name = "dtpBWMUsageTo";
            this.dtpBWMUsageTo.Size = new System.Drawing.Size(96, 20);
            this.dtpBWMUsageTo.TabIndex = 21;
            this.dtpBWMUsageTo.ValueChanged += new System.EventHandler(this.dtpBWMUsageFrom_ValueChanged);
            // 
            // lblBWMUsageFromTitle
            // 
            this.lblBWMUsageFromTitle.AutoSize = true;
            this.lblBWMUsageFromTitle.CustomBackground = false;
            this.lblBWMUsageFromTitle.CustomForeColor = false;
            this.lblBWMUsageFromTitle.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBWMUsageFromTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageFromTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageFromTitle.Location = new System.Drawing.Point(521, 21);
            this.lblBWMUsageFromTitle.Name = "lblBWMUsageFromTitle";
            this.lblBWMUsageFromTitle.Size = new System.Drawing.Size(44, 19);
            this.lblBWMUsageFromTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageFromTitle.StyleManager = null;
            this.lblBWMUsageFromTitle.TabIndex = 22;
            this.lblBWMUsageFromTitle.Text = "From:";
            this.lblBWMUsageFromTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageFromTitle.UseStyleColors = false;
            // 
            // lblBWMUsageToTitle
            // 
            this.lblBWMUsageToTitle.AutoSize = true;
            this.lblBWMUsageToTitle.CustomBackground = false;
            this.lblBWMUsageToTitle.CustomForeColor = false;
            this.lblBWMUsageToTitle.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblBWMUsageToTitle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBWMUsageToTitle.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBWMUsageToTitle.Location = new System.Drawing.Point(673, 21);
            this.lblBWMUsageToTitle.Name = "lblBWMUsageToTitle";
            this.lblBWMUsageToTitle.Size = new System.Drawing.Size(21, 19);
            this.lblBWMUsageToTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBWMUsageToTitle.StyleManager = null;
            this.lblBWMUsageToTitle.TabIndex = 23;
            this.lblBWMUsageToTitle.Text = "to";
            this.lblBWMUsageToTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBWMUsageToTitle.UseStyleColors = false;
            // 
            // frmModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 488);
            this.Controls.Add(this.tcMainTabs);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmModern";
            this.Text = "Black Hole Suite";
            this.Load += new System.EventHandler(this.frmModern_Load);
            this.tcMainTabs.ResumeLayout(false);
            this.tpBWM.ResumeLayout(false);
            this.tpBWM.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tpSettingsBWM.ResumeLayout(false);
            this.tpSettingsBWM.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcMainTabs;
        private MetroFramework.Controls.MetroTabPage tpBWM;
        private MetroFramework.Controls.MetroTabPage tpSettings;
        private MetroFramework.Controls.MetroTabPage tpAbout;
        private MetroFramework.Controls.MetroLabel lblSettingsBWMSpeed;
        private MetroFramework.Controls.MetroToggle togSettingsBWMDaily;
        private MetroFramework.Controls.MetroLabel lblSettingsBWMDaily;
        private MetroFramework.Controls.MetroToggle togSettingsBWMSpeed;
        private MetroFramework.Controls.MetroToggle togSettingsBWMOnStart;
        private MetroFramework.Controls.MetroButton btnSettingsBWMUninstallService;
        private MetroFramework.Controls.MetroLabel lblSettingsBWMAdvanced;
        private MetroFramework.Controls.MetroLabel lblSettingsBWMAutoStart;
        private MetroFramework.Controls.MetroLabel lblBWMDownTitle;
        private MetroFramework.Controls.MetroLabel lblBWMSpeedsTitle;
        private MetroFramework.Controls.MetroLabel lblAboutBlurb;
        private MetroFramework.Controls.MetroLabel lblAboutDeveloper;
        private MetroFramework.Controls.MetroButton btnAboutGithub;
        private MetroFramework.Controls.MetroButton btnAboutDeveloperSite;
        private MetroFramework.Controls.MetroLabel lblBWMUpTitle;
        private MetroFramework.Controls.MetroLabel lblBWMSpeedUp;
        private MetroFramework.Controls.MetroLabel lblBWMSpeedDown;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpSettingsBWM;
        private MetroFramework.Controls.MetroLabel lblSettingsBWMUnit;
        private MetroFramework.Controls.MetroComboBox cboSettingsBWMUnit;
        private MetroFramework.Controls.MetroComboBox cboBWMUsagePeriod;
        private MetroFramework.Controls.MetroLabel lblBWMUsagePeriodCmbTitle;
        private MetroFramework.Controls.MetroLabel lblBWMPeriodUsageTitle;
        private MetroFramework.Controls.MetroLabel lblBWMUsagePeriod;
        private MetroFramework.Controls.MetroLabel lblBWMUsageTotalTitle;
        private MetroFramework.Controls.MetroLabel lblBWMUsageTotal;
        private MetroFramework.Controls.MetroLabel lblBWMUsageUploadedTitle;
        private MetroFramework.Controls.MetroLabel lblBWMUsageUploaded;
        private MetroFramework.Controls.MetroLabel lblBWMUsageDownloadedTitle;
        private MetroFramework.Controls.MetroLabel lblBWMUsageDownloaded;
        private System.Windows.Forms.ListView lstvBWMUsage;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader download;
        private System.Windows.Forms.ColumnHeader upload;
        private System.Windows.Forms.ColumnHeader total;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblBWMUsageTitle;
        private System.Windows.Forms.DateTimePicker dtpBWMUsageTo;
        private System.Windows.Forms.DateTimePicker dtpBWMUsageFrom;
        private MetroFramework.Controls.MetroLabel lblBWMUsageToTitle;
        private MetroFramework.Controls.MetroLabel lblBWMUsageFromTitle;
    }
}