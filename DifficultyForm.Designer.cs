
namespace KeyboardWIndowApp
{
    partial class DifficultyForm
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
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zone7 = new System.Windows.Forms.Panel();
            this.zone5 = new System.Windows.Forms.Panel();
            this.zone3 = new System.Windows.Forms.Panel();
            this.zone4 = new System.Windows.Forms.Panel();
            this.zone6 = new System.Windows.Forms.Panel();
            this.zone8 = new System.Windows.Forms.Panel();
            this.zone1 = new System.Windows.Forms.Panel();
            this.zone2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diffComBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minExeLenText = new System.Windows.Forms.TextBox();
            this.maxExeLenText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errPctText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.typeSpeedText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeZoneText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
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
            // zone7
            // 
            this.zone7.BackColor = System.Drawing.SystemColors.Control;
            this.zone7.ForeColor = System.Drawing.SystemColors.Control;
            this.zone7.Location = new System.Drawing.Point(33, 14);
            this.zone7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zone7.Name = "zone7";
            this.zone7.Size = new System.Drawing.Size(74, 105);
            this.zone7.TabIndex = 2;
            this.zone7.Click += new System.EventHandler(this.zone_Click);
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
            this.zone5.Click += new System.EventHandler(this.zone_Click);
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
            this.zone3.Click += new System.EventHandler(this.zone_Click);
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
            this.zone4.Click += new System.EventHandler(this.zone_Click);
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
            this.zone6.Click += new System.EventHandler(this.zone_Click);
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
            this.zone8.Click += new System.EventHandler(this.zone_Click);
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
            this.zone1.Click += new System.EventHandler(this.zone_Click);
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
            this.zone2.Click += new System.EventHandler(this.zone_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.zone5);
            this.panel1.Controls.Add(this.zone7);
            this.panel1.Controls.Add(this.zone3);
            this.panel1.Controls.Add(this.zone1);
            this.panel1.Controls.Add(this.zone4);
            this.panel1.Controls.Add(this.zone8);
            this.panel1.Controls.Add(this.zone6);
            this.panel1.Controls.Add(this.zone2);
            this.panel1.Location = new System.Drawing.Point(246, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 139);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(337, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбор зон клавиатуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сложность:";
            // 
            // diffComBox
            // 
            this.diffComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diffComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffComBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diffComBox.FormattingEnabled = true;
            this.diffComBox.Location = new System.Drawing.Point(13, 33);
            this.diffComBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diffComBox.Name = "diffComBox";
            this.diffComBox.Size = new System.Drawing.Size(145, 34);
            this.diffComBox.TabIndex = 9;
            this.diffComBox.SelectedIndexChanged += new System.EventHandler(this.diffComBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Длина упражнения:";
            // 
            // minExeLenText
            // 
            this.minExeLenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minExeLenText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minExeLenText.Location = new System.Drawing.Point(13, 126);
            this.minExeLenText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minExeLenText.Name = "minExeLenText";
            this.minExeLenText.Size = new System.Drawing.Size(76, 32);
            this.minExeLenText.TabIndex = 11;
            this.minExeLenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxExeLenText
            // 
            this.maxExeLenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxExeLenText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxExeLenText.Location = new System.Drawing.Point(121, 126);
            this.maxExeLenText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxExeLenText.Name = "maxExeLenText";
            this.maxExeLenText.Size = new System.Drawing.Size(76, 32);
            this.maxExeLenText.TabIndex = 12;
            this.maxExeLenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(92, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "—";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(118, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "max";
            // 
            // errPctText
            // 
            this.errPctText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errPctText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errPctText.Location = new System.Drawing.Point(13, 196);
            this.errPctText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errPctText.Mask = "000%";
            this.errPctText.Name = "errPctText";
            this.errPctText.PromptChar = ' ';
            this.errPctText.Size = new System.Drawing.Size(62, 32);
            this.errPctText.TabIndex = 16;
            this.errPctText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errPctText.ValidatingType = typeof(int);
            this.errPctText.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(11, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Процент ошибок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(11, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Скорость печати:";
            // 
            // typeSpeedText
            // 
            this.typeSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeSpeedText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.typeSpeedText.Location = new System.Drawing.Point(15, 267);
            this.typeSpeedText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeSpeedText.Name = "typeSpeedText";
            this.typeSpeedText.Size = new System.Drawing.Size(76, 32);
            this.typeSpeedText.TabIndex = 19;
            this.typeSpeedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(94, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "зн/мин";
            // 
            // typeZoneText
            // 
            this.typeZoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeZoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeZoneText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.typeZoneText.Location = new System.Drawing.Point(246, 186);
            this.typeZoneText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeZoneText.Name = "typeZoneText";
            this.typeZoneText.ReadOnly = true;
            this.typeZoneText.Size = new System.Drawing.Size(388, 32);
            this.typeZoneText.TabIndex = 21;
            this.typeZoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeZoneText.TextChanged += new System.EventHandler(this.typeZoneText_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(243, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Номера выбранных зон";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(480, 259);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(155, 40);
            this.SaveBtn.TabIndex = 23;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 311);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.typeZoneText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.typeSpeedText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errPctText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxExeLenText);
            this.Controls.Add(this.minExeLenText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diffComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка сложности";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel zone7;
        private System.Windows.Forms.Panel zone5;
        private System.Windows.Forms.Panel zone3;
        private System.Windows.Forms.Panel zone4;
        private System.Windows.Forms.Panel zone6;
        private System.Windows.Forms.Panel zone8;
        private System.Windows.Forms.Panel zone1;
        private System.Windows.Forms.Panel zone2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox diffComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minExeLenText;
        private System.Windows.Forms.TextBox maxExeLenText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox errPctText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox typeSpeedText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox typeZoneText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveBtn;
    }
}