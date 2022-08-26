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
    public partial class F_MainMeNu : Form
    {
        public F_MainMeNu()
        {
            InitializeComponent();
        }
        EC_User User = new EC_User();
        BUS_MainMeNu bus_main = new BUS_MainMeNu();
        public void getUser(EC_User user)
        {
            this.User = user;
        }
        
        private Form CheckTonTai(Type _formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == _formtype)
                    return f;
            }
            return null;
        }

        private void F_MainMeNu_Load(object sender, EventArgs e)
        {
            if (User.PhanQuyen != "True")
            {
                this.tàiKhoảnToolStripMenuItem.Enabled = false;
                this.NhanVienToolStripMenuItem.Enabled = false;
                
            }
            LoadThongTin();
        }

        public void LoadThongTin()
        {
            if (User.PhanQuyen != "True")
            {
                this.laQuyen.Text = "Nhân Viên";
            }
            else
            {
                this.laQuyen.Text = "Admin";
            }
            List<String> TTNV = bus_main.TTNV(User.MaNV);
            this.laMaNV.Text = TTNV[0].ToString();
            this.laTenNV.Text = TTNV[1].ToString();
            this.laGioiTinh.Text = TTNV[2].ToString();
            this.laCV.Text = TTNV[3].ToString();
            this.laCL.Text = TTNV[4].ToString();
        }

        

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = CheckTonTai(typeof(F_Login));
            if (form != null)
                form.Activate();
            else
            {
                F_Login flogin = new F_Login();
                this.Hide();
                flogin.ShowDialog();
                this.Close();
            }
        }

        

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_TaiKhoan));
            if (form != null)
                form.Activate();
            else
            {
                F_TaiKhoan ftaikhoan = new F_TaiKhoan();
                
                ftaikhoan.ShowDialog();
                
            }
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_CaLam));
            if (form != null)
                form.Activate();
            else
            {
                F_CaLam fCaLam = new F_CaLam();

                fCaLam.ShowDialog();

            }
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_CongViec));
            if (form != null)
                form.Activate();
            else
            {
                F_CongViec fCV = new F_CongViec();

                fCV.ShowDialog();

            }
        }

        private void chiTiếtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_NhanVien));
            if (form != null)
                form.Activate();
            else
            {
                F_NhanVien fNV = new F_NhanVien();

                fNV.ShowDialog();
                LoadThongTin();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(FC_Pass));
            if (form != null)
                form.Activate();
            else
            {
                FC_Pass f = new FC_Pass();
                f.getUser(User);
                f.ShowDialog();
                
                User.loadUser(User.UserName);
                
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_NhaCC));
            if (form != null)
                form.Activate();
            else
            {
                F_NhaCC f = new F_NhaCC();
               
                f.ShowDialog();
                
              

            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_KhachHang));
            if (form != null)
                form.Activate();
            else
            {
                F_KhachHang f = new F_KhachHang();

                f.ShowDialog();
                


            }
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DonViTinh));
            if (form != null)
                form.Activate();
            else
            {
                F_DonViTinh f = new F_DonViTinh();

                f.ShowDialog();



            }
        }

        private void nhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_NhomHang));
            if (form != null)
                form.Activate();
            else
            {
                F_NhomHang f = new F_NhomHang();
                f.ShowDialog();
            }
        }

        private void nướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_NuocSX));
            if (form != null)
                form.Activate();
            else
            {
                F_NuocSX f = new F_NuocSX();
                f.ShowDialog();
            }
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_SanPham));
            if (form != null)
                form.Activate();
            else
            {
                F_SanPham f = new F_SanPham();
                f.ShowDialog();
            }
        }

        private void đặtHàngCủaKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DatHang));
            if (form != null)
                form.Activate();
            else
            {
                F_DatHang f = new F_DatHang();
                f.ShowDialog();
            }

        }

        private void danhMụcĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DSDonHD));
            if (form != null)
                form.Activate();
            else
            {
                F_DSDonHD f = new F_DSDonHD();
                f.ShowDialog();
            }
        }

        private void hoáĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_BanHang));
            if (form != null)
                form.Activate();
            else
            {
                F_BanHang f = new F_BanHang();
                f.ShowDialog();
            }
        }

        private void danhMụcHoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DSHoaDonBan));
            if (form != null)
                form.Activate();
            else
            {
                F_DSHoaDonBan f = new F_DSHoaDonBan();
                f.ShowDialog();
            }
        }

        private void đặtHàngNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DatHangNCC));
            if (form != null)
                form.Activate();
            else
            {
                F_DatHangNCC f = new F_DatHangNCC();
                f.ShowDialog();
            }
        }

        private void danhMụcĐơnĐặtHàngNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DSDonDHNCC));
            if (form != null)
                form.Activate();
            else
            {
                F_DSDonDHNCC f = new F_DSDonDHNCC();
                f.ShowDialog();
            }
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_NhapHang));
            if (form != null)
                form.Activate();
            else
            {
                F_NhapHang f = new F_NhapHang();
                f.ShowDialog();
            }
        }

        private void danhMụcHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = CheckTonTai(typeof(F_DSHoaDonN));
            if (form != null)
                form.Activate();
            else
            {
                F_DSHoaDonN f = new F_DSHoaDonN();
                f.ShowDialog();
            }
        }
    }
}
