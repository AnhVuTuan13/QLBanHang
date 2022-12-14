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
    public class BUS_DonDHNCC
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String Ma, String MaNCC, String MaNV, String NgayDat, List<C_CTDonDH> DS)
        {
            String sqladdDH = "INSERT INTO DonDHNCC Values(N'{0}',N'{1}',N'{2}',N'{3}')";
            sqladdDH = string.Format(sqladdDH, Ma, MaNCC, MaNV ,NgayDat);
            dal.ExcuteNonQuery(sqladdDH);

            String sqlChiTiet = "INSERT INTO CTDonDHNCC Values(N'{0}',N'{1}',{2})";

            foreach (var item in DS)
            {
                String sql = String.Format(sqlChiTiet, Ma, item.MaHangHoa, item.SoLuong);
                dal.ExcuteNonQuery(sql);
            }
        }
        public DataTable loadcbNCC()
        {
            string sql = "Select MaNhaCC, CONCAT(MaNhaCC,' - ',TenNhaCC) as NhaCC from NhaCC";
            return dal.getTable(sql);
        }
        public DataTable loadcbNV()
        {
            string sql = "Select MaNhanVien, CONCAT(MaNhanVien,' - ',TenNhanVien) as NhanVien from NhanVien ";
            
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
    }
}
