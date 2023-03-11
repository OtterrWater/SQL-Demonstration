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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQL_Injection_Phase1_440
{
    public partial class SignUp : Form
    {
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);
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

            //check for first name
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

            //check for last name
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

            // Check if email already exists
            MySqlCommand checkEmailCmd = new MySqlCommand("SELECT COUNT(*) FROM user WHERE email = @email", connection);
            checkEmailCmd.Parameters.AddWithValue("@email", textEmail.Text);

            connection.Open();
            //grabbing count of pws
            long countE = (long)checkEmailCmd.ExecuteScalar();
            connection.Close();

            //check for email
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
            else if (countE > 0)
            {
                emR.Visible = true;
                emR.ForeColor = Color.Red;
                emR.Text = "*";
                U_error.Visible = true;
                U_error.ForeColor = Color.Red;
                U_error.Text = "Email already exist";
                inputType = "email";
            }
            else
            {
                emR.Visible = false;
                U_error.Visible = false;
            }

            // Check if username already exists
            MySqlCommand checkUsernameCmd = new MySqlCommand("SELECT COUNT(*) FROM user WHERE username = @username", connection);
            checkUsernameCmd.Parameters.AddWithValue("@username", textUsername.Text);

            connection.Open();
            //grabbing count of usernames
            long countU = (long)checkUsernameCmd.ExecuteScalar();
            connection.Close();

            if (string.IsNullOrEmpty(textUsername.Text))
            {
                usR.Visible = true;
                usR.ForeColor = Color.Red;
                usR.Text = "*";
                inputType = "username";
            }else if (countU > 0)
            {
                usR.Visible = true;
                usR.ForeColor = Color.Red;
                usR.Text = "*";
            }
            else
            {
                usR.Visible = false;
            }

            //check for password
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

            //check if pw is same as re-entered pw
            if (string.IsNullOrEmpty(textcheckPass.Text))
            {
                r_pwR.Visible = true;
                r_pwR.ForeColor = Color.Red;
                r_pwR.Text = "*";
                inputType = "checkpassword";
            }
            else if (textcheckPass.Text != textPass.Text)
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

            //error box appears when any inputType is missing
            if (inputType != "")
            {
                MessageBox.Show("Please fill in missing credentials");
                connection.Close();
                return;
            }
            //login and allow data to be processed
            else
            {

                //query stuff, grabbing values and insert into user(SQL)
                string query = "INSERT INTO user (username, password, firstName, lastName, email) VALUES (@username, @password, @firstName, @lastName, @email)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", textUsername.Text);
                command.Parameters.AddWithValue("@password", textcheckPass.Text);
                command.Parameters.AddWithValue("@firstName", textFN.Text);
                command.Parameters.AddWithValue("@lastName", textLN.Text);
                command.Parameters.AddWithValue("@email", textEmail.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("sign up completed!");
                Login l = new Login();
                l.Show();
                connection.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
