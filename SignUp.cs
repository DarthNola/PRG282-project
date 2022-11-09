using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        List<string> signUpList = new List<string>();
        private void SignUpbtn_click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Fill in all the fields!");
            }
            else
            {
                Signup();
            }
            
           
        }


        #region methods
        // Validation method
        public void Signup()
        {
            FileHandler handler = new FileHandler();
            if (txtConfirm.Text == txtPassword.Text)
            {
                if (txtUsername.Text.Contains(",") || txtPassword.Text.Contains(',') || txtConfirm.Text.Contains(","))
                {
                    MessageBox.Show("Comma is not allowed in either   Username or Password");
                }
                else if (handler.usernamechecker(txtUsername.Text, signUpList) == 1)
                {
                    MessageBox.Show("Username taken Please try again");
                }
                else
                {

                    handler.write(txtUsername.Text, txtPassword.Text, signUpList);
                    Login form1 = new Login();
                    form1.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Password does not match!");
            }

        }
        #endregion

    }
}
