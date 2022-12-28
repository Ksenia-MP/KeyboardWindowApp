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
    public partial class UserForm : Form
    {
        private long UID;

        public UserForm(string u_name)
        {
            InitializeComponent();
            UID = UserWork.GetUserByLogin(u_name).Id;
            userNameLbl.Text = u_name;

            int w = ExercisesTab.Width - 25;
            int h = 60;

            List<Button> btns = ExerciseWork.CreateExecBtns(ExercisesTab, w, h);
            foreach (Button b in btns)
                b.Click += new System.EventHandler(exercise_Click);
        }

        private void exercise_Click(object sender, EventArgs e)
        {
            string exrc_name = (sender as Button).Name.Replace('_', '-').Substring(3, 5);
            Exercise exrc = ExerciseWork.GetExerciseByName(exrc_name);
            this.Hide();
            ExerciseForm exerciseForm = new ExerciseForm(UID, exrc);
            exerciseForm.ShowDialog();
            this.Show();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExerciseForm exerciseForm = new ExerciseForm();
            exerciseForm.ShowDialog();
            this.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm(userNameLbl.Text);
            this.Hide();
            statisticForm.ShowDialog();
            this.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            User user = UserWork.GetUserByLogin(userNameLbl.Text);
            SettingUser su = new SettingUser(user);
            su.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
