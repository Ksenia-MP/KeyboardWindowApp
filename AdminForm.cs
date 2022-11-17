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

        private List<string> GetExerciseNames()
        {
            using (Context context = new Context())
            {
                int dID = int.Parse(ExercisesTab.SelectedTab.Name.Substring(3));
                return context.Exercise.Where(e => e.DifficultyId == dID).Select(e => e.Name).ToList();
            }
        }

        private void DrawTabs(TabControl tb, int btn_width, int btn_height)
        {
            //получим список уровней сложности и добавим вкладки в tb
            List<DiffIdLvl> difficulties = DifficultyWork.GetDiffIdLvls();
            for (int i = 0; i < difficulties.Count; i++)
            {
                tb.TabPages.Add(new TabPage()
                {
                    Name = "dif" + difficulties[i].Level,
                    Text = "lvl " + difficulties[i].Level
                });

            }

            //заполним вкладки tb кнопками с упражнениями
            List<Button> btns = new List<Button>();     //список кнопок

            for (int i = 0; i < difficulties.Count; i++)
            {

            }
            List<string> names = GetExerciseNames();
            for (int i = 0; i < names.Count; i++)
            {
                btns.Add(new Button()
                {
                    Name = i + "Btn",
                    Text = "Упражнение " + names[i],
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { MouseOverBackColor = Color.SkyBlue },
                    BackColor = SystemColors.ButtonHighlight,
                    Location = new Point(0, i * (btn_height + 15) + 10),
                    Height = btn_height,
                    Width = btn_width
                });

                btns[i].Click += new System.EventHandler(exercise_Click);
                tb.SelectedTab.Controls.Add(btns[i]);
            }
        }


        private void LevelSettingsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
