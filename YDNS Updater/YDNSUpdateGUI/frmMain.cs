using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDNSUpdateGUI {
   
   public partial class frmMain : Form {

      public frmMain() {
         InitializeComponent();
      }

      private void frmMain_Load(object sender, EventArgs e) {
         txAPIUser.Text = Program.Config["APIUser"];
         txAPIKey.Text = Program.Config["APIKey"];
         cbProxyEnabled.Checked = Program.Config["ProxyEnabled"].ToLowerInvariant().Trim() == "true" || Program.Config["ProxyEnabled"].ToLowerInvariant().Trim() == "1";
         txProxyUser.Text = Program.Config["ProxyUser"];
         txProxyPass.Text = Program.Config["ProxyPass"];
         txProxyDomain.Text = Program.Config["ProxyDomain"];
         txtHosts.Text = Program.Config["Hosts"];
      }

      private void btnCancel_Click(object sender, EventArgs e) {
         Close();
      }

      private void btnOk_Click(object sender, EventArgs e) {
         Program.SaveConfig(this);
         Close();
      }

      private void btnApply_Click(object sender, EventArgs e) {
         Program.SaveConfig(this);
         MessageBox.Show("Settings saved");
      }

   }
}
