
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
            this.settingsBtn = new System.Windows.Forms.Button();
            this.statisticBtn = new System.Windows.Forms.Button();
            this.exrcBtn = new System.Windows.Forms.Button();
            this.ExercisesTab = new System.Windows.Forms.TabControl();
            this.info = new System.Windows.Forms.PictureBox();
            this.buttonAllStatistic = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.BackColor = System.Drawing.Color.SkyBlue;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLbl.Location = new System.Drawing.Point(0, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(244, 65);
            this.userNameLbl.TabIndex = 11;
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsBtn.Location = new System.Drawing.Point(15, 220);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(215, 60);
            this.settingsBtn.TabIndex = 18;
            this.settingsBtn.Text = "Настройка";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // statisticBtn
            // 
            this.statisticBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.statisticBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statisticBtn.Location = new System.Drawing.Point(15, 150);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Size = new System.Drawing.Size(215, 60);
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
            this.exrcBtn.Location = new System.Drawing.Point(15, 80);
            this.exrcBtn.Name = "exrcBtn";
            this.exrcBtn.Size = new System.Drawing.Size(215, 60);
            this.exrcBtn.TabIndex = 16;
            this.exrcBtn.Text = "Упражнения";
            this.exrcBtn.UseVisualStyleBackColor = false;
            this.exrcBtn.Click += new System.EventHandler(this.exrcBtn_Click);
            // 
            // ExercisesTab
            // 
            this.ExercisesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExercisesTab.ItemSize = new System.Drawing.Size(58, 30);
            this.ExercisesTab.Location = new System.Drawing.Point(248, 71);
            this.ExercisesTab.Multiline = true;
            this.ExercisesTab.Name = "ExercisesTab";
            this.ExercisesTab.SelectedIndex = 0;
            this.ExercisesTab.Size = new System.Drawing.Size(535, 391);
            this.ExercisesTab.TabIndex = 20;
            this.ExercisesTab.SelectedIndexChanged += new System.EventHandler(this.ExercisesTab_SelectedIndexChanged);
            // 
            // info
            // 
            this.info.Image = global::KeyboardWIndowApp.Properties.Resources.infolinear;
            this.info.Location = new System.Drawing.Point(750, 11);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 38);
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
            this.buttonAllStatistic.Location = new System.Drawing.Point(464, 11);
            this.buttonAllStatistic.Name = "buttonAllStatistic";
            this.buttonAllStatistic.Size = new System.Drawing.Size(231, 38);
            this.buttonAllStatistic.TabIndex = 22;
            this.buttonAllStatistic.Text = "Общая статистика";
            this.buttonAllStatistic.UseVisualStyleBackColor = false;
            this.buttonAllStatistic.Click += new System.EventHandler(this.buttonAllStatistic_Click);
            // 
            // logout
            // 
            this.logout.Image = global::KeyboardWIndowApp.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(709, 11);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(35, 38);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 23;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 470);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.buttonAllStatistic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ExercisesTab);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.statisticBtn);
            this.Controls.Add(this.exrcBtn);
            this.Controls.Add(this.userNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button statisticBtn;
        private System.Windows.Forms.Button exrcBtn;
        private System.Windows.Forms.TabControl ExercisesTab;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Button buttonAllStatistic;
        private System.Windows.Forms.PictureBox logout;
    }
}