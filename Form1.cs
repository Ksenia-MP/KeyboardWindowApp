using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace KeyboardWIndowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server=sql11.freesqldatabase.com;user=sql11526749;database=sql11526749;password=7gVU827Kqz;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT login FROM User WHERE id = 1";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            string name = command.ExecuteScalar().ToString();
            // выводим ответ в консоль
            MessageBox.Show(name);
            // закрываем соединение с БД
            conn.Close();
        }
    }
}
