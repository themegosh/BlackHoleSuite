using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BlackHoleLib;

namespace BlackHoleClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            BlackHoleSuite.LoadConfig();

            //if debugging, allow vs exception handling
            if (System.Diagnostics.Debugger.IsAttached)
                Application.Run(new frmModern());
            else
            {
                try //not debug mode, show error window instead
                {
                    Application.Run(new frmModern());
                }
                catch (Exception ex)
                {
                    (new frmError(ex)).ShowDialog(); //this type of error message is temporary
                }
            }

            BlackHoleSuite.SaveConfig();
        }
    }
}
