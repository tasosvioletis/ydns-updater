using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace YDNSUpdater {

   public partial class frmMain : Form {

      public ServiceConfiguration Config;

      public frmMain() {
         this.Config = ServiceConfiguration.Load();
         InitializeComponent();
      }

      private void frmMain_Load(object sender, EventArgs e) {
         this.txtCurrentIP.Text = this.GetPublicIP();
         this.yDnsConfigurationBindingSource.DataSource = this.Config;  // assign binding object
      }

      private void btnCancel_Click(object sender, EventArgs e) {
         Close();
      }

      private void btnOk_Click(object sender, EventArgs e) {
         ServiceConfiguration.Save(Config);
         Close();
      }

      private void btnApply_Click(object sender, EventArgs e) {
         ServiceConfiguration.Save(Config);
         MessageBox.Show("Settings saved");
      }

      public string GetPublicIP() {
         String direction = "";
         WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
         using (WebResponse response = request.GetResponse())
         using (StreamReader stream = new StreamReader(response.GetResponseStream())) {
            direction = stream.ReadToEnd();
         }

         //Search for the ip in the html
         int first = direction.IndexOf("Address: ") + 9;
         int last = direction.LastIndexOf("</body>");
         direction = direction.Substring(first, last - first);

         return direction;
      }
   }
}
