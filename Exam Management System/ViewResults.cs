using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exam_Management_System
{
    public partial class ViewResults : Form
    {
        public ViewResults()
        {
            InitializeComponent();
            GetSubjects();
            DisplayResults();
            GetCandidates();
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
        private void DisplayResults()
        {
            Con.Open();
            string Query = "select * from ResultTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterBySub()
        {
            if (SubjectCb.SelectedValue == null) return;

            try
            {
                if (Con.State == ConnectionState.Open) Con.Close();
                Con.Open();
                string Query = "SELECT * FROM ResultTb1 WHERE RSubject = @Sub";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.Parameters.AddWithValue("@Sub", SubjectCb.SelectedValue.ToString());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ResultsDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        private void GetCandidates()
        {
            try
            {
                if (Con.State == ConnectionState.Open) Con.Close();
                Con.Open();

                string Query = "SELECT CName FROM CandidateTb1";
                SqlCommand cmd = new SqlCommand(Query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                Cbox.DataSource = null;
                Cbox.Items.Clear();


                Cbox.DisplayMember = "CName";
                Cbox.ValueMember = "CName";


                Cbox.DataSource = dt;

                Cbox.SelectedIndex = -1;
                Cbox.ResetText();
                Cbox.Text = "Select Candidate";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        private void FilterByCandidate()
        {
            if (Cbox.SelectedValue == null || Cbox.SelectedIndex == -1) return;

            try
            {
               
                if (Con.State == ConnectionState.Open) Con.Close();
                Con.Open();

               
                string Query = "SELECT * FROM ResultTb1 WHERE RCandidate = @Can";

                SqlCommand cmd = new SqlCommand(Query, Con);
              
                cmd.Parameters.AddWithValue("@Can", Cbox.SelectedValue.ToString());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ResultsDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBySub();
            FilterByCandidate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void QsnCandidates_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void Qsnsub_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void QsnQsn_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
