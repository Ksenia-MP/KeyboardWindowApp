
namespace KeyboardWIndowApp
{
    partial class StaticAdminForm
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
            this.statisticBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comBoxExers = new System.Windows.Forms.ComboBox();
            this.comBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelExers = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statisticBtn
            // 
            this.statisticBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.statisticBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statisticBtn.Location = new System.Drawing.Point(268, 52);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Size = new System.Drawing.Size(215, 60);
            this.statisticBtn.TabIndex = 18;
            this.statisticBtn.Text = "Посмотреть";
            this.statisticBtn.UseVisualStyleBackColor = false;
            this.statisticBtn.Click += new System.EventHandler(this.statisticBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(268, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(268, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "Общая статистика";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comBoxExers
            // 
            this.comBoxExers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxExers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxExers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comBoxExers.FormattingEnabled = true;
            this.comBoxExers.Location = new System.Drawing.Point(32, 80);
            this.comBoxExers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxExers.Name = "comBoxExers";
            this.comBoxExers.Size = new System.Drawing.Size(216, 34);
            this.comBoxExers.TabIndex = 21;
            // 
            // comBoxUsers
            // 
            this.comBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comBoxUsers.FormattingEnabled = true;
            this.comBoxUsers.Location = new System.Drawing.Point(32, 169);
            this.comBoxUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxUsers.Name = "comBoxUsers";
            this.comBoxUsers.Size = new System.Drawing.Size(216, 34);
            this.comBoxUsers.TabIndex = 22;
            // 
            // labelExers
            // 
            this.labelExers.AutoSize = true;
            this.labelExers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExers.Location = new System.Drawing.Point(28, 52);
            this.labelExers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExers.Name = "labelExers";
            this.labelExers.Size = new System.Drawing.Size(121, 26);
            this.labelExers.TabIndex = 23;
            this.labelExers.Text = "По уровню";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(28, 141);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(193, 26);
            this.labelUsers.TabIndex = 24;
            this.labelUsers.Text = "По пользователю";
            // 
            // StaticAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 366);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.labelExers);
            this.Controls.Add(this.comBoxUsers);
            this.Controls.Add(this.comBoxExers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statisticBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaticAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика тренажера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button statisticBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comBoxExers;
        private System.Windows.Forms.ComboBox comBoxUsers;
        private System.Windows.Forms.Label labelExers;
        private System.Windows.Forms.Label labelUsers;
    }
}