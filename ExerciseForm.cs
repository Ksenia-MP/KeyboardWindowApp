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
            InitRtb();
        }

        Color baseKeyClr = Color.SkyBlue;
        Color pressedKeyClr = Color.Azure;
        Color printedClr = Color.PaleGreen;
        Color errorClr = Color.Tomato;
        Color nextCharClr = Color.SkyBlue;

        private Button GetBtn(KeyEventArgs e)
        {
            int pos = e.KeyData.ToString().IndexOf(',');
            string btnname;
            if (pos < 0)
                btnname = e.KeyData.ToString();
            else
                btnname = e.KeyData.ToString().Substring(0, pos);
            return this.Controls.Find(btnname, true).FirstOrDefault() as Button;
        }

        private void rtb_KeyUp(object sender, KeyEventArgs e)
        {
            Button btn = GetBtn(e);
            
            if (btn != null)
            {
                btn.Enabled = true;
                btn.BackColor = baseKeyClr;
            }
        }

        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (!InputLanguage.CurrentInputLanguage.Culture.ToString().ToLower().Contains("ru"))
            {
                MessageBox.Show("Поменяйте раскладку на русскую!");
            }
            else
            {
                Button btn = GetBtn(e);
                
                if (btn != null)
                {
                    btn.Enabled = false;
                    btn.BackColor = pressedKeyClr;
                }
            }
        }


        private void HightLightBtn(char btn_text)
        {
            Button btn;
            if (Char.IsUpper(btn_text))
            {
                btn = this.Controls.OfType<Button>().FirstOrDefault(b => b.Text.Equals("Shift"));
                btn.BackColor = Color.Red;
                Shift = true;
            }
            else
                Shift = false;

            btn = this.Controls.OfType<Button>().FirstOrDefault(b => b.Text.Equals(btn_text.ToString().ToUpper()));
            btn.BackColor = Color.Red;
               
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            HideKeys.Visible = !checkVK.Checked;
        }

        private void InitRtb()
        {
            rtb.Text = text.Substring(0, endindx);
            rtb.SelectionAlignment = HorizontalAlignment.Right;
            rtb.Select(indx, 1);
            rtb.SelectionBackColor = nextCharClr;
            HightLightBtn(text[indx]);
        }

        int indx = 0;
        int endindx = 20;
        string text = "вкЕеаДпгОршБоПщлзПд нпгрш гшрнг аенгпшл"; //йцуйцуйцуйцулоптшагтомдкшгетмо
        bool Shift = false;

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = text[indx];
            char key = e.KeyChar;
            if (ch.Equals(key))
            {
                if (endindx < text.Length)
                {
                    rtb.AppendText(text[endindx].ToString());
                }
                else
                    rtb.AppendText(" ");
                rtb.Select(indx, 1);
                rtb.SelectionBackColor = printedClr;
                indx++; endindx++;
                rtb.Select(indx, 1);
                rtb.SelectionBackColor = nextCharClr;
                rtb.Select(endindx, 0);
                HightLightBtn(text[indx]);
            }
            rtb.Focus();
        }
    }
}
