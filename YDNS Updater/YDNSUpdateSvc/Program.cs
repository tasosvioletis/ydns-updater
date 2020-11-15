using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdateSvc {
   
   class Program {
      
      public static Dictionary<string, Dictionary<string, string>> Config;

      public static void Main(string[] args) {
         var app = new Program();
         app.Run(args);
      }

      public override void Run(string[] args) {
         base.Run(args);
         Config = INIFile.Read(AppPath + "Config.ini");

         WebClient wc = new WebClient();
         if (Config["Proxy"]["Enabled"].ToLowerInvariant().Trim() == "true" || Config["Proxy"]["Enabled"].ToLowerInvariant().Trim() == "1") {
            wc.UseDefaultCredentials = false;
            wc.Proxy.Credentials = new NetworkCredential(Config["Proxy"]["User"], Config["Proxy"]["Pass"], Config["Proxy"]["Domain"]);
         }

         string myIP = wc.DownloadString("http://myexternalip.com/raw");

         string auth = Config["API"]["User"] + ":" + Config["API"]["Key"];
         auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
         wc.Headers.Add(HttpRequestHeader.Authorization, "Basic " + auth);

         foreach (string host in Config["Hosts"].Keys)
            Console.WriteLine(wc.DownloadString(string.Format("https://ydns.io/api/v1/update/?host={0}&ip={1}", host, myIP)));
      }
   }
}
