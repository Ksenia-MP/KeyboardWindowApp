
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMistake = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGVStatistic = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mistake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMistake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSpeed
            // 
            chartArea1.AxisX.Title = "Дата";
            chartArea1.AxisY.Title = "Скорость печати";
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(30, 60);
            this.chartSpeed.Name = "chartSpeed";
            this.chartSpeed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSpeed.Series.Add(series1);
            this.chartSpeed.Size = new System.Drawing.Size(350, 350);
            this.chartSpeed.TabIndex = 0;
            this.chartSpeed.Text = "Скорость печати";
            // 
            // chartMistake
            // 
            chartArea2.AxisX.Title = "Дата";
            chartArea2.AxisY.Title = "% ошибок";
            chartArea2.Name = "ChartArea1";
            this.chartMistake.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartMistake.Legends.Add(legend2);
            this.chartMistake.Location = new System.Drawing.Point(400, 60);
            this.chartMistake.Name = "chartMistake";
            this.chartMistake.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMistake.Series.Add(series2);
            this.chartMistake.Size = new System.Drawing.Size(350, 350);
            this.chartMistake.TabIndex = 1;
            this.chartMistake.Text = "% ошибок";
            this.chartMistake.Click += new System.EventHandler(this.chartMistake_Click);
            // 
            // chartTime
            // 
            chartArea3.AxisX.Title = "Дата";
            chartArea3.AxisY.Title = "Время выполнения";
            chartArea3.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartTime.Legends.Add(legend3);
            this.chartTime.Location = new System.Drawing.Point(770, 60);
            this.chartTime.Name = "chartTime";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTime.Series.Add(series3);
            this.chartTime.Size = new System.Drawing.Size(350, 350);
            this.chartTime.TabIndex = 2;
            this.chartTime.Text = "Время выполнения";
            // 
            // dataGVStatistic
            // 
            this.dataGVStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVStatistic.ColumnHeadersHeight = 29;
            this.dataGVStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.ex,
            this.Length,
            this.Speed,
            this.Mistake,
            this.ColumnTime,
            this.Date});
            this.dataGVStatistic.Location = new System.Drawing.Point(31, 445);
            this.dataGVStatistic.Name = "dataGVStatistic";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVStatistic.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVStatistic.RowHeadersVisible = false;
            this.dataGVStatistic.RowHeadersWidth = 51;
            this.dataGVStatistic.RowTemplate.Height = 24;
            this.dataGVStatistic.Size = new System.Drawing.Size(1089, 321);
            this.dataGVStatistic.TabIndex = 3;
            this.dataGVStatistic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.FillWeight = 80.21389F;
            this.Num.HeaderText = "№";
            this.Num.MinimumWidth = 15;
            this.Num.Name = "Num";
            // 
            // ex
            // 
            this.ex.HeaderText = "Упражнение";
            this.ex.MinimumWidth = 6;
            this.ex.Name = "ex";
            // 
            // Length
            // 
            this.Length.FillWeight = 103.9572F;
            this.Length.HeaderText = "Длина";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            // 
            // Speed
            // 
            this.Speed.FillWeight = 103.9572F;
            this.Speed.HeaderText = "Скорость";
            this.Speed.MinimumWidth = 6;
            this.Speed.Name = "Speed";
            // 
            // Mistake
            // 
            this.Mistake.FillWeight = 103.9572F;
            this.Mistake.HeaderText = "% ошибок";
            this.Mistake.MinimumWidth = 6;
            this.Mistake.Name = "Mistake";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            // 
            // Date
            // 
            this.Date.FillWeight = 103.9572F;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.Location = new System.Drawing.Point(24, 9);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(259, 32);
            this.labelAbout.TabIndex = 4;
            this.labelAbout.Text = "Статистика общая";
            // 
            // DiagrammForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 778);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.dataGVStatistic);
            this.Controls.Add(this.chartTime);
            this.Controls.Add(this.chartMistake);
            this.Controls.Add(this.chartSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiagrammForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика диаграммы";
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMistake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMistake;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.DataGridView dataGVStatistic;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mistake;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}