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
    public partial class F_NhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        private String MaNV,TenNV,GioiTinh,NgaySinh, DienThoai,DiaChi, GhiChu, CViec ,CLam,  Row = "";

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgvNV.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaNV = dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenNV = dgvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                GioiTinh = dgvNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                NgaySinh = dgvNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                DienThoai = dgvNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                DiaChi = dgvNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                CViec = dgvNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                CLam = dgvNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                GhiChu = dgvNV.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FC_NhanVien FcNV = new FC_NhanVien();
                FcNV.loadlb("Sửa Ca Làm");
                FcNV.loadTT(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,CViec,CLam,GhiChu);
                FcNV.ShowDialog();
                loadDGV();
                loadTTDGV();
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_NhanVien FcNV = new FC_NhanVien();
            FcNV.loadlb("Thêm Nhân Viên");
            FcNV.ShowDialog();
            loadDGV();
            loadTTDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + MaNV + " - " + TenNV + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    busnv.Delete(MaNV);
                    loadDGV();
                    loadTTDGV();

                }
            }
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" || txtSearch.Text.Trim() == " ")
            {
                loadTTDGV();
            }
            else
            {
                dgvNV.DataSource = busnv.Search(txtSearch.Text);
            }
        }

        private void F_NhanVien_Load(object sender, EventArgs e)
        {
            loadDGV();
            loadTTDGV();
        }
        
        private void loadDGV()
        {
            dgvNV.DataSource = busnv.LoadDGV();
            dgvNV.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void loadTTDGV()
        {
            if (dgvNV.Rows.Count != 1)
            {
                Row = "0";
                MaNV = dgvNV.Rows[0].Cells[0].Value.ToString();
                TenNV = dgvNV.Rows[0].Cells[1].Value.ToString();
                GioiTinh = dgvNV.Rows[0].Cells[2].Value.ToString();
                NgaySinh = dgvNV.Rows[0].Cells[3].Value.ToString();
                DienThoai = dgvNV.Rows[0].Cells[4].Value.ToString();
                DiaChi = dgvNV.Rows[0].Cells[5].Value.ToString();
                CViec = dgvNV.Rows[0].Cells[6].Value.ToString();
                CLam = dgvNV.Rows[0].Cells[7].Value.ToString();
                GhiChu = dgvNV.Rows[0].Cells[8].Value.ToString();
            }
        }
        public F_NhanVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
