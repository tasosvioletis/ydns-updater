using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace YDNSUpdater.Service {

   public partial class YDNSUpdaterService : ServiceBase {

      private ServiceConfiguration Config { get; set; }

      private DNSUpdater Updater { get; set; }

      public YDNSUpdaterService() {
         InitializeComponent();
      }

      protected override void OnStart(string[] args) {
         Debugger.Launch();
         this.Config = ServiceConfiguration.Load();
         this.timer.Interval = this.Config.CheckInterval * 60 * 1000; //minutes to milliseconds
         this.timer.Enabled = true;
      }

      protected override void OnStop() {
         this.timer.Enabled = false;
      }

      private void timer_Tick(object sender, EventArgs e) {
         this.Updater.Update();
      }

   }
}
