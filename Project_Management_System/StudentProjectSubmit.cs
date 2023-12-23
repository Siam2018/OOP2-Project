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

namespace Project_Management_System
{
    public partial class StudentProjectSubmit : Form
    {
        public StudentProjectSubmit()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.ShowDialog();
            //fileDialog.Filter = " PNG Imag * .png";
            // MessageBox.Show(fileDialog.SafeFileName)

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = fileDialog.FileName;

            }
        }

        private void StudentProjectSubmit_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects sdb = new StudentmyProjects();
            sdb.Show();
        }
    }
}
