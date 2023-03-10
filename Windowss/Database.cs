using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_Injection_Phase1_440
{
    public partial class UserDatabase : Form
    {
        public UserDatabase()
        {
            InitializeComponent();
        }

        //so this will display our table
        private void Database_Load(object sender, EventArgs e)
        {
            //we first enter our try statement that will try to open our database and show the database
            try
            {
                //we call some variables that we will use
                string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
                //we call fourth our connection and adapter
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM project_phase_1_db.user;", connection);
                connection.Open();
                //we also call our dataset
                DataSet ds = new DataSet();
                //we use the adapter to fill our page with our data
                adapter.Fill(ds, "user");
                UserDB.DataSource = ds.Tables["user"];
                //if we succed then we come here and let the user know
                Console.WriteLine("Database succesfully loaded");
                connection.Close();
            }
            //if we fail to show then we come here to let the user know that the database failed to load
            catch (Exception ex)
            {
                Console.WriteLine("failed to load database", ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Database_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void UserDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
