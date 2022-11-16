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
        //Instance of the DataHandler class is created 
        DataHandler handler = new DataHandler();
        FileHandler fileHandler = new FileHandler();
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            //Upon the menu loading the query is executed and datagridview is populated

            try
            {
                string query = @"EXEC StudentsPerLecturer";
                dataGridViewLecturers.DataSource = handler.readData(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }
        //Upon clicking the exit button the following event is executed 
        private void btnExit_Click(object sender, EventArgs e)
        {
            //User are prompt to select Yes or No 
            if (MessageBox.Show("Are you sure you want to exit the application?","Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        //Upon clicking the student button the current form closes and opens the Student form 
        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm ST_Form = new StudentForm();
            ST_Form.Show();
            this.Hide();
        }
        //Upon clicking the module button the current menu closes and opens the Module form 
        private void btnModuleForm_Click(object sender, EventArgs e)
        {
            ModuleForm M_Form = new ModuleForm();
            M_Form.Show();
            this.Hide();
        }

        private void btnInsertLectures_Click(object sender, EventArgs e)
        {

            insertlectures form1 = new insertlectures();
            form1.Show();
        }

        private void dataGridViewLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgRow = dataGridViewLecturers.Rows[e.RowIndex];

                fileHandler.writelecturese(
                  dvgRow.Cells[0].Value.ToString(),
                   dvgRow.Cells[1].Value.ToString(),
                    dvgRow.Cells[2].Value.ToString(),
                 dvgRow.Cells[3].Value.ToString()
                 );



            }
        }
    }
}
