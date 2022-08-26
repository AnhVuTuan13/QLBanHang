using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_TaiKhoan
    {
        DAL_QL dal = new DAL_QL();
        public void ChangeUser(string user, string mk, string quyen)
        {
            String sql = "UPDATE tb_User SET Password = '{0}' , PhanQuyen = {1} WHERE  UserName ='{2}'";
            sql = string.Format(sql, mk, quyen, user);
            dal.ExcuteNonQuery(sql);
        }
    }
}
