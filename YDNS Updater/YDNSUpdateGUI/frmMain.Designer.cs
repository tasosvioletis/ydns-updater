namespace YDNSUpdateGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txAPIUser = new System.Windows.Forms.TextBox();
            this.txAPIKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txProxyPass = new System.Windows.Forms.TextBox();
            this.txProxyUser = new System.Windows.Forms.TextBox();
            this.cbProxyEnabled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txProxyDomain = new System.Windows.Forms.TextBox();
            this.lbHosts = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 187);
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
            this.tabPage1.Size = new System.Drawing.Size(364, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Authentication";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(364, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proxy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDel);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lbHosts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(364, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hosts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txAPIUser
            // 
            this.txAPIUser.Location = new System.Drawing.Point(100, 18);
            this.txAPIUser.Name = "txAPIUser";
            this.txAPIUser.Size = new System.Drawing.Size(247, 20);
            this.txAPIUser.TabIndex = 0;
            // 
            // txAPIKey
            // 
            this.txAPIKey.Location = new System.Drawing.Point(100, 44);
            this.txAPIKey.Name = "txAPIKey";
            this.txAPIKey.Size = new System.Drawing.Size(247, 20);
            this.txAPIKey.TabIndex = 1;
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(146, 205);
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
            this.btnCancel.Location = new System.Drawing.Point(227, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.txProxyPass.Location = new System.Drawing.Point(101, 71);
            this.txProxyPass.Name = "txProxyPass";
            this.txProxyPass.Size = new System.Drawing.Size(247, 20);
            this.txProxyPass.TabIndex = 5;
            this.txProxyPass.UseSystemPasswordChar = true;
            // 
            // txProxyUser
            // 
            this.txProxyUser.Location = new System.Drawing.Point(101, 45);
            this.txProxyUser.Name = "txProxyUser";
            this.txProxyUser.Size = new System.Drawing.Size(247, 20);
            this.txProxyUser.TabIndex = 4;
            // 
            // cbProxyEnabled
            // 
            this.cbProxyEnabled.AutoSize = true;
            this.cbProxyEnabled.Location = new System.Drawing.Point(15, 15);
            this.cbProxyEnabled.Name = "cbProxyEnabled";
            this.cbProxyEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbProxyEnabled.TabIndex = 9;
            this.cbProxyEnabled.Text = "Enabled";
            this.cbProxyEnabled.UseVisualStyleBackColor = true;
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
            this.txProxyDomain.Location = new System.Drawing.Point(101, 97);
            this.txProxyDomain.Name = "txProxyDomain";
            this.txProxyDomain.Size = new System.Drawing.Size(247, 20);
            this.txProxyDomain.TabIndex = 10;
            // 
            // lbHosts
            // 
            this.lbHosts.FormattingEnabled = true;
            this.lbHosts.Location = new System.Drawing.Point(11, 28);
            this.lbHosts.Name = "lbHosts";
            this.lbHosts.Size = new System.Drawing.Size(312, 121);
            this.lbHosts.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hosts to update with this IP:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(330, 57);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(27, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(308, 205);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.ControlBox = false;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YDNS Updater Service GUI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.TextBox txAPIKey;
        public System.Windows.Forms.TextBox txAPIUser;
        public System.Windows.Forms.TextBox txProxyDomain;
        public System.Windows.Forms.CheckBox cbProxyEnabled;
        public System.Windows.Forms.TextBox txProxyPass;
        public System.Windows.Forms.TextBox txProxyUser;
        public System.Windows.Forms.ListBox lbHosts;
    }
}

