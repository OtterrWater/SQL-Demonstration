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
    public partial class Insert_Item : Form
    {
        public Insert_Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            ProductPage productPage= new ProductPage();
            productPage.Show();
            this.Close();
        }
    }
}
