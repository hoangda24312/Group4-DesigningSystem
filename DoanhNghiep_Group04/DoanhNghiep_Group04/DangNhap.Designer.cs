namespace DoanhNghiep_Group04
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            btnDangNhap = new Button();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            panel7 = new Panel();
            textBox3 = new TextBox();
            panel8 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DodgerBlue;
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(479, 336);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(281, 42);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 450);
            panel4.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(436, 398);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(btnDangNhap);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 450);
            panel5.TabIndex = 10;
            panel5.Paint += panel5_Paint;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox3);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(479, 278);
            panel7.Name = "panel7";
            panel7.Size = new Size(278, 35);
            panel7.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(0, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 16);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DodgerBlue;
            panel8.Location = new Point(0, 26);
            panel8.Name = "panel8";
            panel8.Size = new Size(278, 10);
            panel8.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(479, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 49);
            panel3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(42, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 16);
            textBox2.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DodgerBlue;
            panel6.Location = new Point(-3, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(278, 10);
            panel6.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(476, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 49);
            panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(45, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 16);
            textBox1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 10);
            panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(243, 244, 246);
            label4.ForeColor = Color.FromArgb(30, 64, 175);
            label4.Location = new Point(560, 251);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 8;
            label4.Text = "ABZyU";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "DangNhap";
            Text = "Form1";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDangNhap;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel3;
        private Panel panel6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
