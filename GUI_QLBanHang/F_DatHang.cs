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
    public partial class F_DatHang : Form
    {
        public F_DatHang()
        {
            InitializeComponent();
        }
        BUS_DonDH bus = new BUS_DonDH();
        C_AutoID autoID = new C_AutoID();
        List<C_CTDonDH> Ds = new List<C_CTDonDH>();
        String Row = "", MaHH, TenHH;
        public void loadTTDGV()
        {
            if (dataGridView1.Rows.Count != 1)
            {
                Row = "0";
                MaHH = dataGridView1.Rows[0].Cells[0].Value.ToString();
                TenHH = dataGridView1.Rows[0].Cells[1].Value.ToString();
               
            }
        }
        private void loadcb()
        {
            cbSanPham.DataSource = bus.loadcbSP();
            cbSanPham.DisplayMember = "SanPham";
            cbSanPham.ValueMember = "MaHangHoa";
            cbSanPham.SelectedIndex = 0;
            CbKhachHang.DataSource = bus.loadcbKH();
            CbKhachHang.DisplayMember = "KhachHang";
            CbKhachHang.ValueMember = "MaKH";
            CbKhachHang.SelectedIndex = 0;
        }
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("DonDH", "MaDonDH");
            string nextID = autoID.NextID(lastId, "DDH");
            txtMa.Text = nextID;
        }
        private void loadDVT(string MaSP)
        {
            txtDonViTinh.Text = bus.getDVT(MaSP);
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDVT(cbSanPham.SelectedValue.ToString());
        }
        private void loadDGV()
        {
            dataGridView1.Rows.Clear();
            foreach(var it in Ds)
            {
                dataGridView1.Rows.Add(it.MaHangHoa, it.TenHangHoa, it.SoLuong, it.DonViTinh);

            }
        }
        private void F_DatHang_Load(object sender, EventArgs e)
        {
            loadcb();
            loadDVT(cbSanPham.SelectedValue.ToString());
            loadIDNext();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá  Sản Phẩm: " + MaHH +" - "+TenHH+ " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    int k;
                    for (int i = 0; i < Ds.Count; i++)
                        if (Ds[i].MaHangHoa == MaHH)
                        {
                            k = i;
                            Ds.RemoveAt(k);
                            loadDGV();
                            loadTTDGV();
                            break;
                        }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dataGridView1.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaHH = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenHH = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               

            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "" | txtDiaChi.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Địa Chỉ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Ds.Count==0)
                MessageBox.Show("Chưa Có Sản Phẩm Nào Được Thêm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bus.Add(txtMa.Text, CbKhachHang.SelectedValue.ToString(), dateNgayDat.Value.ToString("MM/dd/yyyy"), txtDiaChi.Text, Ds);
                loadIDNext();
                loadcb();
                Ds.Clear();
                loadDGV();
                loadTTDGV();
                txtDiaChi.Clear();
                numberSoLuong.Value = 0;
            }

        }

        private bool checkSP(string sp)
        {
            foreach(var it in Ds)
            {
                if (it.MaHangHoa == sp)
                    return false;
            }
            return true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (numberSoLuong.Value == 0)
            {
                MessageBox.Show("Số Lượng Phải Khác 0", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (checkSP(cbSanPham.SelectedValue.ToString()) == true)
                {
                    C_CTDonDH Item = new C_CTDonDH();
                    Item.MaHangHoa = cbSanPham.SelectedValue.ToString();
                    Item.DonViTinh = bus.getDVT(Item.MaHangHoa);
                    var TenSp = cbSanPham.Text.Split('-');
                    Item.TenHangHoa = TenSp[1].Trim();
                    Item.SoLuong = numberSoLuong.Value.ToString();
                    Ds.Add(Item);
                    loadDGV();
                    loadTTDGV();
                }
                else
                {
                    MessageBox.Show("SP Đã Tồn Tại ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            
        }
    }
}
