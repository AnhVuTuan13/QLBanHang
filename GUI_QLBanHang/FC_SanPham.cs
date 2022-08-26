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
    public partial class FC_SanPham : Form
    {
        public FC_SanPham()
        {
            InitializeComponent();
        }
        C_AutoID autoID = new C_AutoID();
        BUS_FC_HangHoa busfc = new BUS_FC_HangHoa();
        private String NuocSX, NhomHang, DonVi;
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("HangHoa", "MaHangHoa");
            string nextID = autoID.NextID(lastId, "SP");
            txtMaHH.Text = nextID;
        }
        public void loadTT(String Ma, string Ten, String DGNhap, String DGBan, String GhiChu, String SL, String NSX, String NHang, String DVTinh)
        {
            txtMaHH.Text = Ma;
            txtTen.Text = Ten;
            txtDGNhap.Text = DGNhap;
            txtDGBan.Text = DGBan;
            txtghiChu.Text = GhiChu;
            txtSoLg.Text = SL;
            NuocSX = NSX;
            NhomHang = NHang;
            DonVi = DVTinh;

        }
        public void loadlb(String srtlb)
        {
            lbChange.Text = srtlb;
        }
        private void loadcb()
        {
            cbNuocSX.DataSource = busfc.LoadCbNuocSX();
            cbNuocSX.DisplayMember = "TenNuocSX";
            cbNuocSX.ValueMember = "MaNuocSX";

            cbNhomHang.DataSource = busfc.LoadCbNhomHang();
            cbNhomHang.DisplayMember = "TenNhomHang";
            cbNhomHang.ValueMember = "MaNhomHang";

            cbDonViTinh.DataSource = busfc.LoadCbDonViTinh();
            cbDonViTinh.DisplayMember = "TenDonViTinh";
            cbDonViTinh.ValueMember = "MaDonViTinh";

            if (lbChange.Text == "Thêm Sản Phẩm")
            {
                cbNuocSX.SelectedIndex = 0;
                cbNhomHang.SelectedIndex = 0;
                cbDonViTinh.SelectedIndex = 0;
            }
            else
            {
                cbNuocSX.Text = NuocSX;
                cbNhomHang.Text = NhomHang;
                cbDonViTinh.Text = DonVi;
            }


        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" | txtTen.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDGBan.Text.Trim() == "" || txtDGBan.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Đơn Giá Bán", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDGNhap.Text.Trim() == "" | txtDGNhap.Text.Trim() == " ")
                MessageBox.Show("Không Được để Dơn Giá Nhập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtSoLg.Text.Trim() == "" || txtSoLg.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Số Số Lượng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Int32.TryParse(txtSoLg.Text, out int Resul) == false)
                MessageBox.Show("Số Lượng Không Đúng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (float.TryParse(txtDGNhap.Text, out float Resul1) == false)
                MessageBox.Show("Đơn Giá Nhập Không Đúng ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (float.TryParse(txtDGBan.Text, out float Resul2) == false)
                MessageBox.Show("Đơn Giá Bán Không Đúng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                if (lbChange.Text == "Thêm Sản Phẩm")
                {

                    busfc.Add(txtMaHH.Text, txtTen.Text, txtDGNhap.Text, txtDGBan.Text, txtSoLg.Text,
                        txtghiChu.Text, cbNuocSX.SelectedValue.ToString(), cbNhomHang.SelectedValue.ToString(), cbDonViTinh.SelectedValue.ToString());
                }
                else
                {
                    busfc.Change(txtMaHH.Text, txtTen.Text, txtDGNhap.Text, txtDGBan.Text, txtSoLg.Text,
                       txtghiChu.Text, cbNuocSX.SelectedValue.ToString(), cbNhomHang.SelectedValue.ToString(), cbDonViTinh.SelectedValue.ToString());

                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FC_SanPham_Load(object sender, EventArgs e)
        {
            if (lbChange.Text == "Thêm Sản Phẩm")
                loadIDNext();
            loadcb();
        }
    }
}
