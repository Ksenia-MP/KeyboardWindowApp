using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
