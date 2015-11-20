using Qube.ConsoleApp;
using Qube.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDNSUpdateGUI
{
    class Program : ConsoleApplication
    {
        public static Dictionary<string, Dictionary<string, string>> Config;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }

        public override void Run(string[] args)
        {
            base.Run(args);

            ReloadConfig();            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static void ReloadConfig()
        {
            Config = INIFile.Read(AppPath + "Config.ini");
        }

        public static void SaveConfig(frmMain frm)
        {
            Config["API"]["User"] = frm.txAPIUser.Text;
            Config["API"]["Key"] = frm.txAPIKey.Text;
            Config["Proxy"]["User"] = frm.txProxyUser.Text;
            Config["Proxy"]["Pass"] = frm.txProxyPass.Text;
            Config["Proxy"]["Domain"] = frm.txProxyDomain.Text;
            Config["Proxy"]["Enabled"] = frm.cbProxyEnabled.Checked ? "1" : "0";
            Config["Hosts"] = new Dictionary<string, string>();
            foreach (string host in frm.lbHosts.Items)
                Config["Hosts"][host] = "";
            INIFile.Save(Config, AppPath + "Config.ini");
        }
    }
}
