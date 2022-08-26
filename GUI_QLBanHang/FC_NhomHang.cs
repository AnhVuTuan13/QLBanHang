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
    public partial class FC_NhomHang : Form
    {
        C_AutoID autoID = new C_AutoID();
        BUS_FC_NhomHang busfc = new BUS_FC_NhomHang();
        public FC_NhomHang()
        {
            InitializeComponent();
        }
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("NhomHang", "MaNhomHang");
            string nextID = autoID.NextID(lastId, "NH");
            txtMa.Text = nextID;
        }
        public void loadTT(String Mc, String TC)
        {

            txtMa.Text = Mc;
            txtTen.Text = TC;

        }
        public void loadlb(String srtlb)
        {
            lbChange.Text = srtlb;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" | txtTen.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (lbChange.Text == "Thêm Nhóm Hàng")
                {
                    busfc.Add(txtMa.Text, txtTen.Text);
                }
                else
                {
                    busfc.Change(txtMa.Text, txtTen.Text);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FC_NhomHang_Load(object sender, EventArgs e)
        {
            if (lbChange.Text == "Thêm Nhóm Hàng")
                loadIDNext();
        }
    }
}
