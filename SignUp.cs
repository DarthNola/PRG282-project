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
            // Validaton for no null textboxes
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Fill in all the fields!");
            }
            else
            {
                User user = new User();
                user.Signup(txtUsername.Text, txtConfirm.Text, txtPassword.Text, signUpList);
                Login login = new Login();
                login.Show();
                this.Hide();
            }


        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Go back to Login? Note all information entered will not be saved!", "Back to login", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

       
    }
}
