using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exam_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            if (PasswordTb.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else if (PasswordTb.Text == "Admin")
            {
                Questions Obj = new Questions();
                Obj.Show();
                Obj.Show();
            }
            else
            {
                MessageBox.Show("Wrong Admin Password");
                PasswordTb.Text = "";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
