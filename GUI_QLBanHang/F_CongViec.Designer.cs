
namespace GUI_QLBanHang
{
    partial class F_CongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CongViec));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btFind);
            this.panel3.Controls.Add(this.btadd);
            this.panel3.Controls.Add(this.btChange);
            this.panel3.Controls.Add(this.dgvCongViec);
            this.panel3.Location = new System.Drawing.Point(12, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 258);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm theo mã Công Việc hoặc Tên Công Việc";
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(3, 188);
            this.btDelete.Name = "btDelete";
            this.btDelete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btDelete.Size = new System.Drawing.Size(94, 40);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xoá";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(251, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 26);
            this.txtSearch.TabIndex = 9;
            // 
            // btFind
            // 
            this.btFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Image = ((System.Drawing.Image)(resources.GetObject("btFind.Image")));
            this.btFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFind.Location = new System.Drawing.Point(144, 41);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(101, 31);
            this.btFind.TabIndex = 10;
            this.btFind.Text = "Tìm Kiếm";
            this.btFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(3, 96);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(94, 40);
            this.btadd.TabIndex = 8;
            this.btadd.Text = "Thêm ";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Image = ((System.Drawing.Image)(resources.GetObject("btChange.Image")));
            this.btChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChange.Location = new System.Drawing.Point(3, 142);
            this.btChange.Name = "btChange";
            this.btChange.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btChange.Size = new System.Drawing.Size(94, 40);
            this.btChange.TabIndex = 7;
            this.btChange.Text = "Sửa";
            this.btChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCongViec.Location = new System.Drawing.Point(103, 87);
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.Size = new System.Drawing.Size(463, 156);
            this.dgvCongViec.TabIndex = 0;
            this.dgvCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongViec_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCV";
            this.Column1.HeaderText = "Mã Công Việc";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenCV";
            this.Column2.HeaderText = "Tên Công Việc";
            this.Column2.Name = "Column2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 42);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Công Việc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Quay Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "F_CongViec";
            this.Text = "Công Việc";
            this.Load += new System.EventHandler(this.F_CongViec_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}