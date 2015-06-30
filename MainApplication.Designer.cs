namespace GUISmtpClient
{
    partial class MainApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplication));
            this.SendButton = new System.Windows.Forms.Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.ToEmailAddress = new System.Windows.Forms.TextBox();
            this.CCAddress = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.SubjectContent = new System.Windows.Forms.TextBox();
            this.MainInput = new System.Windows.Forms.RichTextBox();
            this.labelPreview = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.Preview = new System.Windows.Forms.WebBrowser();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutText = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.Message = new System.Windows.Forms.ToolStripMenuItem();
            this.SendAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SendAsHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.SendAsTextOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.unicodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.SeperatorOptions = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMessage = new System.Windows.Forms.OpenFileDialog();
            this.SaveMessageDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelCC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SmtpAccountsList = new System.Windows.Forms.ComboBox();
            this.UTF7MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF8MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ASCIIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF32MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(409, 480);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 27);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send E-mail";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(6, 16);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "To:";
            // 
            // ToEmailAddress
            // 
            this.ToEmailAddress.Location = new System.Drawing.Point(54, 13);
            this.ToEmailAddress.Name = "ToEmailAddress";
            this.ToEmailAddress.Size = new System.Drawing.Size(448, 20);
            this.ToEmailAddress.TabIndex = 2;
            // 
            // CCAddress
            // 
            this.CCAddress.Location = new System.Drawing.Point(54, 39);
            this.CCAddress.Name = "CCAddress";
            this.CCAddress.Size = new System.Drawing.Size(448, 20);
            this.CCAddress.TabIndex = 3;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 130);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(42, 13);
            this.labelSubject.TabIndex = 15;
            this.labelSubject.Text = "Subject:";
            // 
            // SubjectContent
            // 
            this.SubjectContent.Location = new System.Drawing.Point(60, 127);
            this.SubjectContent.Name = "SubjectContent";
            this.SubjectContent.Size = new System.Drawing.Size(454, 20);
            this.SubjectContent.TabIndex = 4;
            // 
            // MainInput
            // 
            this.MainInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainInput.Location = new System.Drawing.Point(6, 154);
            this.MainInput.MaxLength = 100000;
            this.MainInput.Name = "MainInput";
            this.MainInput.Size = new System.Drawing.Size(508, 156);
            this.MainInput.TabIndex = 5;
            this.MainInput.Text = "";
            this.MainInput.TextChanged += new System.EventHandler(this.MainInput_LoadPreview);
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(5, 313);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(44, 13);
            this.labelPreview.TabIndex = 16;
            this.labelPreview.Text = "Preview:";
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPanel.Controls.Add(this.Preview);
            this.previewPanel.Location = new System.Drawing.Point(6, 329);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(508, 145);
            this.previewPanel.TabIndex = 6;
            // 
            // Preview
            // 
            this.Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview.Location = new System.Drawing.Point(0, 0);
            this.Preview.Margin = new System.Windows.Forms.Padding(1);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(504, 141);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.Message,
            this.OptionsMenuItem,
            this.HelpMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(524, 24);
            this.MenuStrip.TabIndex = 27;
            this.MenuStrip.Text = "Menu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.Separator1,
            this.SaveMessage,
            this.SaveAsMessage,
            this.Separator2,
            this.ExitApplication});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Text = "&File";
            // 
            // OpenFile
            // 
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFile.Text = "&Open";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            // 
            // SaveMessage
            // 
            this.SaveMessage.Image = ((System.Drawing.Image)(resources.GetObject("SaveMessage.Image")));
            this.SaveMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMessage.Name = "SaveMessage";
            this.SaveMessage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMessage.Text = "&Save";
            this.SaveMessage.Click += new System.EventHandler(this.SaveMessage_Click);
            // 
            // SaveAsMessage
            // 
            this.SaveAsMessage.Name = "SaveAsMessage";
            this.SaveAsMessage.Text = "Save Message &As";
            this.SaveAsMessage.Click += new System.EventHandler(this.SaveAsMessage_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Text = "E&xit";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutText,
            this.CopyText,
            this.PasteText,
            this.Separator3,
            this.SelectAllText});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Text = "&Edit";
            // 
            // CutText
            // 
            this.CutText.Image = ((System.Drawing.Image)(resources.GetObject("CutText.Image")));
            this.CutText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutText.Name = "CutText";
            this.CutText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutText.Text = "Cu&t";
            this.CutText.Click += new System.EventHandler(this.CutText_Click);
            // 
            // CopyText
            // 
            this.CopyText.Image = ((System.Drawing.Image)(resources.GetObject("CopyText.Image")));
            this.CopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyText.Text = "&Copy";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // PasteText
            // 
            this.PasteText.Image = ((System.Drawing.Image)(resources.GetObject("PasteText.Image")));
            this.PasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteText.Name = "PasteText";
            this.PasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteText.Text = "&Paste";
            this.PasteText.Click += new System.EventHandler(this.PasteText_Click);
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            // 
            // SelectAllText
            // 
            this.SelectAllText.Name = "SelectAllText";
            this.SelectAllText.Text = "Select &All";
            this.SelectAllText.Click += new System.EventHandler(this.SelectAllText_Click);
            // 
            // Message
            // 
            this.Message.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendAs,
            this.MessageFormat,
            this.toolStripSeparator2,
            this.WordWrap});
            this.Message.Name = "Message";
            this.Message.Text = "&Message";
            // 
            // SendAs
            // 
            this.SendAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendAsHtml,
            this.SendAsTextOnly});
            this.SendAs.Name = "SendAs";
            this.SendAs.Text = "Send as";
            // 
            // SendAsHtml
            // 
            this.SendAsHtml.Checked = true;
            this.SendAsHtml.CheckOnClick = true;
            this.SendAsHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SendAsHtml.Name = "SendAsHtml";
            this.SendAsHtml.Text = "Html";
            this.SendAsHtml.ToolTipText = "Send Message as Html";
            this.SendAsHtml.Click += new System.EventHandler(this.SendAsHtml_Click);
            // 
            // SendAsTextOnly
            // 
            this.SendAsTextOnly.Name = "SendAsTextOnly";
            this.SendAsTextOnly.Text = "Text/Plain";
            this.SendAsTextOnly.ToolTipText = "Send message as Text Only (All clients support this)";
            this.SendAsTextOnly.Click += new System.EventHandler(this.SendAsTextOnly_Click);
            // 
            // MessageFormat
            // 
            this.MessageFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UTF8MenuItem,
            this.UTF7MenuItem,
            this.UTF32MenuItem,
            this.unicodeMenuItem,
            this.ASCIIMenuItem});
            this.MessageFormat.Name = "MessageFormat";
            this.MessageFormat.Text = "Format";
            // 
            // unicodeMenuItem
            // 
            this.unicodeMenuItem.Name = "unicodeMenuItem";
            this.unicodeMenuItem.Text = "Unicode";
            this.unicodeMenuItem.Click += new System.EventHandler(this.unicodeMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // WordWrap
            // 
            this.WordWrap.Checked = true;
            this.WordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrap.Name = "WordWrap";
            this.WordWrap.Text = "Word Wrap";
            this.WordWrap.Click += new System.EventHandler(this.WordWrap_Click);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountSettings,
            this.SeperatorOptions,
            this.OptionsLoad});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Text = "&Options";
            // 
            // AccountSettings
            // 
            this.AccountSettings.Name = "AccountSettings";
            this.AccountSettings.Text = "Account Settings";
            this.AccountSettings.Click += new System.EventHandler(this.AccountSettings_Click);
            // 
            // SeperatorOptions
            // 
            this.SeperatorOptions.Name = "SeperatorOptions";
            // 
            // OptionsLoad
            // 
            this.OptionsLoad.Name = "OptionsLoad";
            this.OptionsLoad.Text = "&Options";
            this.OptionsLoad.Click += new System.EventHandler(this.OptionsLoad_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpDialog,
            this.Separator4,
            this.AboutDialog});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Text = "&Help";
            // 
            // HelpDialog
            // 
            this.HelpDialog.Name = "HelpDialog";
            this.HelpDialog.Text = "&Help";
            this.HelpDialog.Click += new System.EventHandler(this.HelpDialog_Click);
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            // 
            // AboutDialog
            // 
            this.AboutDialog.Name = "AboutDialog";
            this.AboutDialog.Text = "&About...";
            this.AboutDialog.Click += new System.EventHandler(this.AboutDialog_Load);
            // 
            // OpenMessage
            // 
            this.OpenMessage.FileName = "email1";
            this.OpenMessage.Filter = "Saved Messages (*.sec)|*.sec|All files (*.*)|*.*";
            // 
            // SaveMessageDialog
            // 
            this.SaveMessageDialog.Filter = "Smtp email client message (*.sec)|*.sec|All files (*.*)|*.*";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(6, 42);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(20, 13);
            this.labelCC.TabIndex = 11;
            this.labelCC.Text = "CC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToEmailAddress);
            this.groupBox1.Controls.Add(this.labelTo);
            this.groupBox1.Controls.Add(this.CCAddress);
            this.groupBox1.Controls.Add(this.labelCC);
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Use smtp account:";
            // 
            // SmtpAccountsList
            // 
            this.SmtpAccountsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SmtpAccountsList.FormattingEnabled = true;
            this.SmtpAccountsList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SmtpAccountsList.Location = new System.Drawing.Point(115, 35);
            this.SmtpAccountsList.MaxDropDownItems = 10;
            this.SmtpAccountsList.Name = "SmtpAccountsList";
            this.SmtpAccountsList.Size = new System.Drawing.Size(399, 21);
            this.SmtpAccountsList.TabIndex = 0;
            this.SmtpAccountsList.SelectedIndexChanged += new System.EventHandler(this.SmtpAccountsList_SelectedIndexChanged);
            // 
            // UTF7MenuItem
            // 
            this.UTF7MenuItem.Name = "UTF7MenuItem";
            this.UTF7MenuItem.Text = "UTF 7";
            this.UTF7MenuItem.Click += new System.EventHandler(this.UTF7MenuItem_Click);
            // 
            // UTF8MenuItem
            // 
            this.UTF8MenuItem.Checked = true;
            this.UTF8MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UTF8MenuItem.Name = "UTF8MenuItem";
            this.UTF8MenuItem.Text = "UTF 8";
            this.UTF8MenuItem.Click += new System.EventHandler(this.UTF8MenuItem_Click);
            // 
            // ASCIIMenuItem
            // 
            this.ASCIIMenuItem.Name = "ASCIIMenuItem";
            this.ASCIIMenuItem.Text = "ASCII";
            this.ASCIIMenuItem.Click += new System.EventHandler(this.ASCIIMenuItem_Click);
            // 
            // UTF32MenuItem
            // 
            this.UTF32MenuItem.Name = "UTF32MenuItem";
            this.UTF32MenuItem.Text = "UTF 32";
            this.UTF32MenuItem.Click += new System.EventHandler(this.UTF32MenuItem_Click);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 512);
            this.Controls.Add(this.SmtpAccountsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainInput);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.SubjectContent);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainApplication";
            this.Text = "Simple Smtp Email Client";
            this.Load += new System.EventHandler(this.MainApplication_OnLoad);
            this.previewPanel.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox ToEmailAddress;
        private System.Windows.Forms.TextBox CCAddress;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox SubjectContent;
        private System.Windows.Forms.RichTextBox MainInput;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.WebBrowser Preview;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem SaveMessage;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMessage;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutText;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem PasteText;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripMenuItem SelectAllText;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpDialog;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripMenuItem AboutDialog;
        private System.Windows.Forms.OpenFileDialog OpenMessage;
        private System.Windows.Forms.SaveFileDialog SaveMessageDialog;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsLoad;
        private System.Windows.Forms.ToolStripMenuItem AccountSettings;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem SendAs;
        private System.Windows.Forms.ToolStripMenuItem MessageFormat;
        private System.Windows.Forms.ToolStripMenuItem unicodeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendAsHtml;
        private System.Windows.Forms.ToolStripMenuItem SendAsTextOnly;
        private System.Windows.Forms.ToolStripSeparator SeperatorOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem WordWrap;
        public System.Windows.Forms.ComboBox SmtpAccountsList;
        private System.Windows.Forms.ToolStripMenuItem UTF7MenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF8MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ASCIIMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF32MenuItem;
    }
}

