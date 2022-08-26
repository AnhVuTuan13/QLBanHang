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
    public partial class F_XemCTDonDH : Form
    {
        public F_XemCTDonDH()
        {
            InitializeComponent();
        }
        BUS_XemCTDonDH bus = new BUS_XemCTDonDH();
        String MaDH, MaKH, DiaChi, NgayDat;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_XemCTDonDH_Load(object sender, EventArgs e)
        {
            loaddgv(MaDH);
            loadTT();
        }

        private void loaddgv(string Ma)
        {
            dataGridView1.DataSource = bus.loadDGV(Ma);
        }
        private void loadTT()
        {
            txtMa.Text = MaDH;
            txtMaKH.Text = bus.loadKH(MaKH);
            var Day = NgayDat.Split(' ');
            txtNgayDat.Text = Day[0];
            txtDiaChi.Text = DiaChi;
        }
        public void getTT(string MDH, String MKH, string DC, string Ngay)
        {
            MaDH = MDH;
            MaKH = MKH;
            DiaChi = DC;
            NgayDat = Ngay;
        }
    }
}
