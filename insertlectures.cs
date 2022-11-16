using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG_282_Project
{
    public partial class insertlectures : Form
    {

        DataHandler handler = new DataHandler();
        FileHandler fileHandler = new FileHandler();


        public insertlectures()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            try
            {
                 if (txtID.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtModuleCode.Text =="")
                 {
                     MessageBox.Show("Please fill in all textboxes!");
                 }
                 else
                 {

                     string query = "INSERT INTO Lectures values ('" + txtID.Text + "', '" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtModuleCode.Text + "')";
                    handler.inserLecturers(query);
                   
                    Menu main = new Menu();
                    main.Show();
                    this.Hide();

                }
               
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 handler.CloseConnection();
             }

        }


        private void insertlectures_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list = fileHandler.readlectures();
            foreach (string item in list)
            {
                string[] items = item.Split(',');
                txtID.Text = items[0];
                txtName.Text = items[1];
                txtSurname.Text = items[2];
                txtModuleCode.Text = items[3];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete item", "Remove Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                string query = "DELETE FROM Lectures WHERE  EmpID = " + txtID.Text;
                handler.DML_procedures(query);

                Menu main = new Menu();
                main.Show();
                this.Hide();

            }
            
        }
    }
}
