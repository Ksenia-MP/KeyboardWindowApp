using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Exercise
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Len { get; set; }
        public string Text { get; set; }
        public bool IsRandom { get; set; }
        public long DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }

        public Exercise() {}

        public Exercise(string name, int len, string text)
        {
            Name = name;
            Len = len;
            Text = text;
        }
    }
}
