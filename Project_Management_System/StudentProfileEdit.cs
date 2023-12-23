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
using System.Windows.Forms.VisualStyles;
using Models;
namespace Project_Management_System
{
    public partial class StudentProfileEdit : Form
    {
        string username = "username";
        public StudentProfileEdit()
        {
            InitializeComponent();
        }

        public StudentProfileEdit(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void StudentProfileEdit_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            String[] result = ds.datashow(username);

            txt_username.Text = result[0];
            txt_firstname.Text = result[1];
            txt_lastname.Text = result[2];
            txt_phonenumber.Text = result[3];
            txt_email.Text = result[4];
            txt_gender.Text = result[5];
            String dateOfBirth = result[6];
            String[] token = dateOfBirth.Split('-');
            txt_birthyear.Text = token[0];
            txt_birthmonth.Text = token[1];
            txt_birthday.Text = token[2];
            txt_department.Text = result[7];
            txt_semester.Text = result[8];
            txt_cgpa.Text = result[9];
            txt_currentaddress.Text = result[10];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();
            String dateOfBirth = txt_birthyear.Text + "-" + txt_birthmonth.Text + "-" + txt_birthday.Text;

            Edit ed = new Edit();
            username = ed.editData(txt_username.Text, txt_firstname.Text, txt_lastname.Text, txt_phonenumber.Text, txt_email.Text, txt_gender.Text, dateOfBirth, txt_department.Text, txt_semester.Text, txt_cgpa.Text, txt_currentaddress.Text);

            MessageBox.Show("Your Information is updated!!!");

            StudentProfileEdit_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard sdb = new StudentDeshBoard(username);
            sdb.Show();
        }
    }
}
