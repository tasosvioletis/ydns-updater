using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdater {

   public static class KeyValueConfigurationExtensions {

      public  static string GetValue(this KeyValueConfigurationCollection settings, string key) {
         if (settings[key] == null) {
            return string.Empty;
         }
         else {
            return settings[key].Value;
         }
      }

      public static void SetValue(this KeyValueConfigurationCollection settings, string key, string value) {
         if (settings[key] == null) {
            settings.Add(key, value);
         }
         else {
            settings[key].Value = value;
         }
      }

   }
}
