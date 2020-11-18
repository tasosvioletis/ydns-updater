using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace YDNSUpdater.Service {

   public partial class YDNSUpdaterService : ServiceBase {

      private Timer ServiceTimer;

      private DNSUpdater YDNSService { get; set; }

      public YDNSUpdaterService() {
         InitializeComponent();
      }

      protected override void OnStart(string[] args) {
         this.YDNSService = new DNSUpdater();

         if (this.YDNSService.Config.DebugMode) {
            Debugger.Launch();
         }

         // Hook up the Elapsed event for the timer.
         ServiceTimer = new System.Timers.Timer(10000); 
         ServiceTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
         ServiceTimer.Interval = this.YDNSService.Config.CheckInterval * 60 * 1000; //minutes to milliseconds

         if (this.YDNSService.Config.DebugMode) {
            ServiceTimer.Interval = 1 * 60 * 1000; // 1 minute
         }

         ServiceTimer.Enabled = true;
      }

      protected override void OnStop() {
         ServiceTimer.Enabled = false;
         ServiceTimer.Dispose();
      }

      private void OnTimedEvent(object source, ElapsedEventArgs e) {
         if (!this.YDNSService.IsUpdated()) {
            this.YDNSService.Update();
         }
         Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
      }


   }
}
