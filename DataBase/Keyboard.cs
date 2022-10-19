using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Keyboard
    {
        public long Id { get; set; }
        public string ZoneN { get; set; }
        public char[] Char { get; set; }
        public Keyboard()
        { }
        public Keyboard(string zoneN)
        {
            ZoneN = zoneN;
        }

    }
}
