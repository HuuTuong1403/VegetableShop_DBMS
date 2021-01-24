using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;


namespace VegetableShop_DBMS.Controllers
{
    class SellerSettingController
    {
        public static DataSet Items_Show(string UserName, string PassWord)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName,PassWord);
            return _db.ExecuteQueryDataSet("select Items.ItemName as ItemName from Items", CommandType.Text);
        }
        public static bool ImportItems(string ItemName, string UserName, string PassWord, float Quantity, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop(UserName, PassWord);
            return _db.MyExecuteNonQuery("exec ImportItems N'" + ItemName + "',N'" + UserName + "'," + Quantity, CommandType.Text, ref err);
        }
    }
}
