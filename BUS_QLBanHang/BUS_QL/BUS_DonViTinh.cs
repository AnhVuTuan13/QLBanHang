using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_DonViTinh
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select*from DonViTinh";
            return dal.getTable(sql);
        }
        public DataTable Search(String search)
        {
            String sql = "Select*from DonViTinh Where MaDonViTinh like N'%{0}%' or TenDonViTinh like N'%{1}%'";
            sql = string.Format(sql, search, search);
            return dal.getTable(sql);
        }
        public void Delete(String MaC)
        {
            String sql = "DeleTe DonViTinh Where MaDonViTinh ='{0}'";
            sql = string.Format(sql, MaC);
            dal.ExcuteNonQuery(sql);
        }
    }
}
