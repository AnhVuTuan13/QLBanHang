using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_Pass
    {
        DAL_QL dal = new DAL_QL();
        public void ChangePass(String User, String NewPass)
        {
            string sql = "UPDATE tb_User Set Password='{1}' WHERE UserName='{0}'";
            sql = string.Format(sql, User, NewPass);
            dal.ExcuteNonQuery(sql);
        }
    }
}
