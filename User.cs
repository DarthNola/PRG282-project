using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    internal class User
    {
        string username,password;

        public User()
        {
        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        // Validation method
        public void Signup(string username, string confirm, string pass, List<string> list)
        {
            FileHandler handler = new FileHandler();
            if (confirm == pass)
            {
                if (username.Contains(",") || pass.Contains(',') || confirm.Contains(",")) // username / pasword should not contain a comma
                {
                    MessageBox.Show("Comma is not allowed in either   Username or Password");
                }
                else if (handler.usernamechecker(username, list) == 1) //if thre username that is been used
                {
                    MessageBox.Show("Username taken Please try again");
                }
                else
                {

                    handler.write(username, pass, list);
                    MessageBox.Show("Account successfully created");
                    Login form1 = new Login();
                    SignUp form2 = new SignUp();
                    form2.Hide();
                    form1.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Password does not match!");
            }

        }

    }
}
