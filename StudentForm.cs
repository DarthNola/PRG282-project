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
using System.IO;

namespace PRG_282_Project
{
    public partial class StudentForm : Form
    {
        DataHandler handler = new DataHandler();
        string getStudents = @"SELECT * FROM STUDENTS";
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
           picBoxStudentForm.Image = Image.FromFile("Logo.png");            
           dataGridView1.DataSource =  handler.readData(getStudents);
           dataGridView1.ClearSelection();
           dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();
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
            int number = 0;
            if(int.TryParse(txtSearch.Text.Trim(), out number))
            {
                string query = "IF EXISTS (SELECT * FROM STUDENTS WHERE StudentID =" + txtSearch.Text + ") \n Begin \n SELECT * FROM STUDENTS WHERE StudentID =" + txtSearch.Text + "\n" +
                "End \n ELSE \n SELECT null as StudentID, null as Name, null as Surname, NULL as ST_Image, null as DOB, null as Gender, null as Phone, null as Student_Address, null as Module_Code";
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
                    dataGridView1.AutoResizeRows();              
               
            }
            else
            {
                MessageBox.Show("Please input valid number");
            }
            
        }

        private void Key_Up_Search(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = handler.readData(getStudents);
            dvgRead();
            dataGridView1.ClearSelection();
            dataGridView1.AutoResizeRows();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtGender.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtModule.Text == "")
                {
                    MessageBox.Show("Please fill in all textboxes!");
                }
                else
                {
                    string query = "INSERT INTO STUDENTS values (" + txtID.Text + ", '" + txtName.Text + "', '" + txtSurname.Text + "'," + "NULL" + ", '" + txtDOB.Value + "', '" + txtGender.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', '" + txtModule.Text + "')";
                    handler.DML_procedures(query);
                    dataGridView1.DataSource = handler.readData(getStudents);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                handler.CloseConnection();
            }
            dataGridView1.AutoResizeRows();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Update item", "Update Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                string query = "UPDATE STUDENTS \n SET  Name= '" + txtName.Text + "', Surname= '" + txtSurname.Text + "', DOB= '" + txtDOB.Value + "', Gender= '" + txtGender.Text + "', Phone= '" + txtPhone.Text + "', Student_Address= '" + txtAddress.Text + "', Module_Code= '" + txtModule.Text + "' \n WHERE StudentID = " + txtID.Text;
                handler.DML_procedures(query);
                dataGridView1.DataSource = handler.readData(getStudents);
            }
            dataGridView1.AutoResizeRows();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete item", "Remove Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                string query = "DELETE FROM STUDENTS WHERE StudentID = " + txtID.Text;
                handler.DML_procedures(query);
                dvgRead();
            }
            dataGridView1.AutoResizeRows();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Hide();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {           
            handler.Load_Image(txtImagePath.Text, txtID.Text, this.dataGridView1);
        }
    }
}
