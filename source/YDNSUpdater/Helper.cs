using System.Configuration;
using System.IO;
using System.Reflection;

namespace YDNSUpdater {

   public class Helper {

      public static string GetAppPath() {
         var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
         return path.Substring(6);
      }

      public static Configuration OpenConfig(string configFilePath) {
         var appConfig = ConfigurationManager.OpenExeConfiguration(configFilePath);
         var configFileMap = new ExeConfigurationFileMap();
         configFileMap.ExeConfigFilename = configFilePath;
         var mappedAppConfig = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None, true);
         return mappedAppConfig;
      }

   }
}
