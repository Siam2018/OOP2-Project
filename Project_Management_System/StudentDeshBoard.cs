using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_Management_System
{
    public partial class StudentDeshBoard : Form
    {
        string username = "username";
        public StudentDeshBoard()
        {
            InitializeComponent();
        }

        public StudentDeshBoard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();



        }

        private void StudentDeshBoard_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            String[] result = ds.datashow(username);

            label_Username.Text = result[0];
            label_FirstName.Text = result[1];
            label_LastName.Text = result[2];
            label_PhoneNumber.Text = result[3];
            label_Email.Text = result[4];
            label_Gender.Text = result[5];
            label_BirthDate.Text = result[6];
            label_Department.Text = result[7];
            label_Semester.Text = result[8];
            label_Cgpa.Text = result[9];
            label_CurrentAddress.Text = result[10];
            
            //label_Password.Text = result[11];



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Student_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects(username);
            rg.Show();
        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage hm = new LoginPage();
            hm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage hm = new LoginPage();
            hm.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects hm = new StudentAllProjects();
            hm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects hm = new StudentAllProjects();
            hm.Show();
        }

        private void Camp_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk studentTsk = new StudentTsk();
            studentTsk.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk studentTsk = new StudentTsk();
            studentTsk.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects();
            rg.Show();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void myProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects();
            rg.Show();
        }

        private void allProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects();
            rg.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentChangePass rg = new StudentChangePass(username);
            rg.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProfileEdit spe = new StudentProfileEdit(username);
            spe.Show();
        }

        private void label_Username_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard spe = new StudentDeshBoard(username);
            spe.Show();
        }
    }
}
