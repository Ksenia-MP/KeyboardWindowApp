using KeyboardWIndowApp.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWIndowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginText.Text = "ghrherh";
            passwordText.Text = "111";
        }

        private void Войти_Click(object sender, EventArgs e)
        {
            using (Conteeeeeeeext ac = new Conteeeeeeeext())
            {

            }
        }

        private void Регистрация_Click(object sender, EventArgs e)
        {
            using (Conteeeeeeeext ac = new Conteeeeeeeext())
            {
                ac.Users.Add(new Users(loginText.Text, passwordText.Text));
                ac.SaveChanges();
            }
        }
    }
}
