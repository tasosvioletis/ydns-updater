using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDNSUpdateGUI {

   static class Program {

      public static Dictionary<string,string> Config;

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() {
         ReloadConfig();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         var frm = new frmMain();
         Application.Run(frm);

         SaveConfig(frm);
      }


      public static void ReloadConfig() {
         Config = new Dictionary<string, string>();
         Config["APIUser"] = ConfigurationManager.AppSettings["APIUser"];
         Config["APIKey"] = ConfigurationManager.AppSettings["APIKey"];
         Config["ProxyUser"] = ConfigurationManager.AppSettings["ProxyUser"];
         Config["ProxyPass"] = ConfigurationManager.AppSettings["ProxyPass"];
         Config["ProxyDomain"] = ConfigurationManager.AppSettings["ProxyDomain"];
         Config["ProxyEnabled"] = ConfigurationManager.AppSettings["ProxyEnabled"];
         Config["Hosts"] = ConfigurationManager.AppSettings["Hosts"];
         Config["LastUpdate"] = ConfigurationManager.AppSettings["LastUpdate"];
      }

      public static void SaveConfig(frmMain frm) {
         ConfigurationManager.AppSettings["APIUser"] = frm.txAPIUser.Text;
         ConfigurationManager.AppSettings["APIKey"] = frm.txAPIKey.Text;
         ConfigurationManager.AppSettings["ProxyUser"] = frm.txProxyUser.Text;
         ConfigurationManager.AppSettings["ProxyPass"] = frm.txProxyPass.Text;
         ConfigurationManager.AppSettings["ProxyDomain"] = frm.txProxyDomain.Text;
         ConfigurationManager.AppSettings["ProxyEnabled"] = frm.cbProxyEnabled.Checked ? "1" : "0";
         ConfigurationManager.AppSettings["Hosts"] = frm.txtHosts.Text;
      }

   }

}
