using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VegetableShop_DBMS.Models
{
    class Database_VegetableShop
    {
        //string strConnectionString = "Data Source=DESKTOP-30KMJ3I;Initial Catalog=Database_VegetableStore;Integrated Security=True";
        string strConnectionString = "Data Source=DESKTOP-ID9RBP3;Initial Catalog=Database_VegetableStore;IntegratedSecurity=True";

        //Tạo kết nối
        SqlConnection conn = null;
        //Bộ chuyển đổi
        SqlDataAdapter da = null;
        //Tạo lệnh
        SqlCommand comm = null;
        
        public Database_VegetableShop ()
        {
            //Khởi động connection
            conn = new SqlConnection(strConnectionString);
            //Lệnh gọi để tạo các câu lệnh truy xuất
            comm = conn.CreateCommand();
        }
        public Database_VegetableShop(string tk, string mk)
        {
            if (tk != null && mk != null)
            {
                strConnectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=DoanDBMS;User ID=" + tk + ";Password=" + mk + ";";
            }
            //Gán chuỗi kết nối để kết nối với SQL sever
            conn = new SqlConnection(strConnectionString);
            //Lệnh gọi để tạo các câu lệnh truy xuất
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            //Nếu đã có kết nối thì đóng nó lại
            if (conn.State == ConnectionState.Open)
                conn.Close();
            //Mở kết nối
            conn.Open();
            //Gán câu lệnh  
            comm.CommandText = strSQL;
            //Chọn loại lệnh 
            comm.CommandType = ct;
            //Tạo bộ chuyển đổi
            da = new SqlDataAdapter(comm);

            //Tạo Dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu vào da
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            //Cờ lỗi
            bool f = false;
            //Nếu đã có kết nối thì đóng nó lại
            if (conn.State == ConnectionState.Open)
                conn.Close();
            //Mở kết nối
            conn.Open();
            //Gán câu lệnh 
            comm.CommandText = strSQL;
            //Chọn loại lệnh 
            comm.CommandType = ct;
            try
            {
                //Nếu chương trình chạy bình thường thì cờ được gán là True
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                //Trường hợp lỗi sẽ bắt lỗi
                error = ex.Message;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return f;
        }
    }
}
