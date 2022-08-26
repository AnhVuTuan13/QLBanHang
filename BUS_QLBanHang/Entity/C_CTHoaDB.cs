using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBanHang;
namespace BUS_QLBanHang.Entity
{
    public class C_CTHoaDB
    {

        private string _MaHangHoa;
        private string _TenHangHoa;
        private string _SoLuong;
        private string _DonViTinh;
        private string _DonGiaBan;


        public string MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public string DonGiaBan { get => _DonGiaBan; set => _DonGiaBan = value; }

        public string ThanhTien()
        {
            double Kq = int.Parse(SoLuong) * double.Parse(DonGiaBan);
            return Kq.ToString();
        }
    }
}
