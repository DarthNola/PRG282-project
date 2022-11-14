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
    public partial class Login : Form
    {
        //Variables declared to be used with the write() method 
        public static string name, pass;
        //Instance of the FileHandler class is created 
        FileHandler fileHandler = new FileHandler();
        public Login()
        {
            InitializeComponent();
        }
        //This event is triggered when the Login button is clicked 
        private void btnLogin_Click(object sender, EventArgs e)
        {   
            //Two variables are declared that receives the values entered into the textboxes 
            name = txtUsername.Text;
            pass = txtPassword.Text;
            Menu main = new Menu();             
            //If statement evaluates whether the method is true or false
            if(fileHandler.Read())
            { 
                //Executed if flag is true and user taken to main menu 
                MessageBox.Show("Login Successful");
                main.Show();
                this.Hide();             
            }
            else
            {
                //Executed if flag is false 
                MessageBox.Show("Username and/or Password not found!. Sign Up?");
            }
            //Method called to clear the text boxes 
            clearTextBox();

        }

        //Method is called when the textboxes needs to be cleared 
        public void clearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        //This event is triggered when the Sign Up button is clicked 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
           //The user is taken to the Sign Up form 
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
