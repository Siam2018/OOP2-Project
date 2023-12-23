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
    
    public partial class StudentChangePass : Form
    {
        string username = "username";
        public StudentChangePass()
        {
            InitializeComponent();
        }
        public StudentChangePass(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void StudentChangePass_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationProcedure ap = new AuthenticationProcedure();
            if (txt_oldpassword.Text.Equals("") || txt_newpassword.Text.Equals("") || txt_confirmpassword.Text.Equals(""))
            {
                MessageBox.Show("Please give your passwords!!!");
            }
            else if (ap.authenticationCheck(username, txt_oldpassword.Text))
            {
                if (txt_newpassword.Text.Equals(txt_confirmpassword.Text))
                {
                    Edit ed = new Edit();
                    ed.changePassword(username, txt_newpassword.Text);
                    MessageBox.Show("Your Password has been updated!!!");
                    this.Hide();
                    StudentDeshBoard sdb = new StudentDeshBoard(username);
                    sdb.Show();
                }
                else 
                { 
                    MessageBox.Show("Wrong password!!!");
                    txt_oldpassword.Focus();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard sdb = new StudentDeshBoard(username);
            sdb.Show();
        }
    }
}
