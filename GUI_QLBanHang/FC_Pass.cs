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
    public partial class FC_Pass : Form
    {
        public FC_Pass()
        {
            InitializeComponent();
        }
        EC_User User = new EC_User();
        BUS_FC_Pass BusPass = new BUS_FC_Pass();
        public void getUser(EC_User Us)
        {
            this.User = Us;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtMKC.Text.Trim() == "" || txtMKC.Text.Trim() == " ")
            {
                MessageBox.Show("Không Được để Trống Mật Khẩu Cũ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMKMoi.Text.Trim() == "" || txtMKMoi.Text.Trim() == " ")
            {
                MessageBox.Show("Không Được để  Trống Mật Khẩu Mới", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtMKMoi2.Text.Trim() == "" || txtMKMoi2.Text.Trim() == " ")
            {
                MessageBox.Show("Không Được để Trống Nhập Lại Mật Khẩu Mơi ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMKC.Text.Trim() != User.Password)
                {
                    MessageBox.Show("Mật Khẩu Cũ Không Đúng ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMKMoi.Text != txtMKMoi2.Text)
                {
                    MessageBox.Show("Mật Khẩu Mới và Nhập Lại Mật Khẩu  Không Khớp", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BusPass.ChangePass(User.UserName, txtMKMoi.Text);
                    MessageBox.Show("Thay đổi thành công!", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
