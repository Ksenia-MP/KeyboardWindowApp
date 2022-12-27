using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;
using System.IO;

namespace KeyboardWIndowApp
{
    public partial class ExerciseForm : Form
    {
        private static string FileName = string.Format("{0}Resources\\bup.wav", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
        private SoundPlayer sound = new SoundPlayer(FileName);
        //private SoundPlayer sound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\bup.wav");



        private long UID;
        private Exercise EXERC;
        private int speed = 0;
        private int error = 0;
        private int typed = 0;
        private int time = 0;
        private int difspeed = 0;
        private int diferror = 0;
        private int len = 0;
        private int testlen = 50;
        private bool test;
        private bool soundON = true;

        private List<Button> hlBtns = new List<Button>();
        private Button let;
        private Button shiftkey;

        private int indx = 0;
        private int endindx = 15;
        private string text;
        private bool chartyped = false;
        private bool first = false;

        private readonly Color baseKeyClr = Color.SkyBlue;
        private readonly Color printedClr = Color.PaleGreen;
        private readonly Color errorClr = Color.Tomato;
        private readonly Color nextCharClr = Color.SkyBlue;
        private readonly Color nextKeyClr = Color.IndianRed;

        public ExerciseForm()
        {
            InitializeComponent();
            nameLbl.Text = "Тестовое упражнение";
            List<Keyboard> keys = KeyboardWork.GetKeyboard();
            string chars = "";
            foreach (Keyboard key in keys)
            {
                if (Char.IsLetter(key.Char[0]))
                    chars += key.Char;
            }
            text = ExerciseWork.RandomText(chars, testlen);
            test = true;
            InitControls();
            shiftkey = this.Controls.Find("ShiftKey", true).FirstOrDefault() as Button;
            InitRtb();
        }

        public ExerciseForm(long user_id, Exercise exrc)
        {
            InitializeComponent();
            UID = user_id;
            EXERC = exrc;
            nameLbl.Text = "Упражнение " + exrc.Name;
            if (exrc.IsRandom)
                text = ExerciseWork.RandomText(exrc.Text, exrc.Len);
            else text = exrc.Text;

            test = false;
            shiftkey = this.Controls.Find("ShiftKey", true).FirstOrDefault() as Button;
            InitRtb();
            GetMaxParsms(exrc);
            InitControls();
        }

        private void Reload()
        {
            indx = 0;
            endindx = 15;
            speed = 0;
            error = 0;
            typed = 0;
            time = 0;
            foreach (Button b in hlBtns)
            {
                b.BackColor = baseKeyClr;
            }
        }

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
                HightLightBtn(text[indx].ToString());
        }


        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (!InputLanguage.CurrentInputLanguage.Culture.ToString().ToLower().Contains("ru"))
            {
                timer.Enabled = false;
                MessageBox.Show("Поменяйте раскладку на русскую!");
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
                }
            }
            timer.Enabled = true;
        }


        private void HightLightBtn(string btn_text)
        {
            Button btn;
            if (Char.IsUpper(btn_text[0]) || btn_text == ",")
            {
                shiftkey.BackColor = nextKeyClr;
                hlBtns.Add(shiftkey);
                if (btn_text == ",") btn_text = ". ,";
            }
            if(btn_text == ".") btn_text = ". ,";

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
            HightLightBtn(text[indx].ToString());
        }


        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soundON) sound.Play();
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


            if (!test && error > diferror)
            {
                timer.Enabled = false;
                if (DialogResult.Yes == MessageBox.Show("Вы допустили слишком много ошибок.\n" +
                    "Желаете попробовать еще раз?", ":(", MessageBoxButtons.YesNo))
                {
                    Reload();
                    if (EXERC.IsRandom)
                        text = ExerciseWork.RandomText(EXERC.Text, EXERC.Len);
                    else text = EXERC.Text;
                    InitControls();
                    InitRtb();
                }
                else Close();
            }

            if (indx == text.Length)
            {
                timer.Enabled = false;
                if(test)
                    MessageBox.Show(StatisticWork.GetTestResultString(time, len, error, speed));
                else
                {
                    int err_pct = error * 100 / len;
                    Statistics statistics = new Statistics(speed, err_pct, DateTime.Now, UID, EXERC);
                    StatisticWork.SaveStatistic(statistics);
                    MessageBox.Show(StatisticWork.GetStatisticString(time, len, error, speed));
                }
            }
            e.Handled = true;
        }


        private void GetMaxParsms(Exercise exrc)
        {
            Difficulty diff = DifficultyWork.GetDiffById(exrc.DifficultyId);
            difspeed = diff.TypeSpeed;
            len = exrc.Len;
            diferror = (int)(len * diff.ErrorPct / 100);
        }

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

        private void sound_icon_Click(object sender, EventArgs e)
        {
            if (soundON)
            {
                pictureBox1.Image = Properties.Resources.mute;
                soundON = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.volume;
                soundON = true;
            }
        }

        private void OemQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OemQuestion.Text.ToString());
        }
    }
}
