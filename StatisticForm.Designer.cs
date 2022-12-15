
namespace KeyboardWIndowApp
{
    partial class StatisticForm
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.statisticBtn = new System.Windows.Forms.Button();
            this.exrcBtn = new System.Windows.Forms.Button();
            this.ExercisesTab = new System.Windows.Forms.TabControl();
            this.info = new System.Windows.Forms.PictureBox();
            this.buttonAllStatistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.BackColor = System.Drawing.Color.SkyBlue;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLbl.Location = new System.Drawing.Point(0, 0);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(325, 80);
            this.userNameLbl.TabIndex = 11;
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.testBtn.Location = new System.Drawing.Point(20, 491);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(287, 74);
            this.testBtn.TabIndex = 19;
            this.testBtn.Text = "Тестовое упражнение";
            this.testBtn.UseVisualStyleBackColor = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsBtn.Location = new System.Drawing.Point(20, 271);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(287, 74);
            this.settingsBtn.TabIndex = 18;
            this.settingsBtn.Text = "Настройка";
            this.settingsBtn.UseVisualStyleBackColor = false;
            // 
            // statisticBtn
            // 
            this.statisticBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.statisticBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statisticBtn.Location = new System.Drawing.Point(20, 185);
            this.statisticBtn.Margin = new System.Windows.Forms.Padding(4);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Size = new System.Drawing.Size(287, 74);
            this.statisticBtn.TabIndex = 17;
            this.statisticBtn.Text = "Статистика";
            this.statisticBtn.UseVisualStyleBackColor = false;
            // 
            // exrcBtn
            // 
            this.exrcBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exrcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exrcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exrcBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exrcBtn.Location = new System.Drawing.Point(20, 98);
            this.exrcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exrcBtn.Name = "exrcBtn";
            this.exrcBtn.Size = new System.Drawing.Size(287, 74);
            this.exrcBtn.TabIndex = 16;
            this.exrcBtn.Text = "Упражнения";
            this.exrcBtn.UseVisualStyleBackColor = false;
            // 
            // ExercisesTab
            // 
            this.ExercisesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExercisesTab.ItemSize = new System.Drawing.Size(58, 30);
            this.ExercisesTab.Location = new System.Drawing.Point(331, 87);
            this.ExercisesTab.Margin = new System.Windows.Forms.Padding(4);
            this.ExercisesTab.Multiline = true;
            this.ExercisesTab.Name = "ExercisesTab";
            this.ExercisesTab.SelectedIndex = 0;
            this.ExercisesTab.Size = new System.Drawing.Size(713, 481);
            this.ExercisesTab.TabIndex = 20;
            // 
            // info
            // 
            this.info.Image = global::KeyboardWIndowApp.Properties.Resources.infolinear;
            this.info.Location = new System.Drawing.Point(1000, 4);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(47, 47);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 21;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // buttonAllStatistic
            // 
            this.buttonAllStatistic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAllStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonAllStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllStatistic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAllStatistic.Location = new System.Drawing.Point(684, 4);
            this.buttonAllStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllStatistic.Name = "buttonAllStatistic";
            this.buttonAllStatistic.Size = new System.Drawing.Size(308, 47);
            this.buttonAllStatistic.TabIndex = 22;
            this.buttonAllStatistic.Text = "Общая статистика";
            this.buttonAllStatistic.UseVisualStyleBackColor = false;
            this.buttonAllStatistic.Click += new System.EventHandler(this.buttonAllStatistic_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 578);
            this.Controls.Add(this.buttonAllStatistic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ExercisesTab);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.statisticBtn);
            this.Controls.Add(this.exrcBtn);
            this.Controls.Add(this.userNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatisticForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button statisticBtn;
        private System.Windows.Forms.Button exrcBtn;
        private System.Windows.Forms.TabControl ExercisesTab;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Button buttonAllStatistic;
    }
}