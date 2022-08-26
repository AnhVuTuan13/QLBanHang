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
    public class BUS_MainMeNu
    {
        DAL_QL dal = new DAL_QL();
        public List<String> TTNV(String mavn)
        {
            List<String> TTNV = new List<string>();
            String sql = string.Format("select *from NhanVien INNER JOIN CaLam on  NhanVien.MaCa=CaLam.MaCa  INNER JOIN CongViec ON CongViec.MaCV=NhanVien.MaCV Where MaNhanVien='{0}'", mavn);
            TTNV.Add(mavn);
            TTNV.Add(dal.getString(sql, "TenNhanVien"));
            TTNV.Add(dal.getString(sql, "GioiTinh"));
            TTNV.Add(dal.getString(sql, "TenCV"));
            TTNV.Add(dal.getString(sql, "TenCa"));
            return TTNV;
        }
       
    }
}
