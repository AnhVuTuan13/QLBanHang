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
    public partial class F_NhaCC : Form
    {
        BUS_NhaCC busNCC = new BUS_NhaCC();
        private String MaNCC, TenNCC, DiaChi,DienThoai, Row = "";

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_NhaCC Fc = new FC_NhaCC();
            Fc.loadlb("Thêm Nhà Cung Cấp");
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
                Fc.loadlb("Sửa Nhà Cung Cấp");
                Fc.loadTT(MaNCC, TenNCC, DiaChi,DienThoai);
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
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + MaNCC + " - " + TenNCC + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    busNCC.Delete(MaNCC);
                    loaddgv();
                    loadTTDGV();
                }
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgvNhaCC.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaNCC = dgvNhaCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenNCC = dgvNhaCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                DiaChi = dgvNhaCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                DienThoai = dgvNhaCC.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void F_NhaCC_Load(object sender, EventArgs e)
        {
            loaddgv();
            
            loadTTDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" || txtSearch.Text.Trim() == " ")
            {
                loaddgv();
            }
            else
            {
                dgvNhaCC.DataSource = busNCC.Search(txtSearch.Text);
            }
        }

        public F_NhaCC()
        {
            InitializeComponent();
        }
        private void loaddgv()
        {
            dgvNhaCC.DataSource = busNCC.LoadDGV();
        }
        public void loadTTDGV()
        {
            if (dgvNhaCC.Rows.Count != 1)
            {
                Row = "0";
                MaNCC = dgvNhaCC.Rows[0].Cells[0].Value.ToString();
                TenNCC = dgvNhaCC.Rows[0].Cells[1].Value.ToString();
                DiaChi = dgvNhaCC.Rows[0].Cells[2].Value.ToString();
                DienThoai = dgvNhaCC.Rows[0].Cells[3].Value.ToString();
            }
        }

    }
}
