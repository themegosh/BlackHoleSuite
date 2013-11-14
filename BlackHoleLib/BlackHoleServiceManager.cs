using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Reflection;
using System.Diagnostics;
using System.Configuration.Install;

namespace BlackHoleLib
{
    public class BlackHoleServiceManager
    {
        private const string SERVICE_NAME = "BlackHoleService";
        private const string SERVICE_FILE_NAME = "BlackHoleServer.exe";

        ServiceController BandwidthMontiorService;

        public BlackHoleServiceManager()
        {
            BandwidthMontiorService = GetService();
        }

        ~BlackHoleServiceManager()
        {
            if (IsInstalled)
                BandwidthMontiorService.Close();
        }

        public void UninstallService()
        {
            if (IsInstalled)
            {
                if (BandwidthMontiorService.CanStop)
                    BandwidthMontiorService.Stop();

                ManagedInstallerClass.InstallHelper(new string[] { "/u", SERVICE_FILE_NAME});

                BandwidthMontiorService = GetService();
            }
        }

        public void InstallService()
        {
            if (!IsInstalled)
            {
                ManagedInstallerClass.InstallHelper(new string[] { SERVICE_FILE_NAME });

                BandwidthMontiorService = GetService();
            }
        }

        public void Start()
        {
            if (!IsInstalled)
                InstallService();

            if (BandwidthMontiorService.Status == ServiceControllerStatus.Stopped)
            {
                BandwidthMontiorService.Start();
                BandwidthMontiorService.Refresh();
            }
        }

        public void Stop()
        {
            if (IsInstalled)
            {
                BandwidthMontiorService.Stop();
                BandwidthMontiorService.Refresh();
            }
        }

        public void SetAutomatic()
        {
            if (!IsInstalled)
                InstallService();
            
            ServiceHelper.ChangeStartMode(BandwidthMontiorService, ServiceStartMode.Automatic);
            BandwidthMontiorService.Refresh();
        }

        public void SetManual()
        {
            if (!IsInstalled)
                InstallService();

            ServiceHelper.ChangeStartMode(BandwidthMontiorService, ServiceStartMode.Manual);
            BandwidthMontiorService.Refresh();
        }

        public string GetStatus()
        {
            string status;

            if (IsInstalled)
                status = BandwidthMontiorService.Status.ToString();
            else
                status = "Not Installed";

            return status;
        }

        public bool IsInstalled
        {
            get
            {
                return GetService() == null ? false : true;
            }
        }
        
        private ServiceController GetService()
        {
            return ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == SERVICE_NAME);
        }
    }
}
