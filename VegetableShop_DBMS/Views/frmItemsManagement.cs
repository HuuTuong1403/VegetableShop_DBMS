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
    public partial class frmItemsManagement : Form
    {
        public string UserName;
        public string PassWord;
        public string ItemName;
        string err = "";
        public frmItemsManagement(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
            Image image;
            DataTable dtItemsManagement = ManagementController.ItemsManagement(UserName, PassWord).Tables[0];
            foreach(DataRow dr in dtItemsManagement.Rows)
            {
                string ItemName = dr["ItemName"].ToString();
                string ImportPrice = dr["ImportPrice"].ToString();
                string SalePrice = dr["SalePrice"].ToString();
                string Description = dr["Description"].ToString();
                string Origin = dr["Origin"].ToString();
                string CategoryName = dr["CategoryName"].ToString();
                string SubCategoryName = dr["SubCategoryName"].ToString();
                string Quantity = dr["Quantity"].ToString();
                string ImageTemp = dr["Image"].ToString();
                string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
                string FileName = appPath + ImageTemp;
                image = Image.FromFile(FileName);
                image = new Bitmap(image, new Size(70, 70));
                dtGVItemsManagement.Rows.Add(ItemName, ImportPrice, SalePrice, Description, Origin, CategoryName, SubCategoryName, Quantity, image);
            }
        }
        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            bool check = ManagementController.DeleteItem(UserName, PassWord, ItemName, ref err);
            if (check == true)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn xóa  " + ItemName + " thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Image image;
                    DataTable dtItemsManagement = ManagementController.ItemsManagement(UserName, PassWord).Tables[0];
                    foreach (DataRow dr in dtItemsManagement.Rows)
                    {
                        string ItemName = dr["ItemName"].ToString();
                        string ImportPrice = dr["ImportPrice"].ToString();
                        string SalePrice = dr["SalePrice"].ToString();
                        string Description = dr["Description"].ToString();
                        string Origin = dr["Origin"].ToString();
                        string CategoryName = dr["CategoryName"].ToString();
                        string SubCategoryName = dr["SubCategoryName"].ToString();
                        string Quantity = dr["Quantity"].ToString();
                        string ImageTemp = dr["Image"].ToString();
                        string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
                        string FileName = appPath + ImageTemp;
                        image = Image.FromFile(FileName);
                        image = new Bitmap(image, new Size(70, 70));
                        dtGVItemsManagement.Rows.Add(ItemName, ImportPrice, SalePrice, Description, Origin, CategoryName, SubCategoryName, Quantity, image);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã xóa món ăn khỏi hệ thống KHÔNG thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGVItemsManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemName = dtGVItemsManagement.CurrentRow.Cells["clItemName"].Value.ToString();
        }
    }
}
