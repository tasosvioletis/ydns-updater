using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using YDNSUpdater.Utilities;

namespace YDNSUpdater {

   public class ServiceConfiguration {

      private int _CheckInterval = 60;  //default value

      public string APIUser { get; set; }

      public string APIKey { get; set; }
      public string ProxyUser { get; set; }
      public string ProxyPass { get; set; }
      public string ProxyDomain { get; set; }
      public bool ProxyEnabled { get; set; }
      public string Hosts { get; set; }

      /// <summary>
      /// public ip interval checking (in minutes)
      /// </summary>
      public int CheckInterval {
         get {
            return _CheckInterval;
         }

         set {
            _CheckInterval = value;
            if (_CheckInterval < MinimumInterval) {
               _CheckInterval = MinimumInterval;
            }
         }
      }
            

      private readonly int MinimumInterval = 5;   //5 minutes

      public static string ConfigFilePath {
         get {
            return Path.Combine(Helper.GetAppPath(), Constant.ConfigFileName);
         }
      }


      public static ServiceConfiguration Load() {
         var configFilePath = Path.Combine(Helper.GetAppPath(), Constant.ConfigFileName);
         var appConfig = Helper.OpenConfig(configFilePath);
         var settings = appConfig.AppSettings.Settings;
         var config = new ServiceConfiguration();
         config.APIUser = settings.GetValue( nameof(APIUser));
         config.APIKey = settings.GetValue(nameof(APIKey));
         config.ProxyUser = settings.GetValue(nameof(ProxyUser));
         config.ProxyPass = settings.GetValue(nameof(ProxyPass));
         config.ProxyDomain = settings.GetValue(nameof(ProxyDomain));
         config.ProxyEnabled = settings.GetValue(nameof(ProxyEnabled)).AsBool();
         config.Hosts = settings.GetValue(nameof(Hosts));
         config.CheckInterval = settings.GetValue(nameof(CheckInterval)).AsInt();
         return config;
      }

      public static void Save(ServiceConfiguration config) {
         try {
            var configFilePath = Path.Combine(Helper.GetAppPath(), Constant.ConfigFileName);
            var appConfig = Helper.OpenConfig(configFilePath);
            var settings = appConfig.AppSettings.Settings;

            settings.SetValue( nameof(APIUser), config.APIUser);
            settings.SetValue(nameof(APIKey), config.APIKey);
            settings.SetValue(nameof(ProxyUser), config.ProxyUser);
            settings.SetValue(nameof(ProxyPass), config.ProxyPass);
            settings.SetValue(nameof(ProxyDomain), config.ProxyDomain);
            settings.SetValue(nameof(ProxyEnabled), config.ProxyEnabled.AsText());
            settings.SetValue(nameof(Hosts), config.Hosts);
            settings.SetValue(nameof(CheckInterval), config.CheckInterval.AsText());

            appConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);
         } catch (ConfigurationErrorsException) {
            Console.WriteLine("Error writing app settings");
         }

      }


   }

}
