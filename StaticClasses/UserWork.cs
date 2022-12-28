using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp.StaticClasses
{
    static class UserWork
    {
        public static List<User> GetUsersList()
        {
            using (Context context = new Context())
            {
                return context.User.ToList();
            }
        }

        public static void AddUser(string login, string password)
        {
            using (Context context = new Context())
            {
                context.User.Add(new User(login, password.GetHashCode().ToString()));
                context.SaveChanges();
            }
        }

        //public static User GetUserById(long id)
        //{
        //    using (Context context = new Context())
        //    {
        //        return context.User.FirstOrDefault(u => u.Id == id);
        //    }
        //}

        public static User GetUserByLogin(string login)
        {
            try
            {
                using (Context context = new Context())
                {
                    return context.User.FirstOrDefault(u => u.Login == login);
                }
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("Структура базы данных нарушена");
                Application.Exit();
                return null;
            }
        }

        public static bool UserConfirmed(string login, string password)
        {
            using (Context context = new Context())
            {
                User user = UserWork.GetUserByLogin(login);
                if (user != null && user.Password.Equals(password.GetHashCode().ToString()))
                    return true;
                return false;
            }
        }
    }
}
