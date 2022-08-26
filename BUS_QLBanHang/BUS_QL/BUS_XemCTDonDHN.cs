using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_XemCTDonDHN
    {
        DAL_QL dal = new DAL_QL();
        public DataTable loadDGV(String Ma)
        {
            string sql = "select HangHoa.MaHangHoa,TenHangHoa, CTHoaDonN.SoLuong,TenDonViTinh,DonGiaBan,ThanhTien" +
                " from CTHoaDonN inner join HangHoa On CTHoaDonN.MaHangHoa=HangHoa.MaHangHoa inner join " +
                "  DonViTinh ON  DonViTinh.MaDonViTinh=HangHoa.MaDonViTinh  where CTHoaDonN.MaHDN='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getTable(sql);
        }
        public string loadNCC(string Ma)
        {
            string sql = "Select  CONCAT(MaNhaCC,' - ',TenNCC) as NhaCC from NhaCC  where MaNhaCC='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getString(sql, "KhachHang");
        }
        public string loadNV(string Ma)
        {
            string sql = "Select  CONCAT(MaNhanVien,' - ',TenNhanVien) as NhanVien from NhanVien  where MaNhanVien='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getString(sql, "NhanVien");
        }
    }
}
