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
using KeyboardWIndowApp.StaticClasses;
using KeyboardWIndowApp.DataBase;

namespace KeyboardWIndowApp
{
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();
            InitPanels();
            InitDifficultyes();
        }

        List<Difficulty> difficulties;
        List<int> type_zones;

        private void InitDifficultyes()
        {
            difficulties = DifficultyWork.GetDifficultyes();

            for (int i = 0; i < difficulties.Count; i++)
            {
                diffComBox.Items.Add("Уровень " + difficulties[i].Level);
            }
            if (diffComBox.Items.Count == 0)
            {
                diffComBox.SelectedIndex = -1;
                return;
            }
            diffComBox.SelectedIndex = 0;
            string diffName = diffComBox.SelectedItem.ToString().Substring(8);
            FillControls(diffName);
        }

        private void FillControls(string lvl)
        {
            Difficulty diff = null;
            for (int i = 0; i < difficulties.Count; i++)
            {
                if (difficulties[i].Level == int.Parse(lvl))
                {
                    diff = difficulties[i];
                } 
            }

            if (diff != null)
            {
                minExeLenText.Text = diff.MinLen.ToString();
                maxExeLenText.Text = diff.MaxLen.ToString();
                errPctText.Text = diff.ErrorPct.ToString();
                typeSpeedText.Text = diff.TypeSpeed.ToString();
                type_zones = TypeZoneWork.GetZoneByDiffId(diff.Id);
                type_zones.Sort();
                typeZoneText.Text = String.Join(", ", type_zones);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(string.Format("X:{0} Y:{1}", e.X.ToString(), e.Y.ToString()));
        }

        //---------------------------------------отображение полигонов на клавиатуре-------------------------
        private Color selected_clr = Color.FromArgb(100, Color.Green);
        private Color base_clr = Color.FromArgb(100, Color.CadetBlue);

        private void zone_Click(object sender, EventArgs e)
        {
            ChangeZoneColor((Panel)sender);
        }
        
        private void ChangeZoneColor(Panel panel)
        {
            int zone_num = int.Parse(panel.Name.Substring(4));
            List<int> curr_zones = GetZonesByText(typeZoneText.Text);
            if (panel.BackColor == base_clr)
            {
                curr_zones.Add(zone_num);
                curr_zones.Sort();
            }
            else
            {
                curr_zones.Remove(zone_num);
            }

            typeZoneText.Text = String.Join(", ", curr_zones);
        }

        private List<Panel> panels = new List<Panel>();
        private void InitPanels()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Panel panel) panels.Add(panel);
            }
            panels.Sort((a, b) => a.Name.CompareTo(b.Name));

            SetPolygon(panels.Find(z => z.Name.Equals("zone1")), KeyboardWork.center_zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone2")), KeyboardWork.center_zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone3")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone4")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone5")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone6")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone7")), KeyboardWork.zone_points);
            SetPolygon(panels.Find(z => z.Name.Equals("zone8")), KeyboardWork.right_zone_points);
        }

        private void SetPolygon(Panel panel, Point[] points)
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


        //----------------------------------------------------------------------------------------------
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            errPctText.Select(0, 0);
        }

        private void typeZoneText_TextChanged(object sender, EventArgs e)
        {
            List<int> zones = GetZonesByText(typeZoneText.Text);
            foreach (Panel p in panels)
            {
                p.BackColor = base_clr;
            }

            for (int i = 0; i < zones.Count; i++)
            {
                int n = zones[i] - 1;
                Panel p = panels[n];
                p.BackColor = selected_clr;
            }
        }

        private List<int> GetZonesByText(string text)
        {
            string[] separatingStrings = { ", " };
            List<string> buff = text.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries).ToList();
            return buff.Select(str => int.Parse(str)).Distinct().ToList();
        }

        private void diffComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diffName = diffComBox.SelectedItem.ToString().Substring(8);
            FillControls(diffName);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int lvl = int.Parse(diffComBox.SelectedItem.ToString().Substring(8));
            Difficulty difficulty = difficulties.Find(d => d.Level == lvl);
            difficulty.MinLen = int.Parse(minExeLenText.Text);
            DifficultyWork.UdateDifficulty(lvl, difficulty, GetZonesByText(typeZoneText.Text));
        }
    }
}
