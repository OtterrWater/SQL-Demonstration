using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Injection_Phase1_440
{
    public partial class IntaliizeDB : Form
    {
        public IntaliizeDB()
        {
            InitializeComponent();
        }

        private void IntaliizeDB_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SignUpOrLog sl = new SignUpOrLog();
            sl.Show();
            this.Close();
        }
    }
}
