
namespace GUI_QLBanHang
{
    partial class FC_CaLam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChangeCaLam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbChangeCaLam);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 50);
            this.panel1.TabIndex = 12;
            // 
            // lbChangeCaLam
            // 
            this.lbChangeCaLam.AutoSize = true;
            this.lbChangeCaLam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeCaLam.Location = new System.Drawing.Point(118, 15);
            this.lbChangeCaLam.Name = "lbChangeCaLam";
            this.lbChangeCaLam.Size = new System.Drawing.Size(83, 24);
            this.lbChangeCaLam.TabIndex = 0;
            this.lbChangeCaLam.Text = "Ca Làm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOK);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTenCa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaCa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 226);
            this.panel2.TabIndex = 13;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(87, 179);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(63, 26);
            this.btOK.TabIndex = 19;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Quay Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(122, 100);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(194, 48);
            this.txtMoTa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mô Tả";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCa.Location = new System.Drawing.Point(122, 59);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(194, 26);
            this.txtTenCa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Ca";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCa.Location = new System.Drawing.Point(122, 18);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.ReadOnly = true;
            this.txtMaCa.Size = new System.Drawing.Size(194, 26);
            this.txtMaCa.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Ca";
            // 
            // FC_CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FC_CaLam";
            this.Text = "Ca Làm";
            this.Load += new System.EventHandler(this.FC_CaLam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChangeCaLam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button button1;
    }
}