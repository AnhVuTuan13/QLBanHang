using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_HangHoa
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String Ma, string Ten ,String DGNhap, String DGBan, String SL,String GhiChu, String MaNSX, String MaNhomHang, String MaDonViTinh )
        {
            string sql = "Insert into HangHoa Values('{0}',N'{1}',{2},{3},{4},N'{5}',N'{6}',N'{7}',N'{8}')";
            sql = string.Format(sql, Ma, Ten,DGNhap,DGBan,SL,GhiChu,MaNSX,MaNhomHang,MaDonViTinh);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String Ma, string Ten, String DGNhap, String DGBan, String SL, String GhiChu, String MaNSX, String MaNhomHang, String MaDonViTinh)
        {
            string sql = "UPDATE  HangHoa SET TenHangHoa=N'{1}',DonGiaNhap={2}," +
                "DonGiaBan={3},SoLuong={4}, GhiChu=N'{5}',MaNuocSX=N'{6}',MaNhomHang=N'{7}'," +
                "MaDonViTinh=N'{8}'  WHERE MaHangHoa='{0}'";
            sql = string.Format(sql, Ma, Ten, DGNhap, DGBan, SL, GhiChu, MaNSX, MaNhomHang, MaDonViTinh);
            dal.ExcuteNonQuery(sql);
        }
        public DataTable LoadCbNuocSX()
        {
            string sql = "Select MaNuocSX ,TenNuocSX " +
                "from NuocSX";
            return dal.getTable(sql);
        }
        public DataTable LoadCbNhomHang()
        {
            string sql = "Select *from NhomHang";
            return dal.getTable(sql);
        }
        public DataTable LoadCbDonViTinh()
        {
            string sql = "Select *from DonViTinh";
            return dal.getTable(sql);
        }
    }
}
