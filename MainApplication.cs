using System;
using System.Text;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml;

namespace GUISmtpClient
{
    public partial class MainApplication : Form
    {



        public string MessageLocation = "";
        public static int SelectedAccount = 0;
        public static string FileLocation = "";
        public static string ProgramLocation = "";
        public static int accounts;
        public static MailMessage MessageToSend = new MailMessage();
        public static ArrayList AccountList = new ArrayList();


        public MainApplication()
        {
            InitializeComponent();
            Classes something = new Classes();
        }


        private void MainApplication_OnLoad(object sender, EventArgs e)
        {
            this.SmtpAccountsList.Items.Clear();
            string[] AccountSettings = new string[7];
            FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Smtp Client\\";
            ProgramLocation = Environment.CurrentDirectory;
            FileInfo Settings = new FileInfo(FileLocation + "settings.xml");

            SetWorkingSet(750000, 300000);
            
            #region Loading Settings from Xml file
            FileInfo IfSettingsExist = new FileInfo(FileLocation + "settings.xml");
            if (IfSettingsExist.Exists)
            {
                try
                {
                    XmlDocument DocumentSettings = new XmlDocument();
                    DocumentSettings.Load(FileLocation + "settings.xml");
                    XmlNodeReader ReadSettings = new XmlNodeReader(DocumentSettings);
                    //int current = 1;

                    while (ReadSettings.Read())
                    {
                        switch (ReadSettings.NodeType)
                        {
                            case XmlNodeType.EndElement:
                                if (ReadSettings.Name == "Account")
                                {
                                    this.SmtpAccountsList.Items.Add(AccountSettings[4] + " <" + AccountSettings[5] + ">      --" + AccountSettings[0]);
                                    AccountList.Add(AccountSettings);
                                    AccountSettings = (string[])AccountSettings.Clone();
                                }
                                break;

                            case XmlNodeType.Element:

                                //Get Account Name:
                                switch (ReadSettings.Name)
                                {


                                    case "AccountName":
                                        AccountSettings[0] = ReadSettings.ReadString();
                                        break;

                                    case "Server":
                                        AccountSettings[1] = ReadSettings.ReadString();
                                        break;

                                    case "Port":
                                        AccountSettings[2] = ReadSettings.ReadString();
                                        break;

                                    case "Username":
                                        AccountSettings[3] = ReadSettings.ReadString();
                                        break;

                                    case "Name":
                                        AccountSettings[4] = ReadSettings.ReadString();
                                        break;

                                    case "mailAddress":
                                        AccountSettings[5] = ReadSettings.ReadString();
                                        break;

                                    case "ReplyTo":
                                        AccountSettings[6] = ReadSettings.ReadString();
                                        break;
                                }
                                break;
                        }
                    }
                }
                catch (Exception ErrorMessage)
                {
                    MessageBox.Show("An unexpected error happened while loading settings:\n" + ErrorMessage + "\n\nYou are being allowed to enter this application, but not to send any e-mails until this error has been fixed (needs restarting the application)");
                }
            }
            else
            {
                Directory.CreateDirectory(FileLocation.Remove(FileLocation.Length - 1));
            }


            #endregion
        }


        public static void SetWorkingSet(int lnMaxSize, int lnMinSize)
        {
            System.Diagnostics.Process loProcess = System.Diagnostics.Process.GetCurrentProcess();
            loProcess.MaxWorkingSet = (IntPtr)lnMaxSize;
            loProcess.MinWorkingSet = (IntPtr)lnMinSize;
            //long lnValue = loProcess.WorkingSet; // see what the actual value
        }


        private void MainInput_LoadPreview(object sender, EventArgs e)
        {
            if (this.SendAsHtml.Checked)
                Preview.DocumentText = MainInput.Text;
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            if (this.ToEmailAddress.Text != "")
            {
                MailAddress ToMailAddress = new MailAddress(this.ToEmailAddress.Text);
                MessageToSend.To.Add(ToMailAddress.Address);
                if (this.CCAddress.Text != "")
                {
                    MailAddress CCMailAddress = new MailAddress(this.CCAddress.Text);
                    MessageToSend.CC.Add(CCMailAddress.Address);
                }
                MessageToSend.Subject = SubjectContent.Text;
                MessageToSend.Body = MainInput.Text;
                if (this.SendAsHtml.Checked)
                    MessageToSend.IsBodyHtml = true;
                else
                    MessageToSend.IsBodyHtml = false;

                if (this.UTF8MenuItem.Checked)
                    MessageToSend.BodyEncoding = Encoding.UTF8;
                else if (this.UTF7MenuItem.Checked)
                    MessageToSend.BodyEncoding = Encoding.UTF7;
                else if (this.UTF32MenuItem.Checked)
                    MessageToSend.BodyEncoding = Encoding.UTF32;
                else if (this.unicodeMenuItem.Checked)
                    MessageToSend.BodyEncoding = Encoding.Unicode;
                else
                    MessageToSend.BodyEncoding = Encoding.ASCII;

                SendGUI ShowGUI = new SendGUI();
                ShowGUI.ShowDialog();
                ShowGUI.Dispose();
            }
            else
                MessageBox.Show("You must type a valid e-mail address in order to be able to send a message.");
        }


        private void SmtpAccountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAccount = SmtpAccountsList.SelectedIndex;
            this.SendButton.Enabled = true;
        }



        //--------------------------Menu part------------------------//
        /*/////////////////////////////////////////////////////////////
         * This is the menu part, all items in menu have they'r events
         * here, the main reason is because this part is very easy to
         * understand and should there for not be confused with the
         * program part (above)
         */
        //////////////////////////////////////////////////////////////


        #region MenuPart


        private void CutText_Click(object sender, EventArgs e)
        {
            //Make sure the user has selected SOME text :)
            if (MainInput.SelectedText != "")
                MainInput.Cut();
        }


        private void CopyText_Click(object sender, EventArgs e)
        {
            //Make sure the user has selected SOME text :)
            if (MainInput.SelectedText != "")
                MainInput.Copy();
        }


        private void PasteText_Click(object sender, EventArgs e)
        {
            try //Just in Case ;D
            {
                MainInput.Paste();
            }
            catch (Exception ErrorPaste)
            {
                MessageBox.Show("the following error occured while pasting from clipart:\n\t" + ErrorPaste, "Error while Pasteing");
            }
        }


        private void SelectAllText_Click(object sender, EventArgs e)
        {
            MainInput.SelectAll();
        }


        private void ExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AboutDialog_Load(object sender, EventArgs e)
        {
            About LoadAboutDialog = new About();
            LoadAboutDialog.ShowDialog();
            LoadAboutDialog.Dispose();
        }


        private void HelpDialog_Click(object sender, EventArgs e)
        {
            Help LoadHelpDialog = new Help();
            LoadHelpDialog.ShowDialog();
            LoadHelpDialog.Dispose();
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult OpenMessageResults = new DialogResult();
            OpenMessageResults = OpenMessage.ShowDialog();
            if (OpenMessageResults != DialogResult.Cancel)
            {
                ToEmailAddress.Text = "";
                CCAddress.Text = "";
                SubjectContent.Text = "";
                MainInput.Text = "";

                Classes OpenMessageClass = new Classes();
                MailMessage MessageOpened = OpenMessageClass.OpenMessage(OpenMessage.FileName);

                this.ToEmailAddress.Text = MessageOpened.To.ToString();
                this.CCAddress.Text = MessageOpened.CC.ToString();
                this.SubjectContent.Text = MessageOpened.Subject;
                this.MainInput.Text = MessageOpened.Body;

                if (MessageOpened.IsBodyHtml)
                    this.SendAsHtml.Checked = true;
                else
                    this.SendAsTextOnly.Checked = true;
            }
        }


        #region SaveAsMessage_Click
        private void SaveAsMessage_Click(object sender, EventArgs e)
        {
            DialogResult SaveFileResult = new DialogResult();
            SaveFileResult = SaveMessageDialog.ShowDialog();
            if (SaveFileResult != DialogResult.Cancel)
            {
                MailMessage SaveMessage = new MailMessage();
                MailAddress ToAddress = new MailAddress(this.ToEmailAddress.Text);
                SaveMessage.To.Add(ToAddress);
                MailAddress CCAddress = new MailAddress(this.CCAddress.Text);
                SaveMessage.CC.Add(CCAddress);
                SaveMessage.Subject = this.SubjectContent.Text;
                SaveMessage.Body = this.MainInput.Text;
                Classes SaveMessageToFile = new Classes(SaveMessage);
                if (SaveMessageToFile.SaveEmailMessage(SaveMessageDialog.FileName))
                    MessageBox.Show("File got saved succesfully");
                MessageLocation = SaveMessageDialog.FileName;
            }
        }
        #endregion


        #region SaveMessage_Click
        private void SaveMessage_Click(object sender, EventArgs e)
        {
            if (MessageLocation != "")
            {
                MailMessage SaveMessage = new MailMessage();
                MailAddress ToAddress = new MailAddress(this.ToEmailAddress.Text);
                SaveMessage.To.Add(ToAddress);
                MailAddress CCAddress = new MailAddress(this.CCAddress.Text);
                SaveMessage.CC.Add(CCAddress);
                SaveMessage.Subject = this.SubjectContent.Text;
                SaveMessage.Body = this.MainInput.Text;
                Classes SaveMessageToFile = new Classes(SaveMessage);
                if (SaveMessageToFile.SaveEmailMessage(MessageLocation))
                    MessageBox.Show("File got saved succesfully");
            }
            else
            {
                DialogResult SaveFileResult = new DialogResult();
                SaveFileResult = SaveMessageDialog.ShowDialog();
                if (SaveFileResult != DialogResult.Cancel)
                {
                    MailMessage SaveMessage = new MailMessage();
                    MailAddress ToAddress = new MailAddress(this.ToEmailAddress.Text);
                    SaveMessage.To.Add(ToAddress);
                    MailAddress CCAddress = new MailAddress(this.CCAddress.Text);
                    SaveMessage.CC.Add(CCAddress);
                    SaveMessage.Subject = this.SubjectContent.Text;
                    SaveMessage.Body = this.MainInput.Text;
                    Classes SaveMessageToFile = new Classes(SaveMessage);
                    if (SaveMessageToFile.SaveEmailMessage(SaveMessageDialog.FileName))
                        MessageBox.Show("File got saved succesfully");
                    MessageLocation = SaveMessageDialog.FileName;
                }
            }
        }
        #endregion


        private void OptionsLoad_Click(object sender, EventArgs e)
        {
        }


        private void AccountSettings_Click(object sender, EventArgs e)
        {
            Account LoadAccountsSettings = new Account();
            LoadAccountsSettings.ShowDialog();
            LoadAccountsSettings.Dispose();
            this.SmtpAccountsList.Items.Clear();
            this.SendButton.Enabled = false;
            for (int I = 0; I < AccountList.Count; I++)
            {
                string[] LoadSettings = new string[7];
                LoadSettings = (string[])AccountList[I];
                this.SmtpAccountsList.Items.Add(LoadSettings[4] + " <" + LoadSettings[5] + ">      --" + LoadSettings[0]);
            }
        }


        private void WordWrap_Click(object sender, EventArgs e)
        {
            if (WordWrap.Checked)
            {
                WordWrap.Checked = false;
                MainInput.WordWrap = false;
            }
            else
            {
                WordWrap.Checked = true;
                MainInput.WordWrap = true;
            }
        }


        private void SendAsHtml_Click(object sender, EventArgs e)
        {
            if (this.SendAsTextOnly.Checked)
            {
                SendAsHtml.Checked = true;
                SendAsTextOnly.Checked = false;
                this.MainInput.Size = new System.Drawing.Size(508, 156);

                this.labelPreview.Show();
                this.Preview.Show();
                this.previewPanel.Show();

                Preview.DocumentText = MainInput.Text;
            }
        }


        private void SendAsTextOnly_Click(object sender, EventArgs e)
        {
            if (this.SendAsHtml.Checked)
            {
                SendAsHtml.Checked = false;
                SendAsTextOnly.Checked = true;
                this.labelPreview.Hide();
                this.Preview.Hide();
                this.previewPanel.Hide();
                this.MainInput.Size = new System.Drawing.Size(508, 320);
            }
        }

        private void UTF8MenuItem_Click(object sender, EventArgs e)
        {
            this.UTF8MenuItem.Checked = true;
            this.UTF7MenuItem.Checked = false;
            this.UTF32MenuItem.Checked = false;
            this.unicodeMenuItem.Checked = false;
            this.ASCIIMenuItem.Checked = false;
        }

        private void UTF7MenuItem_Click(object sender, EventArgs e)
        {
            this.UTF8MenuItem.Checked = false;
            this.UTF7MenuItem.Checked = true;
            this.UTF32MenuItem.Checked = false;
            this.unicodeMenuItem.Checked = false;
            this.ASCIIMenuItem.Checked = false;
        }

        private void UTF32MenuItem_Click(object sender, EventArgs e)
        {
            this.UTF8MenuItem.Checked = false;
            this.UTF7MenuItem.Checked = false;
            this.UTF32MenuItem.Checked = true;
            this.unicodeMenuItem.Checked = false;
            this.ASCIIMenuItem.Checked = false;
        }

        private void unicodeMenuItem_Click(object sender, EventArgs e)
        {
            this.UTF8MenuItem.Checked = true;
            this.UTF7MenuItem.Checked = false;
            this.UTF32MenuItem.Checked = false;
            this.unicodeMenuItem.Checked = true;
            this.ASCIIMenuItem.Checked = false;
        }

        private void ASCIIMenuItem_Click(object sender, EventArgs e)
        {
            this.UTF8MenuItem.Checked = false;
            this.UTF7MenuItem.Checked = false;
            this.UTF32MenuItem.Checked = false;
            this.unicodeMenuItem.Checked = false;
            this.ASCIIMenuItem.Checked = true;
        }


        #endregion

        //---------------------End of Menu part----------------------//





    }
}