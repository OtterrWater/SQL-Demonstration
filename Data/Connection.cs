using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQL_Injection_Phase1_440.Data
{
    class Connection
    {
        //we make a public function that will house the the information for the SQL to connect
        public static MySqlConnection connMaster = new MySqlConnection();
        //this is our info so server, database, Uid, and password
        static string server = "127.0.0.1;";
        static string database = "project_phase_1_db;";
        static string Uid = "root;";
        static string password = "123;";
        //this is where the info is taken to 
        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server = {server} database = {database} Uid = {Uid} password = {password}");
            return connMaster;
        }
        //opens up the connection
        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }
        //closes the connection
        public void connClose()
        {
            dataSource();
            connMaster.Close(); 
        }
    }
}
