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
    public partial class F_XemCTHoaDonN : Form
    {
        public F_XemCTHoaDonN()
        {
            InitializeComponent();
        }
        BUS_XemCTHoaDonN bus = new BUS_XemCTHoaDonN();
        String MaDH, NhanVien, NCC, NgayN, TongTien;
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
            txtNhaCC.Text = bus.laodNCC(NCC);
            var Day = NgayN.Split(' ');
            txtNgayDat.Text = Day[0];
            txtNhanVien.Text = bus.loadNV(NhanVien);
            txtTongTien.Text = TongTien;
        }
        public void getTT(string MDH, String MaNCC, string NV, string Ngay, string TT)
        {
            MaDH = MDH;
            NCC = MaNCC;
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
