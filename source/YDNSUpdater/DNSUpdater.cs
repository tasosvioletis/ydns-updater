using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdater {

   public class DNSUpdater {

      private WebClient _HttpClient;
           

      public DNSUpdater() {
         this.Config = ServiceConfiguration.Load();
         this.State = ServiceState.Load(this.Config);
         this.CreateHttpClient();
      }

      private void CreateHttpClient() {
         _HttpClient = new WebClient();
         if (Config.ProxyEnabled) {
            _HttpClient.UseDefaultCredentials = false;
            _HttpClient.Proxy.Credentials = new NetworkCredential(Config.ProxyUser, Config.ProxyPass, Config.ProxyDomain);
         }

      }

      public ServiceConfiguration Config { get; set; }
      public ServiceState State { get; set; }

      public string CurrentIP {
         get {
            return _HttpClient.DownloadString("http://myexternalip.com/raw");
         }
      }

      /// <summary>
      /// shows if YDNS is updated with the current public IP
      /// </summary>
      /// <returns></returns>
      public bool IsUpdated() {
         return this.State.LastIP == this.CurrentIP;
      }

      public void Update() {
         string auth = Config.APIUser + ":" + Config.APIKey;
         auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
         _HttpClient.Headers.Add(HttpRequestHeader.Authorization, "Basic " + auth);

         //foreach (string host in Config["Hosts"].Keys)  //TODO support for multiple hosts
         var host = Config.Hosts;
         var result = _HttpClient.DownloadString(string.Format("https://ydns.io/api/v1/update/?host={0}&ip={1}", host, this.CurrentIP));
         //TODO : logging

         this.State.LastIP = this.CurrentIP;
         this.State.LastUpdate = DateTime.Now;
         ServiceState.Save(this.State);
      }

   }

}
