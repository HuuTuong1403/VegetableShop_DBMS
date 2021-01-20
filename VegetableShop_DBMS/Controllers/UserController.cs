using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;


namespace VegetableShop_DBMS.Controllers
{
    class UserController
    {
        public static DataSet ImageUser(string UserName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select Users.Image from Users where Users.UserName = N'" + UserName + "'", CommandType.Text);
        }
        public static DataSet User_Infor(string UserName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select UserName,FullName,Gender,DateofBirth,PhoneNumber,Email,Image from Users where Users.UserName = N'" + UserName + "'", CommandType.Text);
        }
        //    @UserName nvarchar(50),@FullName nvarchar(50),
        //@Gender nvarchar(10),
        //@DateofBirth date,
        //                        @PhoneNumber varchar(20),
        //@Email nvarchar(MAX),
        //@Image nvarchar(MAX)
        public static bool EditUser(string UserName, string FullName, string Gender,DateTime DateorBirth, 
                                    string PhoneNumber, string Email, string Image, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("exec EditUser N'" + UserName + "',N'" + FullName + "',N'" + Gender +
            "','" + DateorBirth + "',N'" + PhoneNumber + "',N'" + Email + "',N'" + Image + "'",CommandType.Text, ref err);
        }
    }
}
