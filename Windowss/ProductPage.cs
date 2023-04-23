using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using SQL_Injection_Phase1_440.Windowss;

namespace SQL_Injection.Windowss
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string restart = "TRUNCATE TABLE uidstorage;";
            MySqlCommand cmd = new MySqlCommand(restart, connection);
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();

            //takes us back to the login/sign up page when user clicks the logout button
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //takes us to the insertion window when user clicks the insert button
            Insert_Item i = new Insert_Item();
            i.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //takes us to the search window when user clicks search
            Search_Item s = new Search_Item();
            s.Show();
            this.Close();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            //were gonna be using a try statement to try to open mysql and load the data table known as the products
            try
            {
                //we call some variables that we will use
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                //we call fourth our connection and adapter
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM project_phase_1_db.items;", connection);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM project_phase_1_db.rated_items;", connection);
                connection.Open();
                //we also call our dataset
                DataSet pdP = new DataSet();
                //we use the adapter to fill our page with our data
                adapter.Fill(pdP, "items");
                product_db.DataSource = pdP.Tables["items"];
                //prevents an empty row from being generated
                product_db.AllowUserToAddRows = false;

                //if we succed then we come here and let the user know
                Console.WriteLine("Database succesfully loaded");


                ////////////////////////////////////loading in rated items now
                //we also call our dataset
                DataSet RI = new DataSet();
                //we use the adapter to fill our page with our data
                adapter2.Fill(RI, "rated_items");
                Rated_Items.DataSource = RI.Tables["rated_items"];
                //prevents an empty row from being generated
                Rated_Items.AllowUserToAddRows = false;
                Console.WriteLine("rated items succesfully loaded");
                connection.Close();

            }
            //if the data table was not loaded correctly then we will come here
            catch (Exception ex)
            {
                Console.WriteLine("failed to load products database or rate items", ex.Message);
            }
        }

        // Declare a variable to remember the previously selected item ID
        int prevSelectedItemID = -1;
        private void product_db_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (product_db.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = product_db.SelectedRows[0];
                    string selectedItemName = selectedRow.Cells["title"].Value.ToString();
                    int selectedItemID = (int)selectedRow.Cells["id"].Value;

                    Console.WriteLine($"{selectedItemName} {selectedItemID}");
                    //getting the UID from the item
                    int createUID = (int)selectedRow.Cells["UID"].Value;

                    //getting the UID
                    int uid = 0;
                    //we call some variables that we will use
                    string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                    string getUID = "SELECT UID FROM uidstorage LIMIT 1;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    MySqlCommand getuid = new MySqlCommand(getUID, connection);
                    connection.Open();
                    object result = getuid.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        uid = Convert.ToInt32(result);
                    }
                    connection.Close();

                    // Check if the user is trying to rate their own item
                    if (uid == createUID)
                    {
                        MessageBox.Show("You cannot rate your own item.");
                        // if this is the same item as before, show the message box again
                        if (selectedItemID == prevSelectedItemID)
                        {
                            product_db.ClearSelection();
                            prevSelectedItemID = -1;
                        }
                        return; // stop executing the method
                    }

                    //check if the user has already rated the item
                    if (HasUserRatedItem(selectedItemID, uid))
                    {
                        MessageBox.Show("You have already rated this item.");
                        // if this is the same item as before, show the message box again
                        if (selectedItemID == prevSelectedItemID)
                        {
                            product_db.ClearSelection();
                            prevSelectedItemID = -1;
                        }
                        return; // stop executing the method
                    }


                    // Show the rating window form
                    Rate_Page ratePage = new Rate_Page();
                    ratePage.SetSelectedItem(selectedItemName, selectedItemID);
                    ratePage.ShowDialog();
                    //resets the product page to updates the databases
                    this.Close();

                    // Remember the selected item ID
                    prevSelectedItemID = selectedItemID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool HasUserRatedItem(int itemID, int userID){
            // query the database to see if the user has already rated the item
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            string query = "SELECT COUNT(*) FROM rated_items WHERE item_id = @itemID AND rater_UID = @userID";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@itemID", itemID);
            command.Parameters.AddWithValue("@userID", userID);

            int count = 0;

            try
            {
                connection.Open();
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (count > 0)
            {
                // the user has already rated the item
                return true;
            }
            else
            {
                // the user has not yet rated the item
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void product_db_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //this button will sort the datagridview to only show the categories and the items with the highes price for each category
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to database
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Execute query
                string query = "SELECT items.title, items.category, max_prices.max_price \r\nFROM items \r\nINNER JOIN (\r\n  SELECT category, MAX(price) AS max_price \r\n  FROM items \r\n  GROUP BY category\r\n) AS max_prices \r\nON items.category = max_prices.category AND items.price = max_prices.max_price \r\nORDER BY items.title;\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                Console.WriteLine("Successfully retrieved max price for each category.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }




            /*
            try
            {
                // Connect to database
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Execute query
                string getMaxPrice = "SELECT category, MAX(price) AS max_price FROM items GROUP BY category;";
                MySqlCommand getMax = new MySqlCommand(getMaxPrice, connection);
                MySqlDataReader reader = getMax.ExecuteReader();

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Add columns to the DataTable
                dataTable.Columns.Add("Category");
                dataTable.Columns.Add("Max Price");

                // Read the data from the MySqlDataReader and store it in the DataTable
                while (reader.Read())
                {
                    // Create a new row for the DataTable
                    DataRow dataRow = dataTable.NewRow();

                    // Set the values for the columns
                    dataRow["Category"] = reader.GetString("category");
                    dataRow["Max Price"] = reader.GetDecimal("max_price");

                    // Add the row to the DataTable
                    dataTable.Rows.Add(dataRow);
                }

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                Console.WriteLine("Successfully retrieved max price for each category.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
            */

        }

        private void ListUserItems_Click(object sender, EventArgs e)
        {
            //calling variables that will be used
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //getting the saved UID from the storage storage UID
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
            //checking if we got the userID correctly
            Console.WriteLine("user id is: " + uid_storage);

            //---------------------------------------------getting all the items that were posted by the user that got a rating of "excellent or good"-----------------//
            try
            {
                connection.Open();
                // Execute query
                // havent test this out yet but ik that the query works so check it out when you work on this 
                string query = "SELECT title, rate FROM rated_items WHERE UID = @uid_storage AND rate IN ('excellent', 'good');";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@uid_storage", uid_storage);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of items for current user who got their item rated as excellent or good.");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }


        }
        //this will keep track of feature 7, display all users who have neve posted a poor review
        private void ListReviews_Click(object sender, EventArgs e)
        {
            //calling variables that will be used
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //---------------------------------------------getting all the items that were posted by the user that got a rating of "excellent or good"-----------------//
            try
            {
                connection.Open();
                // Execute query
                string query = "SELECT DISTINCT u.uid, u.username\r\n FROM user u\r\n LEFT JOIN rated_items ri ON u.uid = ri.rater_UID\r\n WHERE NOT EXISTS (\r\n SELECT 1\r\n FROM rated_items r\r\n WHERE r.rater_UID = u.uid AND r.rate = 'poor');";


                //this query shows all the users who have never posted a poor review, also it makes sure that it dosent include the user
                //who have not given a rating before

                /*
                 * SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE ri.rater_UID IS NOT NULL
                    AND (
                        NOT EXISTS (
                            SELECT 1
                            FROM rated_items r
                            WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                        )
                    );

                 */


                //this query show all user who have never or have never posted a poor review
                /*  SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE NOT EXISTS (
                    SELECT 1
                    FROM rated_items r
                    WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                    );
                 */
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of users who have never posted a poor review");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
        }
        //feature 6
        private void Feature6_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                // Execute query
                //string query = "SELECT u.uid, u.username FROM user u WHERE u.uid NOT IN (SELECT i.id FROM Items i JOIN rated_items r ON i.id = r.item_id GROUP BY i.id HAVING COUNT(*) >= 3 AND MAX(r.rate) = 'Excellent');";
                string query = "SELECT u.uid, u.username FROM user u WHERE u.uid NOT IN (SELECT ri.uid FROM rated_items ri INNER JOIN (SELECT item_id, COUNT() AS excellent_count FROM rated_items WHERE rate = 'excellent' GROUP BY item_id HAVING COUNT() >= 3) AS e ON e.item_id = ri.item_id WHERE ri.rate = 'excellent' GROUP BY ri.uid) AND EXISTS (SELECT 1 FROM items i WHERE i.uid = u.uid);";
                //this query shows all the users who never post an item that has 3 or more 'excellent' rating
                //who have not given a rating before

                /*
                 * SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE ri.rater_UID IS NOT NULL
                    AND (
                        NOT EXISTS (
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            FROM rated_items r
                            WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                        )
                    );

                 */


                //this query show all user who have never or have never posted a poor review
                /*  SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE NOT EXISTS (
                    SELECT 1
                    FROM rated_items r
                    WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                    );
                 */
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of users who have never posted a poor review");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
        }

        private void Feature9_Click(object sender, EventArgs e)
        {
            //calling variables that will be used
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //---------------------------------------------getting all the items that were posted by the user that got a rating of "excellent or good"-----------------//
            try
            {
                connection.Open();
                // Execute query
                //string query = "SELECT u.uid, u.username FROM user u WHERE u.uid NOT IN (SELECT i.id FROM Items i JOIN rated_items r ON i.id = r.item_id GROUP BY i.id HAVING COUNT(*) >= 3 AND MAX(r.rate) = 'Excellent');";
                string query = "SELECT DISTINCT u.uid, u.username FROM user u JOIN Items i ON u.uid = i.uid LEFT JOIN rated_items ri ON i.id = ri.item_id AND ri.rate IN ('poor', NULL) WHERE ri.item_id IS NULL;";
                //this query shows all the users who never post an item that has 3 or more 'excellent' rating
                //who have not given a rating before

                /*
                 * SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE ri.rater_UID IS NOT NULL
                    AND (
                        NOT EXISTS (
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            FROM rated_items r
                            WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                        )
                    );

                 */


                //this query show all user who have never or have never posted a poor review
                /*  SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE NOT EXISTS (
                    SELECT 1
                    FROM rated_items r
                    WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                    );
                 */
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of users who have never posted a poor review");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
        }
        //feature 4
        private void Feature4_Click(object sender, EventArgs e)
        {
            //calling variables that will be used
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //---------------------------------------------getting all the items that were posted by the user that got a rating of "excellent or good"-----------------//
            try
            {
                connection.Open();
                // Execute query
                string query = "SELECT u.uid, u.username, COUNT(i.uid) AS num_items FROM user u JOIN items i ON u.uid = i.uid WHERE i.post_date >= '2020-05-01' GROUP BY u.uid, u.username HAVING COUNT(i.uid) = (SELECT COUNT(uid) FROM items WHERE post_date >= '2020-05-01' GROUP BY uid ORDER BY COUNT(uid) DESC LIMIT 1) ORDER BY num_items DESC;";
                //string query = "SELECT u.uid, u.username FROM user u JOIN items i ON u.uid = i.uid;";
                //this query shows all the users who never post an item that has 3 or more 'excellent' rating
                //who have not given a rating before

                /*
                 * SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE ri.rater_UID IS NOT NULL
                    AND (
                        NOT EXISTS (
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            SELECT 1
                            FROM rated_items r
                            WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                        )
                    );

                 */


                //this query show all user who have never or have never posted a poor review
                /*  SELECT DISTINCT u.uid, u.username
                    FROM user u
                    LEFT JOIN rated_items ri ON u.uid = ri.rater_UID
                    WHERE NOT EXISTS (
                    SELECT 1
                    FROM rated_items r
                    WHERE r.rater_UID = u.uid AND r.rate = 'poor'
                    );
                 */
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of users who have never posted a poor review");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);

            }
        }
            //feature 8
            private void EachReviewPoor_Click(object sender, EventArgs e)
        {
            //calling variables that will be used
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //---------------------------------------------getting all the items that were posted by the user that got a rating of "excellent or good"-----------------//
            try
            {
                connection.Open();
                // Execute query
                string query = "SELECT u.username, ri.rater_UID AS uid\r\nFROM rated_items ri\r\nINNER JOIN user u ON u.uid = ri.rater_UID\r\nGROUP BY u.username, uid\r\nHAVING COUNT(CASE WHEN rate = 'poor' THEN 1 END) = COUNT(*)\r\n  AND COUNT(*) > 0;\r\n";
               
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                product_db.DataSource = dataTable;

                // Close connection
                connection.Close();
                //send message to console
                Console.WriteLine("Successfully retrieved the list of users who have never posted a poor review");
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
        }
    }
}
