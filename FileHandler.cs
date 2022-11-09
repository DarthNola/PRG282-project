using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG_282_Project
{
    internal class FileHandler
    {
        //Created path for text file 
        string filePath = @"LoginDetail.txt";
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-TM0DEKN; Initial Catalog = Student_Details; Integrated Security = true;");
        public bool Read()
        {
            bool flag = false;
            Login loginForm = new Login();
            Menu mainmenu = new Menu();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] field = line.Split(',');
                        if (field[0] == Login.name.Trim() && field[1] == Login.pass.Trim())
                        {
                            flag = true;
                            break;
                        }
                    }
                    
                }                
               
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }

            return flag;

        }
        public int usernamechecker(string username , List<string>mylist)
        {
            int similar = 0;
            mylist = File.ReadAllLines(filePath).ToList();

            foreach (string item in mylist)
            {
                string[] items = item.Split(',');
                if (items[0] == username)
                {

                    similar = 1;
                }
            }
                return similar;           
        }
        public void write(string username , string password , List<string>mylist)
        {
            
            mylist = File.ReadAllLines(filePath).ToList();
                mylist.Add(username + "," + password);
                File.WriteAllLines(filePath, mylist);
        }

        public BindingSource readData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS", con);
            SqlDataReader reader = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = reader;
            //dataGridView1.DataSource = source;
            con.Close();
            return source;
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public DataSet searchStudents(string query)
        {
            string qry = query;
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set);
            return set;
        }

        public void DML_procedures(string query)
        {
            string qry = query;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
    }
}
