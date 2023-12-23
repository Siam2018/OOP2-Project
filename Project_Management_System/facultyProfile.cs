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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Models;
namespace Project_Management_System
{
    public partial class facultyProfile : Form
    {
        string username = "username";
        public facultyProfile()
        {
            InitializeComponent();
        }
        public facultyProfile(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void facultyProfile_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            string[] result = ds.datashowfaculty(username, "lala");

            label_Username.Text = result[0];
            label_FirstName.Text = result[1];
            label_LastName.Text = result[2];
            label_PhoneNumber.Text = result[3];
            label_Email.Text = result[4];
            label_Gender.Text = result[5];
            label_BirthDate.Text = result[6];
            label_Department.Text = result[7];
            label_CurrentAddress.Text = result[8];
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty_TaskBoard ads = new Faculty_TaskBoard();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyProfileEdit ads = new FacultyProfileEdit();
            ads.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyChangePass ads = new FacultyChangePass();
            ads.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStudentList ads = new RemoveStudentList();
            ads.Show();
        }

        private void currentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyStudentist ads = new FacultyStudentist();
            ads.Show();
        }

        private void appliedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyAppliedStudent ads = new facultyAppliedStudent();
            ads.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
