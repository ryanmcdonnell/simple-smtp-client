namespace GUISmtpClient
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelSmtpServer = new System.Windows.Forms.Label();
            this.SmtpServerName = new System.Windows.Forms.TextBox();
            this.AccountGroup = new System.Windows.Forms.GroupBox();
            this.IdentityReplyTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentityName = new System.Windows.Forms.TextBox();
            this.IdentityEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAccount = new System.Windows.Forms.Button();
            this.ListAccounts = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.AccountGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.LabelUsername);
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.labelSmtpServer);
            this.groupBox1.Controls.Add(this.SmtpServerName);
            this.groupBox1.Location = new System.Drawing.Point(153, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(382, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Default: 25";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(314, 22);
            this.Port.MaxLength = 5;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(41, 20);
            this.Port.TabIndex = 4;
            this.Port.Text = "25";
            this.Port.TextChanged += new System.EventHandler(this.Port_Changed);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(78, 50);
            this.UserName.MaxLength = 82;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(199, 20);
            this.UserName.TabIndex = 5;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_Changed);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(8, 53);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(54, 13);
            this.LabelUsername.TabIndex = 12;
            this.LabelUsername.Text = "Username:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(283, 25);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(25, 13);
            this.labelPort.TabIndex = 11;
            this.labelPort.Text = "Port:";
            // 
            // labelSmtpServer
            // 
            this.labelSmtpServer.AutoSize = true;
            this.labelSmtpServer.Location = new System.Drawing.Point(8, 25);
            this.labelSmtpServer.Name = "labelSmtpServer";
            this.labelSmtpServer.Size = new System.Drawing.Size(64, 13);
            this.labelSmtpServer.TabIndex = 9;
            this.labelSmtpServer.Text = "Smtp Server:";
            // 
            // SmtpServerName
            // 
            this.SmtpServerName.Location = new System.Drawing.Point(78, 22);
            this.SmtpServerName.MaxLength = 82;
            this.SmtpServerName.Name = "SmtpServerName";
            this.SmtpServerName.Size = new System.Drawing.Size(199, 20);
            this.SmtpServerName.TabIndex = 3;
            this.SmtpServerName.TextChanged += new System.EventHandler(this.SmtpServerName_Changed);
            // 
            // AccountGroup
            // 
            this.AccountGroup.BackColor = System.Drawing.Color.Transparent;
            this.AccountGroup.Controls.Add(this.IdentityReplyTo);
            this.AccountGroup.Controls.Add(this.label5);
            this.AccountGroup.Controls.Add(this.label4);
            this.AccountGroup.Controls.Add(this.label1);
            this.AccountGroup.Controls.Add(this.IdentityName);
            this.AccountGroup.Controls.Add(this.IdentityEmail);
            this.AccountGroup.Controls.Add(this.label3);
            this.AccountGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountGroup.Location = new System.Drawing.Point(152, 240);
            this.AccountGroup.Name = "AccountGroup";
            this.AccountGroup.Size = new System.Drawing.Size(423, 145);
            this.AccountGroup.TabIndex = 6;
            this.AccountGroup.TabStop = false;
            this.AccountGroup.Text = "Default Identity";
            // 
            // IdentityReplyTo
            // 
            this.IdentityReplyTo.Location = new System.Drawing.Point(102, 110);
            this.IdentityReplyTo.MaxLength = 124;
            this.IdentityReplyTo.Name = "IdentityReplyTo";
            this.IdentityReplyTo.Size = new System.Drawing.Size(305, 20);
            this.IdentityReplyTo.TabIndex = 9;
            this.IdentityReplyTo.TextChanged += new System.EventHandler(this.IdentityReplyTo_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reply-to address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Each account has an identity, which is the information user sees when reading\r\nyo" +
                "ur messages (E-mails)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Name:";
            // 
            // IdentityName
            // 
            this.IdentityName.Location = new System.Drawing.Point(102, 57);
            this.IdentityName.MaxLength = 124;
            this.IdentityName.Name = "IdentityName";
            this.IdentityName.Size = new System.Drawing.Size(305, 20);
            this.IdentityName.TabIndex = 7;
            this.IdentityName.TextChanged += new System.EventHandler(this.IdentityName_Changed);
            // 
            // IdentityEmail
            // 
            this.IdentityEmail.Location = new System.Drawing.Point(102, 84);
            this.IdentityEmail.MaxLength = 124;
            this.IdentityEmail.Name = "IdentityEmail";
            this.IdentityEmail.Size = new System.Drawing.Size(305, 20);
            this.IdentityEmail.TabIndex = 8;
            this.IdentityEmail.TextChanged += new System.EventHandler(this.IdentityEmail_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email address:";
            // 
            // AccountName
            // 
            this.AccountName.Location = new System.Drawing.Point(253, 59);
            this.AccountName.MaxLength = 52;
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(130, 20);
            this.AccountName.TabIndex = 1;
            this.AccountName.TextChanged += new System.EventHandler(this.AccountName_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account name:";
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(12, 350);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(129, 26);
            this.AddAccount.TabIndex = 12;
            this.AddAccount.Text = "Add new account";
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // ListAccounts
            // 
            this.ListAccounts.FormattingEnabled = true;
            this.ListAccounts.Location = new System.Drawing.Point(12, 25);
            this.ListAccounts.Name = "ListAccounts";
            this.ListAccounts.Size = new System.Drawing.Size(129, 316);
            this.ListAccounts.TabIndex = 0;
            this.ListAccounts.SelectedIndexChanged += new System.EventHandler(this.ListAccounts_LoadAccountSettings);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Location = new System.Drawing.Point(154, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 31);
            this.panel1.TabIndex = 10;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(4, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(164, 23);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Account Setting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Configure your Accounts here, make sure all values are correct.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Type the name of the account which you would like to name\r\nit, etc. \'Work account" +
                "\' or \'Home\' and so on";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(489, 392);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 26);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(399, 392);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(84, 26);
            this.Ok.TabIndex = 10;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Smtp Accounts:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AccountGroup);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.ListAccounts);
            this.Controls.Add(this.label2);
            this.Name = "Account";
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AccountGroup.ResumeLayout(false);
            this.AccountGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelSmtpServer;
        private System.Windows.Forms.TextBox SmtpServerName;
        private System.Windows.Forms.GroupBox AccountGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentityName;
        private System.Windows.Forms.TextBox AccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentityEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.ListBox ListAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox IdentityReplyTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label7;
    }
}