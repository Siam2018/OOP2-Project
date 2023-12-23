using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Management_System
{
    public partial class RegisterPage : Form
    {
        string birthdate = "birthdate";
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
    string.IsNullOrEmpty(txt_semester.Text)
    ||
    string.IsNullOrEmpty(txt_currentaddress.Text) 
                ||
    string.IsNullOrEmpty(txt_password.Text)
    ||
    string.IsNullOrEmpty(textBox11.Text)
    ||
    string.IsNullOrEmpty(txt_cgpa.Text)

    )
            {

                MessageBox.Show(" Complete All Field ");

            }

            else
            {
                birthdate = txt_birthyear.Text +"-"+ txt_birthmonth.Text +"-"+ txt_birthday.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Students(UserName,FirstName,LastName,PhoneNumber,EMail,Gender,BirthDate,Department,Semester,CGPA,CurrentAddress)" +
                    " values(@username,@firstname,@lastname,@phonenumber,@email,@gender,@birthdate,@department,@semester,@cgpa,@currentaddress)", conn);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@gender", txt_gender.Text.ToString());
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@department", txt_department.Text.ToString());
                cmd.Parameters.AddWithValue("@semester", txt_semester.Text.ToString());
                cmd.Parameters.AddWithValue("@cgpa", txt_cgpa.Text);
                cmd.Parameters.AddWithValue("@currentaddress", txt_currentaddress.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlConnection log = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                log.Open();
                SqlCommand cmd2 = new SqlCommand("insert into Authenticate(username,password)values(@username,@password)", log);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BDatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void departmenttxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
