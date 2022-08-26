using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class Bus_TaiKhoan
    {

        DAL_QL dal = new DAL_QL();
        public  DataTable loadTaiKhoan()
        {
            String sql = "Select Username , Password, (case when PhanQuyen = 'true' or PhanQuyen = 1 then 'Admin'" +
                "when PhanQuyen = 'false' or PhanQuyen = 0 then 'NhanVien' end ) as PhanQuyen,	 CONCAT(tb_User.MaNhanVien ,' - ' ,TenNhanVien) AS NhanVien " +
                "from tb_User inner join NhanVien on tb_User.MaNhanVien=NhanVien.MaNhanVien";
            return dal.getTable(sql);
        }
        public DataTable loadSearch(string mavn)
        {
            String sql = "Select Username , Password, (case when PhanQuyen = 'true' or PhanQuyen = 1 then 'Admin'" +
                "when PhanQuyen = 'false' or PhanQuyen = 0 then 'NhanVien' end ) as PhanQuyen,	 CONCAT(tb_User.MaNhanVien ,' - ' ,TenNhanVien) AS NhanVien " +
                "from tb_User inner join NhanVien on tb_User.MaNhanVien=NhanVien.MaNhanVien Where TenNhanVien like N'%{0}%' or tb_User.MaNhanVien like N'%{1}%'";
            sql = string.Format(sql, mavn,mavn);
            return dal.getTable(sql);
        }
    }
}
