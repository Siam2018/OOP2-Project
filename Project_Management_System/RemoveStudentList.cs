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
    public partial class RemoveStudentList : Form
    {
        public RemoveStudentList()
        {
            InitializeComponent();
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

        private void RemoveStudentList_Load(object sender, EventArgs e)
        {

        }
    }
}
