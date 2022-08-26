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
    public partial class F_DonViTinh : Form
    {
        public F_DonViTinh()
        {
            InitializeComponent();
        }
        private String Ma, Ten, Row = "";
        BUS_DonViTinh bus = new BUS_DonViTinh();
        private void loaddgv()
        {
            dgv.DataSource = bus.LoadDGV();
        }
        public void loadTTDGV()
        {
            if (dgv.Rows.Count != 1)
            {
                Row = "0";
                Ma = dgv.Rows[0].Cells[0].Value.ToString();
                Ten = dgv.Rows[0].Cells[1].Value.ToString();
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
                dgv.DataSource = bus.Search(txtSearch.Text);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_DonViTinh Fc = new FC_DonViTinh();
            Fc.loadlb("Thêm Đơn Vị Tính");
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
                FC_DonViTinh Fc = new FC_DonViTinh();
                Fc.loadlb("Sửa Đơn Vị Tính");
                Fc.loadTT(Ma, Ten);
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
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá : " + Ma + " - " + Ten + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    bus.Delete(Ma);
                    loaddgv();
                    loadTTDGV();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                Ma = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Ten = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                

            }
        }

        private void F_DonViTinh_Load(object sender, EventArgs e)
        {
            loaddgv();

            loadTTDGV();
        }
    }
}
