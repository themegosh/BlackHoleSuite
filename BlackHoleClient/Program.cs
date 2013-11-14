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

            BlackHole.LoadConfig();

            Application.Run(new frmModern());

            BlackHole.SaveConfig();

            //try
            //{
                
            /*
                Process[] RunningProcesses = Process.GetProcessesByName("Black Hole");
                if (RunningProcesses.Length == 1)
                {
                    Application.EnableVisualStyles();
                    Application.Run(new frmMain());
                }
                else if (RunningProcesses.Length == 2)
                {
                    if (RunningProcesses[0].StartTime > RunningProcesses[1].StartTime)
                        RunningProcesses[1].Kill();
                    else
                        RunningProcesses[0].Kill();*/

                    
                    //Application.Run(new frmMain());
                    //Application.Run(new frmModern());

                /*}
                else
                    MessageBox.Show("Black Hole is already running!", "!");*/
            //}
			//catch (Exception ex)
			//{
				//(new frmError(ex)).ShowDialog();
			//}

        }
    }
}
