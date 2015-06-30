using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;
using System.Security;

namespace GUISmtpClient
{
    class Classes
    {
        private string MessageLocation = "";
        private MailMessage Message = new MailMessage();
        SecureString Password = new SecureString();

        /// <summary>
        /// Creates a new instance of Class
        /// </summary>
        public Classes()
        {
            //pass no values, very usefull if you only want to open a message from file
        }

        /// <summary>
        /// Create a new instance of Class for sending property
        /// </summary>
        /// <param name="NewMailMessage">Message to be sent</param>
        /// <param name="Password">Secure String to keep Password confidential</param>
        public Classes(MailMessage NewMailMessage, SecureString password)
        {
            Message.To.Add(NewMailMessage.To.ToString());

            if (NewMailMessage.CC.Count != 0)
                Message.CC.Add(NewMailMessage.CC.ToString());

            Message.Subject = NewMailMessage.Subject;
            Message.IsBodyHtml = NewMailMessage.IsBodyHtml;
            Message.Body = NewMailMessage.Body;
            Message.BodyEncoding = NewMailMessage.BodyEncoding;

            Password = password;
            password.Dispose();
        }

        /// <summary>
        /// Create a new instance of Class for sending property
        /// </summary>
        /// <param name="NewMailMessage">Message to be sent</param>
        public Classes(MailMessage NewMailMessage)
        {
            Message.From = NewMailMessage.From;
            Message.To.Add(NewMailMessage.To.ToString());

            if (NewMailMessage.CC.ToString() != "")
                Message.CC.Add(NewMailMessage.CC.ToString());

            Message.Subject = NewMailMessage.Subject;
            Message.IsBodyHtml = NewMailMessage.IsBodyHtml;
            Message.Body = NewMailMessage.Body;
        }


        public bool SaveEmailMessage(string Filename)
        {
            try
            {
                StreamWriter WriteMessage = new StreamWriter(Filename);
                WriteMessage.WriteLine(Message.To.ToString());
                if (Message.CC.ToString() != "")
                {
                    WriteMessage.WriteLine("CC:");
                    WriteMessage.WriteLine(Message.CC.ToString());
                }
                if (Message.IsBodyHtml == true)
                    WriteMessage.WriteLine("1");
                else
                    WriteMessage.WriteLine("0");

                WriteMessage.WriteLine(Message.Subject);
                WriteMessage.WriteLine(Message.Body);
                WriteMessage.Flush();
                WriteMessage.Close();
                MessageLocation = Filename;
                return true;
            }
            catch (FormatException Error)
            {
                MessageBox.Show("Format of MEssage did not meet the parameter specification\n\n" + Error);
            }
            catch (IOException Error)
            {
                MessageBox.Show("Input/Output error\n\n" + Error);
            }
            catch (ObjectDisposedException Error)
            {
                MessageBox.Show("Operation performed on a disposed object\n\n" + Error);
            }
            catch (ArgumentNullException Error)
            {
                MessageBox.Show("Argument passed null to a method that does not accept it as a valid argument\n\n" + Error);
            }
            catch (Exception Error)
            {
                MessageBox.Show("An unknown error occured\n\n" + Error);
            }
            return false;
        }


        public MailMessage OpenMessage(string Filename)
        {
            try
            {
                MailMessage MessageFromFile = new MailMessage();
                StreamReader ReadMessage = new StreamReader(Filename);

                MessageFromFile.To.Add(ReadMessage.ReadLine());
                string buffer = ReadMessage.ReadLine();
                if (buffer == "CC:")
                {
                    MessageFromFile.CC.Add(ReadMessage.ReadLine());
                    MessageFromFile.Subject = ReadMessage.ReadLine();
                }
                else
                    MessageFromFile.Subject = buffer;


                if (ReadMessage.ReadLine() == "1")
                    MessageFromFile.IsBodyHtml = true;
                else
                    MessageFromFile.IsBodyHtml = false;

                MessageFromFile.Body = ReadMessage.ReadToEnd();
                return MessageFromFile;
            }
            catch (FileNotFoundException Error)
            {
                MessageBox.Show("File was not found, please make sure the file really exists\n\n" + Error);
            }
            catch (IOException Error)
            {
                MessageBox.Show("Input/Output error\n\n" + Error);
            }
            catch (OutOfMemoryException Error)
            {
                MessageBox.Show("Out Of memory to read any further\n\n" + Error);
            }
            catch (Exception Error)
            {
                MessageBox.Show("An unknown error occured\n\n" + Error);
            }
            return null;
        }


        public bool SendMail()
        {
            try
            {
                string[] AccountInfo = new string[7];
                AccountInfo = (string[])MainApplication.AccountList[MainApplication.SelectedAccount];
                MailMessage SendMessage = new MailMessage();
                MailAddress FromAddress = new MailAddress(AccountInfo[5], AccountInfo[4]);
                if (AccountInfo[6] != "")
                {
                    MailAddress ReplyTo = new MailAddress(AccountInfo[6]);
                    SendMessage.ReplyTo = ReplyTo;
                }
                SendMessage.From = FromAddress;
                MailAddress ToAddress = new MailAddress(MainApplication.MessageToSend.To.ToString());
                SendMessage.To.Add(ToAddress);

                if (MainApplication.MessageToSend.CC.ToString() != "")
                {
                    MailAddress CCAddress = new MailAddress(MainApplication.MessageToSend.CC.ToString());
                    SendMessage.CC.Add(CCAddress);
                }
                SendMessage.Subject = MainApplication.MessageToSend.Subject;
                SendMessage.Body = MainApplication.MessageToSend.Body;
                SendMessage.BodyEncoding = MainApplication.MessageToSend.BodyEncoding;

                SmtpClient SendMail = new SmtpClient();
                NetworkCredential Authentication = new NetworkCredential();

                Authentication.UserName = AccountInfo[3];
                Authentication.Password = Password.ToString();
                Password.Dispose();
                SendMail.Credentials = Authentication;
                SendMail.Host = AccountInfo[1];
                SendMail.Port = Convert.ToInt32(AccountInfo[2]);

                SendMail.Send(SendMessage);

                return true;
            }
            catch (SmtpFailedRecipientsException Error)
            {
                MessageBox.Show("The Message could not be delivered to all recipients\n\n" + Error);
            }
            catch (ArgumentNullException Error)
            {
                MessageBox.Show("An argument null was passed to a method when it does not accept it as a valid argument" + Error);
            }
            catch (SmtpException Error)
            {
                MessageBox.Show("The program was unable to complete the operation of sending this message" + Error);
            }
            catch (InvalidOperationException Error)
            {
                MessageBox.Show("The object current state was invalid\n\n" + Error);
            }
            catch (ArgumentOutOfRangeException Error)
            {
                MessageBox.Show("The value of an argument is outside the allowable range of values as defined by the invoked method\n\n" + Error);
            }
            return false;
        }
    }
}
