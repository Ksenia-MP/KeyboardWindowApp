using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class ExerciseWork
    {
        /// <summary>
        /// Возвращает список упражнений по уровню сложности
        /// </summary>
        /// <param name="lvl">Уровень сложности</param>
        /// <returns>Список упражнений</returns>
        public static List<Exercise> GetExercsByDiff(int lvl)
        {
            using (Context context = new Context())
            {
                return context.Exercise.Where(e => e.DifficultyId == DifficultyWork.GetIdByName(lvl)).ToList();
            }
        }

        /// <summary>
        /// Возвращает список названий упражнений для указанного уровня сложности
        /// </summary>
        /// <param name="diffId">ID уровня сложности</param>
        /// <returns>Список названий упражнений</returns>
        private static List<string> GetExerciseNames(long dId)
        {
            using (Context context = new Context())
            {
                return context.Exercise.Where(e => e.DifficultyId == dId).Select(e => e.Name).ToList();
            }
        }


        /// <summary>
        /// Конструктор автоматического создания вкладок и их заполнения кнопками с упражнениями
        /// </summary>
        /// <param name="tab">заполняемый TabControl</param>
        /// <param name="btn_width">ширина кнопки</param>
        /// <param name="btn_height">высота кнопки</param>
        /// <returns>Возвращает список созданных кнопок</returns>
        public static List<Button> CreateExecBtns(TabControl tab, int btn_width, int btn_height)
        {
            List<DiffIdLvl> difficulties;
            List<string> exerc_names;
            List<Button> btns = new List<Button>();
            //получим список уровней сложности и добавим вкладки в tab

            difficulties = DifficultyWork.GetDiffIdLvls();
            difficulties.Sort((a, b) => a.Level.CompareTo(b.Level));

            for (int i = 0; i < difficulties.Count; i++)
            {
                tab.TabPages.Add(new TabPage()      //добавим вкладку
                {
                    Name = "dif" + difficulties[i].Level,
                    Text = "lvl " + difficulties[i].Level
                });

                //отрисовка кнопок с упражнениями
                exerc_names = GetExerciseNames(difficulties[i].Id);
                for (int j = 0; j < exerc_names.Count; j++)
                {
                    btns.Add(new Button()
                    {
                        Name = "Btn" + exerc_names[j].Replace('-','_'),
                        Text = "Упражнение " + exerc_names[j],
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance = { MouseOverBackColor = Color.SkyBlue },
                        BackColor = SystemColors.ButtonHighlight,
                        Location = new Point(0, j * (btn_height + 15) + 10),
                        Height = btn_height,
                        Width = btn_width
                    });

                    tab.TabPages[i].Controls.Add(btns[j]);
                }
            }
            return btns;
        }
    }
}
