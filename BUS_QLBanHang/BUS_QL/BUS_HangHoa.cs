using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_HangHoa
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "select MaHangHoa , TenHangHoa, DonGiaNhap, DonGiaBan, SoLuong ,NuocSX.TenNuocSX," +
                "NhomHang.TenNhomHang,DonViTinh.TenDonViTinh ,GhiChu  from HangHoa, NuocSX, NhomHang, DonViTinh" +
                " where HangHoa.MaNuocSX=NuocSX.MaNuocSX and HangHoa.MaDonViTinh=DonViTinh.MaDonViTinh and HangHoa.MaNhomHang=NhomHang.MaNhomHang";
            return dal.getTable(sql);
        }
        public DataTable Search(String search)
        {
            String sql = "select MaHangHoa , TenHangHoa, DonGiaNhap, DonGiaBan, SoLuong ,NuocSX.TenNuocSX," +
                 "NhomHang.TenNhomHang,DonViTinh.TenDonViTinh ,GhiChu  from HangHoa, NuocSX, NhomHang, DonViTinh" +
                 " where HangHoa.MaNuocSX=NuocSX.MaNuocSX and HangHoa.MaDonViTinh=DonViTinh.MaDonViTinh and HangHoa.MaNhomHang=NhomHang.MaNhomHang" +
                 " WHERE MaHangHoa LIKE N'%{0}%' or TenHangHoa LIKE N'%{0}%' or  DonGiaNhap LIKE '%{0}%' or  DonGiaBan LIKE '%{0}%' or  " +
                 " SoLuong LIKE '%{0}%' or  NuocSX.TenNuocSX LIKE N'%{0}%' or  NhomHang.TenNhomHang LIKE N'%{0}%' or  " +
                 " DonViTinh.TenDonViTinh LIKE N'%{0}%' or  GhiChu LIKE N'%{0}%' or  HangHoa.MaNuocSX LIKE N'%{0}%' or " +
                 " HangHoa.MaNhomHang LIKE N'%{0}%' or HangHoa.MaDonViTinh LIKE N'%{0}%' ";

            sql = string.Format(sql, search);
            return dal.getTable(sql);
        }
        public void Delete(String MaC)
        {
            String sql = "DeleTe HangHoa Where MaHangHoa ='{0}'";
            sql = string.Format(sql, MaC);
            dal.ExcuteNonQuery(sql);
        }
    }
}
