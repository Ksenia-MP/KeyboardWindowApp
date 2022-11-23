using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;

namespace KeyboardWIndowApp
{
    public partial class AdminForm : Form
    {
        Button curr_btn = null;

        public AdminForm()
        {
            InitializeComponent();

            int w = ExercisesTab.Width - 25;
            int h = 60;

            List<Button> btns = ExerciseWork.CreateExecBtns(ExercisesTab, w, h);
            foreach (Button b in btns) 
                b.Click += new System.EventHandler(exercise_Click);
        }

        private void exercise_Click(object sender, EventArgs e)
        {
            if (curr_btn == (Button)sender)
            {
                curr_btn.BackColor = SystemColors.ButtonHighlight;
                curr_btn = null;
            }
            else
            {
                if (curr_btn == null)
                    curr_btn = (Button)sender;
                else
                {
                    curr_btn.BackColor = SystemColors.ButtonHighlight;
                    curr_btn = (Button)sender;
                }
                curr_btn.BackColor = Color.SkyBlue;
            }
        }

        private void LevelSettingsBtn_Click(object sender, EventArgs e)
        {
            DifficultyForm difficulty = new DifficultyForm();
            this.Hide();
            difficulty.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
