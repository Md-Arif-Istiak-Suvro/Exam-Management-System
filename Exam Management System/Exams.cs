using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exam_Management_System
{
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
            FetchQuestions();
            timer1.Start();

            TimingBar.Value = 300;
            CnameLbl.Text = Login.CandName;
            SubjectLbl.Text = Login.SubName;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True");

        string[] Answers = new string[10];
        private void FetchQuestions()
        {
            try
            {
                Con.Open();

                string Query = "SELECT TOP 10 * FROM QuestionTb1 ORDER BY NEWID()";

                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int num = i + 1;

                    DataRow dr = dt.Rows[i];


                    Control[] qControl = this.Controls.Find("Q" + num, true);

                    if (qControl.Length > 0)
                    {
                        qControl[0].Text = dr["QDesc"].ToString();
                    }

                    for (int j = 1; j <= 4; j++)
                    {
                        Control[] optControl =
                            this.Controls.Find("Q" + num + "0" + j, true);

                        if (optControl.Length > 0)
                        {
                            optControl[0].Text = dr["QO" + j].ToString();
                        }
                    }


                    Answers[i] = dr["QA"].ToString();
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
        int Chorno = 300;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Chorno -= 1;

            if (Chorno >= 0)
            {
                TimingBar.Value = Chorno;
            }

            if (Chorno <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time Over");
                Login obj = new Login();
                obj.Show();
                this.Close();
            }

        }
        int FinalScore = 0;

        private void CalculateScore()
        {
            FinalScore = 0; 

            for (int i = 0; i < 10; i++)
            {
                int qNum = i + 1;
                string userSelection = "";

                for (int j = 1; j <= 4; j++)
                {
                   
                    Control[] rb = this.Controls.Find("Q" + qNum + "0" + j, true);

                    if (rb.Length > 0 && ((RadioButton)rb[0]).Checked)
                    {
                        userSelection = rb[0].Text;
                        break;
                    }
                }
                if (userSelection == Answers[i])
                {
                    FinalScore++;
                }
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            CalculateScore();
            InsertResult();  
            MessageBox.Show("Exam Finished!\nYour Total Score: " + FinalScore + " / 10");

            Login log = new Login();
            log.Show();
            this.Hide();

        }
        private void InsertResult()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ResultTb1 (RSubject,RCandidate,RDate,RTime,RScore) values (@RS,@RC,@RD,@RT,@RSc)", Con);

                cmd.Parameters.AddWithValue("@RS", SubjectLbl.Text);
                cmd.Parameters.AddWithValue("@RC", CnameLbl.Text);
                cmd.Parameters.AddWithValue("@RD", QDateP.Value.Date);
                cmd.Parameters.AddWithValue("@RT", QTimep.Text); 
                cmd.Parameters.AddWithValue("@RSc", FinalScore);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Result Saved Successfully!");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error saving result: " + Ex.Message);
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
    }
}
