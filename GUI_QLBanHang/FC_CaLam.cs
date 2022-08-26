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
    public partial class FC_CaLam : Form
    {
        public FC_CaLam()
        {
            InitializeComponent();
        }
        C_AutoID autoID = new C_AutoID();
        BUS_FC_CaLam busfcl = new BUS_FC_CaLam();
        private void loadIDNext()
        {
            string lastId = autoID.GetLastID("CaLam", "MaCa");
            string nextID = autoID.NextID(lastId, "MC");
            txtMaCa.Text = nextID;
        }
        public void loadTT(String Mc,String TC,String MT)
        {
            txtMaCa.Text = Mc;
            txtTenCa.Text = TC;
            txtMoTa.Text = MT;
        }
        public void loadlb(String srtlb)
        {
            lbChangeCaLam.Text = srtlb;
        }
        private void FC_CaLam_Load(object sender, EventArgs e)
        {
            if (lbChangeCaLam.Text == "Thêm Ca Làm")
                loadIDNext();
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtTenCa.Text.Trim() == "" | txtTenCa.Text.Trim() == " ")
                MessageBox.Show("Không Được để Trống Tên Ca", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (lbChangeCaLam.Text == "Thêm Ca Làm")
                {
                    busfcl.Add(txtMaCa.Text, txtTenCa.Text, txtMoTa.Text);
                }
                else
                {
                    busfcl.Change(txtMaCa.Text, txtTenCa.Text, txtMoTa.Text);
                }
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
