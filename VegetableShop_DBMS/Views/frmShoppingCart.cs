using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controllers;
namespace VegetableShop_DBMS.Views
{
    public partial class frmShoppingCart : Form
    {
        public string UserName;
        public frmShoppingCart(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
            DataTable dtCart = OrderItemsController.ShowCart(UserName).Tables[0];
            foreach (DataRow dr in dtCart.Rows)
            {
                string ImageTemp = dr["Image"].ToString();
                Image image;
                if (ImageTemp != "")
                {
                    string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
                    string FileName = appPath + ImageTemp;
                    image = Image.FromFile(FileName);
                }
                else
                {
                    ImageTemp = "10.jpg";
                    string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
                    string FileName = appPath + ImageTemp;
                    image = Image.FromFile(FileName);
                }
                string ItemName = dr["ItemName"].ToString();
                string Description = dr["Description"].ToString();
                string PaidPrice = dr["PaidPrice"].ToString();
                string Orgin = dr["Orgin"].ToString();
                string Quantity = dr["Quantity"].ToString();
                dtGVShoppingCart.Rows.Add(image, ItemName, Description, PaidPrice, Orgin, Quantity);
            }
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
