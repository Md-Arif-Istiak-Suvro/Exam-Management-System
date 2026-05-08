using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Exam_Management_System
{
    public partial class Candidates : Form

    {
        int Key = 0;

        public Candidates()
        {
            InitializeComponent();
            DisplayCandidates();
        }
        private void OpenConnection()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PasswordTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            Key = 0;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True");

        private void DisplayCandidates()
        {
            Con.Open();
            string Query = "select * from CandidateTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into CandidateTb1 (CName,CAge,CPass,CScore,CAdd,Cphone) values(@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", score);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);

                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Added");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || CAgeTb.Text == "Age" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CandidateTb1 set CName=@Cn, CAge=@Ca, CPass=@Cp, CAdd=@Cad, Cphone=@Cpn where CId=@CId", Con);

                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cpn", PhoneTb.Text);

                    cmd.Parameters.AddWithValue("@CId", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }
            }

        }

        private void CandidatesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CandidatesDGV.CurrentRow != null)
            {
                CNameTb.Text = CandidatesDGV.CurrentRow.Cells[1].Value.ToString();
                CAgeTb.Text = CandidatesDGV.CurrentRow.Cells[2].Value.ToString();
                PasswordTb.Text = CandidatesDGV.CurrentRow.Cells[3].Value.ToString();
                AddressTb.Text = CandidatesDGV.CurrentRow.Cells[5].Value.ToString();
                PhoneTb.Text = CandidatesDGV.CurrentRow.Cells[6].Value.ToString();

                if (CNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(CandidatesDGV.CurrentRow.Cells[0].Value.ToString());
                }
            }

        }

        private void Qsnsub_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }
    }



}

