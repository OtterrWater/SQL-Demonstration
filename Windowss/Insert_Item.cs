using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

            //getting the storage UID
            int uid_storage = 0;
            string getUID_storage = "SELECT UID FROM uidstorage LIMIT 1;";
            MySqlCommand getuid_storage = new MySqlCommand(getUID_storage, connection);

            connection.Open();
            object result = getuid_storage.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                uid_storage = Convert.ToInt32(result);
            }
            connection.Close();

            string count_query = "SELECT COUNT(*) FROM (SELECT UID, post_date FROM items WHERE UID = @uid AND post_date = CURDATE() UNION ALL SELECT UID, post_date FROM rated_items WHERE UID = @uid AND post_date = CURDATE()) AS all_items";
            MySqlCommand count_command = new MySqlCommand(count_query, connection);
            count_command.Parameters.AddWithValue("@uid", uid_storage);

            connection.Open();
            int Total_Items_byday = Convert.ToInt32(count_command.ExecuteScalar());
            connection.Close();

            // Check if the user is trying to rate their own item
            if (Total_Items_byday >= 3)
            {
                t_R.Visible = true;
                t_R.ForeColor = Color.Red;
                t_R.Text = "*";
                t_error.Visible = true;
                t_error.ForeColor = Color.Red;
                t_error.Text = "You have reached the maximum of three entries";
                inputType = "textTitle";
            }
            else if(string.IsNullOrEmpty(textDescription.Text)){
                t_R.Visible = true;
                t_R.ForeColor = Color.Red;
                t_R.Text = "*";
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
                //geting the UID to insert to the table
                string getUID = "SELECT UID FROM uidstorage LIMIT 1;";
                MySqlCommand getuid = new MySqlCommand(getUID, connection);
                connection.Open();
                int uid = 0;
                //object result = getuid.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    uid = Convert.ToInt32(result);
                }

                //query that will call the mysql code/query to be ran
                string que = "INSERT INTO items (title, description, category, price, post_date, UID) VALUES (@title, @description, @category, @price, CURDATE(), @UID)";
                //we call variables that will be used like cmd
                MySqlCommand cmd = new MySqlCommand(que, connection);
                //these will be used to help combat against sql injection attacks
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@UID", uid);
                
                //used to establish connection with the mysql schema
                
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

        private void Insert_Item_Load(object sender, EventArgs e)
        {
          
        }
    }
}
