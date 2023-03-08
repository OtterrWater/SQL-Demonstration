using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_Injection_Phase1_440
{
    public partial class IntaliizeDB : Form
    {
        public IntaliizeDB()
        {
            InitializeComponent();
            //we set both the succes and error text to false so they dont show on startup
            conSuccess.Visible = false;
            conError.Visible = false;
        }

        private void IntaliizeDB_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //this will keep our connection info
            string connectionString = "Server=127.0.0.1;Database=project_phase_1_db;Uid=root;Pwd=123;";
            string tableName = "user";
            //these strings will hold our queries
            string dropTableQuery = $"DROP TABLE IF EXISTS {tableName};";
            string createTableQuery = $"CREATE TABLE IF NOT EXISTS {tableName}" +
                $"(username VARCHAR(50) PRIMARY KEY, password VARCHAR(50) NOT NULL, " +
                $"firstName VARCHAR(50) NOT NULL,lastName VARCHAR(50) NOT NULL," +
                $"email VARCHAR(50) UNIQUE NOT NULL);";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand dropTableCommand = new MySqlCommand(dropTableQuery, connection);
            MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
            //once the button is clicked we try to connect to the mySQL server
            try 
            { 
                //we call this to open up a connection
                connection.Open();
                Console.WriteLine($"Connection established!");
                //if we have connected succesfully we display success
                conSuccess.Visible = true;
                conError.Visible = false;
            }
            //if we havent connected succesfully
            catch 
            {
                Console.WriteLine($"Failed to connect");
                //we make error visible
                conError.Visible = true;
                conSuccess.Visible = false;
                //we then close the connection
                connection.Close();
            }
            //we then try to drop the previous table if there is any 
            try
            {
                //we call the drop table command 
                dropTableCommand.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName} dropped successfully!");
                
            }
            //if the table was not able to succesfully be dropped then we come here
            catch (Exception ex)
            {
                Console.WriteLine($"Error dropping table {tableName}: {ex.Message}");
                connection.Close(); 
            }
            //recreate the table
            try
            {
                //we call the create table command
                createTableCommand.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName} recreated successfully!");
            }
            //if the table was not succesfully recreated then we come here
            catch (Exception ex)
            {
                Console.WriteLine($"Error recreating table {tableName}: {ex.Message}");
                connection.Close();
            }
            //we come here once were done with the rest 
            finally
            {   
                //we open the sign up or login page
                SignUpOrLog sl = new SignUpOrLog();
                sl.Show();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConSuccess_Click(object sender, EventArgs e)
        {

        }

    }
}
