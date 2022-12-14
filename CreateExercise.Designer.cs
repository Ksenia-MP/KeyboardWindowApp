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
            this.diffComBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countChar = new System.Windows.Forms.NumericUpDown();
            this.character = new System.Windows.Forms.RichTextBox();
            this.exerciseText = new System.Windows.Forms.RichTextBox();
            this.openBut = new System.Windows.Forms.Button();
            this.generateBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.diffName = new System.Windows.Forms.Label();
            this.zone6 = new System.Windows.Forms.Panel();
            this.zone2 = new System.Windows.Forms.Panel();
            this.zone5 = new System.Windows.Forms.Panel();
            this.zone7 = new System.Windows.Forms.Panel();
            this.zone3 = new System.Windows.Forms.Panel();
            this.zone1 = new System.Windows.Forms.Panel();
            this.zone4 = new System.Windows.Forms.Panel();
            this.zone8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countChar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название упражнения";
            // 
            // exerciseName
            // 
            this.exerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.exerciseName.Location = new System.Drawing.Point(226, 13);
            this.exerciseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exerciseName.MaxLength = 2;
            this.exerciseName.Multiline = true;
            this.exerciseName.Name = "exerciseName";
            this.exerciseName.Size = new System.Drawing.Size(102, 42);
            this.exerciseName.TabIndex = 1;
            this.exerciseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exerciseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exerciseName_KeyPress);
            // 
            // diffComBox
            // 
            this.diffComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diffComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffComBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diffComBox.FormattingEnabled = true;
            this.diffComBox.Location = new System.Drawing.Point(10, 97);
            this.diffComBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diffComBox.Name = "diffComBox";
            this.diffComBox.Size = new System.Drawing.Size(145, 34);
            this.diffComBox.TabIndex = 11;
            this.diffComBox.SelectedIndexChanged += new System.EventHandler(this.diffComBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сложность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(166, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество символов:";
            // 
            // countChar
            // 
            this.countChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countChar.Location = new System.Drawing.Point(170, 98);
            this.countChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countChar.Name = "countChar";
            this.countChar.Size = new System.Drawing.Size(157, 32);
            this.countChar.TabIndex = 13;
            // 
            // character
            // 
            this.character.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.character.Location = new System.Drawing.Point(9, 132);
            this.character.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(323, 37);
            this.character.TabIndex = 14;
            this.character.Text = "";
            this.character.TextChanged += new System.EventHandler(this.character_TextChanged);
            this.character.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.character_KeyPress);
            // 
            // exerciseText
            // 
            this.exerciseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exerciseText.Location = new System.Drawing.Point(9, 167);
            this.exerciseText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exerciseText.Name = "exerciseText";
            this.exerciseText.Size = new System.Drawing.Size(559, 244);
            this.exerciseText.TabIndex = 15;
            this.exerciseText.Text = "";
            this.exerciseText.TextChanged += new System.EventHandler(this.exerciseText_TextChanged);
            this.exerciseText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exerciseText_KeyPress);
            // 
            // openBut
            // 
            this.openBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openBut.Location = new System.Drawing.Point(572, 167);
            this.openBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(172, 47);
            this.openBut.TabIndex = 16;
            this.openBut.Text = "Открыть файл";
            this.openBut.UseVisualStyleBackColor = false;
            this.openBut.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // generateBut
            // 
            this.generateBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateBut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.generateBut.Location = new System.Drawing.Point(572, 219);
            this.generateBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(172, 47);
            this.generateBut.TabIndex = 17;
            this.generateBut.Text = "Сгенерировать";
            this.generateBut.UseVisualStyleBackColor = false;
            this.generateBut.Click += new System.EventHandler(this.generateBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBut.Location = new System.Drawing.Point(572, 362);
            this.saveBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(172, 47);
            this.saveBut.TabIndex = 18;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // diffName
            // 
            this.diffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.diffName.Location = new System.Drawing.Point(170, 13);
            this.diffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diffName.Name = "diffName";
            this.diffName.Size = new System.Drawing.Size(51, 41);
            this.diffName.TabIndex = 19;
            this.diffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zone6
            // 
            this.zone6.BackColor = System.Drawing.SystemColors.Control;
            this.zone6.ForeColor = System.Drawing.SystemColors.Control;
            this.zone6.Location = new System.Drawing.Point(232, 14);
            this.zone6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone6.Name = "zone6";
            this.zone6.Size = new System.Drawing.Size(59, 105);
            this.zone6.TabIndex = 4;
            // 
            // zone2
            // 
            this.zone2.BackColor = System.Drawing.SystemColors.Control;
            this.zone2.ForeColor = System.Drawing.SystemColors.Control;
            this.zone2.Location = new System.Drawing.Point(158, 14);
            this.zone2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone2.Name = "zone2";
            this.zone2.Size = new System.Drawing.Size(112, 105);
            this.zone2.TabIndex = 6;
            // 
            // zone5
            // 
            this.zone5.BackColor = System.Drawing.SystemColors.Control;
            this.zone5.ForeColor = System.Drawing.SystemColors.Control;
            this.zone5.Location = new System.Drawing.Point(58, 14);
            this.zone5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone5.Name = "zone5";
            this.zone5.Size = new System.Drawing.Size(58, 105);
            this.zone5.TabIndex = 3;
            // 
            // zone7
            // 
            this.zone7.BackColor = System.Drawing.SystemColors.Control;
            this.zone7.ForeColor = System.Drawing.SystemColors.Control;
            this.zone7.Location = new System.Drawing.Point(33, 14);
            this.zone7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone7.Name = "zone7";
            this.zone7.Size = new System.Drawing.Size(74, 105);
            this.zone7.TabIndex = 2;
            // 
            // zone3
            // 
            this.zone3.BackColor = System.Drawing.SystemColors.Control;
            this.zone3.ForeColor = System.Drawing.SystemColors.Control;
            this.zone3.Location = new System.Drawing.Point(83, 14);
            this.zone3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone3.Name = "zone3";
            this.zone3.Size = new System.Drawing.Size(62, 105);
            this.zone3.TabIndex = 4;
            // 
            // zone1
            // 
            this.zone1.BackColor = System.Drawing.SystemColors.Control;
            this.zone1.ForeColor = System.Drawing.SystemColors.Control;
            this.zone1.Location = new System.Drawing.Point(108, 14);
            this.zone1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone1.Name = "zone1";
            this.zone1.Size = new System.Drawing.Size(106, 105);
            this.zone1.TabIndex = 5;
            // 
            // zone4
            // 
            this.zone4.BackColor = System.Drawing.SystemColors.Control;
            this.zone4.ForeColor = System.Drawing.SystemColors.Control;
            this.zone4.Location = new System.Drawing.Point(208, 14);
            this.zone4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone4.Name = "zone4";
            this.zone4.Size = new System.Drawing.Size(62, 105);
            this.zone4.TabIndex = 4;
            // 
            // zone8
            // 
            this.zone8.BackColor = System.Drawing.SystemColors.Control;
            this.zone8.ForeColor = System.Drawing.SystemColors.Control;
            this.zone8.Location = new System.Drawing.Point(257, 14);
            this.zone8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone8.Name = "zone8";
            this.zone8.Size = new System.Drawing.Size(111, 105);
            this.zone8.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zone6);
            this.panel1.Controls.Add(this.zone2);
            this.panel1.Controls.Add(this.zone5);
            this.panel1.Controls.Add(this.zone7);
            this.panel1.Controls.Add(this.zone3);
            this.panel1.Controls.Add(this.zone1);
            this.panel1.Controls.Add(this.zone4);
            this.panel1.Controls.Add(this.zone8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(355, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 139);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyboardWIndowApp.Properties.Resources.Keyboard_layout;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.Image = global::KeyboardWIndowApp.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(572, 271);
            this.refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 41);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 21;
            this.refresh.TabStop = false;
            this.refresh.Visible = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // CreateExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 422);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diffName);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.exerciseText);
            this.Controls.Add(this.character);
            this.Controls.Add(this.countChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diffComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exerciseName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание упражнения";
            ((System.ComponentModel.ISupportInitialize)(this.countChar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exerciseName;
        private System.Windows.Forms.ComboBox diffComBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countChar;
        private System.Windows.Forms.RichTextBox character;
        private System.Windows.Forms.RichTextBox exerciseText;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.Button generateBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label diffName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel zone6;
        private System.Windows.Forms.Panel zone2;
        private System.Windows.Forms.Panel zone5;
        private System.Windows.Forms.Panel zone7;
        private System.Windows.Forms.Panel zone3;
        private System.Windows.Forms.Panel zone1;
        private System.Windows.Forms.Panel zone4;
        private System.Windows.Forms.Panel zone8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox refresh;
    }
}