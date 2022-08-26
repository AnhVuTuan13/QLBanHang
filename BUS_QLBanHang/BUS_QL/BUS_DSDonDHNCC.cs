using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_DSDonDHNCC
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select*from DonDHNCC";
            return dal.getTable(sql);
        }
        public void Delete(String MaC)
        {
            String sql = "DeleTe DonDHNCC Where MaDonDHNCC ='{0}'";
            sql = string.Format(sql, MaC);
            dal.ExcuteNonQuery(sql);
        }
        public DataTable Search(String search)
        {
            String sql = "Select*from DonDHNCC Where MaDonDHNCC like N'%{0}%' or MaNhanVien like N'%{0}%' or MaNhaCC like N'%{0}%' or NgayDat like N'%{0}%'";
            sql = string.Format(sql, search);
            return dal.getTable(sql);
        }
    }
}
