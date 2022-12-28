using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KeyboardWIndowApp.DataBase;
using KeyboardWIndowApp.StaticClasses;

namespace KeyboardWIndowApp
{
    public partial class DiagrammForm : Form
    {
        public DiagrammForm() // Общая статистика
        {
            InitializeComponent();
            labelAbout.Text = "Общая"; 
            List<Statistics> st = StatisticWork.GetListStatAll();
            int[] ar_ex_time = new int[st.Count];
            for (int i = 0; i < st.Count; i++)
            {
                Exercise ex = ExerciseWork.GetExerciseById(st[i].ExerciseId);
                dataGVStatistic.Rows.Add(i + 1, ex.Name, ex.Len, st[i].TipeSpeed, 
                    st[i].ErrorPct, ar_ex_time[i] = (int)(60 * ex.Len) / st[i].TipeSpeed, st[i].Date);
            }
            chartView(st, ar_ex_time);
        }

        public DiagrammForm(string u_name, long u_id) // Статистика для пользователя
        {
            InitializeComponent();
            labelAbout.Text = "Для пользователя " + u_name;
            
            List<Statistics> st = StatisticWork.GetListStatByUID(u_id);
            int[] ar_ex_time = new int [st.Count];
            for (int i = 0; i < st.Count; i++)
            {
                Exercise ex = ExerciseWork.GetExerciseById(st[i].ExerciseId);
                dataGVStatistic.Rows.Add(i + 1, ex.Name, ex.Len, st[i].TipeSpeed, 
                    st[i].ErrorPct, ar_ex_time[i] = (int)(60 * ex.Len) / st[i].TipeSpeed, st[i].Date);
            }
            chartView(st, ar_ex_time);
            //dataGVStatistic.Rows.Add("1", "0", "0", stat.TipeSpeed, stat.ErrorPct, stat.TipeSpeed, stat.Date);
        }

        public DiagrammForm(long ex_id, string ex_name) // Статистика для упражнения
        {
            InitializeComponent();
            labelAbout.Text = "Статистика по упражнению " + ex_name;
            Exercise ex = ExerciseWork.GetExerciseByName(ex_name);
            List<Statistics> st = StatisticWork.GetListStatByExersID(ex_id);
            int[] ar_ex_time = new int[st.Count];
            for (int i = 0; i < st.Count; i++)
            {
                dataGVStatistic.Rows.Add(i + 1, ex_name, ex.Len, st[i].TipeSpeed, 
                    st[i].ErrorPct, ar_ex_time[i] = (int)(60* ex.Len)/ st[i].TipeSpeed, st[i].Date);
            }
            chartView(st, ar_ex_time);
        }

        public DiagrammForm(long ex_id, string ex_name, string u_name, long u_id) // Статистика для упражнения по пользователю
        {
            InitializeComponent();
            labelAbout.Text = "По упражнению " + ex_name + " для пользователя " + u_name;
            
            Exercise ex = ExerciseWork.GetExerciseByName(ex_name);
            List<Statistics> st = StatisticWork.GetListStatByUIDAndExersID(u_id, ex_id);
            int[] ar_ex_time = new int[st.Count];
            for (int i = 0; i < st.Count; i++)
            {
                dataGVStatistic.Rows.Add(i + 1, ex_name, ex.Len, st[i].TipeSpeed,
                    st[i].ErrorPct, ar_ex_time[i] = (int)(60 * ex.Len) / st[i].TipeSpeed, st[i].Date);
            }
            chartView(st, ar_ex_time);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void chartView(List<Statistics> st, int [] arr)
        {
            Series mySeriesSpeed = new Series("Скорость");
            Series mySeriesMistake = new Series("Ошибки");
            Series mySeriesTime = new Series("Время");
            for (int i = 0; i < st.Count; i++)
            {
                mySeriesSpeed.Points.AddXY(st[i].Date, st[i].TipeSpeed);
                mySeriesMistake.Points.AddXY(st[i].Date, st[i].ErrorPct);
                mySeriesTime.Points.AddXY(st[i].Date, arr[i]);
            }
            chartSpeed.Series[0] = mySeriesSpeed;
            chartMistake.Series[0] = mySeriesMistake;
            chartTime.Series[0] = mySeriesTime;

        }

        private void chartMistake_Click(object sender, EventArgs e)
        {

        }
    }
}
