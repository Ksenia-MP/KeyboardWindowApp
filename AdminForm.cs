using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp
{
    public partial class AdminForm : Form
    {
        List<Button> btns;
        public AdminForm()
        {
            InitializeComponent();
            
            int w = ExercisesTab.Width - 25;
            btns = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                btns.Add(new Button()
                {
                    Name = i + "Btn",
                    Text = "Button" + i,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = SystemColors.ButtonHighlight,
                    FlatAppearance = { MouseOverBackColor = Color.SkyBlue },
                    Location = new Point(0, i * 75 + 10),
                    Height = 60,
                    Width = w
                });

                this.btns[i].Click += new System.EventHandler(exercise_Click);
                ExercisesTab.SelectedTab.Controls.Add(btns[i]);
            }
        }

        private void exercise_Click(object sender, EventArgs e)
        {

        }

    }
}
