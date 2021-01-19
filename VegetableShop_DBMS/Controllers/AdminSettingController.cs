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
        public static bool Register_Seller(string UserName, string PassWord, string FullName, string Gender, DateTime DateofBirth,
            string PhoneNumber, string Email, string Image, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("execute RegisterSeller N'" + UserName + "',N'" + PassWord + "',N'" + FullName + "',N'" + Gender + "',N'" + DateofBirth + "',N'" + PhoneNumber + "',N'" + Email + "',N'" + Image + "'", CommandType.Text, ref err);
        }
        public static bool AddItems(string ItemName, float ImportPrice, float SalePrice, string Description, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("execute AddItems N'" + ItemName + "'," + ImportPrice + " , " + SalePrice + " , N'" + Description + "'", CommandType.Text, ref err);
        }
        //public static DataSet IDDistrict_Find(string DistrictName)
        //{
        //    Database_VegetableShop _db = new Database_VegetableShop();
        //    return _db.ExecuteQueryDataSet("select District.Id from District where District.Name = N'" + DistrictName + "'", CommandType.Text);
        //}
        //public static DataSet District_Show(int Id)
        //{
        //    Database_VegetableShop _db = new Database_VegetableShop();
        //    return _db.ExecuteQueryDataSet("select District.Type + ' ' + District.Name as DistrictName from District where District.ProvinceId = N'" + Id + "'", CommandType.Text);
        //}
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
    }
}
