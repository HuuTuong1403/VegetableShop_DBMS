using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShop_DBMS.Models;

namespace VegetableShop_DBMS.Controllers
{
    class SignUpController
    {
        public static DataSet Province_Show ()
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select Province.Type + ' ' + Province.Name as ProvinceName from Province", CommandType.Text);
        }
        public static DataSet IDProvince_Find(string ProvinceName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select dbo.IDProvince_Find(N'"+ProvinceName+"')", CommandType.Text);
        }
        public static DataSet IDDistrict_Find(string DistrictName)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select District.Id from District where District.Name = N'"+DistrictName+"'", CommandType.Text);
        }
        public static DataSet District_Show(int Id)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select District.Type + ' ' + District.Name as DistrictName from District where District.ProvinceId = N'"+Id+"'", CommandType.Text);
        }
        public static DataSet Ward_Show(int Id)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.ExecuteQueryDataSet("select Ward.Type + ' ' + Ward.Name as WardName from Ward where Ward.DistrictID = N'" +Id+ "'", CommandType.Text);
        }
        public static bool Register_Customer (string UserName, string PassWord, string FullName, string Gender, DateTime DateofBirth, 
            string PhoneNumber, string Email, string Image, string Province, string District, string Ward, string Street, ref string err)
        {
            Database_VegetableShop _db = new Database_VegetableShop();
            return _db.MyExecuteNonQuery("execute RegisterCustomer N'" + UserName + "',N'" + PassWord + "',N'" + FullName + "',N'" + Gender + "',N'" + DateofBirth + "',N'" + PhoneNumber + "',N'" + Email + "',N'" + Image + "',N'" + Province + "',N'" + District + "',N'" + Ward + "',N'" + Street + "'", CommandType.Text, ref err);
        }
    }
}
