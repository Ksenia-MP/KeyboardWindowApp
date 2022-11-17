using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using (Context context = new Context())
            {
                return context.Difficulty.Select(d => new DiffIdLvl { Id = d.Id, Level = d.Level }).ToList();
            }
        }

        public static long GetIdByName(int lvl)
        {
            using (Context context = new Context())
            {
                return context.Difficulty.Where(d => d.Level == lvl).Select(d => d.Id).FirstOrDefault();
            }
        }
    }
}
