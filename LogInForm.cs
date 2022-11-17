using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            loginText.Text = "admin";
            passwordText.Text = "admin";
        }

        private void Войти_Click(object sender, EventArgs e)
        {
            if (UserWork.UserConfirmed(loginText.Text, passwordText.Text))
            {
                User user = UserWork.GetUserByLogin(loginText.Text);
                if (user.Admin)
                {
                    Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else MessageBox.Show("Вход выполнен.");
            }
            else MessageBox.Show("Пользователь с указанными логином и паролем не найден");
            
            this.Close();
        }

        private void Регистрация_Click(object sender, EventArgs e)
        {
            if (UserWork.GetUserByLogin(loginText.Text) == null)
            {
                if (passwordText.Text.Equals(reptpassText.Text))
                {
                    UserWork.AddUser(loginText.Text, passwordText.Text);
                    //войти в систему
                    MessageBox.Show("Регистрация прошла успешно.");
                }
                else MessageBox.Show("Пароли не совпадают.");
            }
            else MessageBox.Show("Пользователь с указанным логином уже существует.");
            
        }

        private void ShowHide(Control control)
        {
            control.Visible = !control.Visible;
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            if (AcceptButton == LogInBtn)
                AcceptButton = RegBtn;
            else
                AcceptButton = LogInBtn;

            ShowHide(showRegBtn);
            ShowHide(LogInBtn);
            ShowHide(RegBtn);
            ShowHide(reptpassLabel);
            ShowHide(reptpassText);
            ShowHide(newhereLable);
            ShowHide(showLogInBtn);
        }
    }
}
