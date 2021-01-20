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
    public partial class frmShoppingCart : Form
    {
        public string UserName;
        public frmShoppingCart(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
        }

        private void btnOrderCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTable dtIDUser = OrderItemsController.IDUser_Find(UserName).Tables[0];
            string IDUser = dtIDUser.Rows[0][0].ToString();
            DataTable dtAddress_User = OrderItemsController.All_Address_Show(IDUser).Tables[0];
            string DefaultAddress = "";
            string PhoneNumber = "";
            string FullName = "";
            foreach (DataRow dr in dtAddress_User.Rows)
            {
                if (dr["IsDefault"].ToString() == "1")
                {
                    DefaultAddress = dr["Street"].ToString() + ", " + dr["Ward"].ToString() + ", " + dr["District"].ToString() + ", " + dr["Province"].ToString();
                    PhoneNumber = dr["PhoneNumber"].ToString();
                    FullName = dr["FullName"].ToString();
                }
            }
            frmShipping frmShip = new frmShipping(UserName, DefaultAddress, PhoneNumber, FullName);
            frmShip.ShowDialog();
        }
    }
}
