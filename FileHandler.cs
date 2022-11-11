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
        SqlConnection con = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = Student_Details; Integrated Security = true;");
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

        public BindingSource readData(string query)
        {
            string qry = query;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
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
            DataSet set = new DataSet();
            try
            {
                string qry = query;
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);                
                adapter.Fill(set);                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return set;            
            
        }

        public void DML_procedures(string query)
        {
            try
            {
                string qry = query;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            
        }

        public void Load_Image(string Image_Path, string ID, DataGridView dgv)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                Image_Path = picPath;
            }

            byte[] imageBt = null;
            FileStream fstream = new FileStream(Image_Path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);            
            string qry = @"UPDATE STUDENTS SET ST_Image =" + "@IMG \n WHERE StudentID= " + ID;            
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader reader;
            if (ID != "")
            {
                try
                {
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("@IMG", imageBt));
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Inserted image");
                    con.Close();
                    Image_Path = "";
                    dgv.DataSource = readData("SELECT * FROM Students");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a item in Data Grid");
            }
            dgv.AutoResizeRows();
        }


       
    }
}
