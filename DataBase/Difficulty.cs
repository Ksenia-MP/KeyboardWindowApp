using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Difficulty
    {
        public long Id { get; set; }
        public int Level { get; set; }
        public int ErrorPct { get; set; }
        public int MinLen { get; set; }
        public int MaxLen { get; set; }
        public int TypeSpeed { get; set; }
        public Difficulty(int level, int errorPct, int minLen, int maxLen, int typeSpeed)
        {
            Level = level;
            ErrorPct = errorPct;
            MinLen = minLen;
            MaxLen = maxLen;
            TypeSpeed = typeSpeed;
        }
        public Difficulty()
        { }
    }
}
