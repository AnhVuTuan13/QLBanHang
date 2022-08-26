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
    public partial class FC_CongVIec : Form
    {
        C_AutoID autoID = new C_AutoID();
        BUS_FC_CongViec busfvCV = new BUS_FC_CongViec();
        public FC_CongVIec()
        {
            InitializeComponent();
        }

        private void FC_CongVIec_Load(object sender, EventArgs e)
        {
            if (lbChangeCV.Text == "Thêm Công Việc")
                loadIDNext();
        }
        public void loadlb(string lb)
        {
            lbChangeCV.Text = lb;
        }
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("CongViec", "MaCV");
            string nextID = autoID.NextID(lastId, "CV");
            txtMaCV.Text = nextID;
        }
        public void loadTT(String McV, String TCV)
        {
            txtMaCV.Text = McV;
            txtTenCV.Text = TCV;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text.Trim() == "" | txtTenCV.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên Công Việc", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (lbChangeCV.Text == "Thêm Công Việc")
                {
                    busfvCV.Add(txtMaCV.Text, txtTenCV.Text);
                }
                else
                {
                    busfvCV.Change(txtMaCV.Text, txtTenCV.Text);
                }
                this.Close();
            }
        }
    }
}
