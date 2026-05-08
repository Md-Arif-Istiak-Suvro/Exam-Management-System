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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True");

        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }
        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;
        }
        private void DisplayQuestions()
        {
            Con.Open();
            string Query = "select * from QuestionTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into QuestionTb1 (QDesc,QO1,QO2,QO3,QO4,QA,QS) values(@Qd,@O1,@O2,@O3,@O4,@Qan,@Qsu)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
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
        int Key = 0;

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("Update QuestionTb1 set QDesc=@Qd, QO1=@O1, QO2=@O2, QO3=@O3, QO4=@O4, QA=@Qan, QS=@Qsu where QId=@QKey", Con);

                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());


                    cmd.Parameters.AddWithValue("@QKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Updated");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    if (Con.State == ConnectionState.Open) Con.Close();
                }
            }
        }

        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = QuestionsDGV.Rows[e.RowIndex];

                QuestTb.Text = row.Cells[1].Value.ToString();
                Op1Tb.Text = row.Cells[2].Value.ToString();
                Op2Tb.Text = row.Cells[3].Value.ToString();
                Op3Tb.Text = row.Cells[4].Value.ToString();
                Op4Tb.Text = row.Cells[5].Value.ToString();
                AnswerTb.Text = row.Cells[6].Value.ToString();
                SubjectCb.SelectedValue = row.Cells[7].Value.ToString();

                if (QuestTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void QsnCandidates_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void Qsnsub_Click(object sender, EventArgs e)
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
