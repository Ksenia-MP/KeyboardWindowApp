using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Users
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public Users()
        { }
    }

}