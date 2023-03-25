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
    public partial class Search_Item : Form
    {
        static string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public Search_Item()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProductPage pG = new ProductPage();
            pG.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string query = "SELECT * FROM items WHERE category=@category;";
                MySqlCommand commnad = new MySqlCommand(query, connection);
                commnad.Parameters.AddWithValue("@category", InputText.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commnad);
                connection.Open();
                DataSet table = new DataSet();
                //we use the adapter to fill our page with our data
                adapter.Fill(table, "items");
                dataGridViewResults.DataSource = table.Tables["items"];
                //if we succed then we come here and let the user know
                Console.WriteLine("Database succesfully loaded");
                connection.Close();
                */
                string[] categories = InputText.Text.Split(',');
                string query = "SELECT * FROM items WHERE category IN (" + string.Join(",", categories.Select(c => "'" + c.Trim() + "'")) + ");";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet table = new DataSet();
                adapter.Fill(table, "items");
                dataGridViewResults.DataSource = table.Tables["items"];
                Console.WriteLine("Database successfully loaded");
                connection.Close();
            }
            catch(Exception ex){
                Console.WriteLine("error with loading the data", ex.Message);
            }
            
        }
    }
}
