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
    public partial class F_NuocSX : Form
    {
        public F_NuocSX()
        {
            InitializeComponent();
        }
        private String Ma, Ten, Row = "";
        BUS_NuocSX bus = new BUS_NuocSX();
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
            FC_NuocSX Fc = new FC_NuocSX();
            Fc.loadlb("Thêm Nước Sản Xuất");
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
                FC_NuocSX Fc = new FC_NuocSX();
                Fc.loadlb("Sửa Nước Sản Xuất");
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

        private void F_NuocSX_Load(object sender, EventArgs e)
        {
            loaddgv();

            loadTTDGV();
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
    }
}
