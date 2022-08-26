using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_NhaCC
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String Ma, string Ten, string DiaChi, String sdt)
        {
            string sql = "Insert into NhaCC Values('{0}',N'{1}',N'{2}',N'{3}')";
            sql = string.Format(sql, Ma, Ten, DiaChi,sdt);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String Ma, string Ten, string DiaChi, String sdt)
        {
            string sql = "UPDATE  NhaCC SET TenNhaCC=N'{1}' , DiaChi=N'{2}', DienThoai='{3}' WHERE MaNhaCC='{0}'";
            sql = string.Format(sql, Ma, Ten, DiaChi, sdt);
            dal.ExcuteNonQuery(sql);
        }
    }
}
