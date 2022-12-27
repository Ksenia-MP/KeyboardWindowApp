using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardWIndowApp.StaticClasses;

namespace KeyboardWIndowApp.DataBase
{
    public class Statistics
    {
        public long Id { get; set; }
        public int TipeSpeed { get; set; }
        public int ErrorPct { get; set; }
        public DateTime Date { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public Statistics() { }

        public Statistics(int ts, int err, DateTime date, long user_id, Exercise exerc)
        {
            TipeSpeed = ts;
            ErrorPct = err;
            Date = date;
            UserId = user_id;
            //User = UserWork.GetUserById(user_id);
            ExerciseId = exerc.Id;
            //Exercise = exerc;
        }

    }
}
