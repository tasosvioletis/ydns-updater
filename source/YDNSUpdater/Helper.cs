using System.IO;
using System.Reflection;

namespace YDNSUpdater {

   public class Helper {

      public static string GetAppPath() {
         var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
         return path.Substring(6);
      }

   }
}
