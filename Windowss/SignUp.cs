﻿using MySql.Data.MySqlClient;
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
                fnR.Visible = true;
                fnR.ForeColor = Color.Red;
                fnR.Text = "*";
                inputType = "Fname";
            }
            else
            {
                fnR.Visible = false;
            }

            if (string.IsNullOrEmpty(textLN.Text))
            {
                lnR.Visible = true;
                lnR.ForeColor = Color.Red;
                lnR.Text = "*";
                inputType = "Lname";
            }
            else
            {
                lnR.Visible = false;
            }

            if (string.IsNullOrEmpty(textEmail.Text))
            {
                emR.Visible = true;
                emR.ForeColor = Color.Red;
                emR.Text = "*";
                inputType = "email";
            }
            else if (!textEmail.Text.Contains("@") || !textEmail.Text.Contains(".com"))
            {
                emR.Visible = true;
                emR.ForeColor = Color.Red;
                emR.Text = "*";
                U_error.Visible = true;
                U_error.ForeColor = Color.Red;
                U_error.Text = "Please enter a valid email address";
                inputType = "email";
            }
            else
            {
                emR.Visible = false;
                U_error.Visible = false;
            }

            if (string.IsNullOrEmpty(textUsername.Text))
            {
                usR.Visible = true;
                usR.ForeColor = Color.Red;
                usR.Text = "*";
                inputType = "username";
            }
            else
            {
                usR.Visible = false;
            }
            
            if (string.IsNullOrEmpty(textPass.Text) || textcheckPass.Text != textPass.Text)
            {
                pwR.Visible = true;
                pwR.ForeColor = Color.Red;
                pwR.Text = "*";
                inputType = "password";
            }
            else
            {
                pwR.Visible = false;
            }
            
            if (string.IsNullOrEmpty(textcheckPass.Text))
            {
                r_pwR.Visible = true;
                r_pwR.ForeColor = Color.Red;
                r_pwR.Text = "*";
                inputType = "checkpassword";
            }else if (textcheckPass.Text != textPass.Text)
            {
                r_pwR.Visible = true;
                r_pwR.ForeColor = Color.Red;
                r_pwR.Text = "*";
                p_error.Visible = true;
                p_error.ForeColor = Color.Red;
                p_error.Text = "Password does not match";
                inputType = "checkpassword";
            }
            else
            {
                p_error.Visible = false;
                r_pwR.Visible = false;
            }

            if (inputType != "")
            {
                MessageBox.Show("Please fill in missing credentials");
            }
            else
            {
                MessageBox.Show("sign up completed!");
                Login l = new Login();
                l.Show();
                this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
