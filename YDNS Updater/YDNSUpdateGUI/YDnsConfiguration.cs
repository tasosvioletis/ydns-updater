using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdateGUI {

   public class YDnsConfiguration {

      public string APIUser { get; set; }

      public string APIKey { get; set; }
      public string ProxyUser { get; set; }
      public string ProxyPass { get; set; }
      public string ProxyDomain { get; set; }
      public bool ProxyEnabled { get; set; }
      public string Hosts { get; set; }
      public DateTime LastUpdate { get; set; }


      public static YDnsConfiguration Load() {
         var config = new YDnsConfiguration();
         config.APIUser = ConfigurationManager.AppSettings[nameof(APIUser)];
         config.APIKey = ConfigurationManager.AppSettings[nameof(APIKey)];
         config.ProxyUser = ConfigurationManager.AppSettings[nameof(ProxyUser)];
         config.ProxyPass = ConfigurationManager.AppSettings[nameof(ProxyPass)];
         config.ProxyDomain = ConfigurationManager.AppSettings[nameof(ProxyDomain)];
         config.ProxyEnabled = ConfigurationManager.AppSettings[nameof(ProxyEnabled)].AsBool();
         config.Hosts = ConfigurationManager.AppSettings[nameof(Hosts)];
         config.LastUpdate = ConfigurationManager.AppSettings[nameof(LastUpdate)].AsDate();
         return config;
      }

      public static void Save(YDnsConfiguration  config) {
         try {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            SetValue(settings, nameof(APIUser), config.APIUser);
            SetValue(settings,nameof(APIKey), config.APIKey);
            SetValue(settings,nameof(ProxyUser), config.ProxyUser);
            SetValue(settings,nameof(ProxyPass), config.ProxyPass);
            SetValue(settings,nameof(ProxyDomain), config.ProxyDomain);
            SetValue(settings,nameof(ProxyEnabled), config.ProxyEnabled.AsText());
            SetValue(settings, nameof(Hosts), config.Hosts);
            
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
         } catch (ConfigurationErrorsException) {
            Console.WriteLine("Error writing app settings");
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
