using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Statistics
    {
        public long Id { get; set; }
        public int TipeSpeed { get; set; }
        public int ErrorPct { get; set; }
        public long UsersId { get; set; }
        public Users Users { get; set; }
        public long ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public Statistics()
        { }

    }
}
