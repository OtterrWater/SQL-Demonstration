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
        private string _selectedItemName;
        private int _selectedItemId;
        private int _uid;
        //calling variables that will be used
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public void SetSelectedItem(string selectedItemName, int selectedItemId)
        {
            _selectedItemName = selectedItemName;
            _selectedItemId = selectedItemId;
        }

        public void SetUid(int uid)
        {
            _uid = uid;
        }


        public Rate_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputType = "";
            //get the item id that was selected
            int itemID = _selectedItemId;
            string titleName = _selectedItemName;
            Console.WriteLine(itemID+ " " + titleName);

            // Retrieve the rater UID from the uidstorage table
            //---------------------------------------------------------

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

            string count_query = "SELECT COUNT(*) FROM rated_items WHERE rater_UID = @uid AND rate_date = CURDATE()";
            MySqlCommand count_command = new MySqlCommand(count_query, connection);
            count_command.Parameters.AddWithValue("@uid", uid_storage);

            connection.Open();
            int Total_Rates_byday = Convert.ToInt32(count_command.ExecuteScalar());
            connection.Close();

            if (Total_Rates_byday >= 3)
            {
                R_max.Visible = true;
                R_max.ForeColor = Color.Red;
                R_max.Text = "You have reached the maximum of three ratings";
                inputType = "textTitle";
            }
            else
            {
                R_max.Visible = false;
            }

            //HERE-----------------------------------------------------
            if (inputType != "")
            {
                MessageBox.Show("Please make sure to fill in all fields");
                connection.Close();
                return;
                //if the input boxes are not empty then we come here
            }
            else
            {
                string query = "SELECT * FROM items WHERE id = @itemId AND title = @title";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemId", itemID);
                command.Parameters.AddWithValue("@title", titleName);
                //this is where we will increment the rating 

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string selectedItemName = "";
                if (inputType != "")
                {
                    MessageBox.Show("Please make sure to fill in all fields");
                    connection.Close();
                    return;
                    //if the input boxes are not empty then we come here
                }
                else if (reader.Read())
                {
                    // Get the item details from the fetched data
                    selectedItemName = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    string category = reader["category"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    DateTime postDate = Convert.ToDateTime(reader["post_DATE"]);
                    int UID = Convert.ToInt32(reader["UID"]);

                    //Insert the rating along with the fetched item details into the rated_items table
                    query = "INSERT INTO rated_items (item_id, title, description, category, price, post_date, rate, rate_description, UID, rate_date, rater_UID) " +
                            "VALUES (@itemID, @title, @description, @category, @price, @post_date, @rating, @rating_description, @UID, CURDATE(), @rater_UID)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemID", itemID);
                    command.Parameters.AddWithValue("@title", selectedItemName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@post_date", postDate);
                    command.Parameters.AddWithValue("@UID", UID);
                    command.Parameters.AddWithValue("@rater_UID", uid_storage);

                    // ADDING THE INTS INTO DROPDOWN BOX    
                    command.Parameters.AddWithValue("@rating", comboBox1.SelectedItem);

                    command.Parameters.AddWithValue("@rating_description", textBox1.Text);
                    reader.Close();
                    command.ExecuteNonQuery();




                    /*
                    // Delete the row from the items table
                    query = "DELETE FROM items WHERE id = @itemId";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemId", itemID);
                    command.ExecuteNonQuery();
                    */
                }
                connection.Close();

                //takes us back to the product page
                ProductPage p = new ProductPage();
                p.Show();
                this.Close();
            }
        }

        private void Rate_Page_Load(object sender, EventArgs e)
        {
            try
            {
                
                string newLabelText = _selectedItemName;
                itemNameLabel.Text = newLabelText;
                

                //stops the user from inputting anything in the combo box
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPage l = new ProductPage();
            l.Show();
            this.Close();
        }
    }
}
