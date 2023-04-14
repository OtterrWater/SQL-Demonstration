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

        private void product_db_SelectionChanged(object sender, EventArgs e)
        {
            ///this is where we will check if they are trying to rate their own thing
            ///we will also check to see if they havent rated more than 3 things
            try
            {
            if (product_db.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = product_db.SelectedRows[0];
                    string selectedItemName = selectedRow.Cells["title"].Value.ToString();
                    int selectedItemID = (int)selectedRow.Cells["id"].Value;

                    // Show the rating window form
                    Rate_Page ratePage = new Rate_Page();
                    ratePage.SetSelectedItem(selectedItemName, selectedItemID);
                    ratePage.ShowDialog();
                    this.Close();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
