namespace KeyboardWIndowApp
{
    partial class SettingUser
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
            this.delBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.saveBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.keyCheck = new System.Windows.Forms.CheckBox();
            this.musicCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личные данные";
            // 
            // delBut
            // 
            this.delBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.delBut.Location = new System.Drawing.Point(351, 12);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(247, 60);
            this.delBut.TabIndex = 1;
            this.delBut.Text = "Удалить аккаунт";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.passwordText.Location = new System.Drawing.Point(18, 163);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(307, 39);
            this.passwordText.TabIndex = 4;
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.loginText.Location = new System.Drawing.Point(18, 89);
            this.loginText.Multiline = true;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(307, 38);
            this.loginText.TabIndex = 5;
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.saveBut.ForeColor = System.Drawing.Color.White;
            this.saveBut.Location = new System.Drawing.Point(351, 282);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(247, 60);
            this.saveBut.TabIndex = 6;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Настройка тренажера";
            // 
            // keyCheck
            // 
            this.keyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.keyCheck.Location = new System.Drawing.Point(18, 254);
            this.keyCheck.Name = "keyCheck";
            this.keyCheck.Size = new System.Drawing.Size(327, 41);
            this.keyCheck.TabIndex = 8;
            this.keyCheck.Text = "Виртуальная клавиатура";
            this.keyCheck.UseVisualStyleBackColor = true;
            // 
            // musicCheck
            // 
            this.musicCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.musicCheck.Location = new System.Drawing.Point(18, 301);
            this.musicCheck.Name = "musicCheck";
            this.musicCheck.Size = new System.Drawing.Size(327, 41);
            this.musicCheck.TabIndex = 9;
            this.musicCheck.Text = "Звук нажатия клавиш";
            this.musicCheck.UseVisualStyleBackColor = true;
            // 
            // SettingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 361);
            this.Controls.Add(this.musicCheck);
            this.Controls.Add(this.keyCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingUser";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox keyCheck;
        private System.Windows.Forms.CheckBox musicCheck;
    }
}