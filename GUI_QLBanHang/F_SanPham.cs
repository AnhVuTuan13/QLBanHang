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

    public partial class F_SanPham : Form
    {
        BUS_HangHoa bus = new BUS_HangHoa();
        private String MaHH, TenH, DonGiaN, DonGiaB, SoLg, GhiChu, NuocSX, NhomHang, DonVi, Row = "";

        public F_SanPham()
        {
            InitializeComponent();
        }
        private void loadDGV()
        {
            dgv.DataSource = bus.LoadDGV();
           
        }
        private void loadTTDGV()
        {
            if (dgv.Rows.Count != 1)
            {
                Row = "0";
                MaHH = dgv.Rows[0].Cells[0].Value.ToString();
                TenH = dgv.Rows[0].Cells[1].Value.ToString();
                DonGiaN = dgv.Rows[0].Cells[2].Value.ToString();
                DonGiaB = dgv.Rows[0].Cells[3].Value.ToString();
                SoLg = dgv.Rows[0].Cells[4].Value.ToString();
                NuocSX = dgv.Rows[0].Cells[5].Value.ToString();
                NhomHang = dgv.Rows[0].Cells[6].Value.ToString();
                DonVi = dgv.Rows[0].Cells[7].Value.ToString();
                GhiChu = dgv.Rows[0].Cells[8].Value.ToString();
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
                dgv.DataSource = bus.Search(txtSearch.Text);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_SanPham Fc = new FC_SanPham();
            Fc.loadlb("Thêm Sản Phẩm");
            Fc.ShowDialog();
            loadDGV();
            loadTTDGV();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FC_SanPham Fc = new FC_SanPham();
                Fc.loadlb("Sửa Sản Phẩm");
                Fc.loadTT(MaHH, TenH, DonGiaN, DonGiaB, GhiChu, SoLg , NuocSX, NhomHang, DonVi);
                Fc.ShowDialog();
                loadDGV();
                loadTTDGV();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + MaHH + " - " + TenH + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    bus.Delete(MaHH);
                    loadDGV();
                    loadTTDGV();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgv.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaHH = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenH = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                DonGiaN = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                DonGiaB = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                SoLg = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                NuocSX = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                NhomHang = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                DonVi = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                GhiChu = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void F_SanPham_Load(object sender, EventArgs e)
        {
            loadDGV();
            loadTTDGV();
        }
    }
}
