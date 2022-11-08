using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class StudentForm : Form
    {
        FileHandler handler = new FileHandler();
        public StudentForm()
        {
            InitializeComponent();
        }
        public void dvgRead()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            txtGender.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtModule.Text = "";
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {            
           dataGridView1.DataSource =  handler.readData();
           dataGridView1.ClearSelection();
        }

        private void GetInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgRow = dataGridView1.Rows[e.RowIndex];
                txtID.Text = dvgRow.Cells[0].Value.ToString();
                txtName.Text = dvgRow.Cells[1].Value.ToString();
                txtSurname.Text = dvgRow.Cells[2].Value.ToString();
                txtDOB.Text = dvgRow.Cells[4].Value.ToString();
                txtGender.Text = dvgRow.Cells[5].Value.ToString();
                txtPhone.Text = dvgRow.Cells[6].Value.ToString();
                txtAddress.Text = dvgRow.Cells[7].Value.ToString();
                txtModule.Text = dvgRow.Cells[8].Value.ToString();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "IF EXISTS (SELECT * FROM STUDENTS WHERE StudentID =" + txtSearch.Text + ") \n Begin \n SELECT * FROM STUDENTS WHERE StudentID =" + txtSearch.Text + "\n" +
                "End \n ELSE \n SELECT 0 as StudentID, 'No record' as Name, 'No record' as Surname, NULL as ST_Image, 'No record' as DOB, 'No record' as Gender, 'No record' as Phone, 'No record' as Student_Address, 'No record' as Module_Code";
            if (txtSearch.Text != "")
            {
                dataGridView1.DataSource = handler.searchStudents(query).Tables[0];                
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtSurname.Text = row.Cells[2].Value.ToString();
                    txtDOB.Text = row.Cells[4].Value.ToString();
                    txtGender.Text = row.Cells[5].Value.ToString();
                    txtPhone.Text = row.Cells[6].Value.ToString();
                    txtAddress.Text = row.Cells[7].Value.ToString();
                    txtModule.Text = row.Cells[8].Value.ToString();
                }
                
                
            }
        }

        private void Key_Up_Search(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = handler.readData();
            dvgRead();
            dataGridView1.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO STUDENTS values (" + txtID.Text + ", '" + txtName.Text + "', '" + txtSurname.Text + "'," + "NULL" + ", '" + txtDOB.Text + "', '" + txtGender.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', '" + txtModule.Text + "')";
            handler.DML_procedures(query);
            dataGridView1.DataSource = handler.readData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Update item", "Update Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                string query = "UPDATE STUDENTS \n SET  Name= '" + txtName.Text + "', Surname= '" + txtSurname.Text + "', ST_Image= " + "NULL" + ", DOB= '" + txtDOB.Text + "', Gender= '" + txtGender.Text + "', Phone= '" + txtPhone.Text + "', Student_Address= '" + txtAddress.Text + "', Module_Code= '" + txtModule.Text + "' \n WHERE StudentID = " + txtID.Text;
                handler.DML_procedures(query);
                dataGridView1.DataSource = handler.readData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete item", "Remove Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                string query = "DELETE FROM STUDENTS WHERE StudentID = " + txtID.Text;
                handler.DML_procedures(query);
            }
        }
    }
}
