using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SQL_Injection.Windowss;

namespace SQL_Injection
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
            string tableName2 = "items";
            string tableName4 = "rates";
            string tableName5 = "rated_items";
            string tableName7 = "UIDstorage";
            //these strings will hold our queries
            string dropTableQuery = $"DROP TABLE IF EXISTS {tableName};";
            string createTableQuery = $"CREATE TABLE IF NOT EXISTS {tableName}" +
                $"(uid INT AUTO_INCREMENT," +
                $"username VARCHAR(50), " +
                $"password VARCHAR(50) NOT NULL, " +
                $"firstName VARCHAR(50) NOT NULL," +
                $"lastName VARCHAR(50) NOT NULL," +
                $"email VARCHAR(50) UNIQUE NOT NULL," +
                $"PRIMARY KEY (uid, username));";
            string dropTableQuery2 = $"DROP TABLE IF EXISTS {tableName2};";
            string createTableQuery2 = $"CREATE TABLE IF NOT EXISTS {tableName2}" +
                $"(id INT AUTO_INCREMENT PRIMARY KEY," +
                $"title VARCHAR(255) NOT NULL," +
                $"description TEXT," +
                $"category VARCHAR(255)," +
                $"price DECIMAL(10,2)," +
                $"post_date DATE," +
                $"UID INT);";
            string dropTableQuery4 = $"DROP TABLE IF EXISTS {tableName4};";
            string createTableQuery4 = $"CREATE TABLE IF NOT EXISTS {tableName4}" +
                $"(rate VARCHAR(255) NOT NULL)";
            string ratesQuery = $"INSERT INTO rates (rate) VALUES ('excellent'), ('good'), ('fair'), ('poor');";
            string dropTableQuery5 = $"DROP TABLE IF EXISTS {tableName5};";
            string createTableQuery5 = $"CREATE TABLE IF NOT EXISTS {tableName5}" +
                 $"(id INT AUTO_INCREMENT," +
                 $"item_id INT NOT NULL," +
                 $"title VARCHAR(255) NOT NULL," +
                 $"description TEXT," +
                 $"category VARCHAR(255)," +
                 $"price DECIMAL(10,2)," +
                 $"post_date DATE," +
                 $"rate VARCHAR(255)," +
                 $"rate_description TEXT," +
                 $"UID INT," +
                 $"rate_date DATE," +
                 $"rater_UID INT," +
                 $"CONSTRAINT pk_rated_items PRIMARY KEY (item_id, rate_date, rater_UID)," +
                 $"CONSTRAINT pk_rated_items_id UNIQUE (id));";

            string dropTableQuery7 = $"DROP TABLE IF EXISTS {tableName7};";
            string createTableQuery7 = $"CREATE TABLE IF NOT EXISTS {tableName7}" +
                $"(UID INT);";
            //so for the code above i dont think we need post_date tbh.. ill see tho
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand dropTableCommand = new MySqlCommand(dropTableQuery, connection);
            MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
            MySqlCommand dropTableCommand2 = new MySqlCommand(dropTableQuery2, connection);
            MySqlCommand createTableCommand2 = new MySqlCommand(createTableQuery2, connection);
            MySqlCommand dropTableCommand4 = new MySqlCommand(dropTableQuery4, connection);
            MySqlCommand createTableCommand4 = new MySqlCommand(createTableQuery4, connection);
            MySqlCommand dropTableCommand5 = new MySqlCommand(dropTableQuery5, connection);
            MySqlCommand createTableCommand5 = new MySqlCommand(createTableQuery5, connection);
            MySqlCommand dropTableCommand7 = new MySqlCommand(dropTableQuery7, connection);
            MySqlCommand createTableCommand7 = new MySqlCommand(createTableQuery7, connection);


            MySqlCommand insertRates = new MySqlCommand(ratesQuery, connection);
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
                //we call the drop table command 
                dropTableCommand2.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName2} dropped successfully!");
                //we call the drop table command 
                dropTableCommand4.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName4} dropped successfully!");
                dropTableCommand5.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName5} dropped succesfully!");
                dropTableCommand7.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName7} dropped succesfully!");

            }
            //if the table was not able to succesfully be dropped then we come here
            catch (Exception ex)
            {
                Console.WriteLine($"Error dropping table {tableName} and {tableName2} and {tableName4} and {tableName5} and {tableName7}: {ex.Message}");
                connection.Close(); 
            }
            //recreate the table
            try
            {
                //we call the create table command
                createTableCommand.ExecuteNonQuery();
                //we call the create table command
                createTableCommand2.ExecuteNonQuery();
                //we call the create table command
                createTableCommand4.ExecuteNonQuery();
                insertRates.ExecuteNonQuery();
                //we call the create table command
                createTableCommand5.ExecuteNonQuery();
                //we call the create table command
                createTableCommand7.ExecuteNonQuery();
                Console.WriteLine($"Table {tableName} and {tableName2} and {tableName4} and {tableName5}  and {tableName7} recreated successfully!");
            }
            //if the table was not succesfully recreated then we come here
            catch (Exception ex)
            {
                Console.WriteLine($"Error recreating table {tableName} and {tableName2} and {tableName4} and {tableName5} and {tableName7}: {ex.Message}");
                connection.Close();
            }
            //we come here once were done with the rest 
            finally
            {
                Login l = new Login();
                l.Show();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConSuccess_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
