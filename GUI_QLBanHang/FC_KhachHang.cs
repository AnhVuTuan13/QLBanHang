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
    public partial class FC_KhachHang : Form
    {
        C_AutoID autoID = new C_AutoID();
        BUS_FC_KhachHang busfcKH = new BUS_FC_KhachHang();
        public FC_KhachHang()
        {
            InitializeComponent();
        }
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("KhachHang", "MaKH");
            string nextID = autoID.NextID(lastId, "KH");
            txtMaKH.Text = nextID;
        }
        public void loadTT(String Mc, String TC, String DC, String DT)
        {
            txtMaKH.Text = Mc;
            txtTenKH.Text = TC;
            txtDiaChi.Text = DC;
            txtDienThoai.Text = DT;
        }
        public void loadlb(String srtlb)
        {
            lbChangeKH.Text = srtlb;
        }
        private bool checkSDT(String sdt)
        {
            if (sdt.Length == 10)
            {
                return true;
            }
            else
                return false;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "" | txtTenKH.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDiaChi.Text.Trim() == "" | txtDiaChi.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Địa Chỉ ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDienThoai.Text.Trim() == "" | txtDienThoai.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Điện Thoại ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (checkSDT(txtDienThoai.Text.Trim()) == false || Int64.TryParse(txtDienThoai.Text, out long result) == false)
                MessageBox.Show("Số Điện Thoại Không Chính Xác", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (lbChangeKH.Text == "Thêm Khách Hàng")
                {
                    busfcKH.Add(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);
                }
                else
                {
                    busfcKH.Change(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FC_KhachHang_Load(object sender, EventArgs e)
        {
            if (lbChangeKH.Text == "Thêm Khách Hàng")
                loadIDNext();
        }
    }
}
