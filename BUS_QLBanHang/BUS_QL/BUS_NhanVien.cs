using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_NhanVien
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DienThoai, DiaChi, CongViec.TenCV, CaLam.TenCa, GhiChu " +
                "from NhanVien inner join CongViec on CongViec.MaCV=NhanVien.MaCV " +
                "inner join CaLam On CaLam.MaCa=NhanVien.MaCa";
            return dal.getTable(sql);
        }
        public DataTable Search(String search)
        {
            String sql = "Select MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DienThoai, DiaChi, CongViec.TenCV, CaLam.TenCa, GhiChu" +
                "from NhanVien inner join CongViec on CongViec.MaCV=NhanVien.MaCV " +
                "inner join CaLam On CaLam.MaCa=NhanVien.MaCa" +
                "Where MaNhanVien like '{0}' or  TenNhanVien like N'{0}' or  GioiTinh like N'{0}'  or  NgaySinh like N'{0}'  or  DienThoai like N'{0}' " +
                "or  DiaChi like N'{0}'  or  TenCV like N'{0}'  or  TenCa like N'{0}'  or  GhiChu like N'{0}'";
            sql = string.Format(sql, search);
            return dal.getTable(sql);
        }
        public void Delete(String Ma)
        {
            String sql = "DeleTe NhanVien Where MaNhanVien ='{0}'";
            sql = string.Format(sql, Ma);
            dal.ExcuteNonQuery(sql);
        }
    }
}
