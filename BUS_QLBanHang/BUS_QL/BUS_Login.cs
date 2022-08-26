using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QLBanHang
{
    public class BUS_Login
    {
        DAL_QL dal = new DAL_QL();
        public bool checkUser(string Username , string pass)
        {
            string sqlcheck = string.Format("select*from tb_User where Username='{0}' and Password='{1}'", Username, pass);
            DataTable tb = dal.getTable(sqlcheck);
            if (tb.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
