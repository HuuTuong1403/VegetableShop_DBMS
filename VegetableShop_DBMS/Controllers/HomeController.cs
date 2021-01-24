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

    }
}
