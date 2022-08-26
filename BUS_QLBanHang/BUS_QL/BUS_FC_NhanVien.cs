using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_NhanVien
    {
        DAL_QL dal = new DAL_QL();
        public DataTable loadCbCongViec()
        {
            string sql = "Select MaCV ,TenCV " +
                "from CongViec";
            return dal.getTable(sql);
        }
        public DataTable loadCbCaLam()
        {
            string sql = "Select MaCa, TenCA  " +
                "from CaLam";
            return dal.getTable(sql);
        }
        public void Add(String Ma, string Ten, String GioiT, String NgaySinh, String DienThoai, String DiaChi, String MaCV , String MaCa ,String ghiChu)
        {
            string sql = "Insert into NhanVien Values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')";
            sql = string.Format(sql,Ma, Ten,GioiT,NgaySinh,DienThoai,DiaChi,ghiChu,MaCV,MaCa);
            dal.ExcuteNonQuery(sql);
        }
        public void createAccount(String UserN, String MaNV)
        {
            string sql = "Insert Into tb_User Values('{0}','12345', 0 ,'{1}')";
            sql = string.Format(sql, UserN, MaNV);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String Ma, string Ten, String GioiT, String NgaySinh, String DienThoai, String DiaChi, String MaCV, String MaCa, String ghiChu)
        {
            string sql = "UPDATE  NhanVien SET TenNhanVien =N'{1}' ,GioiTinh =N'{2}' ,NgaySinh =N'{3}' , DienThoai =N'{4}' ,DiaChi =N'{5}' " +
                ",GhiChu =N'{6}' ,MaCV =N'{7}' ,MaCa =N'{8}' WHERE MaNhanVien ='{0}' ";
            sql = string.Format(sql, Ma, Ten, GioiT, NgaySinh, DienThoai, DiaChi, ghiChu, MaCV, MaCa);
            dal.ExcuteNonQuery(sql);
        }
    }
}
