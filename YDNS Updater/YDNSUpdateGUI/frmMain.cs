using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDNSUpdateGUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txAPIUser.Text = Program.Config["API"]["User"];
            txAPIKey.Text = Program.Config["API"]["Key"];
            cbProxyEnabled.Checked = Program.Config["Proxy"]["Enabled"].ToLowerInvariant().Trim() == "true" || Program.Config["Proxy"]["Enabled"].ToLowerInvariant().Trim() == "1";
            txProxyUser.Text = Program.Config["Proxy"]["User"];
            txProxyPass.Text = Program.Config["Proxy"]["Pass"];
            txProxyDomain.Text = Program.Config["Proxy"]["Domain"];
            foreach (string host in Program.Config["Hosts"].Keys)
                lbHosts.Items.Add(host);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.SaveConfig(this);
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string host = "";
            InputDialog.Show(ref host);
            if (!string.IsNullOrEmpty(host))
                if (lbHosts.Items.Cast<string>().Where(x => x.ToLowerInvariant().Trim() == host.ToLowerInvariant().Trim()).SingleOrDefault() == null)
                    lbHosts.Items.Add(host);
                else
                    MessageBox.Show("The host already exists");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = lbHosts.SelectedItems.Count - 1; i >= 0; i--)
                lbHosts.Items.Remove(lbHosts.SelectedItems[i]);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Program.SaveConfig(this);
            MessageBox.Show("Settings saved");
        }
    }
}
