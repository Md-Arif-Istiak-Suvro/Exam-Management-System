using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Exam_Management_System
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            Key = 0;


        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True");

        private void DisplaySubjects()
        {
            Con.Open();
            string Query = "select * from SubjectTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into SubjectTb1 (SName) values(@Sn)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SNameTb.Text = SubjectsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (SNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(SubjectsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Select The Subject To Edit");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "Update SubjectTb1 set SName=@SName where SId=@SId",
                        Con
                    );

                    cmd.Parameters.AddWithValue("@SName", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SId", Key);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Subject Updated");

                    Con.Close();

                    DisplaySubjects();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void QsnCandidates_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void QsnQsn_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
