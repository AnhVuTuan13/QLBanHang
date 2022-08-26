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
    public partial class FC_NhanVien : Form
    {
        C_AutoID autoID = new C_AutoID();
        BUS_FC_NhanVien busfcnv = new BUS_FC_NhanVien();
        private String GioiTinh, CaLam, CongViec;
        public FC_NhanVien()
        {
            InitializeComponent();
        }

        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("NhanVien", "MaNhanVien");
            string nextID = autoID.NextID(lastId, "NV");
            txtMaNV.Text = nextID;
        }
        public void loadTT(String Ma, string Ten, String GioiT, String NgaySinh, String DienThoai, String DiaChi, String CV, String CaL, String ghiChu)
        {
            txtMaNV.Text = Ma;
            txtTenNV.Text = Ten;
            txtGhiChu.Text = ghiChu;
            txtDienThoai.Text = DienThoai;
            txtDiaChi.Text = DiaChi;
            DatePickNgaySinh.Text = NgaySinh;
            CaLam = CaL;
            CongViec = CV;
            GioiTinh = GioiT;
           
        }
        public void loadlb(String srtlb)
        {
            lbChangeNV.Text = srtlb;
        }

        private void FC_NhanVien_Load(object sender, EventArgs e)
        {
            if (lbChangeNV.Text == "Thêm Nhân Viên")
                loadIDNext();
            loadcb();
        }
        private void loadcb()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Khác");
            
            cbCaLam.DataSource = busfcnv.loadCbCaLam();
            cbCaLam.DisplayMember = "TenCa";
            cbCaLam.ValueMember = "MaCa";
            
            cbCongViec.DataSource = busfcnv.loadCbCongViec();
            cbCongViec.DisplayMember = "TenCV";
            cbCongViec.ValueMember = "MaCV";

            if(lbChangeNV.Text == "Thêm Nhân Viên") 
            {
                cbGioiTinh.Text = "Nam";
                cbCaLam.SelectedIndex = 0;
                cbCongViec.SelectedIndex = 0;
            }
            else
            {
                cbGioiTinh.Text = GioiTinh;
                cbCaLam.Text = CaLam;
                cbCongViec.Text = CongViec;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtTenNV.Text.Trim() == "" | txtTenNV.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên Nhân Viên", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDienThoai.Text.Trim() == "" || txtDienThoai.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Số Điện Thoại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (checkSDT(txtDienThoai.Text.Trim())== false || Int64.TryParse(txtDienThoai.Text, out long result)==false)
                MessageBox.Show("Số Điện Thoại Không Chính Xác", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDiaChi.Text.Trim() == "" | txtDiaChi.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Địa Chỉ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                
                if (lbChangeNV.Text == "Thêm Nhân Viên")
                {
                    
                    busfcnv.Add(txtMaNV.Text, txtTenNV.Text,cbGioiTinh.
                        Text,DatePickNgaySinh.Value.ToString("MM/dd/yyyy"), 
                        txtDienThoai.Text,txtDiaChi.Text,cbCongViec.SelectedValue.ToString(),
                        cbCaLam.SelectedValue.ToString(),txtGhiChu.Text);
                    busfcnv.createAccount(txtMaNV.Text, txtMaNV.Text);
                }
                else
                {
                    busfcnv.Change(txtMaNV.Text, txtTenNV.Text, cbGioiTinh.
                          Text, DatePickNgaySinh.Value.ToString("MM/dd/yyyy"),
                          txtDienThoai.Text, txtDiaChi.Text, cbCongViec.SelectedValue.ToString(),
                          cbCaLam.SelectedValue.ToString(), txtGhiChu.Text);

                }
                this.Close();
            }
        }
    }
}
