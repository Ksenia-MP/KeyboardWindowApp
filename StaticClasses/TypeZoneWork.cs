using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class TypeZoneWork
    {
        public static List<int> GetZoneByDiffId(long diffId)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.TypeZone.Where(t => t.DifficultyId == diffId).Select(t => t.ZoneN).ToList();
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }

        public static List<string> GetDiffsZones(List<Difficulty> difficulties)
        {
            using (Context context = new Context())
            {
                List<string> diffzones = new List<string>();  
                foreach (Difficulty diff in difficulties)
                {
                    diffzones.Add(String.Join(",", GetZoneByDiffId(diff.Id)));
                }
                return diffzones;
            }
        }

        public static void SetZones(long diffId, List<int> zones)
        {
            using (Context context = new Context())
            {
                context.TypeZone.RemoveRange(context.TypeZone.Where(t => t.DifficultyId == diffId));

                List<TypeZone> zoneList = new List<TypeZone>();
                foreach(int zone in zones)
                {
                    zoneList.Add(new TypeZone {DifficultyId = diffId, ZoneN = zone });
                }

                context.TypeZone.AddRange(zoneList);
                context.SaveChanges();
            }
        }

        //public static long GetDiffId(int zoneN)
        //{
        //    using (Context context = new Context())
        //    {
        //        return context.TypeZone.Where(t => t.ZoneN == zoneN).Select(t => t.DifficultyId).FirstOrDefault();
        //    }
        //}
    }
}
