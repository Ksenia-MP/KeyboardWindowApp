using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;
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
    public partial class StaticAdminForm : Form
    {
        public StaticAdminForm()
        {
            InitializeComponent();
            InitComBox();
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            DiagrammForm diagrammForm = new DiagrammForm(
                ExerciseWork.GetExerciseByName(comBoxExers.Text).Id, comBoxExers.Text);
            diagrammForm.ShowDialog();
        }

        private void InitComBox()
        {
            List<User> us = UserWork.GetUsersList();
            
            for (int i = 0; i < us.Count; i++)
            {
                if (!us[i].Login.Equals("admin")) 
                    comBoxUsers.Items.Add(us[i].Login);
            }
            if (us.Count == 0)
            {
                comBoxUsers.SelectedIndex = -1;
                return;
            }
            comBoxUsers.SelectedIndex = 0;

            List<DiffIdLvl> dId = DifficultyWork.GetDiffIdLvls();
            List<string> ex = new List<string>();
            for (int i = 0; i < dId.Count; i++)
            {
                ex.AddRange(ExerciseWork.GetExerciseNames(dId[i].Id));
                ex.Sort((a, b) => a.CompareTo(b));
            }
            

            for (int i = 0; i < ex.Count; i++)
            {
                comBoxExers.Items.Add(ex[i]);
            }
            if (ex.Count == 0)
            {
                comBoxExers.SelectedIndex = -1;
                return;
            }
            comBoxExers.SelectedIndex = 0;
            //string diffLvl = comBoxUsers.SelectedItem.ToString().Substring(8);
            //FillControls(diffLvl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiagrammForm diagrammForm = new DiagrammForm();
            diagrammForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiagrammForm diagrammForm = new DiagrammForm(
                comBoxUsers.Text, UserWork.GetUserByLogin(comBoxUsers.Text).Id);
            diagrammForm.ShowDialog();
        }
    }
}
