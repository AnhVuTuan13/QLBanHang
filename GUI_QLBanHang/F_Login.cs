using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QLBanHang.BUS_QLBanHang;
using BUS_QLBanHang.Entity;
namespace GUI_QLBanHang
{
    public partial class F_Login : Form
    {
        BUS_Login login = new BUS_Login();
        EC_User User = new EC_User();
        public F_Login()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            if (login.checkUser(username, pass))
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User.loadUser(username);
                F_MainMeNu mainMenu = new F_MainMeNu();
                mainMenu.getUser(User);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Taì Khoản Mật Khẩu Không Chính Xac!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
