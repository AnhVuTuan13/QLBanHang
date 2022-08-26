using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DAL_QL
    {
        private SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=LAPTOP-ODFCL5Q0;Initial Catalog=QLBANHANG;Integrated Security=True");
        }
        public DataTable getTable(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dt.Dispose();
            conn.Close();
            return tb;
        }
        //Thực thi câu lệnh
        public void ExcuteNonQuery(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand com = new SqlCommand(strsql, conn);
            com.ExecuteNonQuery();
            com.Dispose();
            com.Clone();
            conn.Close();
        }
        public string getString(string srtsql,string Colname)
        {
            string kq = "";
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(srtsql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                kq = dt[Colname].ToString();
            }
            conn.Close();
            return kq;
        }
    }
}
   