using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class OrderItemsController
    {
        public static DataSet IDUser_Find(string UserName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select IDUser from Users where Users.Username = N'" + UserName + "'", CommandType.Text);
        }
        public static bool Add_AddressForUser(string IDUser, string Province, string District, string Ward, string Street, string PhoneNumber, string FullName, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("exec AddAddressForUser N'" + IDUser + "',N'" + Province + "',N'" + District + "',N'" + Ward + "',N'" + Street + "',N'" + PhoneNumber + "',N'" + FullName + "'", CommandType.Text, ref err);
        }
        public static DataSet All_Address_Show(string IDUser)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select *  from Address_Users where IDUser = N'" + IDUser + "'", CommandType.Text);
        }
        public static bool AddCart(string UserName, string ItemName, float SalePrice, float Quantity, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("exec AddCart N'" + UserName + "',N'" + ItemName + "'," + SalePrice + ", " + Quantity, CommandType.Text, ref err);
        }
        public static DataSet ShowCart(string UserName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.ShowCart(N'" + UserName + "')", CommandType.Text);
        }
        public static bool OrderItem (string UserName, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("exec OrderItem N'" + UserName + "'", CommandType.Text, ref err);
        }
    }
}
