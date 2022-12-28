using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class DifficultyWork
    {

        public static List<Difficulty> GetDifficultyes()
        {
            using (Context context = new Context())
            {
                return context.Difficulty.ToList();
            }
        }

        public static List<DiffIdLvl> GetDiffIdLvls()
        {
            List<DiffIdLvl> list = new List<DiffIdLvl>();
            try
            {

                using (Context context = new Context())
                {
                    list = context.Difficulty.Select(d => new DiffIdLvl { Id = d.Id, Level = d.Level }).ToList();
                }
                if (list.Count == 0)
                {
                    MessageBox.Show("Информация отсутствует в базе данных");
                    Application.Exit();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
            }
            return list;
        }

        public static long GetIdByName(int lvl)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Difficulty.Where(d => d.Level == lvl).Select(d => d.Id).FirstOrDefault();
                }

            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return new long();
            }
        }

        public static Difficulty GetDiffById(long id)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.Difficulty.FirstOrDefault(d => d.Id == id);
                }
            }
            catch(Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }

        //public static Difficulty GetDiffByName(int lvl)
        //{
        //    using (Context context = new Context())
        //    {
        //        return context.Difficulty.FirstOrDefault(d => d.Level == lvl);
        //    }
        //}

        public static void UdateDifficulty(int old_diff_lvl, Difficulty new_diff, List<int> new_typeZones)
        {
            try
            {
                using (Context context = new Context())
                {
                    var difficulty = context.Difficulty.Where(d => d.Level == old_diff_lvl).FirstOrDefault();
                    if (difficulty != null)
                    {
                        difficulty.MaxLen = new_diff.MaxLen;
                        difficulty.MinLen = new_diff.MinLen;
                        difficulty.ErrorPct = new_diff.ErrorPct;
                        difficulty.TypeSpeed = new_diff.TypeSpeed;
                        context.SaveChanges();

                        TypeZoneWork.SetZones(difficulty.Id, new_typeZones);
                    }
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
            }
        }
    }
}
