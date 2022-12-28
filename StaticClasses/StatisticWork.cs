using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (speed_dif == 0)
                text += "Показатели скорости печати слижком низкие\nРекомендуем начать обучение с первого уровня сложности.";
            else
                text += "\nРекомендуемая сложность: Уровень " + speed_dif;
            return text;
        }

        public static void SaveStatistic (Statistics stat)
        {
            using (Context context = new Context())
            {
                context.Statistics.Add(stat);
                context.SaveChanges();
            }
        }
        public static Statistics GetStatisticsByName(long u_id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics/*.Include/*(ex => ex.Exercise)*/.FirstOrDefault(e => e.UserId.Equals(u_id));
                    
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
        public static Statistics GetNameByUID(long u_id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics.FirstOrDefault(e => e.UserId.Equals(u_id));

                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
        public static List<Statistics> GetListStatByUID(long u_id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics.Where(e => e.UserId.Equals(u_id)).ToList();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
        public static List<Statistics> GetListStatByExersID(long ex_id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics.Where(e => e.ExerciseId.Equals(ex_id)).ToList();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
        public static List<Statistics> GetListStatByUIDAndExersID(long u_id, long ex_id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics.Where(e => e.UserId.Equals(u_id)).Where(e => e.ExerciseId.Equals(ex_id)).ToList();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
        public static List<Statistics> GetListStatAll()
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Statistics.ToList();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }
    }
}
