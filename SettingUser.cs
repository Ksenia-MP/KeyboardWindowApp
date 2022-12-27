using KeyboardWIndowApp.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class SettingUser : Form
    {
        User user;
        public SettingUser(User u_user)
        {
            InitializeComponent();
            loginText.Text = u_user.Login;
            user = u_user;
            var appSettings = ConfigurationManager.AppSettings;
            if (appSettings["keyCheck"] == "1")
                keyCheck.Checked = true;
            if (appSettings["musicCheck"] == "1")
                musicCheck.Checked = true;
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                context.User.Remove(user);
                context.SaveChanges();
                MessageBox.Show("Пользователь удален!");
                Close();
                Application.Restart();
            }
            
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            string err_str = "";
            if (loginText.Text.Length > 2 && loginText.Text.Length <= 8)
                user.Login = loginText.Text;
            else err_str += "Логин должен содержать от 2-х до 8-ми символов\n";

            if (passwordText.Text != "")
                if (passwordText.Text.Length > 4 && passwordText.Text.Length <= 12)
                    user.Password = passwordText.Text.GetHashCode().ToString();
                else err_str += "Пароль должен содержать от 4-х до 12-ти символов\n";

            var appSettings = ConfigurationManager.AppSettings;
            if (keyCheck.Checked)
                appSettings["keyCheck"] = "1";
            else
                appSettings["keyCheck"] = "0";
            
            if (musicCheck.Checked)
                appSettings["musicCheck"] = "1";
            else
                appSettings["musicCheck"] = "0";
            if (err_str != "")
            {
                MessageBox.Show(err_str);
            }
            else
            {
                using (Context context = new Context())
                {
                    context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.User.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Изменения сохранены");
                }
            }
            
        }
    }
}
