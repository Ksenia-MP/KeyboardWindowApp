using KeyboardWIndowApp.DataBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardWIndowApp.DataBase;


namespace KeyboardWIndowApp.StaticClasses
{
    static class KeyboardWork
    {
        public static Point[] zone_points = {
            new Point(0,25), new Point(0,0), new Point(24,0), new Point(24,25),
            new Point(37,25), new Point(54, 98), new Point(30,98), new Point(13, 25)
        };

        public static Point[] center_zone_points = {
            new Point(0,25), new Point(0,0), new Point(49,0), new Point(49,25),
            new Point(62,25), new Point(79, 98), new Point(30,98), new Point(13, 25)
        };

        public static Point[] right_zone_points = {
            new Point(0,25), new Point(0,0), new Point(24,0), new Point(24,25),
            new Point(87,25), new Point(87,50),
            new Point(54, 98), new Point(30,98), new Point(13, 25)
        };

        public static int GetZoneN(string ch)
        {
            using (Context context = new Context())
            {
                return context.Keyboard.Where(k => k.Char.Equals(ch)).Select(k => k.ZoneN).FirstOrDefault();
            }
        }

        public static List<Keyboard> GetKeyboard()
        {
            using (Context context = new Context())
            {
                return context.Keyboard.ToList();
            }
        }

        public static List<int> TextZones(string characters)
        {
            using (Context context = new Context())
            {
                List<Keyboard> keys = context.Keyboard.ToList();
                List<int> zones = new List<int>();
                int zone;

                foreach (char ch in characters)
                {
                    zone = keys.Where(k => k.Char.Equals(ch.ToString())).Select(k => k.ZoneN).FirstOrDefault();
                    if (!zones.Contains(zone))
                        zones.Add(zone);
                }
                return zones;
            }
        }

        public static string GetChars(int zoneN)
        {
            using (Context context = new Context())
            {
                return string.Join("",context.Keyboard.Where(k => k.ZoneN == zoneN).Select(k => k.Char).ToArray());
            }
        }
    }
}
