namespace BlackHoleClient
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.txtError = new System.Windows.Forms.TextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnRestar = new MetroFramework.Controls.MetroButton();
            this.btnCopyToClip = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.Location = new System.Drawing.Point(23, 63);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(399, 183);
            this.txtError.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Highlight = false;
            this.btnClose.Location = new System.Drawing.Point(346, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestar.Highlight = false;
            this.btnRestar.Location = new System.Drawing.Point(265, 252);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRestar.StyleManager = null;
            this.btnRestar.TabIndex = 5;
            this.btnRestar.Text = "Restart";
            this.btnRestar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClip.Highlight = false;
            this.btnCopyToClip.Location = new System.Drawing.Point(23, 252);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(114, 23);
            this.btnCopyToClip.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCopyToClip.StyleManager = null;
            this.btnCopyToClip.TabIndex = 6;
            this.btnCopyToClip.Text = "Copy to Clipboard";
            this.btnCopyToClip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCopyToClip.Click += new System.EventHandler(this.btnCopyToClip_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 298);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(324, 146);
            this.Name = "frmError";
            this.Text = "Black Hole - Critical Error!";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtError;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnRestar;
        private MetroFramework.Controls.MetroButton btnCopyToClip;
    }
}