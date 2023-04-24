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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQL_Injection_Phase1_440.Windowss
{
    public partial class Feature2 : Form
    {
        public Feature2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {

                //we create our variabels that we will be using
                string cat1 = c1.Text;
                string cat2 = c2.Text;



                ///checks if its empty or not
                //we first check the input is null if it is then we send the user a message letting them know that they didnt put anything
                if (string.IsNullOrEmpty(cat1) || string.IsNullOrEmpty(cat2))
                {
                    MessageBox.Show("Please input Username and Password");
                }

                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();


                //the input for the login page will be passed through here which will make it more secure since user can no longer pass sql code directly
                //into sql
                cmd.Parameters.AddWithValue("@cat1", cat1);
                cmd.Parameters.AddWithValue("@cat2", cat2);

                //starts the process to display stuff
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);



                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data from the MySqlDataAdapter
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;





                connection.Close();
                Console.WriteLine("succes");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error with loading table: " + ex);
            }

        }

        private void c1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ProductPage pd = new ProductPage();
            pd.Show();
            this.Close();
        }
    }
}
