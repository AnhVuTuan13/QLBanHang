﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.BUS_QL
{
    public class BUS_FC_DonViTinh
    {
        DAL_QL dal = new DAL_QL();
        public void Add(String Ma, string Ten)
        {
            string sql = "Insert into DonViTinh Values('{0}',N'{1}')";
            sql = string.Format(sql, Ma, Ten);
            dal.ExcuteNonQuery(sql);
        }
        public void Change(String Ma, string Ten)
        {
            string sql = "UPDATE  DonViTinh SET TenDonViTinh=N'{1}' WHERE MaDonviTinh='{0}'";
            sql = string.Format(sql, Ma, Ten);
            dal.ExcuteNonQuery(sql);
        }
    }
}
