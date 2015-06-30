using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace GUISmtpClient
{
    public partial class Account : Form
    {
        ArrayList Settings = new ArrayList();
        int SettingsChanged = 0;

        public Account()
        {
            InitializeComponent();
        }

        private void ListAccounts_LoadAccountSettings(object sender, EventArgs e)
        {
                this.AccountName.Text = (string)Settings[0 + (ListAccounts.SelectedIndex * 7)];
                this.SmtpServerName.Text = (string)Settings[1 + (ListAccounts.SelectedIndex * 7)];
                this.Port.Text = (string)Settings[2 + (ListAccounts.SelectedIndex * 7)];
                this.UserName.Text = (string)Settings[3 + (ListAccounts.SelectedIndex * 7)];
                this.IdentityName.Text = (string)Settings[4 + (ListAccounts.SelectedIndex * 7)];
                this.IdentityEmail.Text = (string)Settings[5 + (ListAccounts.SelectedIndex * 7)];
                this.IdentityReplyTo.Text = (string)Settings[6 + (ListAccounts.SelectedIndex * 7)];
        }

        private void Account_Load(object sender, EventArgs e)
        {
            string[] LoadSettings = new string[7];
            FileInfo IfSettingsExist = new FileInfo(MainApplication.FileLocation + "settings.xml");
            if (IfSettingsExist.Exists == false)
            {
                this.groupBox1.Hide();
                this.label10.Hide();
                this.label6.Hide();
                this.Port.Hide();
                this.UserName.Hide();
                this.LabelUsername.Hide();
                this.labelPort.Hide();
                this.labelSmtpServer.Hide();
                this.SmtpServerName.Hide();
                this.AccountGroup.Hide();
                this.IdentityReplyTo.Hide();
                this.label5.Hide();
                this.label4.Hide();
                this.label1.Hide();
                this.IdentityName.Hide();
                this.IdentityEmail.Hide();
                this.label3.Hide();
                this.AccountName.Hide();
                this.label8.Hide();
                this.label9.Hide();

                this.label2.Text = "There are no Accounts Available, please click 'Add new Account' to add\nan Account";
            }
            else
            {
                for (int I = 0; I < MainApplication.AccountList.Count; I++)
                {
                    LoadSettings = (string[])MainApplication.AccountList[I];
                    this.ListAccounts.Items.Add(LoadSettings[0]);

                    Settings.Add(LoadSettings[0]);
                    Settings.Add(LoadSettings[1]);
                    Settings.Add(LoadSettings[2]);
                    Settings.Add(LoadSettings[3]);
                    Settings.Add(LoadSettings[4]);
                    Settings.Add(LoadSettings[5]);
                    Settings.Add(LoadSettings[6]);
                    LoadSettings = (string[])LoadSettings.Clone();
                }
                this.ListAccounts.SelectedIndex = 0;

                this.AccountName.Text = (string)Settings[0];
                this.SmtpServerName.Text = (string)Settings[1];
                this.Port.Text = (string)Settings[2];
                this.UserName.Text = (string)Settings[3];
                this.IdentityName.Text = (string)Settings[4];
                this.IdentityEmail.Text = (string)Settings[5];
                this.IdentityReplyTo.Text = (string)Settings[6];
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AccountName_Changed(object sender, EventArgs e)
        {
            Settings[0 + (ListAccounts.SelectedIndex * 7)] = this.AccountName.Text;
        }

        private void SmtpServerName_Changed(object sender, EventArgs e)
        {
            Settings[1 + (ListAccounts.SelectedIndex * 7)] = this.SmtpServerName.Text;
        }

        private void Port_Changed(object sender, EventArgs e)
        {
            Settings[2 + (ListAccounts.SelectedIndex * 7)] = this.Port.Text;
        }

        private void UserName_Changed(object sender, EventArgs e)
        {
            Settings[3 + (ListAccounts.SelectedIndex * 7)] = this.UserName.Text;
        }

        private void IdentityName_Changed(object sender, EventArgs e)
        {
            Settings[4 + (ListAccounts.SelectedIndex * 7)] = this.IdentityName.Text;
        }

        private void IdentityEmail_Changed(object sender, EventArgs e)
        {
            Settings[5 + (ListAccounts.SelectedIndex * 7)] = this.IdentityEmail.Text;
        }

        private void IdentityReplyTo_Changed(object sender, EventArgs e)
        {
            Settings[6 + (ListAccounts.SelectedIndex * 7)] = this.IdentityReplyTo.Text;
        }


        private void AddAccount_Click(object sender, EventArgs e)
        {
            if (label2.Text.Length > 15)
            {
                this.groupBox1.Show();
                this.label10.Show();
                this.label6.Show();
                this.Port.Show();
                this.UserName.Show();
                this.LabelUsername.Show();
                this.labelPort.Show();
                this.labelSmtpServer.Show();
                this.SmtpServerName.Show();
                this.AccountGroup.Show();
                this.IdentityReplyTo.Show();
                this.label5.Show();
                this.label4.Show();
                this.label1.Show();
                this.IdentityName.Show();
                this.IdentityEmail.Show();
                this.label3.Show();
                this.AccountName.Show();
                this.label8.Show();
                this.label9.Show();

                this.label2.Text = "Account name:";
            }
            this.ListAccounts.Items.Add("New Account");

            Settings.Add("New Account");
            Settings.Add("");
            Settings.Add("25");
            Settings.Add("");
            Settings.Add("");
            Settings.Add("");
            Settings.Add("");

            if (this.ListAccounts.Items.Count > 0)
                this.ListAccounts.SelectedIndex = this.ListAccounts.Items.Count - 1;
            else
                this.ListAccounts.SelectedIndex = this.ListAccounts.Items.Count;
            SettingsChanged = SettingsChanged + 1;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            bool SaveSettings = true;
            for (int A = 0; A < this.ListAccounts.Items.Count; A++)
            {
                for (int I = 0; I < 6; I++)
                {
                    if ((string)Settings[I + (A * 7)] == "")
                        SaveSettings = false;
                }
            }
            if (SaveSettings)
            {
                FileInfo IfSettingsExist = new FileInfo(MainApplication.FileLocation + "settings.xml");
                string[] SaveToMain = new string[7];
                if (IfSettingsExist.Exists)
                {
                    XmlDocument WriteSettings = new XmlDocument();
                    try
                    {
                        int currentAccount = 0;
                        WriteSettings.Load(MainApplication.FileLocation + "settings.xml");
                        XPathNavigator nav = WriteSettings.CreateNavigator();
                        XPathNodeIterator accounts = nav.Select("/Settings/Account");


                        while (accounts.MoveNext()) // visits each "Account" element.
                        {
                            XPathNavigator account = accounts.Current;
                            // Select all child elements (skip comments, pi's, cdata, just visit elements).
                            XPathNodeIterator children = account.Select("*");
                            while (children.MoveNext())
                            {
                                XPathNavigator child = children.Current;
                                switch (child.LocalName)
                                {
                                    case "AccountName":
                                        child.SetValue((string)Settings[0 + (currentAccount * 7)]);
                                        SaveToMain[0] = (string)Settings[0 + (currentAccount * 7)];
                                        break;

                                    case "Server":
                                        child.SetValue((string)Settings[1 + (currentAccount * 7)]);
                                        SaveToMain[1] = (string)Settings[1 + (currentAccount * 7)];
                                        break;

                                    case "Port":
                                        child.SetValue((string)Settings[2 + (currentAccount * 7)]);
                                        SaveToMain[2] = (string)Settings[2 + (currentAccount * 7)];
                                        break;

                                    case "Username":
                                        child.SetValue((string)Settings[3 + (currentAccount * 7)]);
                                        SaveToMain[3] = (string)Settings[3 + (currentAccount * 7)];
                                        break;

                                    case "Name":
                                        child.SetValue((string)Settings[4 + (currentAccount * 7)]);
                                        SaveToMain[4] = (string)Settings[4 + (currentAccount * 7)];
                                        break;

                                    case "mailAddress":
                                        child.SetValue((string)Settings[5 + (currentAccount * 7)]);
                                        SaveToMain[5] = (string)Settings[5 + (currentAccount * 7)];
                                        break;

                                    case "ReplyTo":
                                        child.SetValue((string)Settings[6 + (currentAccount * 7)]);
                                        SaveToMain[6] = (string)Settings[6 + (currentAccount * 7)];
                                        break;
                                }
                            }
                            MainApplication.AccountList[currentAccount] = SaveToMain;
                            SaveToMain = (string[])SaveToMain.Clone();

                            currentAccount++;
                        }

                        nav.MoveToRoot();
                        nav.MoveToFirstChild();

                        for (int NrAccount = 0; NrAccount < SettingsChanged; NrAccount++)
                        {
                            XmlElement NewAccount = WriteSettings.CreateElement("Account");
                            XmlElement NameAccount = WriteSettings.CreateElement("AccountName");
                            NameAccount.InnerText = (string)Settings[0 + (ListAccounts.Items.Count - NrAccount - 1) * 7];

                            XmlElement Server = WriteSettings.CreateElement("Server");
                            Server.InnerText = (string)Settings[1 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];

                            XmlElement Port = WriteSettings.CreateElement("Port");
                            Port.InnerText = (string)Settings[2 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];

                            XmlElement Username = WriteSettings.CreateElement("Username");
                            Username.InnerText = (string)Settings[3 + ((ListAccounts.Items.Count + NrAccount - 1) * 7)];

                            XmlElement Name = WriteSettings.CreateElement("Name");
                            Name.InnerText = (string)Settings[4 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];

                            XmlElement mailAddress = WriteSettings.CreateElement("mailAddress");
                            mailAddress.InnerText = (string)Settings[5 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];

                            XmlElement ReplyTo = WriteSettings.CreateElement("ReplyTo");
                            ReplyTo.InnerText = (string)Settings[6 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];

                            NewAccount.AppendChild(NameAccount);
                            NewAccount.AppendChild(Server);
                            NewAccount.AppendChild(Port);
                            NewAccount.AppendChild(Username);
                            NewAccount.AppendChild(Name);
                            NewAccount.AppendChild(mailAddress);
                            NewAccount.AppendChild(ReplyTo);

                            WriteSettings.AppendChild(NewAccount);

                            SaveToMain[0] = (string)Settings[0 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[1] = (string)Settings[1 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[2] = (string)Settings[2 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[3] = (string)Settings[3 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[4] = (string)Settings[4 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[5] = (string)Settings[5 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            SaveToMain[6] = (string)Settings[6 + ((ListAccounts.Items.Count - NrAccount - 1) * 7)];
                            MainApplication.AccountList.Add(SaveToMain);
                            SaveToMain = (string[])SaveToMain.Clone();
                        }

                        XmlTextWriter Writer = new XmlTextWriter(MainApplication.FileLocation + "settings.xml", null);
                        Writer.Formatting = Formatting.Indented;

                        WriteSettings.Save(Writer);
                        this.Close();
                    }
                    catch (Exception ErrorMessage)
                    {
                        MessageBox.Show("En Error occured while saving settings: \n\n" + ErrorMessage);
                    }
                }
                else
                {
                    try
                    {
                        XmlTextWriter writer = new XmlTextWriter(MainApplication.FileLocation + "settings.xml", null);
                        writer.Formatting = Formatting.Indented;
                        writer.Indentation = 5;

                        writer.WriteStartElement("Settings");
                        for (int I = 0; I < this.ListAccounts.Items.Count; I++)
                        {
                            writer.WriteStartElement("Account");

                            writer.WriteStartElement("AccountName");
                            writer.WriteString((string)Settings[0 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Server");
                            writer.WriteString((string)Settings[1 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Port");
                            writer.WriteString((string)Settings[2 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Username");
                            writer.WriteString((string)Settings[3 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Name");
                            writer.WriteString((string)Settings[4 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("mailAddress");
                            writer.WriteString((string)Settings[5 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("ReplyTo");
                            writer.WriteString((string)Settings[6 + (7 * I)]);
                            writer.WriteEndElement();

                            writer.WriteEndElement();

                            SaveToMain[0] = (string)Settings[0 + (I * 7)];
                            SaveToMain[1] = (string)Settings[1 + (I * 7)];
                            SaveToMain[2] = (string)Settings[2 + (I * 7)];
                            SaveToMain[3] = (string)Settings[3 + (I * 7)];
                            SaveToMain[4] = (string)Settings[4 + (I * 7)];
                            SaveToMain[5] = (string)Settings[5 + (I * 7)];
                            SaveToMain[6] = (string)Settings[6 + (I * 7)];
                            MainApplication.AccountList.Add(SaveToMain);
                            SaveToMain = (string[])SaveToMain.Clone();
                        }
                        writer.WriteEndElement();
                        writer.Flush();
                        writer.Close();
                        this.Close();
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("En Error occured while saving settings: \n\n" + Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill these values befour continuing:\n\t* Name Account\n\t* Server, Port and username\n\t* e-mail address and name");
            }
        }
    }
}