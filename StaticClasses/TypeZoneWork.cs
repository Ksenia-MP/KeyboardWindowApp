using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class TypeZoneWork
    {
        public static List<int> GetZoneByDiffId(long diffId)
        {
            using (Context context = new Context())
            {
                return context.TypeZone.Where(t => t.DifficultyId == diffId).Select(t => t.ZoneN).ToList();
            }
        }

        public static void SetZones(long diffId, List<int> zones)
        {
            using (Context context = new Context())
            {
                context.TypeZone.RemoveRange(context.TypeZone.Where(t => t.DifficultyId == diffId));

                List<TypeZone> zoneList = null;
                foreach(int zone in zones)
                {
                    zoneList.Add(new TypeZone(zone, diffId));
                }

                context.TypeZone.AddRange(zoneList);
                context.SaveChanges();
            }
        }
    }
}
