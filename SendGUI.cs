using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows.Forms;

namespace GUISmtpClient
{
    public partial class SendGUI : Form
    {
        private SecureString SecurePassword = new SecureString();

        public SendGUI()
        {
            InitializeComponent();
        }

        private void SendGUI_Load(object sender, EventArgs e)
        {
            string[] SelectedAccount = new string[7];
            SelectedAccount = (string[])MainApplication.AccountList[MainApplication.SelectedAccount];
            this.label.Text = "Please enter the password for " + SelectedAccount[5] + ":";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Button.Enabled = false;
            this.PasswordTextBox.Hide();
            this.label.Text = "Please wait while sending message to " + MainApplication.MessageToSend.To.ToString();
            this.Button.Enabled = false;
            this.progressBar.Visible = true;
            this.Controls.Add(this.progressBar);
            SendMail();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (this.PasswordTextBox.Text != "")
                this.Button.Enabled = true;
            else
                this.Button.Enabled = false;
        }

        private void SendMail()
        {
            Classes SendNewMail = new Classes(MainApplication.MessageToSend, SecurePassword);
            SecurePassword.Dispose();
            if (SendNewMail.SendMail())
                this.Close();
            else
            {
                this.Button.Enabled = true;
                this.label.Text = "An error occured while sending, do you want to try again?";
            }
        }
    }
}