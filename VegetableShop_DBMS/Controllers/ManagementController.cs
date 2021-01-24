﻿using System;
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
        public static bool DeleteUser(string UserName, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("exec DeleteUser N'" + UserName + "'", CommandType.Text, ref err);
        }
        public static DataSet ItemsManagement()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from ItemsManagement", CommandType.Text);
        }
        public static DataSet ImportDetailsManagement()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from ImportDetailsManagement", CommandType.Text);
        }
        public static DataSet OrderManagement(string UserName, string OrderStateName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select * from dbo.OrderManagement('N" + UserName + "',N'" + OrderStateName + "')",CommandType.Text);
        }
    }
}