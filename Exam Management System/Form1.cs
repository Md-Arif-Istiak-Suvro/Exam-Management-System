using Microsoft.Data.SqlClient;
using System.Data;

namespace Exam_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GetSubjects();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string CandName = "", SubName = "";

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


        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Candidate Name and Password");
            }
            else
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CandidateTb1 where CName='" + UnameTb.Text + "' and cpass='" + PasswordTb.Text + "'", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    CandName = UnameTb.Text;
                    SubName = SubjectCb.SelectedValue.ToString();
                    Exams Obj = new Exams();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong UID and Password");
                }

                Con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
