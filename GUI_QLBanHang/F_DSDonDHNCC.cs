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
    public partial class F_DSDonDHNCC : Form
    {
        public F_DSDonDHNCC()
        {
            InitializeComponent();
        }
        private String MaDH, MaNCC, NgayDat, MaNhanVien, Row = "";

        BUS_DSDonDHNCC bus = new BUS_DSDonDHNCC();
        private void loaddgv()
        {
            dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.DataSource = bus.LoadDGV();

        }
        public void loadTTDGV()
        {
            if (dgv.Rows.Count != 1)
            {
                Row = "0";
                MaDH = dgv.Rows[0].Cells[0].Value.ToString();
                MaNCC = dgv.Rows[0].Cells[1].Value.ToString();
                MaNhanVien = dgv.Rows[0].Cells[2].Value.ToString();
                NgayDat = dgv.Rows[0].Cells[3].Value.ToString();
            }
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
                MaDH = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                MaNCC = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                NgayDat = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                MaNhanVien = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void F_DSDonDHNCC_Load(object sender, EventArgs e)
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
                dgv.DataSource = bus.Search(txtSearch.Text);
                loadTTDGV();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + MaDH + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    bus.Delete(MaDH);
                    loaddgv();
                    loadTTDGV();
                }
            }
        }

        private void btSee_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đơn Hàng Cần xem", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                F_XemCTDonDHNCC f = new F_XemCTDonDHNCC();
                f.getTT(MaDH, MaNCC, MaNhanVien, NgayDat);
                f.ShowDialog();
            }
        }
    }
}
