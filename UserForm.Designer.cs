
namespace KeyboardWIndowApp
{
    partial class UserForm
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
            this.info = new System.Windows.Forms.PictureBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.statisticBtn = new System.Windows.Forms.Button();
            this.exrcBtn = new System.Windows.Forms.Button();
            this.ExercisesTab = new System.Windows.Forms.TabControl();
            this.userNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Image = global::KeyboardWIndowApp.Properties.Resources.infolinear;
            this.info.Location = new System.Drawing.Point(1000, 13);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(47, 47);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 18;
            this.info.TabStop = false;
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
            this.testBtn.TabIndex = 15;
            this.testBtn.Text = "Тестовое упражнение";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
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
            this.settingsBtn.TabIndex = 14;
            this.settingsBtn.Text = "Настройка";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // statisticBtn
            // 
            this.statisticBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statisticBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statisticBtn.Location = new System.Drawing.Point(20, 185);
            this.statisticBtn.Margin = new System.Windows.Forms.Padding(4);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Size = new System.Drawing.Size(287, 74);
            this.statisticBtn.TabIndex = 13;
            this.statisticBtn.Text = "Статистика";
            this.statisticBtn.UseVisualStyleBackColor = false;
            // 
            // exrcBtn
            // 
            this.exrcBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.exrcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exrcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exrcBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exrcBtn.Location = new System.Drawing.Point(20, 98);
            this.exrcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exrcBtn.Name = "exrcBtn";
            this.exrcBtn.Size = new System.Drawing.Size(287, 74);
            this.exrcBtn.TabIndex = 12;
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
            this.ExercisesTab.TabIndex = 11;
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
            this.userNameLbl.TabIndex = 10;
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 578);
            this.Controls.Add(this.info);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.statisticBtn);
            this.Controls.Add(this.exrcBtn);
            this.Controls.Add(this.ExercisesTab);
            this.Controls.Add(this.userNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "Клавиатурный тренажер";
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button statisticBtn;
        private System.Windows.Forms.Button exrcBtn;
        private System.Windows.Forms.TabControl ExercisesTab;
        private System.Windows.Forms.Label userNameLbl;
    }
}