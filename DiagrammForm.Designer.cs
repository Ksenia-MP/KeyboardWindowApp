
namespace KeyboardWIndowApp
{
    partial class DiagrammForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMistake = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGVStatistic = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mistake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMistake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSpeed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(30, 15);
            this.chartSpeed.Name = "chartSpeed";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSpeed.Series.Add(series1);
            this.chartSpeed.Size = new System.Drawing.Size(250, 250);
            this.chartSpeed.TabIndex = 0;
            this.chartSpeed.Text = "Скорость печати";
            // 
            // chartMistake
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMistake.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMistake.Legends.Add(legend2);
            this.chartMistake.Location = new System.Drawing.Point(300, 15);
            this.chartMistake.Name = "chartMistake";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMistake.Series.Add(series2);
            this.chartMistake.Size = new System.Drawing.Size(250, 250);
            this.chartMistake.TabIndex = 1;
            this.chartMistake.Text = "% ошибок";
            // 
            // chartTime
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTime.Legends.Add(legend3);
            this.chartTime.Location = new System.Drawing.Point(570, 15);
            this.chartTime.Name = "chartTime";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTime.Series.Add(series3);
            this.chartTime.Size = new System.Drawing.Size(250, 250);
            this.chartTime.TabIndex = 2;
            this.chartTime.Text = "Время выполнения";
            // 
            // dataGVStatistic
            // 
            this.dataGVStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Level,
            this.Length,
            this.Speed,
            this.Mistake,
            this.Time,
            this.Date});
            this.dataGVStatistic.Location = new System.Drawing.Point(30, 300);
            this.dataGVStatistic.Name = "dataGVStatistic";
            this.dataGVStatistic.RowHeadersWidth = 51;
            this.dataGVStatistic.RowTemplate.Height = 24;
            this.dataGVStatistic.Size = new System.Drawing.Size(790, 274);
            this.dataGVStatistic.TabIndex = 3;
            this.dataGVStatistic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "№";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            // 
            // Level
            // 
            this.Level.HeaderText = "Уровень";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Скорость";
            this.Speed.MinimumWidth = 6;
            this.Speed.Name = "Speed";
            // 
            // Mistake
            // 
            this.Mistake.HeaderText = "% ошибок";
            this.Mistake.MinimumWidth = 6;
            this.Mistake.Name = "Mistake";
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // DiagrammForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 603);
            this.Controls.Add(this.dataGVStatistic);
            this.Controls.Add(this.chartTime);
            this.Controls.Add(this.chartMistake);
            this.Controls.Add(this.chartSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiagrammForm";
            this.Text = "Статистика диаграммы";
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMistake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMistake;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.DataGridView dataGVStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mistake;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}