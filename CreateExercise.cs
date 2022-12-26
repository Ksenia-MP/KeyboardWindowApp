using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class CreateExercise : Form
    {
        private Exercise _exercise = new Exercise();
        private List<Difficulty> difficulties = DifficultyWork.GetDifficultyes();
        private static List<Keyboard> keys = KeyboardWork.GetKeyboard();
        private List<string> diffZones = new List<string>();

        private List<int> type_zones;
        private List<Panel> panels = new List<Panel>();

        private bool GenerateState = false;
        private bool OpenState = false;

        Color noColor = Color.Transparent;
        Color setClr = Color.FromArgb(100, Color.Green);
        Color onRndClr = Color.SkyBlue;
        Color offRndClr = SystemColors.ControlLightLight;



        public CreateExercise()
        {
            InitializeComponent();
            InitPanels();
            InitDifficultyes();
        }

        public CreateExercise(Exercise exercise)
        {
            InitializeComponent();
            InitPanels();
            InitDifficultyes();
            _exercise = exercise;
            diffComBox.Text = "Уровень " + exercise.Difficulty.Level;
            diffName.Text = exercise.Name.Split('-')[0] + "-";
            exerciseName.Text = exercise.Name.Split('-')[1];
            countChar.Value = exercise.Len;
            if (exercise.IsRandom)
            {
                GenerateState = true;
                character.Text = exercise.Text;
                generateBut.BackColor = onRndClr;
                exerciseText.Text = ExerciseWork.RandomText(character.Text, (int)countChar.Value);
            }
            else
            {
                exerciseText.Text = exercise.Text;
                character.Text = "Набрано " + exercise.Len + " символов";
            }
            refresh.Visible = GenerateState;
            character.ReadOnly = !GenerateState;
            exerciseText.ReadOnly = GenerateState;
        }

        private void InitPanels()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Panel panel) panels.Add(panel);
            }
            panels.Sort((a, b) => a.Name.CompareTo(b.Name));

            SetPolygon(panels.Find(z => z.Name.Equals("zone1")), KeyboardWork.center_zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone2")), KeyboardWork.center_zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone3")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone4")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone5")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone6")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone7")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone8")), KeyboardWork.right_zone_points);
        }

        private void SetPolygon(Panel panel, Point[] points)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddPolygon(points);
                Region region = new Region(gp);
                panel.Region = region;
                panel.BackColor = noColor;
                panel.Parent = pictureBox1;
            }
        }

        private void InitDifficultyes()
        {
            difficulties.Sort((a, b) => a.Level.CompareTo(b.Level));
            diffZones = TypeZoneWork.GetDiffsZones(difficulties);

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


        private void diffComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            diffName.Text = "0" + diffComBox.Text[8] + "-";

            int diffLvl = int.Parse(diffComBox.SelectedItem.ToString().Substring(8));
            Difficulty diff = difficulties.FirstOrDefault(d => d.Level == diffLvl);
            SetPanels(diff.Id);
            countChar.Minimum = diff.MinLen;
            countChar.Maximum = diff.MaxLen;

            List<int> d_zones = diffZones[diffComBox.SelectedIndex]
                    .Split(',').Select(int.Parse).ToList();
            string allowedchars = "";
            foreach (int z in d_zones)
            {
                allowedchars += KeyboardWork.GetChars(z);
            }

            if (GenerateState)
            {
                character.Text = DeleteWrongSymbols(character.Text, allowedchars);

            }
            else
            {
                exerciseText.TextChanged -= exerciseText_TextChanged;
                exerciseText.Text = DeleteWrongSymbols(exerciseText.Text, allowedchars);
                exerciseText.TextChanged += exerciseText_TextChanged;

                if (exerciseText.TextLength > difficulties[diffComBox.SelectedIndex].MaxLen)
                {
                    string text = exerciseText.Text;
                    text = text.Substring(0, difficulties[diffComBox.SelectedIndex].MaxLen);
                    exerciseText.Text = text;
                }
                character.Text = "Набрано " + exerciseText.TextLength + " символов";
            }

        }

        private void SetPanels(long id)
        {
            foreach (Panel p in panels)
            {
                p.BackColor = noColor;
            }

            type_zones = TypeZoneWork.GetZoneByDiffId(id);
            type_zones.Sort();
            for (int i = 0; i < type_zones.Count; i++)
            {
                int n = type_zones[i] - 1;
                Panel p = panels[n];
                p.BackColor = setClr;
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (GenerateState)
            {
                if (DialogResult.No == MessageBox.Show("Открытие текста из файла\nотключит генерацию текста.\nПродолжить?",
                    "Продолжить?", MessageBoxButtons.YesNo)) return;
                generateBut_Click(sender, e);
            }
            OpenState = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|exc files (*.exc)|*.exc";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; //относительный путь
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();
                string text;

                using (StreamReader reader = new StreamReader(fileStream, Encoding.Default))
                {
                    text = reader.ReadToEnd();
                }

                text = text.Replace("ё", "е");
                exerciseText.Text = text;
            }
        }

        private void exerciseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            bool error_flag = false;
            string error_mes = "В процессе сохранения возникли ошибки: \n";

            if ((diffName.Text + exerciseName.Text).Length == 5)
                _exercise.Name = diffName.Text + exerciseName.Text;
            else
            {
                error_mes += "Введите название уровня состоящее из 2 цифр\n";
                error_flag = true;
            }

            int i = diffComBox.SelectedIndex;
            _exercise.DifficultyId = difficulties[i].Id;
            _exercise.Difficulty = difficulties[i];

            if (_exercise.Difficulty.MinLen <= exerciseText.TextLength && _exercise.Difficulty.MaxLen >= exerciseText.TextLength)
                _exercise.Len = (int)(countChar.Value);
            else
            {
                error_mes += "Недопустимая длина упражнения\nРазмер текста не соответствует уровню. Минимальная длинна теста "
                    + _exercise.Difficulty.MinLen + " Максимальная " + _exercise.Difficulty.MaxLen;
                error_flag = true;
            }

            if (GenerateState)
            {
                _exercise.IsRandom = true;
                _exercise.Text = character.Text;
            }
            else
            {
                _exercise.IsRandom = false;
                _exercise.Text = exerciseText.Text;
            }

            if (!error_flag)
            {
                using (Context context = new Context())
                {
                    try
                    {
                        context.Entry(_exercise.Difficulty).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                        if (_exercise.Id == 0)
                        {
                            context.Exercise.Add(_exercise);
                        }
                        else
                        {
                            context.Entry(_exercise).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            context.Exercise.Update(_exercise);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Изменения сохранены");
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                        MessageBox.Show(error_mes + ex.InnerException.Message);
                    }
                }
                //Close();
            }
            else MessageBox.Show(error_mes);

            //int i = 0;
            //while (difficulties[i].Id == int.Parse(diffComBox.Text.Split(' ')[1]))
            //{
            //    _exercise.DifficultyId = difficulties[i].Id;
            //    _exercise.Difficulty = difficulties[i];
            //    i++;
            //}
            //if (_exercise.Difficulty.MinLen <= exerciseText.TextLength && _exercise.Difficulty.MaxLen >= exerciseText.TextLength)
            //{ 
            //    _exercise.Text = exerciseText.Text; 
            //    using (Context context = new Context())
            //    {
            //        context.Entry(_exercise.Difficulty).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            //        if (_exercise.Id == 0)
            //        {
            //            context.Exercise.Add(_exercise);
            //        }
            //        else
            //        {
            //            context.Entry(_exercise).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //            context.Exercise.Update(_exercise);
            //        }
            //        context.SaveChanges();
            //    }
            //    Close();
            //}
            //else
            //    MessageBox.Show("Размер текста не соответствует уровню. Минимальная длинна теста " + _exercise.Difficulty.MinLen + " Максимальная " + _exercise.Difficulty.MaxLen);

        }

        //сделать удаление

        private void exerciseText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char number = e.KeyChar;
            //if (number == 8)
            //{
            //    e.Handled = true;
            //    character.Text = GetCharecters(character.Text);
            //    //удаление символа - удаление из текста
            //}
        }

        private void character_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char number = e.KeyChar;
            //if (number == 8)
            //{
            //    e.Handled = true;
            //    character.Text = "";
            //    foreach (var c in exerciseText.Text)
            //        if (!character.Text.Contains(c))
            //            character.Text += c;
            //    countChar.Value = exerciseText.TextLength;
            //}
        }

        private string GetCharecters(string text)
        {
            string chars = "";
            string ch;
            foreach (var c in text)
            {
                ch = c.ToString().ToLower();
                if (!chars.Contains(ch) && !ch.Equals(" "))
                    chars += ch;
            }

            return chars;
        }

        private List<int> GetTextZones(string chars)
        {
            List<int> zones = new List<int>();
            int z;
            foreach (char ch in chars)
            {
                z = keys.Where(k => k.Char.Equals(ch.ToString())).Select(k => k.ZoneN).FirstOrDefault();
                if (!zones.Contains(z))
                    zones.Add(z);
            }

            return zones;
        }

        private string DeleteWrongSymbols(string text)
        {
            string symbols = string.Join("", keys.Select(k => k.Char).ToArray());
            symbols += symbols.ToUpper() + " ";
            IEnumerable<Char> allowed = text.Select(c => symbols.Contains(c.ToString()) ? c : '*');

            string result = new string(allowed.ToArray());
            result = result.Replace("*", "");
            return result;
        }

        private string DeleteWrongSymbols(string text, string allowedsymbols)
        {
            allowedsymbols += allowedsymbols.ToUpper() + " ";
            IEnumerable<Char> allowed = text.Select(c => (allowedsymbols.Contains(c.ToString())) ? c : '*');

            string result = new string(allowed.ToArray());
            result = result.Replace("*", "");
            return result;
        }

        /// <summary>
        /// Проверка сложности текста
        /// </summary>
        /// <param name="text">Текст упражнения</param>
        /// <param name="chars">Символы упражнения</param>
        /// <returns></returns>
        private int GetDiffIndex(ref string text, string chars)
        {
            int lenDiff = 0;
            if (text.Length > difficulties[difficulties.Count - 1].MaxLen)
            {
                text = text.Substring(0, difficulties[difficulties.Count - 1].MaxLen);
                lenDiff = difficulties.Count - 1;
                return lenDiff;
            }
            else
                while (text.Length > difficulties[lenDiff].MaxLen && lenDiff < difficulties.Count)
                    lenDiff++;

            int zoneDiff = 0;

            //список зон задействованных в тексте упражнения
            List<int> zones = GetTextZones(chars);

            bool foundall;
            for (int i = 0; i < difficulties.Count; i++)
            {
                //список зон для i-ой сложности
                List<int> d_zones = diffZones[i].Split(',').Select(int.Parse).ToList();
                foundall = false;
                foreach (int zone in zones)
                {
                    //проверяем, содержатся ли в зонах текущей сложности зоны текста
                    foundall = d_zones.Contains(zone);
                    if (!foundall)
                    {
                        zoneDiff++;
                        break;
                    }
                }
                if (foundall)
                {
                    zoneDiff = Math.Min(zoneDiff, difficulties[i].Level - 1);
                }
            }

            return Math.Max(zoneDiff, lenDiff);
        }

        private void exerciseText_TextChanged(object sender, EventArgs e)
        {
            if (GenerateState) return;

            string text = exerciseText.Text;
            int diffIndx = GetDiffIndex(ref text, GetCharecters(text));
            if (diffIndx == diffComBox.Items.Count)
            {
                MessageBox.Show("Текст содержит недопустимые символы.\nВозможно, выбрана неверная раскладка.");
                text = DeleteWrongSymbols(text);
            }

            exerciseText.TextChanged -= exerciseText_TextChanged;  // останавливаем обработчик события
            exerciseText.Text = text;
            exerciseText.TextChanged += exerciseText_TextChanged; // запускаем обработчик события

            character.Text = "Набрано " + exerciseText.TextLength + " символов";
            exerciseText.SelectionStart = exerciseText.TextLength;
            if (diffIndx != diffComBox.Items.Count && diffComBox.SelectedIndex != diffIndx)
            {
                diffComBox.SelectedIndex = diffIndx;
            }
            countChar.Value = (exerciseText.TextLength < countChar.Minimum) ? countChar.Minimum : exerciseText.TextLength;
            exerciseText.Select(exerciseText.TextLength, 0);
        }

        private void generateBut_Click(object sender, EventArgs e)
        {
            generateBut.BackColor = (generateBut.BackColor == onRndClr) ? offRndClr : onRndClr;
            GenerateState = (generateBut.BackColor == onRndClr) ? true : false;
            character.Text = "";
            character.ReadOnly = !GenerateState;
            exerciseText.Text = "";
            exerciseText.ReadOnly = GenerateState;
            refresh.Visible = GenerateState;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (character.TextLength == 0)
            {
                List<int> d_zones = diffZones[diffComBox.SelectedIndex].Split(',').Select(int.Parse).ToList();
                string chars = "";
                foreach (int zoneN in d_zones)
                {
                    chars += string.Join("", keys.Where(k => k.ZoneN == zoneN).Select(k => k.Char).ToArray());
                }
                character.Text = chars;
            }

            exerciseText.Text = ExerciseWork.RandomText(character.Text, (int)countChar.Value);
        }

        private void character_TextChanged(object sender, EventArgs e)
        {
            if (!GenerateState) return;

            string text = GetCharecters(character.Text);
            int diffIndx = GetDiffIndex(ref text, text);
            if (diffIndx == diffComBox.Items.Count)
            {
                MessageBox.Show("Текст содержит недопустимые символы.\nВозможно, выбрана неверная раскладка.");
                character.Text = DeleteWrongSymbols(text);
                return;
            }
            character.TextChanged -= exerciseText_TextChanged;
            character.Text = text;
            character.TextChanged += exerciseText_TextChanged;

            exerciseText.TextChanged -= exerciseText_TextChanged;
            exerciseText.Text = DeleteWrongSymbols(exerciseText.Text, text);
            exerciseText.TextChanged += exerciseText_TextChanged;

            character.SelectionStart = character.TextLength;
            if (diffComBox.SelectedIndex != diffIndx)
                diffComBox.SelectedIndex = diffIndx;
        }
    }
}