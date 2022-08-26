using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_CaLam
    {
        DAL_QL dal = new DAL_QL();
        public DataTable LoadDGV()
        {
            String sql = "Select*from CaLam";
            return dal.getTable(sql);
        }
        public DataTable SearchCaLam(String search)
        {
            String sql = "Select*from CaLam Where MaCa like N'%{0}%' or TenCa like N'%{1}%' or Mota like N'%{2}%'";
            sql = string.Format(sql,search, search, search);
            return dal.getTable(sql);
        }
        public void DeleteCa(String MaC)
        {
            String sql = "DeleTe CaLam Where MaCa ='{0}'";
            sql = string.Format(sql, MaC);
            dal.ExcuteNonQuery(sql);
        }
    }
}
