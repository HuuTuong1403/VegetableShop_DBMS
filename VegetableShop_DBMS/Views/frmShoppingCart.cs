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
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnOrderCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShipping frmShip = new frmShipping();
            frmShip.ShowDialog();
        }
    }
}
