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
        //calling variables that will be used
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
           //calling variabels that will be used
            string title = textTitle.Text;
            string description = textDescription.Text;
            string category = textCategory.Text;
            string price = textPrice.Text;
            //query that will call the mysql code/query to be ran
            string que = "INSERT INTO items (title, description, category, price, post_date) VALUES (@title, @description, @category, @price, CURDATE())";
            //we first check if the input boxes are empty if they are then we jump here and let the user know
            if (string.IsNullOrEmpty(textTitle.Text) || string.IsNullOrEmpty(textDescription.Text) || string.IsNullOrEmpty(textCategory.Text) || string.IsNullOrEmpty(textPrice.Text)){
                MessageBox.Show("Please make sure to fill in all fields");
            //if the input boxes are not empty then we come here
            }else{
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
                MessageBox.Show("product inserted!");
                //then user is sent back to the product page
                ProductPage productPage = new ProductPage();
                productPage.Show();
                this.Close();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
