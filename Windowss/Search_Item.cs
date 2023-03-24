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
    public partial class Search_Item : Form
    {
        public Search_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPage pG = new ProductPage();
            pG.Show();
            this.Close();
        }
    }
}
