using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableShop_DBMS.Views
{
    public partial class frmShipping : Form
    {
        public frmShipping()
        {
            InitializeComponent();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShoppingCart frmShopping = new frmShoppingCart();
            frmShopping.ShowDialog();
            this.Close();
        }
    }
}
