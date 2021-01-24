using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class ManagementController
    {
        public static DataSet UserManagement()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from UserManagement", CommandType.Text);
        }
        public static bool DeleteUser(string UserNameUser, string UserName, string PassWord, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.MyExecuteNonQuery("exec DeleteUser N'" + UserNameUser + "'", CommandType.Text, ref err);
        }
        public static DataSet ItemsManagement(string UserName, string PassWord)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select * from ItemsManagement", CommandType.Text);
        }
        public static DataSet ImportDetailsManagement(string UserName, string PassWord)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select * from ImportDetailsManagement", CommandType.Text);
        }
        public static DataSet OrderManagement(string UserName, string PassWord,  string OrderStateName)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select * from dbo.OrderManagement (N'" + UserName + "',N'" + OrderStateName + "')", CommandType.Text);
        }
        public static DataSet OrderManagementDetail(string UserName, string PassWord, string IDBill)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select * from dbo.OrderManagementDetail (N'" + IDBill + "')", CommandType.Text);
        }
        public static bool ChangeState(string UserName, string PassWord, string IDBill, string OrderStateName, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.MyExecuteNonQuery("exec ChangeState N'" + UserName + "', N'" + IDBill + "',N'" + OrderStateName + "'", CommandType.Text, ref err);
        }
        public static DataSet ShowCountOrder(string UserName, string PassWord, string OrderStateName)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.ExecuteQueryDataSet("select dbo.CountOrder(N'" + UserName + "',N'" + OrderStateName+"')", CommandType.Text);
        }
    }
}
