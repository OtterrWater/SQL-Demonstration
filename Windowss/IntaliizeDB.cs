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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Odbc;

namespace SQL_Injection_Phase1_440
{
    public partial class IntaliizeDB : Form
    {
        //we call the connection class and make con to call the functions
        Data.Connection con = new Data.Connection();
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
            //once the button is clicked we try to connect
            try
            {
                //provides info for the connection
                Data.Connection.dataSource();

                //this opens up the connection
                con.connOpen();
         
                //if we have connected succesfully we display success
                conSuccess.Visible = true;
                conError.Visible = false;

                
            }
            //if the connection was not succesful we come here
            catch (Exception)
            { 
                //we make error visible
                conError.Visible = true;
                conSuccess.Visible = false;
                //we close the connection
                con.connClose();
            }
            finally
            {   
                //we open the sign up or login page
                SignUpOrLog sl = new SignUpOrLog();
                sl.Show();
            }
            
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conSuccess_Click(object sender, EventArgs e)
        {

        }

    }
}
