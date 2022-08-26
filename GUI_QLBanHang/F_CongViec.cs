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
    public partial class F_CongViec : Form
    {
        BUS_CongViec buscv = new BUS_CongViec();
        private String MaCV, TenCV, Row = "";

        private void F_CongViec_Load(object sender, EventArgs e)
        {
            loadDGV();
            loadTTDGV(); 
        }

        public F_CongViec()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "" || txtSearch.Text.Trim() == " ")
            {
                loadDGV();
            }
            else
            {
                dgvCongViec.DataSource = buscv.SearchCV(txtSearch.Text);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_CongVIec FcCV = new FC_CongVIec();
            FcCV.loadlb("Thêm Công Việc");
            FcCV.ShowDialog();
            loadDGV();
            loadTTDGV();
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgvCongViec.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaCV = dgvCongViec.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenCV = dgvCongViec.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Row == "")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FC_CongVIec FcCV = new FC_CongVIec();
                FcCV.loadlb("Sửa Công Việc");
                FcCV.loadTT(MaCV, TenCV);
                FcCV.ShowDialog();
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
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá Công Việc: " + MaCV + " - " + TenCV + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    buscv.DeleteCV(MaCV);
                    loadDGV();
                    loadTTDGV();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDGV()
        {
            dgvCongViec.DataSource = buscv.LoadDGV();
        }
        public void loadTTDGV()
        {
            if (dgvCongViec.Rows.Count != 1)
            {
                Row = "0";
                MaCV = dgvCongViec.Rows[0].Cells[0].Value.ToString();
                TenCV = dgvCongViec.Rows[0].Cells[1].Value.ToString();
            }
        }

    }
}
