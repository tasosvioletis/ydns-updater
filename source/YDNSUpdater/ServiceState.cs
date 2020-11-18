using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.ServiceProcess;
using YDNSUpdater.Utilities;

namespace YDNSUpdater {

   public class ServiceState {

      private ServiceConfiguration _Config;

      public ServiceState(ServiceConfiguration config) {
         _Config = config;
      }

      public bool IsServiceRunning { get; set; }

      public string IsServiceRunningText {
         get {
            if (this.IsServiceRunning) {
               return "Running";
            }
            else {
               return "Stopped";
            }
         }
      }

      public string IsServiceRunningButtonText {
         get {
            if (this.IsServiceRunning) {
               return "Stop";
            }
            else {
               return "Start";
            }
         }
      }

      /// <summary>
      /// Last known public IP
      /// </summary>
      public string LastIP { get; set; }

      public DateTime LastUpdate { get; set; }

      public string CurrentIP { get; set; }

      public string GetPublicIP() {
         var httpClient = this.CreateHttpClient();
         return httpClient.DownloadString("http://myexternalip.com/raw");
      }

      public bool GetServiceStatus() {
         var service = new ServiceController(Constant.ServiceName);
         var result = false;
         try {
            if (service != null) {
               result = (service.Status == ServiceControllerStatus.Running);
            }
         } catch {
            // TODO logging
         }
         return result;
      }

      public static ServiceState Load(ServiceConfiguration config) {
         var appConfig = Helper.OpenConfig(ServiceConfiguration.ConfigFilePath);
         var settings = appConfig.AppSettings.Settings;
         var state = new ServiceState(config);
         state.LastUpdate = settings.GetValue(nameof(LastUpdate)).AsDate();
         state.LastIP = settings.GetValue(nameof(LastIP));
         state.CurrentIP = state.GetPublicIP();
         state.IsServiceRunning = state.GetServiceStatus();
         return state;
      }

      public static void Save(ServiceState config) {
         try {
            var appConfig = Helper.OpenConfig(ServiceConfiguration.ConfigFilePath);
            var settings = appConfig.AppSettings.Settings;

            settings.SetValue(nameof(LastIP), config.LastIP.AsText());
            settings.SetValue(nameof(LastUpdate), config.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss"));

            appConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);
         } catch (ConfigurationErrorsException) {
            Console.WriteLine("Error writing app settings");
         }

      }

      private WebClient CreateHttpClient() {
         var httpClient = new WebClient();
         if (_Config.ProxyEnabled) {
            httpClient.UseDefaultCredentials = false;
            httpClient.Proxy.Credentials = new NetworkCredential(_Config.ProxyUser, _Config.ProxyPass, _Config.ProxyDomain);
         }
         return httpClient;
      }

      public void StartService() {
         var service = new ServiceController(Constant.ServiceName);
         try {
            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
         } catch {
            // ...
         }
         this.IsServiceRunning = this.GetServiceStatus();
      }

      public void StopService() {
         var service = new ServiceController(Constant.ServiceName);
         try {
            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
         } catch {
            // ...
         }
         this.IsServiceRunning = this.GetServiceStatus();
      }

      public void RestartService() {
         if (!this.IsServiceRunning) {
            return;
         }
         this.StopService();
         this.StartService();
      }
   }

}
