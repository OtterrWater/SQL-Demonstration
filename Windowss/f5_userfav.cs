using MySql.Data.MySqlClient;
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
    public partial class f5_userfav : Form
    {
        public f5_userfav()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //CREATES DUMMY TABLE
            /*
             * GO INTO DUMMY TABLE favored_user IN WORKBENCH: INPUT

            INSERT INTO favored_users VALUES (1,2)
            -> (UID, favored_UID)
            -> execute current statement
             */
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string userInput = c1.Text;
                string query = $"SELECT DISTINCT f1.uid, f2.uid FROM favored_users f1 JOIN favored_users f2 ON f1.favored_uid = f2.favored_uid AND f1.uid < f2.uid WHERE f1.favored_uid = {userInput}";
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
            }
            catch (Exception ex)
            {
                //if were unable to laod the data then we come here
                Console.WriteLine("Failed to load data: {0}", ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ProductPage f = new ProductPage();
            f.Show();
            this.Close();
        }
    }
}
