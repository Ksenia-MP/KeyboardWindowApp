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
    public partial class StatisticForm : Form
    {
        public StatisticForm(string u_name)
        {
            InitializeComponent();
            userNameLbl.Text = u_name;

            int w = ExercisesTab.Width - 25;
            int h = 60;

            List<Button> btns = ExerciseWork.CreateExecBtns(ExercisesTab, w, h);
            foreach (Button b in btns)
                b.Click += new System.EventHandler(exercise_Click);
        }

        private void exercise_Click(object sender, EventArgs e) // Сделать для статистики
        {
            string exrc_name = (sender as Button).Name.Replace('_', '-').Substring(3, 5);
            Exercise exrc = ExerciseWork.GetExerciseByName(exrc_name);
            this.Hide();
            ExerciseForm exerciseForm = new ExerciseForm(exrc);
            exerciseForm.ShowDialog();
            this.Show();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAllStatistic_Click(object sender, EventArgs e)
        {
            DiagrammForm diagrammForm = new DiagrammForm();
            diagrammForm.ShowDialog();
        }
    }
}
