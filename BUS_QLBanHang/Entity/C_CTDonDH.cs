using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.Entity
{
    public class C_CTDonDH
    {
        private string _MaHangHoa;
        private string _TenHangHoa;
        private string _SoLuong;
        private string _DonViTinh;
       
        

        public string MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        

       
       
    }
}
