using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controllers;

namespace VegetableShop_DBMS.Views
{
    public partial class frmAddItem : Form
    {
        string ItemImageName = "";
        string err = "";
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CategoryName = cbbCategory.SelectedItem.ToString();

            DataTable dtIDCategory = AdminSettingController.IDCategory_Find(CategoryName).Tables[0];
            string IDCategory = dtIDCategory.Rows[0][0].ToString();

            DataTable dtSubCategory = AdminSettingController.SubCategory_Show(IDCategory).Tables[0];
            cbbSubCategory.Items.Clear();
            foreach (DataRow dr in dtSubCategory.Rows)
            {
                string SubCategoryName = dr["SubCategoryName"].ToString();
                cbbSubCategory.Items.Add(SubCategoryName);
            }

        }

        private void cbbCategory_Click(object sender, EventArgs e)
        {

            DataTable dt = AdminSettingController.Category_Show().Tables[0];
            cbbCategory.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string temp = dr["CategoryName"].ToString();
                cbbCategory.Items.Add(temp);
            }
        }

        private void btnChooseImageItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select a Image";
            openFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ItemImageName = openFile.SafeFileName;
                string filepath = openFile.FileName;
                string fileName = appPath + ItemImageName;
                if (File.Exists(fileName) == false)
                {
                    File.Copy(filepath, fileName);
                    ptBImageProduct.Image = new Bitmap(fileName);
                }
                else
                {
                    MessageBox.Show("Hình ảnh bạn chọn bị trùng. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            string ItemName = txtItemName.Text.Trim();
            float ImportPrice = float.Parse(txtImportPrice.Text.Trim());
            float SalePrice = float.Parse(txtSalePrice.Text.Trim());
            string Description = txtDescription.Text.Trim();
            string Orgin = txtOrgin.Text.Trim();
            string Image = ItemImageName;
            string CategoryName = cbbCategory.SelectedItem.ToString();
            DataTable dtIDCategory = AdminSettingController.IDCategory_Find(CategoryName).Tables[0];
            string IDCategory = dtIDCategory.Rows[0][0].ToString();
            string SubCategoryName = cbbSubCategory.SelectedItem.ToString();
            DataTable dtIDSubcategory = AdminSettingController.IDSubCategory_Find(SubCategoryName).Tables[0];
            string IDSubCategory = dtIDSubcategory.Rows[0][0].ToString();

            //bool check = SignUpController.Register_Customer(UserName, PassWord, FullName, Gender, 
            //    DateofBirth, PhoneNumber, Email, Image, Province, District, Ward, Street, ref err);
            bool check = AdminSettingController.AddItem(ItemName, ImportPrice, SalePrice, Description, Orgin, IDCategory, IDSubCategory, Image, ref err);
            if (check == true)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn đã thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    txtItemName.Clear();
                    txtImportPrice.Clear();
                    txtSalePrice.Clear();
                    txtDescription.Clear();
                    txtOrgin.Clear();
                    cbbCategory.Items.Clear();
                    cbbCategory.Text = "Chọn loại";
                    cbbSubCategory.Items.Clear();
                    cbbSubCategory.Text = "Chọn danh mục";
                    ptBImageProduct.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại, xin thử lại lần nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
