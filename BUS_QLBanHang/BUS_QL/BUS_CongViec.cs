using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_CongViec
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select*from CongViec";
            return dal.getTable(sql);
        }
        public DataTable SearchCV(String search)
        {
            String sql = "Select*from CongViec Where MaCV like '%{0}%' or TenCV like N'%{1}%' ";
            sql = string.Format(sql, search, search);
            return dal.getTable(sql);
        }
        public void DeleteCV(String MaCV)
        {
            String sql = "DeleTe CongViec Where MaCV ='{0}'";
            sql = string.Format(sql, MaCV);
            dal.ExcuteNonQuery(sql);
        }
    }
}
