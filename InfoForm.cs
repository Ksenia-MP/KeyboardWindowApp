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
            try
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}Resources\\info.html", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                System.Diagnostics.Process.Start(FileName);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Файл справки отсутствует");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл справки поврежден");

            }

        }

        private void AboutDev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
