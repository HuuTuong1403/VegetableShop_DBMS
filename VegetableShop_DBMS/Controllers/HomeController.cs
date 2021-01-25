using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class HomeController
    {
        public static DataSet ShowItem(string UserName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select ItemName, SalePrice, Image from Items", CommandType.Text);
        }
        public static DataSet PriceItem(string ItemName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select SalePrice from Items where Items.ItemName = N'" + ItemName + "'", CommandType.Text);
        }
        public static DataSet FindItems_ItemName(string ItemName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.FindItems_ItemName(N'" + ItemName + "')", CommandType.Text);
        }
        public static DataSet FindItems_Category (string Category)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.FindItems_Category(N'" + Category + "')", CommandType.Text);
        }
        public static DataSet FindItems_SubCategory (string SubCategory)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.FindItems_SubCategory(N'" + SubCategory + "')", CommandType.Text);
        }
    }
}
