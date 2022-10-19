using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class TypeZone
    {
        public long Id { get; set; }
        public long DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
        public long KeyboardId { get; set; }
        public Keyboard Keyboard { get; set; }
        public TypeZone()
        { }
        
    }
}
