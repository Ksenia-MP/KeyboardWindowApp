using System;
using System.IO;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(String.Format("file:///{0}/Info.html", curDir));
        }
    }
}
