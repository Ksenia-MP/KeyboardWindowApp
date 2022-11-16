using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp
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

        public static void AddUser (string login, string password)
        {
            using (Context context = new Context())
            {
                context.User.Add(new User(login, password.GetHashCode().ToString()));
                context.SaveChanges();
            }
        }

        public static void AddUser (User user)
        {
            using (Context context = new Context())
            {
                context.User.Add(user);
            }
        }

        public static User GetUserById(int id)
        {
            using (Context context = new Context())
            {
                return context.User.FirstOrDefault(u => u.Id == id);
            }
        }

        public static User GetUserByLogin(string login)
        {
            using (Context context = new Context())
            {
                return context.User.FirstOrDefault(u => u.Login == login);
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
