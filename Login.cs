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
        public static string name, pass;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            name = txtUsername.Text;
            pass = txtPassword.Text;
            Menu main = new Menu();
            FileHandler fileHandler = new FileHandler();           
            if(fileHandler.Read())
            {
                main.Show();
                this.Hide();             
            }
            else
            {
                MessageBox.Show("Username and/or Password not found!. Sign Up?");
            }
            clearTextBox();

        }
        public void clearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
