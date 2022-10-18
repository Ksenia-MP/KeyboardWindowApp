
namespace KeyboardWIndowApp
{
    partial class Form1
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
            this.Войти = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.Регистрация = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Войти
            // 
            this.Войти.Location = new System.Drawing.Point(89, 105);
            this.Войти.Margin = new System.Windows.Forms.Padding(4);
            this.Войти.Name = "Войти";
            this.Войти.Size = new System.Drawing.Size(167, 45);
            this.Войти.TabIndex = 0;
            this.Войти.Text = "Войти";
            this.Войти.UseVisualStyleBackColor = true;
            this.Войти.Click += new System.EventHandler(this.Войти_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(89, 22);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(419, 22);
            this.loginText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(89, 67);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(419, 22);
            this.passwordText.TabIndex = 4;
            // 
            // Регистрация
            // 
            this.Регистрация.Location = new System.Drawing.Point(341, 105);
            this.Регистрация.Margin = new System.Windows.Forms.Padding(4);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(167, 45);
            this.Регистрация.TabIndex = 5;
            this.Регистрация.Text = "Регистрация";
            this.Регистрация.UseVisualStyleBackColor = true;
            this.Регистрация.Click += new System.EventHandler(this.Регистрация_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 163);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Войти);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Войти;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button Регистрация;
    }
}

