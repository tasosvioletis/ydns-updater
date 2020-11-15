using System;
using System.Collections.Specialized;
using System.Configuration;
using YDNSUpdater.Utilities;

namespace YDNSUpdater {

   public class ServiceConfiguration {

      private int _CheckInterval = 5;

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
            

      public DateTime LastUpdate { get; set; }

      private readonly int MinimumInterval = 5;   //5 minutes


      public static ServiceConfiguration Load(string configFile ="") {
         //YDNSUpdaterUI.exe.config

         var config = new ServiceConfiguration();

         configFile = @"D:\Tasos\Projects\YDNSUpdater\source.git\source\YDNSUpdaterUI\bin\Debug\YDNSUpdaterUI.exe.config";

         var conf = ConfigurationManager.OpenExeConfiguration(configFile);
         var settings = conf.AppSettings.Settings;

         config.APIUser = GetValue(settings, nameof(APIUser));
         config.APIKey = GetValue(settings, nameof(APIKey));
         config.ProxyUser = GetValue(settings, nameof(ProxyUser));
         config.ProxyPass = GetValue(settings, nameof(ProxyPass));
         config.ProxyDomain = GetValue(settings, nameof(ProxyDomain));
         config.ProxyEnabled = GetValue(settings, nameof(ProxyEnabled)).AsBool();
         config.Hosts = GetValue(settings, nameof(Hosts));
         config.CheckInterval = GetValue(settings, nameof(CheckInterval)).AsInt();
         config.LastUpdate = GetValue(settings, nameof(LastUpdate)).AsDate();
         return config;
      }

      public static void Save(ServiceConfiguration  config) {
         try {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            SetValue(settings, nameof(APIUser), config.APIUser);
            SetValue(settings, nameof(APIKey), config.APIKey);
            SetValue(settings, nameof(ProxyUser), config.ProxyUser);
            SetValue(settings, nameof(ProxyPass), config.ProxyPass);
            SetValue(settings, nameof(ProxyDomain), config.ProxyDomain);
            SetValue(settings, nameof(ProxyEnabled), config.ProxyEnabled.AsText());
            SetValue(settings, nameof(Hosts), config.Hosts);
            SetValue(settings, nameof(Hosts), config.CheckInterval.AsText());

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
         } catch (ConfigurationErrorsException) {
            Console.WriteLine("Error writing app settings");
         }

      }

      private static string GetValue(KeyValueConfigurationCollection settings, string key) {
         if (settings[key] == null) {
            return string.Empty;
         }
         else {
            return settings[key].Value;
         }
      }

      private static void SetValue(KeyValueConfigurationCollection settings, string key, string value) {
         if (settings[key] == null) {
            settings.Add(key, value);
         }
         else {
            settings[key].Value = value;
         }
      }

   }

}
