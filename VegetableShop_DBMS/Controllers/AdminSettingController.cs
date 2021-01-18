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
            return _db.MyExecuteNonQuery("execute AddItems N'" + ItemName + "'," + ImportPrice + " , " + SalePrice + " , N'" + Description + "'", CommandType.Text, ref err)
        }
    }
}
