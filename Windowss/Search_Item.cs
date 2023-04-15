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
using SQL_Injection_Phase1_440.Windowss;

namespace SQL_Injection.Windowss
{
    public partial class Search_Item : Form
    {
        //calling variables that we will be using
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Search_Item()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this is the done button when its clicked were takeb back to the product page
            ProductPage pG = new ProductPage();
            pG.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //we first try to open and load the data for the specific category that were looking for
            try
            {
                // Split the category string by comma into an array of strings
                string[] categories = InputText.Text.Split(',');
                // Create the SQL query with the LIKE operator to retrieve items that contain the word "love" in their category
                string query = "SELECT * FROM items WHERE category LIKE '%" + InputText.Text + "%';";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet table = new DataSet();
                adapter.Fill(table, "items");
                dataGridViewResults.DataSource = table.Tables["items"];
                // Let the user know that the database was successfully loaded
                Console.WriteLine("Database successfully loaded");
                connection.Close();
            }
            //if there was an error with loading the data then we come here
            catch (Exception ex){
                Console.WriteLine("error with loading the data", ex.Message);
            }
            
        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Declare a variable to remember the previously selected item ID
        int prevSelectedItemID = -1;
        private void dataGridViewResults_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResults.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewResults.SelectedRows[0];
                    string selectedItemName = selectedRow.Cells["title"].Value.ToString();
                    int selectedItemID = (int)selectedRow.Cells["id"].Value;
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
                            dataGridViewResults.ClearSelection();
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

        private void Search_Item_Load(object sender, EventArgs e)
        {
            //prevents an empty row from being generated
            dataGridViewResults.AllowUserToAddRows = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
