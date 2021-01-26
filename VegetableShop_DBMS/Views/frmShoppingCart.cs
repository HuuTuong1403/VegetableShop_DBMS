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
        public string PassWord;
        public string ItemNameTemp;
        public string err;
        public frmShoppingCart(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
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
                image = new Bitmap(image, new Size(70, 70));
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
            DataTable dtIDUser = OrderItemsController.IDUser_Find(UserName, PassWord).Tables[0];
            string IDUser = dtIDUser.Rows[0][0].ToString();

            string Roles = UserController.ShowRole(UserName).Tables[0].Rows[0][0].ToString();
            string DefaultAddress = "";
            string PhoneNumber = "";
            string FullName = "";
            if (Roles == "Seller")
            {
                DefaultAddress = "105 Đường 11, phường Tăng Nhơn Phú B, Quận 9, Thành phố Hồ Chí Minh";
                PhoneNumber = "0333963285";
                FullName = UserName;
            }
            else
            {
                DataTable dtAddress_User = OrderItemsController.All_Address_Show(IDUser, UserName, PassWord).Tables[0];
                foreach (DataRow dr in dtAddress_User.Rows)
                {
                    if (dr["IsDefault"].ToString() == "1")
                    {
                        DefaultAddress = dr["Street"].ToString() + ", " + dr["Ward"].ToString() + ", " + dr["District"].ToString() + ", " + dr["Province"].ToString();
                        PhoneNumber = dr["PhoneNumber"].ToString();
                        FullName = dr["FullName"].ToString();
                    }
                }
            }         
            frmShipping frmShip = new frmShipping(UserName, PassWord, DefaultAddress, PhoneNumber, FullName);
            frmShip.ShowDialog();
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn xóa " + ItemNameTemp + " khỏi giỏ hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                bool check = OrderItemsController.DeleteItem_Cart(UserName, PassWord, ItemNameTemp, ref err);
                if (check == true)
                {
                    MessageBox.Show("Bạn đã xóa " + ItemNameTemp + " khỏi giỏ hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtCart = OrderItemsController.ShowCart(UserName).Tables[0];
                    dtGVShoppingCart.Rows.Clear();
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
                        image = new Bitmap(image, new Size(70, 70));
                        string ItemName = dr["ItemName"].ToString();
                        string Description = dr["Description"].ToString();
                        string PaidPrice = dr["PaidPrice"].ToString();
                        string Orgin = dr["Orgin"].ToString();
                        string Quantity = dr["Quantity"].ToString();
                        dtGVShoppingCart.Rows.Add(image, ItemName, Description, PaidPrice, Orgin, Quantity);
                    }
                }
            }
        }

        private void dtGVShoppingCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNameTemp = dtGVShoppingCart.CurrentRow.Cells["colItemName"].Value.ToString();
        }

        private void dtGVShoppingCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float Quantity = float.Parse(this.dtGVShoppingCart.CurrentRow.Cells["colQuantity"].Value.ToString());
            string ItemName = this.dtGVShoppingCart.CurrentRow.Cells["colItemName"].Value.ToString();
            bool check = OrderItemsController.UpdateItem_Cart(UserName, PassWord, ItemName, Quantity, ref err);
            if (check == true)
            {
                MessageBox.Show("Bạn đã thay đổi số lượng món ăn " + ItemName + " là : " + Quantity, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn đã thay đổi số lượng món ăn " + ItemName + " thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
