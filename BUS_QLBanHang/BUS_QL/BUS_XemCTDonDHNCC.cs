using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_XemCTDonDHNCC
    {
        DAL_QL dal = new DAL_QL();
        public DataTable loadDGV(String Ma)
        {
            string sql = "select HangHoa.MaHangHoa,TenHangHoa,CTDonDHNCC.SoLuong, TenDonViTinh from CTDonDHNCC,HangHoa,DonViTinh " +
                "where CTDonDHNCC.MaHangHoa=HangHoa.MaHangHoa and HangHoa.MaDonViTinh=DonViTinh.MaDonViTinh and MaDonDHNCC='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getTable(sql);
        }
        public string loadNhaCC(string Ma)
        {
            string sql = "Select  CONCAT(MaNhaCC,' - ',TenNhaCC) as NhaCC from NhaCC  where MaNhaCC='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getString(sql, "NhaCC");
        }
        public string loadNV(string Ma)
        {
            string sql = "Select  CONCAT(MaNhanVien,' - ',TenNhanVien) as NhanVien from NhanVien  where MaNhanVien='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getString(sql, "NhanVien");
        }
    }
}
