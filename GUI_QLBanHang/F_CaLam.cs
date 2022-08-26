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
    public partial class F_CaLam : Form
    {
        public F_CaLam()
        {
            InitializeComponent();
        }
        BUS_CaLam buscl = new BUS_CaLam();
        private String MaCa,TenCa,MoTa,Row="";
        private void loaddgv()
        {
            dgvCaLam.DataSource = buscl.LoadDGV();
        }
        public   void  loadTTDGV()
        {
            if (dgvCaLam.Rows.Count != 1)
            {
                Row = "0";
                MaCa = dgvCaLam.Rows[0].Cells[0].Value.ToString();
                TenCa = dgvCaLam.Rows[0].Cells[1].Value.ToString();
                MoTa = dgvCaLam.Rows[0].Cells[2].Value.ToString();
            }
           
           
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()=="" || txtSearch.Text.Trim() == " ")
            {
                loaddgv();
            }
            else
            {
                dgvCaLam.DataSource = buscl.SearchCaLam(txtSearch.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if(Row=="")
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FC_CaLam FcCaLam = new FC_CaLam();
                FcCaLam.loadlb("Sửa Ca Làm");
                FcCaLam.loadTT(MaCa, TenCa, MoTa);
                FcCaLam.ShowDialog();
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
                DialogResult dl = MessageBox.Show("Bạn Có Muốn Xoá Ca: " + MaCa + " - " + TenCa + " !", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    buscl.DeleteCa(MaCa);
                    loaddgv();
                    loadTTDGV();
                }
            }
                

        }

        

        private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dgvCaLam.Rows.Count - 1)
            {
                Row = "";
            }
            else
            {
                Row = e.RowIndex.ToString();
                MaCa = dgvCaLam.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenCa = dgvCaLam.Rows[e.RowIndex].Cells[1].Value.ToString();
                MoTa = dgvCaLam.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void F_CaLam_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadTTDGV();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FC_CaLam FcCaLam = new FC_CaLam();
            FcCaLam.loadlb("Thêm Ca Làm") ;
            FcCaLam.ShowDialog();
            loaddgv();
            loadTTDGV();
        }
    }
}
