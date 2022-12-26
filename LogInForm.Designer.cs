
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
            this.LogInBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogInBtn.Location = new System.Drawing.Point(108, 266);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(239, 60);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Вход";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginText.Location = new System.Drawing.Point(21, 45);
            this.loginText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginText.MaxLength = 8;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(407, 38);
            this.loginText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordText.Location = new System.Drawing.Point(21, 123);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.MaxLength = 12;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(407, 38);
            this.passwordText.TabIndex = 4;
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegBtn.Location = new System.Drawing.Point(108, 266);
            this.RegBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(239, 60);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Visible = false;
            this.RegBtn.Click += new System.EventHandler(this.Registr_Click);
            // 
            // reptpassText
            // 
            this.reptpassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reptpassText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reptpassText.Location = new System.Drawing.Point(21, 197);
            this.reptpassText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reptpassText.MaxLength = 12;
            this.reptpassText.Name = "reptpassText";
            this.reptpassText.PasswordChar = '●';
            this.reptpassText.Size = new System.Drawing.Size(407, 38);
            this.reptpassText.TabIndex = 7;
            this.reptpassText.Visible = false;
            // 
            // reptpassLabel
            // 
            this.reptpassLabel.AutoSize = true;
            this.reptpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reptpassLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reptpassLabel.Location = new System.Drawing.Point(15, 163);
            this.reptpassLabel.Name = "reptpassLabel";
            this.reptpassLabel.Size = new System.Drawing.Size(283, 32);
            this.reptpassLabel.TabIndex = 6;
            this.reptpassLabel.Text = "Повторите пароль:";
            this.reptpassLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "__________________________";
            // 
            // showRegBtn
            // 
            this.showRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showRegBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showRegBtn.Location = new System.Drawing.Point(108, 431);
            this.showRegBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showRegBtn.Name = "showRegBtn";
            this.showRegBtn.Size = new System.Drawing.Size(239, 60);
            this.showRegBtn.TabIndex = 9;
            this.showRegBtn.Text = "Регистрация";
            this.showRegBtn.UseVisualStyleBackColor = true;
            this.showRegBtn.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // newhereLable
            // 
            this.newhereLable.AutoSize = true;
            this.newhereLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newhereLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newhereLable.Location = new System.Drawing.Point(105, 382);
            this.newhereLable.Name = "newhereLable";
            this.newhereLable.Size = new System.Drawing.Size(245, 32);
            this.newhereLable.TabIndex = 10;
            this.newhereLable.Text = "Впервые здесь?";
            // 
            // showLogInBtn
            // 
            this.showLogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showLogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showLogInBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showLogInBtn.Location = new System.Drawing.Point(108, 431);
            this.showLogInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showLogInBtn.Name = "showLogInBtn";
            this.showLogInBtn.Size = new System.Drawing.Size(239, 60);
            this.showLogInBtn.TabIndex = 11;
            this.showLogInBtn.Text = "<< Назад";
            this.showLogInBtn.UseVisualStyleBackColor = true;
            this.showLogInBtn.Visible = false;
            this.showLogInBtn.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LogInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 531);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.newhereLable);
            this.Controls.Add(this.showRegBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reptpassText);
            this.Controls.Add(this.reptpassLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showLogInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

