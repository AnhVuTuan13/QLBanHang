﻿
namespace GUI_QLBanHang
{
    partial class F_XemCTDonDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChangeCaLam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(116, 17);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(130, 26);
            this.txtMa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Đơn Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChangeCaLam);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 50);
            this.panel1.TabIndex = 16;
            // 
            // lbChangeCaLam
            // 
            this.lbChangeCaLam.AutoSize = true;
            this.lbChangeCaLam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeCaLam.Location = new System.Drawing.Point(193, 13);
            this.lbChangeCaLam.Name = "lbChangeCaLam";
            this.lbChangeCaLam.Size = new System.Drawing.Size(263, 24);
            this.lbChangeCaLam.TabIndex = 0;
            this.lbChangeCaLam.Text = "Xem Chi Tiết Đơn Đặt Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNgayDat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 91);
            this.panel2.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 173);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đơn Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(116, 49);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(194, 26);
            this.txtMaKH.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách Hàng";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDat.Location = new System.Drawing.Point(451, 53);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.ReadOnly = true;
            this.txtNgayDat.Size = new System.Drawing.Size(130, 26);
            this.txtNgayDat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày Đặt";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(387, 10);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(194, 26);
            this.txtDiaChi.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Địa Chỉ";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHangHoa";
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenHangHoa";
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.Name = "Column2";
            // 
            // column3
            // 
            this.column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column3.DataPropertyName = "SoLuong";
            this.column3.HeaderText = "Số Lượng";
            this.column3.Name = "column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenDonViTinh";
            this.Column4.HeaderText = "Đơn Vị Tính";
            this.Column4.Name = "Column4";
            // 
            // F_XemCTDonDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_XemCTDonDH";
            this.Text = "Xem Chi Tiết Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.F_XemCTDonDH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChangeCaLam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}