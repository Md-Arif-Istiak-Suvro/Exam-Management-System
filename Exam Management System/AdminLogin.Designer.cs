namespace Exam_Management_System
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            HeadName2 = new Label();
            HeadName = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            Loginbutton = new Button();
            PasswordTb = new TextBox();
            passwordLabel = new Label();
            LoginLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(HeadName2);
            panel1.Controls.Add(HeadName);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 601);
            panel1.TabIndex = 37;
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(825, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(390, 255);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Transparent;
            Loginbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.ForeColor = Color.BlueViolet;
            Loginbutton.Location = new Point(521, 335);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(94, 37);
            Loginbutton.TabIndex = 43;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(425, 255);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(300, 27);
            PasswordTb.TabIndex = 42;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(497, 192);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(142, 25);
            passwordLabel.TabIndex = 39;
            passwordLabel.Text = "Enter Password";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.BlueViolet;
            LoginLabel.Location = new Point(486, 50);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(163, 60);
            LoginLabel.TabIndex = 38;
            LoginLabel.Text = "Admin";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 603);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Loginbutton);
            Controls.Add(PasswordTb);
            Controls.Add(passwordLabel);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label HeadName2;
        private Label HeadName;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button Loginbutton;
        private TextBox PasswordTb;
        private Label passwordLabel;
        private Label LoginLabel;
    }
}