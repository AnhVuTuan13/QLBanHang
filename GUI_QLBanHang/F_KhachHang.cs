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
    public partial class F_KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        private String MaKH, TenKH, DiaChi, DienThoai, Row = "";
        public F_KhachHang()
        {
            InitializeComponent();
        }
        private void loaddgv()
        {
            dgvKH.DataSource = busKH.LoadDGV();
        }
        public void loadTTDGV()
        {
            if (dgvKH.Rows.Count != 1)
            {
                Row = "0";
                MaKH = dgvKH.Rows[0].Cells[0].Value.ToString();
                TenKH = dgvKH.Rows[0].Cells[1].Value.ToString();
                DiaChi = dgvKH.Rows[0].Cells[2].Value.ToString();
                DienThoai = dgvKH.Rows[0].Cells[3].Value.ToString();
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" || txtSearch.Text.Trim() == " ")
            {
                loaddgv();
            }
            else
            {
                dgvKH.DataSource = busKH.Search(txtSearch.Text);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_KhachHang Fc = new FC_KhachHang();
            Fc.loadlb("Thêm Khách Hàng");
            Fc.ShowDialog();
            loaddgv();
            loadTTDGV();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FC_NhaCC Fc = new FC_NhaCC();
                Fc.loadlb("Sửa Khách Hàng");
                Fc.loadTT(MaKH, TenKH, DiaChi, DienThoai);
                Fc.ShowDialog();
                loaddgv();
                loadTTDGV();
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + MaKH + " - " + TenKH + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    busKH.Delete(MaKH);
                    loaddgv();
                    loadTTDGV();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgvKH.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaKH = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenKH = dgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                DiaChi = dgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                DienThoai = dgvKH.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            loaddgv();

            loadTTDGV();

        }
    }
}
