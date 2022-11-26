using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class CreateExercise : Form
    {
        private Exercise _exercise = new Exercise();
        List<Difficulty> difficulties = DifficultyWork.GetDifficultyes();
        public CreateExercise()
        {
            InitializeComponent();
            InitDifficultyes();
            exerciseName.MaxLength = 2;
        }

        public CreateExercise(Exercise exercise)
        {
            InitializeComponent();
            InitDifficultyes();
            exerciseName.MaxLength = 2;
            _exercise = exercise;
            diffComBox.Text = "Уровень " + exercise.Difficulty.Level;
            diffName.Text = exercise.Name.Split('-')[0] + "-";
            exerciseName.Text = exercise.Name.Split('-')[1];
            countChar.Value = exercise.Len;
            exerciseText.Text = exercise.Text;
            if (exercise.IsRandom) generateBut.BackColor = Color.SteelBlue;
            character.Text = "";
            foreach (var c in exercise.Text)
                if (!character.Text.Contains(c))
                    character.Text += c;
        }
        private void InitDifficultyes()
        {
            difficulties.Sort((a, b) => a.Level.CompareTo(b.Level));

            for (int i = 0; i < difficulties.Count; i++)
            {
                diffComBox.Items.Add("Уровень " + difficulties[i].Level);
            }
            if (diffComBox.Items.Count == 0)
            {
                diffComBox.SelectedIndex = -1;
                return;
            }
            diffComBox.SelectedIndex = 0;
            string diffLvl = diffComBox.SelectedItem.ToString().Substring(8);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|exc files (*.exc)|*.exc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    exerciseText.Text = reader.ReadToEnd();
                }
                foreach (var c in exerciseText.Text)
                    if (!character.Text.Contains(c))
                        character.Text += c;
                countChar.Value = exerciseText.TextLength;
                int i = 0;
                while (exerciseText.TextLength > difficulties[i++].MaxLen && i < difficulties.Count)
                    diffComBox.Text = "Уровень " + difficulties[i].Level;
            }

        }

        private void diffComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            diffName.Text = "0" + diffComBox.Text[8] + "-";
        }

        private void exerciseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            _exercise.Name = diffName.Text + exerciseName.Text;
            _exercise.Len = (int)(countChar.Value);
            _exercise.Text = exerciseText.Text;
            if (generateBut.BackColor == Color.SteelBlue)
                _exercise.IsRandom = true;
            int i = 0;
            while (difficulties[i++].Id == diffComBox.Text[8])
            {
                _exercise.DifficultyId = difficulties[i].Id;
                _exercise.Difficulty = difficulties[i];
            }
            if (_exercise.Id == 0)
            {
                using (Context context = new Context())
                {
                    context.Exercise.Add(_exercise);
                    context.SaveChanges();
                }
            }
            else
            {
                using (Context context = new Context())
                {
                    context.Exercise.Update(_exercise);
                    context.SaveChanges();
                }
            }
        }

        private void exerciseText_KeyPress(object sender, KeyPressEventArgs e)
        {
            countChar.Value = exerciseText.TextLength;
            foreach (var c in exerciseText.Text)
                if (!character.Text.Contains(c))
                    character.Text += c;
            int i = 0;
            while (exerciseText.TextLength > difficulties[i++].MaxLen && i < difficulties.Count)
                diffComBox.Text = "Уровень " + difficulties[i].Level;
            char number = e.KeyChar;
            if ( number == 8)
            {
                e.Handled = true;
                character.Text = "";
                foreach (var c in exerciseText.Text)
                    if (!character.Text.Contains(c))
                        character.Text += c;
                countChar.Value = exerciseText.TextLength;
                int j = 0;
                while (exerciseText.TextLength > difficulties[j++].MaxLen && j < difficulties.Count)
                    diffComBox.Text = "Уровень " + difficulties[j].Level;
            }    
                
        }
    }
}
