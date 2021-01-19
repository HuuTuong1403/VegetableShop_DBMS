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
    public partial class frmAddItem : Form
    {
        string ItemImageName = "";
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
            string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Image\imagesProduct";
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Title = "Select a Image";
            //openFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            //string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
            //if (Directory.Exists(appPath) == false)
            //{
            //    Directory.CreateDirectory(appPath);
            //}
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    iName = openFile.SafeFileName;
            //    string filepath = openFile.FileName;
            //    string fileName = appPath + iName;
            //    if (File.Exists(fileName) == false)
            //    {
            //        File.Copy(filepath, fileName);
            //        ptBImageUser.Image = new Bitmap(fileName);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Hình ảnh bạn chọn bị trùng. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}
