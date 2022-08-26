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
    public partial class F_TaiKhoan : Form
    {
        Bus_TaiKhoan bustk = new Bus_TaiKhoan();
        string rowselect = "";
        string UserName, NVien,PQuyen,MKhau;
        
        public F_TaiKhoan()
        {
            InitializeComponent();
        }
        private void loadTTDGV()
        {
            if(dgvTk.Rows.Count != 1)
            {
                rowselect = "0";
                UserName = dgvTk.Rows[0].Cells[0].Value.ToString();
                NVien = dgvTk.Rows[0].Cells[3].Value.ToString();
                MKhau = dgvTk.Rows[0].Cells[1].Value.ToString();
                PQuyen = dgvTk.Rows[0].Cells[2].Value.ToString();
            }
        }
        private void F_TaiKhoan_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadTTDGV();
        }
        private void loaddgv()
        {
            dgvTk.DataSource = bustk.loadTaiKhoan();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "" || txtSearch.Text.Trim()== " ")
            {
                loaddgv();
            }
            else
            {
                dgvTk.DataSource = bustk.loadSearch(txtSearch.Text);
            }
        }

        private void dgvTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex== dgvTk.Rows.Count-1)
            {
                rowselect = "";
            }
            else
            {
                
                rowselect = e.RowIndex.ToString();
                UserName = dgvTk.Rows[e.RowIndex].Cells[0].Value.ToString();
                NVien= dgvTk.Rows[e.RowIndex].Cells[3].Value.ToString();
                MKhau= dgvTk.Rows[e.RowIndex].Cells[1].Value.ToString();
                PQuyen = dgvTk.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            

            }
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(rowselect == "")
            {
                MessageBox.Show("Chọn Sai dòng! Vui Lòng chọn Đúng dòng cần sửa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FC_TaiKhoan f = new FC_TaiKhoan();
                f.getThongTin(UserName, MKhau, PQuyen, NVien);
                f.ShowDialog();
                loaddgv();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
