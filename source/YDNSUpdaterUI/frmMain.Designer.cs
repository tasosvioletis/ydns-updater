﻿namespace YDNSUpdater
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txAPIKey = new System.Windows.Forms.TextBox();
            this.txAPIUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txProxyDomain = new System.Windows.Forms.TextBox();
            this.cbProxyEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txProxyPass = new System.Windows.Forms.TextBox();
            this.txProxyUser = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLastKnownIP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrentIP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastUpdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHosts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnUpdateNow = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.serviceStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yDnsConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDnsConfigurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 217);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txAPIKey);
            this.tabPage1.Controls.Add(this.txAPIUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Authentication";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "API Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txAPIKey
            // 
            this.txAPIKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "APIKey", true));
            this.txAPIKey.Location = new System.Drawing.Point(100, 44);
            this.txAPIKey.Name = "txAPIKey";
            this.txAPIKey.Size = new System.Drawing.Size(247, 20);
            this.txAPIKey.TabIndex = 1;
            // 
            // txAPIUser
            // 
            this.txAPIUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "APIUser", true));
            this.txAPIUser.Location = new System.Drawing.Point(100, 18);
            this.txAPIUser.Name = "txAPIUser";
            this.txAPIUser.Size = new System.Drawing.Size(247, 20);
            this.txAPIUser.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txProxyDomain);
            this.tabPage2.Controls.Add(this.cbProxyEnabled);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txProxyPass);
            this.tabPage2.Controls.Add(this.txProxyUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proxy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Domain";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txProxyDomain
            // 
            this.txProxyDomain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "ProxyDomain", true));
            this.txProxyDomain.Location = new System.Drawing.Point(101, 97);
            this.txProxyDomain.Name = "txProxyDomain";
            this.txProxyDomain.Size = new System.Drawing.Size(247, 20);
            this.txProxyDomain.TabIndex = 10;
            // 
            // cbProxyEnabled
            // 
            this.cbProxyEnabled.AutoSize = true;
            this.cbProxyEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.yDnsConfigurationBindingSource, "ProxyEnabled", true));
            this.cbProxyEnabled.Location = new System.Drawing.Point(15, 15);
            this.cbProxyEnabled.Name = "cbProxyEnabled";
            this.cbProxyEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbProxyEnabled.TabIndex = 9;
            this.cbProxyEnabled.Text = "Enabled";
            this.cbProxyEnabled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txProxyPass
            // 
            this.txProxyPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "ProxyPass", true));
            this.txProxyPass.Location = new System.Drawing.Point(101, 71);
            this.txProxyPass.Name = "txProxyPass";
            this.txProxyPass.Size = new System.Drawing.Size(247, 20);
            this.txProxyPass.TabIndex = 5;
            this.txProxyPass.UseSystemPasswordChar = true;
            // 
            // txProxyUser
            // 
            this.txProxyUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "ProxyUser", true));
            this.txProxyUser.Location = new System.Drawing.Point(101, 45);
            this.txProxyUser.Name = "txProxyUser";
            this.txProxyUser.Size = new System.Drawing.Size(247, 20);
            this.txProxyUser.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnService);
            this.tabPage3.Controls.Add(this.lblService);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnUpdateNow);
            this.tabPage3.Controls.Add(this.txtLastKnownIP);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtCurrentIP);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtLastUpdate);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtHosts);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(364, 191);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hosts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLastKnownIP
            // 
            this.txtLastKnownIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceStateBindingSource, "LastIP", true));
            this.txtLastKnownIP.Location = new System.Drawing.Point(92, 102);
            this.txtLastKnownIP.Name = "txtLastKnownIP";
            this.txtLastKnownIP.Size = new System.Drawing.Size(257, 20);
            this.txtLastKnownIP.TabIndex = 15;
            this.txtLastKnownIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Last known IP:";
            // 
            // txtCurrentIP
            // 
            this.txtCurrentIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceStateBindingSource, "CurrentIP", true));
            this.txtCurrentIP.Location = new System.Drawing.Point(92, 76);
            this.txtCurrentIP.Name = "txtCurrentIP";
            this.txtCurrentIP.Size = new System.Drawing.Size(257, 20);
            this.txtCurrentIP.TabIndex = 13;
            this.txtCurrentIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Current IP:";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceStateBindingSource, "LastUpdate", true));
            this.txtLastUpdate.Location = new System.Drawing.Point(92, 128);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(137, 20);
            this.txtLastUpdate.TabIndex = 11;
            this.txtLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Last update:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "multiple host names may applied separated with comma";
            this.label7.Visible = false;
            // 
            // txtHosts
            // 
            this.txtHosts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yDnsConfigurationBindingSource, "Hosts", true));
            this.txtHosts.Location = new System.Drawing.Point(11, 29);
            this.txtHosts.Multiline = true;
            this.txtHosts.Name = "txtHosts";
            this.txtHosts.Size = new System.Drawing.Size(338, 31);
            this.txtHosts.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Host:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(146, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(227, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(308, 235);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnUpdateNow
            // 
            this.btnUpdateNow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdateNow.Location = new System.Drawing.Point(274, 126);
            this.btnUpdateNow.Name = "btnUpdateNow";
            this.btnUpdateNow.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateNow.TabIndex = 16;
            this.btnUpdateNow.Text = "Update now";
            this.btnUpdateNow.UseVisualStyleBackColor = true;
            this.btnUpdateNow.Click += new System.EventHandler(this.btnUpdateNow_Click);
            // 
            // btnService
            // 
            this.btnService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceStateBindingSource, "IsServiceRunningButtonText", true));
            this.btnService.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnService.Location = new System.Drawing.Point(274, 155);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 19;
            this.btnService.Text = "Start";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lblService
            // 
            this.lblService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceStateBindingSource, "IsServiceRunningText", true));
            this.lblService.Location = new System.Drawing.Point(92, 157);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(137, 20);
            this.lblService.TabIndex = 18;
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Service:";
            // 
            // serviceStateBindingSource
            // 
            this.serviceStateBindingSource.DataSource = typeof(YDNSUpdater.ServiceState);
            // 
            // yDnsConfigurationBindingSource
            // 
            this.yDnsConfigurationBindingSource.DataSource = typeof(YDNSUpdater.ServiceConfiguration);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(395, 271);
            this.ControlBox = false;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YDNS Updater";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDnsConfigurationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.TextBox txAPIKey;
        public System.Windows.Forms.TextBox txAPIUser;
        public System.Windows.Forms.TextBox txProxyDomain;
        public System.Windows.Forms.CheckBox cbProxyEnabled;
        public System.Windows.Forms.TextBox txProxyPass;
        public System.Windows.Forms.TextBox txProxyUser;
      private System.Windows.Forms.Label label7;
      public System.Windows.Forms.Label txtLastUpdate;
      private System.Windows.Forms.Label label8;
      public System.Windows.Forms.TextBox txtHosts;
      public System.Windows.Forms.Label txtCurrentIP;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.BindingSource yDnsConfigurationBindingSource;
      public System.Windows.Forms.Label txtLastKnownIP;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Button btnUpdateNow;
      private System.Windows.Forms.Button btnService;
      public System.Windows.Forms.Label lblService;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.BindingSource serviceStateBindingSource;
   }
}

