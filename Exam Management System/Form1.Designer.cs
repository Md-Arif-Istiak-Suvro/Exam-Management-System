namespace Exam_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            HeadName2 = new Label();
            HeadName = new Label();
            LoginLabel = new Label();
            passwordLabel = new Label();
            UserNameLabel = new Label();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            Loginbutton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            SubjectCb = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(HeadName2);
            panel1.Controls.Add(HeadName);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 601);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // HeadName2
            // 
            HeadName2.AutoSize = true;
            HeadName2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeadName2.Location = new Point(0, 300);
            HeadName2.Name = "HeadName2";
            HeadName2.Size = new Size(290, 31);
            HeadName2.TabIndex = 1;
            HeadName2.Text = "Exam Management System";
            // 
            // HeadName
            // 
            HeadName.AutoSize = true;
            HeadName.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadName.Location = new Point(69, 219);
            HeadName.Name = "HeadName";
            HeadName.Size = new Size(139, 62);
            HeadName.TabIndex = 0;
            HeadName.Text = "AIUB";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.BlueViolet;
            LoginLabel.Location = new Point(492, 24);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(142, 60);
            LoginLabel.TabIndex = 26;
            LoginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(426, 302);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(92, 25);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.ForeColor = Color.Black;
            UserNameLabel.Location = new Point(426, 193);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(105, 25);
            UserNameLabel.TabIndex = 28;
            UserNameLabel.Text = "User Name";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(426, 238);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(300, 27);
            UnameTb.TabIndex = 29;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(426, 343);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(300, 27);
            PasswordTb.TabIndex = 30;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Transparent;
            Loginbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.ForeColor = Color.BlueViolet;
            Loginbutton.Location = new Point(509, 410);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(94, 37);
            Loginbutton.TabIndex = 31;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(391, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(391, 343);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(820, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // SubjectCb
            // 
            SubjectCb.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectCb.ForeColor = Color.Black;
            SubjectCb.FormattingEnabled = true;
            SubjectCb.Location = new Point(483, 106);
            SubjectCb.Name = "SubjectCb";
            SubjectCb.Size = new Size(168, 36);
            SubjectCb.TabIndex = 35;
            SubjectCb.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(509, 532);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 36;
            label1.Text = "Admin Login";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 603);
            Controls.Add(label1);
            Controls.Add(SubjectCb);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Loginbutton);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(UserNameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label HeadName2;
        private Label HeadName;
        private PictureBox pictureBox1;
        private Label LoginLabel;
        private Label passwordLabel;
        private Label UserNameLabel;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private Button Loginbutton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ComboBox SubjectCb;
        private Label label1;
    }
}
