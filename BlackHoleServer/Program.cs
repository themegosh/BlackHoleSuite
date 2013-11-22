using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using BlackHoleLib;

namespace BlackHoleServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main( string[] args )
        {
            if (args != null && args.Length == 1 && args[0].Length > 1
                && (args[0][0] == '-' || args[0][0] == '/'))
            {
                switch (args[0].Substring(1).ToLower())
                {
                    default:
                        break;
                    case "install":
                    case "i":
                        ServiceManager.InstallService();
                        break;
                    case "uninstall":
                    case "u":
                        ServiceManager.UninstallService();
                        break;
                }
            }
            else
                BlackHoleServer.BlackHoleService.Run(new BlackHoleService());
        }
    }
}
