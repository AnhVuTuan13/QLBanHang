using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.Entity
{
    public class C_AutoID
    {
        DAL_QL dal = new DAL_QL();
        public string GetLastID(string nameTable, string nameSelectColumn)
        {
            string sql = "SELECT TOP 1 {0} FROM {1} ORDER BY {2} DESC";
            sql = string.Format(sql, nameSelectColumn, nameTable, nameSelectColumn);
            return dal.getString(sql, nameSelectColumn);
        }
        public string NextID(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "0001";  // fixwidth default
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
    }

}
