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
    public partial class FC_NhaCC : Form
    {
        C_AutoID autoID = new C_AutoID();
        BUS_FC_NhaCC busfcNhaCC = new BUS_FC_NhaCC();
        public FC_NhaCC()
        {
            InitializeComponent();
        }
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("NhaCC", "MaNhaCC");
            string nextID = autoID.NextID(lastId, "NCC");
            txtMaNCC.Text = nextID;
        }
        public void loadTT(String Mc, String TC, String DC,String DT)
        {
            txtMaNCC.Text = Mc;
            txtTenNCC.Text = TC;
            txtDiaChi.Text = DC;
            txtDienThoai.Text = DT;
        }
        public void loadlb(String srtlb)
        {
            lbChangeNhaCC.Text = srtlb;
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
            if (txtTenNCC.Text.Trim() == "" | txtTenNCC.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDiaChi.Text.Trim() == "" | txtDiaChi.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Địa Chỉ ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDienThoai.Text.Trim() == "" | txtDienThoai.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Điện Thoại ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (checkSDT(txtDienThoai.Text.Trim()) == false || Int64.TryParse(txtDienThoai.Text, out long result) == false)
                MessageBox.Show("Số Điện Thoại Không Chính Xác", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (lbChangeNhaCC.Text == "Thêm Nhà Cung Cấp")
                {
                    busfcNhaCC.Add(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
                }
                else
                {
                    busfcNhaCC.Change(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FC_NhaCC_Load(object sender, EventArgs e)
        {
            if (lbChangeNhaCC.Text == "Thêm Nhà Cung Cấp")
                loadIDNext();
        }
    }
}
