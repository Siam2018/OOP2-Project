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
    public partial class FacultyProfileEdit : Form
    {
        string username = "username";
        public FacultyProfileEdit()
        {
            InitializeComponent();
        }
        public FacultyProfileEdit(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void FacultyProfileEdit_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            String[] result = ds.datashowfaculty(username, "faculty");

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
            txt_currentaddress.Text = result[8];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String dateOfBirth = txt_birthyear.Text + "-" + txt_birthmonth.Text + "-" + txt_birthday.Text;

            Edit ed = new Edit();
            this.username = ed.editDatafaculty(txt_username.Text, txt_firstname.Text, txt_lastname.Text, txt_phonenumber.Text, txt_email.Text, txt_gender.Text, dateOfBirth, txt_department.Text, txt_currentaddress.Text);

            MessageBox.Show("Your Information is updated!!!");
            

            FacultyProfileEdit_Load(sender, e);
            
        }
    }
}
