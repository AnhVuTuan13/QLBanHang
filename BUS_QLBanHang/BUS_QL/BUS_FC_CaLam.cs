using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_CaLam
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String MaC, string TenC ,String MoT)
        {
            string sql = "Insert into CaLam Values('{0}',N'{1}',N'{2}')";
            sql = string.Format(sql, MaC, TenC, MoT);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String MaC, string TenC, String MoT)
        {
            string sql = "UPDATE  CaLam SET TenCa=N'{1}' ,MoTa=N'{2}' WHERE MaCa='{0}'";
            sql = string.Format(sql, MaC, TenC, MoT);
            dal.ExcuteNonQuery(sql);    
        }
    }
}
