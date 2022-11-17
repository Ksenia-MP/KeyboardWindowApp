
namespace KeyboardWIndowApp
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.reptpassText = new System.Windows.Forms.TextBox();
            this.reptpassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showRegBtn = new System.Windows.Forms.Button();
            this.newhereLable = new System.Windows.Forms.Label();
            this.showLogInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(54, 152);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(125, 37);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Вход";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.Войти_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(13, 25);
            this.loginText.Margin = new System.Windows.Forms.Padding(2);
            this.loginText.MaxLength = 8;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(191, 20);
            this.loginText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(13, 73);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordText.MaxLength = 12;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(191, 20);
            this.passwordText.TabIndex = 4;
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(54, 152);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(125, 37);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Visible = false;
            this.RegBtn.Click += new System.EventHandler(this.Регистрация_Click);
            // 
            // reptpassText
            // 
            this.reptpassText.Location = new System.Drawing.Point(13, 121);
            this.reptpassText.Margin = new System.Windows.Forms.Padding(2);
            this.reptpassText.MaxLength = 12;
            this.reptpassText.Name = "reptpassText";
            this.reptpassText.PasswordChar = '●';
            this.reptpassText.Size = new System.Drawing.Size(191, 20);
            this.reptpassText.TabIndex = 7;
            this.reptpassText.Visible = false;
            // 
            // reptpassLabel
            // 
            this.reptpassLabel.AutoSize = true;
            this.reptpassLabel.Location = new System.Drawing.Point(11, 105);
            this.reptpassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reptpassLabel.Name = "reptpassLabel";
            this.reptpassLabel.Size = new System.Drawing.Size(103, 13);
            this.reptpassLabel.TabIndex = 6;
            this.reptpassLabel.Text = "Повторите пароль:";
            this.reptpassLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "___________________________________";
            // 
            // showRegBtn
            // 
            this.showRegBtn.Location = new System.Drawing.Point(64, 228);
            this.showRegBtn.Name = "showRegBtn";
            this.showRegBtn.Size = new System.Drawing.Size(105, 28);
            this.showRegBtn.TabIndex = 9;
            this.showRegBtn.Text = "Регистрация";
            this.showRegBtn.UseVisualStyleBackColor = true;
            this.showRegBtn.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // newhereLable
            // 
            this.newhereLable.AutoSize = true;
            this.newhereLable.Location = new System.Drawing.Point(71, 212);
            this.newhereLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newhereLable.Name = "newhereLable";
            this.newhereLable.Size = new System.Drawing.Size(91, 13);
            this.newhereLable.TabIndex = 10;
            this.newhereLable.Text = "Впервые здесь?";
            // 
            // showLogInBtn
            // 
            this.showLogInBtn.Location = new System.Drawing.Point(64, 228);
            this.showLogInBtn.Name = "showLogInBtn";
            this.showLogInBtn.Size = new System.Drawing.Size(105, 28);
            this.showLogInBtn.TabIndex = 11;
            this.showLogInBtn.Text = "<< Назад";
            this.showLogInBtn.UseVisualStyleBackColor = true;
            this.showLogInBtn.Visible = false;
            this.showLogInBtn.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LogInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 267);
            this.Controls.Add(this.newhereLable);
            this.Controls.Add(this.showRegBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reptpassText);
            this.Controls.Add(this.reptpassLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.showLogInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.TextBox reptpassText;
        private System.Windows.Forms.Label reptpassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showRegBtn;
        private System.Windows.Forms.Label newhereLable;
        private System.Windows.Forms.Button showLogInBtn;
    }
}

