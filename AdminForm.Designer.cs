
namespace KeyboardWIndowApp
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExercisesTab = new System.Windows.Forms.TabControl();
            this.ExrcsBtn = new System.Windows.Forms.Button();
            this.adminStatBtn = new System.Windows.Forms.Button();
            this.createExrcBtn = new System.Windows.Forms.Button();
            this.LevelSettingsBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администратор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ExercisesTab.Size = new System.Drawing.Size(713, 478);
            this.ExercisesTab.TabIndex = 2;
            // 
            // ExrcsBtn
            // 
            this.ExrcsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ExrcsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExrcsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExrcsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExrcsBtn.Location = new System.Drawing.Point(20, 98);
            this.ExrcsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExrcsBtn.Name = "ExrcsBtn";
            this.ExrcsBtn.Size = new System.Drawing.Size(287, 74);
            this.ExrcsBtn.TabIndex = 3;
            this.ExrcsBtn.Text = "Упражнения";
            this.ExrcsBtn.UseVisualStyleBackColor = false;
            // 
            // adminStatBtn
            // 
            this.adminStatBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminStatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.adminStatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminStatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminStatBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminStatBtn.Location = new System.Drawing.Point(20, 185);
            this.adminStatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminStatBtn.Name = "adminStatBtn";
            this.adminStatBtn.Size = new System.Drawing.Size(287, 74);
            this.adminStatBtn.TabIndex = 4;
            this.adminStatBtn.Text = "Статистика";
            this.adminStatBtn.UseVisualStyleBackColor = false;
            this.adminStatBtn.Click += new System.EventHandler(this.adminStatBtn_Click);
            // 
            // createExrcBtn
            // 
            this.createExrcBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createExrcBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.createExrcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createExrcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createExrcBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createExrcBtn.Location = new System.Drawing.Point(20, 271);
            this.createExrcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createExrcBtn.Name = "createExrcBtn";
            this.createExrcBtn.Size = new System.Drawing.Size(287, 74);
            this.createExrcBtn.TabIndex = 5;
            this.createExrcBtn.Text = "Создать упражнение";
            this.createExrcBtn.UseVisualStyleBackColor = false;
            this.createExrcBtn.Click += new System.EventHandler(this.createExrcBtn_Click);
            // 
            // LevelSettingsBtn
            // 
            this.LevelSettingsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LevelSettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.LevelSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LevelSettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelSettingsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LevelSettingsBtn.Location = new System.Drawing.Point(20, 357);
            this.LevelSettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LevelSettingsBtn.Name = "LevelSettingsBtn";
            this.LevelSettingsBtn.Size = new System.Drawing.Size(287, 74);
            this.LevelSettingsBtn.TabIndex = 6;
            this.LevelSettingsBtn.Text = "Настройка сложности";
            this.LevelSettingsBtn.UseVisualStyleBackColor = false;
            this.LevelSettingsBtn.Click += new System.EventHandler(this.LevelSettingsBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeBtn.Location = new System.Drawing.Point(441, 15);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(207, 49);
            this.changeBtn.TabIndex = 7;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delBtn.Location = new System.Drawing.Point(647, 15);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(207, 49);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // info
            // 
            this.info.Image = global::KeyboardWIndowApp.Properties.Resources.infolinear;
            this.info.Location = new System.Drawing.Point(1000, 13);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(47, 47);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 9;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 578);
            this.Controls.Add(this.info);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.LevelSettingsBtn);
            this.Controls.Add(this.createExrcBtn);
            this.Controls.Add(this.adminStatBtn);
            this.Controls.Add(this.ExrcsBtn);
            this.Controls.Add(this.ExercisesTab);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Режим администратора";
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl ExercisesTab;
        private System.Windows.Forms.Button ExrcsBtn;
        private System.Windows.Forms.Button adminStatBtn;
        private System.Windows.Forms.Button createExrcBtn;
        private System.Windows.Forms.Button LevelSettingsBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.PictureBox info;
    }
}