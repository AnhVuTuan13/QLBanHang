using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
using BUS_QLBanHang.Entity;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_BanHang
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String Ma, String KH,String MaNV, String NgayDat, String TongTien, List<C_CTHoaDB> DS)
        {
            String sqladdDH = "INSERT INTO HoaDonB Values(N'{0}',N'{1}',N'{2}',N'{3}',{4})";
            sqladdDH = string.Format(sqladdDH, Ma, KH, MaNV,NgayDat, TongTien);
            dal.ExcuteNonQuery(sqladdDH);

            String sqlChiTiet = "INSERT INTO CTHoaDonB Values(N'{0}',N'{1}',{2},{3})";

            foreach (var item in DS)
            {
                String sql = String.Format(sqlChiTiet, Ma, item.MaHangHoa, item.SoLuong,item.ThanhTien());
                dal.ExcuteNonQuery(sql);
            }
        }
        public DataTable loadcbKH()
        {
            string sql = "Select MaKH, CONCAT(MaKH,' - ',TenKH) as KhachHang from KhachHang";
            return dal.getTable(sql);
        }

        public DataTable loadcbSP()
        {
            string sql = "Select MaHangHoa, CONCAT(MaHangHoa,' - ',TenHangHoa) as SanPham from HangHoa";
            return dal.getTable(sql);
        }
        public string getDVT(string MaSP)
        {
            String sql = "select *from HangHoa ,DonViTinh where HangHoa.MaDonViTinh= DonViTinh.MaDonViTinh and MaHangHoa ='{0}'";
            sql = string.Format(sql, MaSP);
            return dal.getString(sql, "TenDonViTinh");
        }
        public string getDGB(string MaSP)
        {
            String sql = "select * from HangHoa ,DonViTinh where HangHoa.MaDonViTinh= DonViTinh.MaDonViTinh and MaHangHoa ='{0}'";
            sql = string.Format(sql, MaSP);
            return dal.getString(sql, "DonGiaBan");
        }
        public DataTable loadcbNV()
        {
            string sql = "Select MaNhanVien, CONCAT(MaNhanVien,' - ',TenNhanVien) as NhanVien from NhanVien";
            return dal.getTable(sql);
        }
    }
}
