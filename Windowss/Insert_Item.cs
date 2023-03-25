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

namespace SQL_Injection_Phase1_440.Windowss
{
    public partial class Insert_Item : Form
    {
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Insert_Item()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
           
            
            string title = textTitle.Text;
            string description = textDescription.Text;
            string category = textCategory.Text;
            string price = textPrice.Text;
            //query stuff, grabbing values and insert into user(SQL)
            string que = "INSERT INTO items (title, description, category, price, post_date) VALUES (@title, @description, @category, @price, CURDATE())";
           
            string que2 = $"INSERT INTO user_posts (user_name, post_date, num_posts) " +
                $"VALUES (@user_name, CURDATE(), 1)" +
                $" ON DUPLICATE KEY UPDATE num_posts = num_posts + 1";

            if (string.IsNullOrEmpty(textTitle.Text) || string.IsNullOrEmpty(textDescription.Text) || string.IsNullOrEmpty(textCategory.Text) || string.IsNullOrEmpty(textPrice.Text)){
               
                MessageBox.Show("Please make sure to fill in all fields");
            }else{
                MySqlCommand cmd = new MySqlCommand(que, connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                connection.Open(); 
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("product inserted!");
                ProductPage productPage = new ProductPage();
                productPage.Show();
                this.Close();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
