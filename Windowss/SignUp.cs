using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQL_Injection_Phase1_440
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputType = "";
            if (string.IsNullOrEmpty(textFN.Text))
            {
                inputType = "Fname";
            }
            else if (string.IsNullOrEmpty(textLN.Text))
            {
                inputType = "Lname";
            }
            else if (string.IsNullOrEmpty(textEmail.Text))
            {
                inputType = "email";
            }
            else if (string.IsNullOrEmpty(textUsername.Text))
            {
                inputType = "username";
            }
            else if (string.IsNullOrEmpty(textPass.Text))
            {
                inputType = "password";
            }
            else if (string.IsNullOrEmpty(textcheckPass.Text))
            {
                inputType = "checkpassword";
            }

            switch (inputType)
            {
                case "Fname":
                    MessageBox.Show("Please enter first name");
                    break;
                case "Lname":
                    MessageBox.Show("Please enter last name");
                    break;
                case "email":
                    MessageBox.Show("Please enter email address");
                    break;
                case "username":
                    MessageBox.Show("Please enter username");
                    break;
                case "password":
                    MessageBox.Show("Please enter password");
                    break;
                case "checkpassword":
                    MessageBox.Show("Please enter password");
                    break;
                default:
                    if (inputType != "")
                    {
                        MessageBox.Show("Unknown input type: " + inputType);
                    }
                    else
                    {
                        MessageBox.Show("sign up completed!");
                        Login l = new Login();
                        l.Show();
                        this.Close();
                    }
                    break;
            }
        }


        private void textFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
