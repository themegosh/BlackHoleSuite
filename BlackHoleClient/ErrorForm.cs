using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using MetroFramework.Forms;

namespace BlackHoleClient
{
    public partial class frmError : MetroForm 
    {
        private Exception ex;

        public frmError(Exception anEx)
        {
            InitializeComponent();

            this.ex = anEx;
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            txtError.Text = string.Format("Message: {0}\r\nStack trace:\r\n\r\n{1}", ex.Message, ex.StackTrace);
        }

        private void btnCopyToClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtError.Text);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
