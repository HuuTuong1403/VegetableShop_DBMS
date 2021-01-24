using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;


namespace VegetableShop_DBMS.Controllers
{
    class AdminSettingController
    {
        public static bool Register_Seller(string UserName, string UserNameSeller, string PassWord, string PassWordSeller, string FullName, string Gender, DateTime DateofBirth,
            string PhoneNumber, string Email, string Image, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.MyExecuteNonQuery("execute RegisterSeller N'" + UserNameSeller + "',N'" + PassWordSeller + "',N'" + FullName + "',N'" + Gender + "',N'" + DateofBirth + "',N'" + PhoneNumber + "',N'" + Email + "',N'" + Image + "'", CommandType.Text, ref err);
        }
        public static DataSet Category_Show ()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select Category.CategoryName as CategoryName from Category", CommandType.Text);
        }
        public static DataSet IDCategory_Find(string CategoryName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select dbo.IDCategory_Find(N'" + CategoryName + "')", CommandType.Text);
        }
        public static DataSet SubCategory_Show(string IDCategory)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select SubCategory.SubCategoryName as SubCategoryName from SubCategory where SubCategory.IDCategory = '" + IDCategory + "'", CommandType.Text);
        }
        public static DataSet IDSubCategory_Find(string SubCategoryName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select IDSubCategory from SubCategory where SubCategory.SubCategoryName = N'" + SubCategoryName + "'", CommandType.Text);
        }
        public static bool AddItem(string UserName, string PassWord, string ItemName, float ImportPrice, float SalePrice, string Description, string Orgin,
                                    string IDCategory, string IDSubcategory, string Image, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.MyExecuteNonQuery("exec AddItems N'" + ItemName + "'," + ImportPrice + "," + SalePrice + ",N'" + Description +
                "',N'" + Orgin + "',N'" + IDCategory + "',N'" + IDSubcategory + "',N'" + Image + "'", CommandType.Text, ref err);
        }
    }
}
