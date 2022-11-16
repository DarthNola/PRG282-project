using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG_282_Project
{
    public partial class ModuleForm : Form
    {// Creating an instance to the datahandler class
        DataHandler handler = new DataHandler();
        string getModules = @"SELECT * FROM Codes";
        public ModuleForm()
        {
            InitializeComponent();
        }

        public void dvgRead()
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtDescription.Text = "";
            txtLink.Text = "";            
        }

        private void ModuleForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = handler.readData(getModules);
                dataGridView1.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Hide();
        }

        //Inserting a course

        private void btnInsertCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourseID.Text == "" || txtCourseName.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("Please fill in all textboxes!");
                }
                else
                {
                    string query = "INSERT INTO Codes values ('" + txtCourseID.Text + "', '" + txtCourseName.Text + "', '" + txtDescription.Text + "', '" + txtLink.Text + "')";
                    handler.DML_procedures(query);
                    dataGridView1.DataSource = handler.readData(getModules);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                handler.CloseConnection();
            }
            dataGridView1.AutoResizeColumns();
        }

        //Removing a course

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Do you want to delete item", "Remove Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    string query = "DELETE FROM Codes WHERE Module_Code = '" + txtCourseID.Text + "';";
                    handler.DML_procedures(query);
                    dvgRead();
                }
                dataGridView1.AutoResizeColumns();
        }

        //Get items from datagridrow to textboxes

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCourseID.Text = row.Cells[0].Value.ToString();
                txtCourseName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                txtLink.Text = row.Cells[3].Value.ToString();
            }
        }

        //Update a course

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Update item", "Update Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "UPDATE Codes \n SET  Module_Name= '" + txtCourseName.Text + "', Description= '" + txtDescription.Text + "', Source_Link= '" + txtLink.Text + "' \n WHERE Module_Code = '" + txtCourseID.Text + "';";
                handler.DML_procedures(query);
                dataGridView1.DataSource = handler.readData(getModules);
            }
            dataGridView1.AutoResizeRows();
        }

        //After clearing the Search textbox, datagridview will refresh and display all data in selected table

        private void txtSearchCourseID_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = handler.readData(getModules);
            dvgRead();
            dataGridView1.ClearSelection();
            dataGridView1.AutoResizeRows();
        }

        //Search the course by ID

        private void btnSearchCourseID_Click(object sender, EventArgs e)
        {
            
                string query = "IF EXISTS (SELECT * FROM Codes WHERE Module_Code ='" + txtSearchCourseID.Text + "') \n Begin \n SELECT * FROM Codes WHERE Module_Code ='" + txtSearchCourseID.Text + "'\n" +
                "End \n ELSE \n SELECT null as Module_Code, null as Module_Name, null as Description, NULL as Source_Link";
                if (txtSearchCourseID.Text != "")
                {
                    dataGridView1.DataSource = handler.searchStudents(query).Tables[0];
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
                    foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                    {
                        txtCourseID.Text = row.Cells[0].Value.ToString();
                        txtCourseName.Text = row.Cells[1].Value.ToString();
                        txtDescription.Text = row.Cells[2].Value.ToString();
                        txtLink.Text = row.Cells[3].Value.ToString();
                        
                    }

                }
                dataGridView1.AutoResizeRows();            
            
        }
    }
}
