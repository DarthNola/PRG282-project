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
            Signup();
           
        }


        #region methods
        // Validation method
        public void Signup()
        {
            FileHandler handler = new FileHandler();
            if (Confirmtb.Text == Passwordtb.Text)
            {
                if (userNametb.Text.Contains(",") || Passwordtb.Text.Contains(',') || Confirmtb.Text.Contains(","))
                {
                    MessageBox.Show("Comma is not allowed in either   Username or Password");
                }
                else if (handler.usernamechecker(userNametb.Text, signUpList) == 1)
                {
                    MessageBox.Show("Username taken Please try again");
                }
                else
                {

                    handler.write(userNametb.Text, Passwordtb.Text, signUpList);
                    Login form1 = new Login();
                    form1.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Password does is  matching");
            }

        }
        #endregion

    }
}
