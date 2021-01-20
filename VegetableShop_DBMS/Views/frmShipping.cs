using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controller;
namespace VegetableShop_DBMS.Views
{
    public partial class frmShipping : Form
    {
        public string UserName;
        public string DefaultAddress;
        public frmShipping(string UserName, string DefaultAddress, string PhoneNumber, string FullName)
        {
            this.UserName = UserName;
            this.DefaultAddress = DefaultAddress;
            InitializeComponent();
            this.lblAddress.Text = DefaultAddress;
            this.lblFullName.Text = FullName;
            this.lblPhoneNumber.Text = PhoneNumber;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShoppingCart frmShopping = new frmShoppingCart(UserName);
            frmShopping.ShowDialog();
            this.Close();
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDefaultAddress frmDefault = new frmDefaultAddress(UserName, DefaultAddress);
            frmDefault.ShowDialog();
            this.Close();
        }
    }
}
