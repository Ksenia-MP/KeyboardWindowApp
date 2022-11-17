
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(328, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // zone7
            // 
            this.zone7.BackColor = System.Drawing.SystemColors.Control;
            this.zone7.ForeColor = System.Drawing.SystemColors.Control;
            this.zone7.Location = new System.Drawing.Point(60, 47);
            this.zone7.Name = "zone7";
            this.zone7.Size = new System.Drawing.Size(56, 129);
            this.zone7.TabIndex = 2;
            this.zone7.Click += new System.EventHandler(this.zone_Click);
            this.zone7.Paint += new System.Windows.Forms.PaintEventHandler(this.zone_Paint);
            this.zone7.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone7.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone5
            // 
            this.zone5.BackColor = System.Drawing.SystemColors.Control;
            this.zone5.ForeColor = System.Drawing.SystemColors.Control;
            this.zone5.Location = new System.Drawing.Point(94, 47);
            this.zone5.Name = "zone5";
            this.zone5.Size = new System.Drawing.Size(67, 129);
            this.zone5.TabIndex = 3;
            this.zone5.Click += new System.EventHandler(this.zone_Click);
            this.zone5.Paint += new System.Windows.Forms.PaintEventHandler(this.zone_Paint);
            this.zone5.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone5.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone3
            // 
            this.zone3.BackColor = System.Drawing.SystemColors.Control;
            this.zone3.ForeColor = System.Drawing.SystemColors.Control;
            this.zone3.Location = new System.Drawing.Point(127, 47);
            this.zone3.Name = "zone3";
            this.zone3.Size = new System.Drawing.Size(67, 129);
            this.zone3.TabIndex = 4;
            this.zone3.Click += new System.EventHandler(this.zone_Click);
            this.zone3.Paint += new System.Windows.Forms.PaintEventHandler(this.zone_Paint);
            this.zone3.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone3.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone4
            // 
            this.zone4.BackColor = System.Drawing.SystemColors.Control;
            this.zone4.ForeColor = System.Drawing.SystemColors.Control;
            this.zone4.Location = new System.Drawing.Point(292, 47);
            this.zone4.Name = "zone4";
            this.zone4.Size = new System.Drawing.Size(67, 129);
            this.zone4.TabIndex = 4;
            this.zone4.Click += new System.EventHandler(this.zone_Click);
            this.zone4.Paint += new System.Windows.Forms.PaintEventHandler(this.zone_Paint);
            this.zone4.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone4.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone6
            // 
            this.zone6.BackColor = System.Drawing.SystemColors.Control;
            this.zone6.ForeColor = System.Drawing.SystemColors.Control;
            this.zone6.Location = new System.Drawing.Point(326, 47);
            this.zone6.Name = "zone6";
            this.zone6.Size = new System.Drawing.Size(67, 129);
            this.zone6.TabIndex = 4;
            this.zone6.Click += new System.EventHandler(this.zone_Click);
            this.zone6.Paint += new System.Windows.Forms.PaintEventHandler(this.zone_Paint);
            this.zone6.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone6.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone8
            // 
            this.zone8.BackColor = System.Drawing.SystemColors.Control;
            this.zone8.ForeColor = System.Drawing.SystemColors.Control;
            this.zone8.Location = new System.Drawing.Point(359, 47);
            this.zone8.Name = "zone8";
            this.zone8.Size = new System.Drawing.Size(109, 129);
            this.zone8.TabIndex = 4;
            this.zone8.Click += new System.EventHandler(this.zone_Click);
            this.zone8.Paint += new System.Windows.Forms.PaintEventHandler(this.right_zone_Paint);
            this.zone8.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone8.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone1
            // 
            this.zone1.BackColor = System.Drawing.SystemColors.Control;
            this.zone1.ForeColor = System.Drawing.SystemColors.Control;
            this.zone1.Location = new System.Drawing.Point(160, 47);
            this.zone1.Name = "zone1";
            this.zone1.Size = new System.Drawing.Size(119, 129);
            this.zone1.TabIndex = 5;
            this.zone1.Click += new System.EventHandler(this.zone_Click);
            this.zone1.Paint += new System.Windows.Forms.PaintEventHandler(this.center_zone_Paint);
            this.zone1.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone1.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // zone2
            // 
            this.zone2.BackColor = System.Drawing.SystemColors.Control;
            this.zone2.ForeColor = System.Drawing.SystemColors.Control;
            this.zone2.Location = new System.Drawing.Point(225, 47);
            this.zone2.Name = "zone2";
            this.zone2.Size = new System.Drawing.Size(119, 129);
            this.zone2.TabIndex = 6;
            this.zone2.Click += new System.EventHandler(this.zone_Click);
            this.zone2.Paint += new System.Windows.Forms.PaintEventHandler(this.center_zone_Paint);
            this.zone2.MouseEnter += new System.EventHandler(this.zone_MouseEnter);
            this.zone2.MouseLeave += new System.EventHandler(this.zone_MouseLeave);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zone7);
            this.Controls.Add(this.zone8);
            this.Controls.Add(this.zone6);
            this.Controls.Add(this.zone4);
            this.Controls.Add(this.zone2);
            this.Controls.Add(this.zone1);
            this.Controls.Add(this.zone3);
            this.Controls.Add(this.zone5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DifficultyForm";
            this.Text = "Настройка сложности";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}