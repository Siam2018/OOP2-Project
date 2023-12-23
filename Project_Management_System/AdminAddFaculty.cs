using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class AdminAddFaculty : Form
    {
        string username = "username";
        string birthdate = "birthdate";
        public AdminAddFaculty()
        {
            InitializeComponent();
        }
        public AdminAddFaculty(string  username)
        {
            this.username = username;
            InitializeComponent();
        }

        

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard ads = new AdminFacultyBoard();
            ads.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard ads = new AdminFacultyBoard();
            ads.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddFaculty ads = new AdminAddFaculty();
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void AdminFacultyBoard_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyProfileEdit ads = new FacultyProfileEdit();
            ads.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firstname.Text)
              ||
              string.IsNullOrEmpty(txt_birthyear.Text)
              ||
              string.IsNullOrEmpty(txt_birthmonth.Text)
              ||
              string.IsNullOrEmpty(txt_birthday.Text)
              ||
              string.IsNullOrEmpty(txt_email.Text)
              ||
            string.IsNullOrEmpty(txt_phonenumber.Text)
            ||
            string.IsNullOrEmpty(txt_lastname.Text)
            ||
            string.IsNullOrEmpty(txt_currentaddress.Text)
                        ||
            string.IsNullOrEmpty(txt_password.Text)
            ||
            string.IsNullOrEmpty(textBox11.Text)
        )
            {

                MessageBox.Show(" Complete All Field ");

            }
            else 
            {
                birthdate = txt_birthyear.Text + "-" + txt_birthmonth.Text + "-" + txt_birthday.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Faculties(UserName,FirstName,LastName,PhoneNumber,EMail,Gender,BirthDate,Department,CurrentAddress)" +
                    " values(@username,@firstname,@lastname,@phonenumber,@email,@gender,@birthdate,@department,@currentaddress)", conn);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@gender", txt_gender.Text.ToString());
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@department", txt_department.Text.ToString());
                cmd.Parameters.AddWithValue("@currentaddress", txt_currentaddress.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlConnection log = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                log.Open();
                SqlCommand cmd2 = new SqlCommand("insert into FacultyAuthenticate(username,password)values(@username,@password)", log);
                cmd2.Parameters.AddWithValue("@username", txt_username.Text);
                cmd2.Parameters.AddWithValue("@password", txt_password.Text);

                cmd2.ExecuteNonQuery();
                log.Close();

                MessageBox.Show("Congratulations for Register , Click ok to Login");
                this.Hide();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
            
        }

        private void btn_addfaculty_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
