using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class Menu : Form
    {
        FileHandler fhandler = new FileHandler();
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            string query = @"EXEC StudentsPerLecturer";
            dataGridViewLecturers.DataSource = fhandler.readData(query);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?","Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm ST_Form = new StudentForm();
            ST_Form.Show();
            this.Hide();
        }

        private void btnModuleForm_Click(object sender, EventArgs e)
        {
            ModuleForm M_Form = new ModuleForm();
            M_Form.Show();
            this.Hide();
        }
    }
}
