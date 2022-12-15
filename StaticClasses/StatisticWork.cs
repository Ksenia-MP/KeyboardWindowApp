using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class StatisticWork
    {
        public static string GetStatisticString(int time, int len, int error, int speed)
        {
            int err_pct = error * 100 / len;
            return String.Format("Поздравляем! Вы завершили задание за {0} сек. " +
                "\nКоличество набранных символов: {1}\nДопущено ошибок: {2} это {3}% от всей длины текста" +
                "\nСкорость печати: {4} зн/мин\n", time, len, error, err_pct, speed);
        }

        public static string GetTestResultString(int time, int len, int error, int speed)
        {
            int err_pct = error * 100 / len;
            List<Difficulty> difficulties = DifficultyWork.GetDifficultyes();
            string text = GetStatisticString(time, len, error, speed);
            int err_dif = 0;
            int speed_dif = 0;
            foreach (Difficulty d in difficulties)
            {
                if (d.ErrorPct >= err_pct) err_dif = d.Level;
                if (d.TypeSpeed <= speed) speed_dif = d.Level;
            }
            text += "\nРекомендуемая сложность: Уровень " + speed_dif;
            return text;
        }
    }
}
