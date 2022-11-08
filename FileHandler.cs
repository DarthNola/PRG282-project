using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG_282_Project
{
    internal class FileHandler
    {
        string filePath = @"C:\PRG 282 Project(LoginForm)(2.0)\bin\Debug\LoginDetail.txt";
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
    }
}
