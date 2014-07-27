using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Reflection;
using System.Diagnostics;
using System.Configuration.Install;
using System.Management;

namespace BlackHoleLib
{
    public class ServiceManager
    {
        private const string SERVICE_NAME = "BlackHoleService";
        private const string SERVICE_FILE_NAME = "BlackHoleServer.exe";

        ServiceController BandwidthMontiorService;

        public ServiceManager()
        {
            VerifyServiceFilePath();
            SetService();

            BandwidthMontiorService = new ServiceController();
        }

        ~ServiceManager()
        {
            try
            {
                BandwidthMontiorService.Close();
            }
            catch { }
        }

        public static void UninstallService()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", "/LogFile=", SERVICE_FILE_NAME });
            }
            catch { }
        }

        public static void UninstallService(string customPath)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", "/LogFile=", customPath });
            }
            catch { }
        }

        public static void InstallService()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/LogFile=", SERVICE_FILE_NAME });
            }
            catch { }
        }

        public void Start()
        {
            if (!IsInstalled)
            {
                InstallService();
                SetService();
            }

            try
            {
                BandwidthMontiorService.Start();
                BandwidthMontiorService.Refresh();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void Stop()
        {
            try
            {
                BandwidthMontiorService.Stop();
                BandwidthMontiorService.Refresh();
            }
            catch { }
        }

        public void SetAutomatic()
        {
            if (!IsInstalled)
            {
                InstallService();
                SetService();
            }

            try
            {
                ServiceHelper.ChangeStartMode(BandwidthMontiorService, ServiceStartMode.Automatic);
                BandwidthMontiorService.Refresh();
            }
            catch { }
        }

        public void SetManual()
        {
            if (!IsInstalled)
            {
                InstallService();
                SetService();
            }

            try
            {
                ServiceHelper.ChangeStartMode(BandwidthMontiorService, ServiceStartMode.Manual);
                BandwidthMontiorService.Refresh();
            }
            catch { }
        }

        /*
         * not used
         * 
        public string GetStatus()
        {
            SetService();
            BandwidthMontiorService.Refresh();

            return IsInstalled ? BandwidthMontiorService.Status.ToString() : "Not Installed";
        }*/

        public bool IsInstalled
        {
            get
            {
                SetService();
                return BandwidthMontiorService == null ? false : true;
            }
        }

        private void SetService()
        {
            BandwidthMontiorService = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == SERVICE_NAME);
        }

        private void VerifyServiceFilePath()
        {
            ManagementClass mc = new ManagementClass("Win32_Service");
            foreach (ManagementObject mo in mc.GetInstances())
            {
                if (mo.GetPropertyValue("Name").ToString() == "BlackHoleService")
                {
                    if (mo.GetPropertyValue("PathName").ToString().Trim('"') != BlackHoleSuite.APP_DIR + "\\" + SERVICE_FILE_NAME)
                    {
                        UninstallService(mo.GetPropertyValue("PathName").ToString().Trim('"'));
                        InstallService();
                    }
                }
            }
        }
    }
}
