using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_KhachHang
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select*from KhachHang";
            return dal.getTable(sql);
        }
        public DataTable Search(String search)
        {
            String sql = "Select*from KhachHang Where MaKH like N'%{0}%' or TenKH like N'%{0}%' or DiaChi like N'%{0}%' or DienThoai like N'%{0}%'";
            sql = string.Format(sql, search);
            return dal.getTable(sql);
        }
        public void Delete(String MaC)
        {
            String sql = "DeleTe KhachHang Where MaKH ='{0}'";
            sql = string.Format(sql, MaC);
            dal.ExcuteNonQuery(sql);
        }
    }
}
