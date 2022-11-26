using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;

namespace KeyboardWIndowApp
{
    public partial class ExerciseForm : Form
    {
        public ExerciseForm()
        {
            InitializeComponent();
            nameLbl.Text = "Тестовое упражнение";
            text = ExerciseWork.RandomText("апро", testlen);
            InitRtb();
            test = true;
            InitControls();
            shiftkey = this.Controls.Find("ShiftKey", true).FirstOrDefault() as Button;
        }

        public ExerciseForm(Exercise exrc)
        {
            InitializeComponent();
            if (exrc.IsRandom)
                text = ExerciseWork.RandomText(exrc.Text, exrc.Len);
            else text = exrc.Text;
            InitRtb();
            test = false;
            nameLbl.Text = "Упражнение " + exrc.Name;
            GetMaxParsms(exrc);
            InitControls();


            shiftkey = this.Controls.Find("ShiftKey", true).FirstOrDefault() as Button;
        }

        Color baseKeyClr = Color.SkyBlue;
        Color printedClr = Color.PaleGreen;
        Color errorClr = Color.Tomato;
        Color nextCharClr = Color.SkyBlue;
        Color nextKeyClr = Color.IndianRed;

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
                if (chartyped)
                {
                    btn.BackColor = baseKeyClr;
                }
                btn.Enabled = true;
                if (e.Shift)
                {
                    shiftkey.BackColor = baseKeyClr;
                    let.BackColor = baseKeyClr;
                }
            }
            foreach(Button button in hlBtns)
            {
                button.BackColor = baseKeyClr;
            }

            if (indx < text.Length)
                HightLightBtn(text[indx]);
        }

        List<Button> hlBtns = new List<Button>();
        Button let;
        Button shiftkey;

        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (!InputLanguage.CurrentInputLanguage.Culture.ToString().ToLower().Contains("ru"))
            {
                timer.Enabled = false;
                MessageBox.Show("Поменяйте раскладку на русскую!");
                timer.Enabled = true;
            }
            else
            {
                Button btn = GetBtn(e);
                if (e.Shift)
                {
                    let = btn;
                }
                if (btn != null)
                {
                    btn.Enabled = false;
                    //btn.BackColor = pressedKeyClr;
                }
            }
        }


        private void HightLightBtn(char btn_text)
        {
            Button btn;
            if (Char.IsUpper(btn_text))
            {
                shiftkey.BackColor = nextKeyClr;
                Shift = true;
                hlBtns.Add(shiftkey);
            }
            else
                Shift = false;

            btn = this.Controls.OfType<Button>().FirstOrDefault(b => b.Text.Equals(btn_text.ToString().ToUpper()));
            btn.BackColor = nextKeyClr;
            hlBtns.Add(btn);
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            HideKeys.Visible = !checkVK.Checked;
        }

        private void InitRtb()
        {
            if (endindx >= text.Length)
                endindx = text.Length;
            rtb.Text = text.Substring(0, endindx);
            rtb.SelectionAlignment = HorizontalAlignment.Right;
            rtb.Select(indx, 1);
            rtb.SelectionBackColor = nextCharClr;
            HightLightBtn(text[indx]);
        }

        int indx = 0;
        int endindx = 15;
        string text;// = "вкЕеаДпгОршБоПщлзПд нпгрш гшрнг аенгпшл"; //йцуйцуйцуйцулоптшагтомдкшгетмо
        bool chartyped = false;
        bool Shift;
        bool first = false;


        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (indx < text.Length)
            {
                if (!first)
                {
                    first = true;
                }
                else
                {
                    char ch = text[indx];
                    char key = e.KeyChar;
                    chartyped = false;
                    if (ch.Equals(key))
                    {

                        rtb.Select(indx, 1);
                        rtb.SelectionBackColor = printedClr;
                    }
                    else
                    {
                        rtb.Select(indx, 1);
                        rtb.SelectionBackColor = errorClr;
                        error++;
                    }

                    if (endindx < text.Length)
                    {
                        rtb.AppendText(text[endindx].ToString());
                    }
                    else
                        rtb.AppendText(" ");

                    indx++; endindx++;
                    rtb.Select(indx, 1);
                    rtb.SelectionBackColor = nextCharClr;
                    rtb.Select(endindx, 0);

                    chartyped = true;
                    rtb.Focus();

                    typed++;
                    InitControls();
                }
            }

            if (indx == text.Length)
            {
                timer.Enabled = false;
                MessageBox.Show("Finish");
            }
            e.Handled = true;
        }

        private int speed = 0;
        private int error = 0;
        private int typed = 0;
        private int time = 0;
        private int difspeed = 0;
        private int diferror = 0;
        private int len = 0;
        private int testlen = 60;

        private void GetMaxParsms(Exercise exrc)
        {
            Difficulty diff = DifficultyWork.GetDiffById(exrc.DifficultyId);
            difspeed = diff.TypeSpeed;
            len = exrc.Len;
            diferror = (int)(len * diff.ErrorPct / 100);
        }

        bool test;
        private void InitControls()
        {
            if (test)
            {
                speedLbl.Text = speed + " зн/мин";
                errorLbl.Text = error.ToString();
                len = testlen;
            }
            else
            {
                speedLbl.Text = speed + " / " + difspeed + " зн/мин";
                errorLbl.Text = error + " / " + diferror;
            }
            countLbl.Text = typed + " / " + len;
            timeLbl.Text = time + " с";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            double coeff = 60d / time;
            speed = (int)(coeff * typed);
            InitControls();
        }
    }
}
