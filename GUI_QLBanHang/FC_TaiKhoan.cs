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
    public partial class FC_TaiKhoan : Form
    {
        public FC_TaiKhoan()
        {
            InitializeComponent();
        }
        string UserName, NVien, PQuyen, MKhau;
        BUS_FC_TaiKhoan busfc = new BUS_FC_TaiKhoan();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FC_TaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
           
            MKhau = txtMK.Text.Trim();
            if(MKhau==""||MKhau==" ")
                MessageBox.Show("Không Được để Mật Khẩu Trống!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    busfc.ChangeUser(UserName, MKhau,  cbquyen.SelectedValue.ToString());
                    MessageBox.Show("Thay Đổi Thành Công!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }

        }

        

        public void getThongTin(string user, string mk, string quyen, string nv)
        {
            this.UserName = user;
            this.MKhau = mk;
            this.PQuyen = quyen;
            
            this.NVien = nv;
        }
        private void loaddata()
        {
            this.txtTK.Text=UserName;
            this.txtMK.Text=MKhau;
            this.txtNV.Text = NVien;
            loadCbQuyen();
        }
        private void loadCbQuyen()
        {
            cbquyen.DisplayMember = "Text";
            cbquyen.ValueMember = "Value";
            var items = new[] {
                new { Text = "Admin", Value = "1" },
                new { Text = "Nhân Viên", Value = "0" }
            };
            cbquyen.DataSource = items;
           
            cbquyen.Text =PQuyen;
        }
    }
}
