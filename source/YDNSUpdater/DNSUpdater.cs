using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdater {

   public class DNSUpdater {

      public DNSUpdater() { 
      }

      public ServiceConfiguration Config { get; set; }

      public void Update() {

         WebClient wc = new WebClient();
         if (Config.ProxyEnabled) {
            wc.UseDefaultCredentials = false;
            wc.Proxy.Credentials = new NetworkCredential(Config.ProxyUser, Config.ProxyPass, Config.ProxyDomain);
         }

         string myIP = wc.DownloadString("http://myexternalip.com/raw");

         string auth = Config.APIUser + ":" + Config.APIKey;
         auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
         wc.Headers.Add(HttpRequestHeader.Authorization, "Basic " + auth);

         //foreach (string host in Config["Hosts"].Keys)
         var host = Config.Hosts;
            Console.WriteLine(wc.DownloadString(string.Format("https://ydns.io/api/v1/update/?host={0}&ip={1}", host, myIP)));
      }

   }

}
