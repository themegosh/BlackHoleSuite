using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BlackHoleLib;
using System.Security.Principal;

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

            if (!IsUserAdministrator())
                MessageBox.Show("You need to run this program as Administrator to continue!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
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

        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }
}
