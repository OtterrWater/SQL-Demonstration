using MySql.Data.MySqlClient;
using SQL_Injection;
using SQL_Injection.Windowss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Injection_Phase1_440.Windowss
{
    public partial class Rate_Page : Form
    {
        /*
        public int SelectedItemId { get; set; }
        public int SelectedItemName { get; set; }
        */
        private string _selectedItemName;
        private int _selectedItemId;

        public Rate_Page(string selectedItemName, int selectedItemId)
        {
            _selectedItemName = selectedItemName;
            _selectedItemId = selectedItemId;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             //this is where we will increment the rating    

                //get the item id that was selected
                int itemID = _selectedItemId;
                string titleName = _selectedItemName;
                //fetch the data of the item that weve selected
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                string query = "SELECT * FROM items WHERE id = @itemId AND title = @title";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemId", itemID);
                command.Parameters.AddWithValue("@title", titleName);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string selectedItemName = "";
                if (reader.Read())
                {
                    // Get the item details from the fetched data
                    selectedItemName = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    string category = reader["category"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    DateTime postDate = Convert.ToDateTime(reader["post_DATE"]);

                    // Insert the rating along with the fetched item details into the rated_items table
                    query = "INSERT INTO rated_items (id, title, description, category, price, post_date, rate, rate_description) " +
                            "VALUES (@itemID, @title, @description, @category, @price, @post_date, @rating, @rating_description)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemID", itemID);
                    command.Parameters.AddWithValue("@title", selectedItemName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@post_date", postDate);
                    command.Parameters.AddWithValue("@rating", Convert.ToInt32(comboBox1.SelectedItem));
                    command.Parameters.AddWithValue("@rating_description", textBox1.Text);
                    reader.Close();
                    command.ExecuteNonQuery();

                    // Delete the row from the items table
                    query = "DELETE FROM items WHERE id = @itemId";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemId", itemID);
                    command.ExecuteNonQuery();
                }
                connection.Close();

                //takes us back to the product page
                ProductPage p = new ProductPage();
                p.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed to insert: " + ex.Message);
            }
        }

        private void Rate_Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                string query = "SELECT rate FROM project_phase_1_db.rates;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                 {
                 comboBox1.Items.Add(reader["rate"].ToString());
                 }
                connection.Close();
                Console.WriteLine("succesfully loaded the rates");
            }catch(Exception ex)
            {
                Console.WriteLine("failed to load", ex.Message);
            }
            
                
        }
    }
}
