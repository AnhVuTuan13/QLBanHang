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
    public partial class F_XemCTDonDHNCC : Form
    {
        public F_XemCTDonDHNCC()
        {
            InitializeComponent();
        }
        BUS_XemCTDonDHNCC bus = new BUS_XemCTDonDHNCC();
        private String MaDH, MaNCC, MaNhanVien, NgayDat;

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
            txtMaNCC.Text = bus.loadNhaCC(MaNCC);
            var Day = NgayDat.Split(' ');
            txtNgayDat.Text = Day[0];
            txtNhanVien.Text = bus.loadNV(MaNhanVien);
        }
        public void getTT(string MDH, String MNCC, string NV, string Ngay)
        {
            MaDH = MDH;
            MaNhanVien = NV;
            MaNCC = MNCC;
            NgayDat = Ngay;
        }
       

        private void XemCTDonDHNCC_Load(object sender, EventArgs e)
        {
            loaddgv(MaDH);
            loadTT();
        }
    }
}
