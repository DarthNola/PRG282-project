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
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm ST_Form = new StudentForm();
            ST_Form.Show();
            this.Hide();
        }
    }
}
