using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_Injection.Windowss
{
    public partial class Insert_Item : Form
    {
        //calling variables that will be used
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Insert_Item()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //calling variabels that will be used
            string inputType = "";
            string title = textTitle.Text;
            string description = textDescription.Text;
            string category = textCategory.Text;
            string price = textPrice.Text;
            //we first check if the input boxes are empty if they are then we jump here and let the user know

            //query to count the number of existing entries
            string countQuery = "SELECT COUNT(*) FROM items";

            //create MySqlCommand objects for both queries
            MySqlCommand countCmd = new MySqlCommand(countQuery, connection);

            connection.Open();
            //execute the count query and retrieve the result
            int countAll = Convert.ToInt32(countCmd.ExecuteScalar());
            connection.Close();

            //title
            if (string.IsNullOrEmpty(textTitle.Text))
            {
                t_R.Visible = true;
                t_R.ForeColor = Color.Red;
                t_R.Text = "*";
                inputType = "textTitle";
            }else if (countAll >= 3){
                t_R.Visible = true;
                t_R.ForeColor = Color.Red;
                t_R.Text = "*";
                t_error.Visible = true;
                t_error.ForeColor = Color.Red;
                t_error.Text = "Username has reached the maximum three inputs";
                inputType = "textTitle";
            }
            else
            {
                t_R.Visible = false;
                t_error.Visible = false;
            }
            
            //descript
            if (string.IsNullOrEmpty(textDescription.Text))
            {
                d_R.Visible = true;
                d_R.ForeColor = Color.Red;
                d_R.Text = "*";
                inputType = "textDescription";
            }
            else
            {
                d_R.Visible = false;
            }

            //category
            if (string.IsNullOrEmpty(textCategory.Text))
            {
                c_R.Visible = true;
                c_R.ForeColor = Color.Red;
                c_R.Text = "*";
                inputType = "textCategory";
            }
            else
            {
                c_R.Visible = false;
            }

            //price
            int intValue;
            if (string.IsNullOrEmpty(textPrice.Text))
            {
                p_R.Visible = true;
                p_R.ForeColor = Color.Red;
                p_R.Text = "*";
                inputType = "textPrice";
            }
            else if(!int.TryParse(textPrice.Text, out int priceValue))
            {
                p_R.Visible = true;
                p_R.ForeColor = Color.Red;
                p_R.Text = "*";
                inputType = "textPrice";
                p_error.Visible = true;
                p_error.ForeColor = Color.Red;
                p_error.Text = "Input a valid price";
            } 
            else
            {
                p_R.Visible = false;
                p_error.Visible = false;
            }

            if (inputType != ""){
                MessageBox.Show("Please make sure to fill in all fields");
                connection.Close();
                return;
                //if the input boxes are not empty then we come here
            }
            else{
                //query that will call the mysql code/query to be ran
                string que = "INSERT INTO items (title, description, category, price, post_date) VALUES (@title, @description, @category, @price, CURDATE())";
                //we call variables that will be used like cmd
                MySqlCommand cmd = new MySqlCommand(que, connection);
                //these will be used to help combat against sql injection attacks
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                //used to establish connection with the mysql schema
                connection.Open();
                //used to execute the query
                cmd.ExecuteNonQuery();
                //closes connection
                connection.Close();
                //lets user know that it was succesfully inserted
                MessageBox.Show("product inserted!               ");
                //then user is sent back to the product page
                ProductPage productPage = new ProductPage();
                productPage.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPage l = new ProductPage();
            l.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
