using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class ExerciseForm : Form
    {
        public ExerciseForm()
        {
            InitializeComponent();
        }

        Color baseKeyClr = Color.SkyBlue;
        Color pressedKeyClr = Color.Azure;

        private void rtb_KeyUp(object sender, KeyEventArgs e)
        {
            int pos = e.KeyData.ToString().IndexOf(',');
            string btnname;
            if (pos < 0)
                btnname = e.KeyData.ToString();
            else
                btnname = e.KeyData.ToString().Substring(0, pos);

            Button btn = this.Controls.Find(btnname, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                btn.Enabled = true;
                btn.BackColor = baseKeyClr;
            }
        }

        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            int pos = e.KeyData.ToString().IndexOf(',');
            string btnname;
            if (pos < 0)
                btnname = e.KeyData.ToString();
            else
                btnname = e.KeyData.ToString().Substring(0, pos);

            Button btn = this.Controls.Find(btnname, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                btn.Enabled = false;
                btn.BackColor = pressedKeyClr;
            }

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            HideKeys.Visible = !checkVK.Checked;
        }

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
