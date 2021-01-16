using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class SignInController
    {
        public static DataSet SignIn(string UserName, string PassWord)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select dbo.SignIn(N'" + UserName + "',N'" + PassWord + "')", CommandType.Text);
        }
    }
}
