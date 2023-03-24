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
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Insert_Item i = new Insert_Item();
            i.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Search_Item s = new Search_Item();
            s.Show();
            this.Close();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

        }
    }
}
