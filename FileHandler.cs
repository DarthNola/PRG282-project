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
    //This class contains all the methods used to read and write from the text file 
    internal class FileHandler
    {
        //Absolute path of the text file used to read and write the username and password
        string filePath = @"LoginDetail.txt";
       
     
        //This method reads the username and password from the text file called LoginDetail
        public bool Read(string username, string password)
        {
            //Creating instance of the user 
            User Users = new User(username,password);
            //Flag is used to keep track of the condition 
            bool flag = false;
            //Try statement is executed 
            try
            {
                //Stream reader is used to read from the file 
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] field = line.Split(',');
                        //Check if the user name and password entered by the user is in the text file 
                        if (field[0] == Users.Username.Trim() && field[1] == Users.Password.Trim())
                        {
                            flag = true;
                            break;
                        }
                    }
                    
                }                
               
            }
            //Catch statement catches any error if one occurs during the execution of the try
            catch (Exception e)
            {
                //Error is displayed to the user 
               MessageBox.Show(e.Message);
            }
            //Flag is returned as either true or false 
            return flag;

        }
        //This method check if the username already exists 
        public int usernamechecker(string username , List<string>mylist)
        {
            int similar = 0;
            //All lines are read from the text file and stored into a list 
            mylist = File.ReadAllLines(filePath).ToList();
            //Loop to check if username entered is found in the list
            foreach (string item in mylist)
            {
                string[] items = item.Split(',');
                if (items[0] == username)
                {
                    //Similar is set to 1 if username already exists 
                    similar = 1;
                }
            }
                return similar;           
        }

        //This method writes the username and password to the list 
        public void write(string username , string password , List<string>mylist)
        {       
            //Items are read from the text file and converted into a list 
            mylist = File.ReadAllLines(filePath).ToList();
            //Username and password is added to the list and then written to the text file 
            mylist.Add(username + "," + password);
            File.WriteAllLines(filePath, mylist);
        }

       

    }
}
