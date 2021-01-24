using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class StatisticController
    {
        public static DataSet Sum_Revenue(string UserName, string PassWord, DateTime DateStart, DateTime DateEnd)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select dbo.Sum_Revenue('" + DateStart + "','" + DateEnd + "')", CommandType.Text);
        }
        public static DataSet Sum_QuantityRevenue(string UserName, string PassWord, DateTime DateStart, DateTime DateEnd)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select dbo.Sum_QuantityRevenue('" + DateStart + "','" + DateEnd + "')", CommandType.Text);
        }
        public static DataSet Statistic_Revenue(string UserName, string PassWord, DateTime DateStart, DateTime DateEnd)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select * from dbo.Statistic_Revenue('" + DateStart + "','" + DateEnd + "')", CommandType.Text);
        }
        public static DataSet Top5BestSeller()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.Top5BestSeller ()", CommandType.Text);
        }
        public static DataSet Top5Seller()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.Top5Seller ()", CommandType.Text);
        }
        public static DataSet Top5Customer()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.Top5Customer()", CommandType.Text);
        }
    }
}
