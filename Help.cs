using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUISmtpClient
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            HelpList.SelectedIndex = 0;
            MainHelp.LoadFile(MainApplication.ProgramLocation + "help\\welcome.rtf");
        }

        private void HelpList_IndexChanged(object sender, EventArgs e)
        {
            if (HelpList.SelectedIndex == 0)
            {
                MainHelp.LoadFile(MainApplication.ProgramLocation + "help\\welcome.rtf");
            }
            if (HelpList.SelectedIndex == 1)
            {
                MainHelp.LoadFile(MainApplication.ProgramLocation + "help\\problems.rtf");
            }
            if (HelpList.SelectedIndex == 2)
            {
                MainHelp.LoadFile(MainApplication.ProgramLocation + "help\\connecting.rtf");
            }
            if (HelpList.SelectedIndex == 3)
            {
                MainHelp.LoadFile(MainApplication.ProgramLocation + "help\\sending.rtf");
            }
        }
    }
}