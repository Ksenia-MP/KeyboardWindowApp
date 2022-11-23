
namespace KeyboardWIndowApp
{
    partial class CreateExercise
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
            this.exerciseName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diffComBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countChar = new System.Windows.Forms.NumericUpDown();
            this.character = new System.Windows.Forms.RichTextBox();
            this.exerciseText = new System.Windows.Forms.RichTextBox();
            this.openBut = new System.Windows.Forms.Button();
            this.generateBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countChar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название упражнения";
            // 
            // exerciseName
            // 
            this.exerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.exerciseName.Location = new System.Drawing.Point(227, 16);
            this.exerciseName.Multiline = true;
            this.exerciseName.Name = "exerciseName";
            this.exerciseName.Size = new System.Drawing.Size(209, 51);
            this.exerciseName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyboardWIndowApp.Properties.Resources.Keyboard_layout;
            this.pictureBox1.Location = new System.Drawing.Point(447, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // diffComBox
            // 
            this.diffComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diffComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffComBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diffComBox.FormattingEnabled = true;
            this.diffComBox.Location = new System.Drawing.Point(14, 119);
            this.diffComBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diffComBox.Name = "diffComBox";
            this.diffComBox.Size = new System.Drawing.Size(192, 39);
            this.diffComBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сложность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(222, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кол-во символов:";
            // 
            // countChar
            // 
            this.countChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.countChar.Location = new System.Drawing.Point(227, 120);
            this.countChar.Name = "countChar";
            this.countChar.Size = new System.Drawing.Size(209, 34);
            this.countChar.TabIndex = 13;
            // 
            // character
            // 
            this.character.Location = new System.Drawing.Point(12, 163);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(429, 45);
            this.character.TabIndex = 14;
            this.character.Text = "";
            // 
            // exerciseText
            // 
            this.exerciseText.Location = new System.Drawing.Point(12, 214);
            this.exerciseText.Name = "exerciseText";
            this.exerciseText.Size = new System.Drawing.Size(835, 299);
            this.exerciseText.TabIndex = 15;
            this.exerciseText.Text = "";
            // 
            // openBut
            // 
            this.openBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.openBut.Location = new System.Drawing.Point(853, 214);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(207, 58);
            this.openBut.TabIndex = 16;
            this.openBut.Text = "Открыть файл";
            this.openBut.UseVisualStyleBackColor = false;
            this.openBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateBut
            // 
            this.generateBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.generateBut.Location = new System.Drawing.Point(853, 291);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(207, 58);
            this.generateBut.TabIndex = 17;
            this.generateBut.Text = "Сгенерировать";
            this.generateBut.UseVisualStyleBackColor = false;
            this.generateBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.Color.Blue;
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.saveBut.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBut.Location = new System.Drawing.Point(853, 455);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(207, 58);
            this.saveBut.TabIndex = 18;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            // 
            // CreateExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 525);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.exerciseText);
            this.Controls.Add(this.character);
            this.Controls.Add(this.countChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diffComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exerciseName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateExercise";
            this.Text = "Создание упражнения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exerciseName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox diffComBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countChar;
        private System.Windows.Forms.RichTextBox character;
        private System.Windows.Forms.RichTextBox exerciseText;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.Button generateBut;
        private System.Windows.Forms.Button saveBut;
    }
}