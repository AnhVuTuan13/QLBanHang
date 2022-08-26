using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang.BUS_QL;
using BUS_QLBanHang.Entity;
namespace GUI_QLBanHang
{
    public partial class F_XemCTHoaDonB : Form
    {
        public F_XemCTHoaDonB()
        {
            InitializeComponent();
        }
        BUS_CTHoaDonB bus = new BUS_CTHoaDonB();
        String MaDH, MaKH, NhanVien, NgayN ,TongTien;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loaddgv(string Ma)
        {
            dataGridView1.DataSource = bus.loadDGV(Ma);
        }
        private void loadTT()
        {
            txtMa.Text = MaDH;
            txtMaKH.Text = bus.loadKH(MaKH);
            var Day = NgayN.Split(' ');
            txtNgayDat.Text = Day[0];
            txtNhanVien.Text = bus.loadNV(NhanVien);
            txtTongTien.Text = TongTien;
        }
        public void getTT(string MDH, String MKH, string NV, string Ngay,string TT)
        {
            MaDH = MDH;
            MaKH = MKH;
            NhanVien = NV;
            NgayN = Ngay;
            TongTien = TT;
        }
       
        private void F_XemCTHoaDonB_Load(object sender, EventArgs e)
        {
            loaddgv(MaDH);
            loadTT();
        }
    }
}
