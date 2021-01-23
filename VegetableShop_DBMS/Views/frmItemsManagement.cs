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
        public frmItemsManagement()
        {
            InitializeComponent();
            Image image;
            DataTable dtItemsManagement = ManagementController.ItemsManagement().Tables[0];
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
    }
}
