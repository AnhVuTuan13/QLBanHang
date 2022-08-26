using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_CTHoaDonB
    {
        DAL_QL dal = new DAL_QL();
        public DataTable loadDGV(String Ma)
        {
            string sql = "select HangHoa.MaHangHoa,TenHangHoa, CTHoaDonB.SoLuong,TenDonViTinh,DonGiaBan,ThanhTien  " +
                "from CTHoaDonB inner join HangHoa On CTHoaDonB.MaHangHoa=HangHoa.MaHangHoa inner join " +
                "DonViTinh ON  DonViTinh.MaDonViTinh=HangHoa.MaDonViTinh  where CTHoaDonB.MaHDB='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getTable(sql);
        }
        public string loadKH(string Ma)
        {
            string sql = "Select  CONCAT(MaKH,' - ',TenKH) as KhachHang from KhachHang  where MaKH='{0}'";
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
