using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_XemCTDonDH
    {
        DAL_QL dal = new DAL_QL();
        public DataTable loadDGV(String Ma)
        {
            string sql = "select HangHoa.MaHangHoa,TenHangHoa,CTDonDH.SoLuong, TenDonViTinh from CTDonDH,HangHoa,DonViTinh  " +
                "where CTDonDH.MaHangHoa=HangHoa.MaHangHoa and HangHoa.MaDonViTinh=DonViTinh.MaDonViTinh and MaDonDH='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getTable(sql);
        }
        public string loadKH(string Ma)
        {
            string sql = "Select  CONCAT(MaKH,' - ',TenKH) as KhachHang from KhachHang  where MaKH='{0}'";
            sql = string.Format(sql, Ma);
            return dal.getString(sql, "KhachHang");
        }
    }
}
