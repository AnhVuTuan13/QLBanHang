using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_CongViec
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String MaCV, string TenCV)
        {
            string sql = "Insert into CongViec Values('{0}',N'{1}')";
            sql = string.Format(sql, MaCV, TenCV);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String MaCV, string TenCV)
        {
            string sql = "UPDATE  CongViec SET TenCV=N'{1}'  WHERE MaCV='{0}'";
            sql = string.Format(sql, MaCV, TenCV);
            dal.ExcuteNonQuery(sql);
        }
    }
}
