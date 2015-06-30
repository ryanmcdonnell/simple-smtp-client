namespace GUISmtpClient
{
    partial class Help
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
            this.HelpList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainHelp = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelpList
            // 
            this.HelpList.FormattingEnabled = true;
            this.HelpList.Items.AddRange(new object[] {
            "Welcome",
            "Problems",
            " - Problem with connecting",
            " - Problem sending e-mail"});
            this.HelpList.Location = new System.Drawing.Point(12, 43);
            this.HelpList.Name = "HelpList";
            this.HelpList.Size = new System.Drawing.Size(138, 264);
            this.HelpList.TabIndex = 0;
            this.HelpList.SelectedIndexChanged += new System.EventHandler(this.HelpList_IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "See list of known problems:";
            // 
            // MainHelp
            // 
            this.MainHelp.Location = new System.Drawing.Point(169, 23);
            this.MainHelp.Name = "MainHelp";
            this.MainHelp.Size = new System.Drawing.Size(482, 311);
            this.MainHelp.TabIndex = 2;
            this.MainHelp.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "My e-mail is: jojjn@simnet.is";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 346);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MainHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelpList);
            this.CenterToScreen();
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HelpList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MainHelp;
        private System.Windows.Forms.TextBox textBox1;
    }
}