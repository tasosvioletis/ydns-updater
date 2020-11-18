using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace YDNSUpdater {

   public partial class frmMain : Form {

      public ServiceConfiguration Config;
      public ServiceState State;

      public frmMain() {
         InitializeComponent();
      }

      private void frmMain_Load(object sender, EventArgs e) {
         this.RefreshData();
      }

      private void btnCancel_Click(object sender, EventArgs e) {
         Close();
      }

      private void btnOk_Click(object sender, EventArgs e) {
         ServiceConfiguration.Save(Config);
         this.State.RestartService();
         Close();
      }

      private void btnApply_Click(object sender, EventArgs e) {
         ServiceConfiguration.Save(Config);
         this.State.RestartService();
         MessageBox.Show("Settings saved!");
      }

      private void btnUpdateNow_Click(object sender, EventArgs e) {
         var service = new DNSUpdater();
         service.Update();
         this.RefreshData();
      }

      private void btnService_Click(object sender, EventArgs e) {
         if (this.State.IsServiceRunning){
            this.State.StopService();
         }else {
            this.State.StartService();
         }
         this.RefreshData();
      }

      private void RefreshData() {
         this.Config = ServiceConfiguration.Load();
         this.State = ServiceState.Load(this.Config);
         this.yDnsConfigurationBindingSource.DataSource = this.Config;
         this.serviceStateBindingSource.DataSource = this.State;
      }

   }
}
