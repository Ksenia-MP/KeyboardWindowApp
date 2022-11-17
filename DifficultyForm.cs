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

namespace KeyboardWIndowApp
{
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            

            

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(string.Format("X:{0} Y:{1}", e.X.ToString(), e.Y.ToString()));
        }

        //---------------------------------------отображение полигонов на клавиатуре-------------------------
        private bool was_clicked = false;
        private Color selected_clr = Color.FromArgb(100, Color.Green);
        private Color base_clr = Color.FromArgb(100, Color.Red);
        private Color buf_clr;

        

        private Point[] zone_points = {
            new Point(0, 0),
            new Point(25, 0),
            new Point(42, 73),
            new Point(17,73)
        };

        private Point[] centrer_zone_points = {
            new Point(0, 0),
            new Point(50, 0),
            new Point(67, 73),
            new Point(17,73)
        };

        private Point[] right_zone_points = {
            new Point(0, 0),
            new Point(75, 0),
            new Point(75,25),
            new Point(60,25),
            new Point(42, 73),
            new Point(17,73)
        };

        private void zone_Click(object sender, EventArgs e)
        {
            if (buf_clr == base_clr)
                ((Panel)sender).BackColor = selected_clr;
            else
                ((Panel)sender).BackColor = base_clr;
            buf_clr = ((Panel)sender).BackColor;
            was_clicked = true;
        }

        private void zone_MouseEnter(object sender, EventArgs e)
        {
            buf_clr = ((Panel)sender).BackColor;
            ((Panel)sender).BackColor = Color.FromArgb(100, Color.Black);
            was_clicked = true;
        }

        private void zone_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = buf_clr;
            was_clicked = true;
        }

        private void zone_Paint(object sender, PaintEventArgs e)
        {
            SetPolygon((Panel)sender, zone_points);
        }

        private void center_zone_Paint(object sender, PaintEventArgs e)
        {
            SetPolygon((Panel)sender, centrer_zone_points);
        }
        
        private void right_zone_Paint(object sender, PaintEventArgs e)
        {
            SetPolygon((Panel)sender, right_zone_points);
        }

        private void SetPolygon(Panel panel, Point[] points)
        {
            if (!was_clicked)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddPolygon(points);
                    Region region = new Region(gp);
                    panel.Region = region;
                    panel.BackColor = base_clr;
                    panel.Parent = pictureBox1;
                }
            }
            was_clicked = false;
        }
        //----------------------------------------------------------------------------------------------
    }
}
