
namespace App_sale_manager
{
    partial class Form_ChiTietNH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietNH));
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoHDNH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNVNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.txtGiaTriDN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bnt_Print = new System.Windows.Forms.Button();
            this.PrintP_HoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.Print_HoaDon = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(167, 153);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(280, 22);
            this.txtMaDT.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 107;
            this.label12.Text = "Mã đối tác";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(167, 237);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(280, 22);
            this.txtMaNV.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 105;
            this.label11.Text = "Mã nhân viên";
            // 
            // txtSoHDNH
            // 
            this.txtSoHDNH.Location = new System.Drawing.Point(167, 25);
            this.txtSoHDNH.Name = "txtSoHDNH";
            this.txtSoHDNH.ReadOnly = true;
            this.txtSoHDNH.Size = new System.Drawing.Size(280, 22);
            this.txtSoHDNH.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Số hoá đơn nhập";
            // 
            // txtNVNhap
            // 
            this.txtNVNhap.Location = new System.Drawing.Point(167, 195);
            this.txtNVNhap.Name = "txtNVNhap";
            this.txtNVNhap.ReadOnly = true;
            this.txtNVNhap.Size = new System.Drawing.Size(280, 22);
            this.txtNVNhap.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "Nhân viên nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Đối tác cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "Chi tiết đơn nhập";
            // 
            // dgvChiTietNH
            // 
            this.dgvChiTietNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNH.Location = new System.Drawing.Point(12, 310);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(568, 437);
            this.dgvChiTietNH.TabIndex = 109;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(167, 72);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.ReadOnly = true;
            this.txtNgayNhap.Size = new System.Drawing.Size(280, 22);
            this.txtNgayNhap.TabIndex = 112;
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(167, 114);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.ReadOnly = true;
            this.txtTenDT.Size = new System.Drawing.Size(280, 22);
            this.txtTenDT.TabIndex = 111;
            // 
            // txtGiaTriDN
            // 
            this.txtGiaTriDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTriDN.Location = new System.Drawing.Point(167, 768);
            this.txtGiaTriDN.Name = "txtGiaTriDN";
            this.txtGiaTriDN.ReadOnly = true;
            this.txtGiaTriDN.Size = new System.Drawing.Size(280, 26);
            this.txtGiaTriDN.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 771);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 113;
            this.label8.Text = "Tổng giá trị";
            // 
            // bnt_Print
            // 
            this.bnt_Print.Location = new System.Drawing.Point(499, 24);
            this.bnt_Print.Name = "bnt_Print";
            this.bnt_Print.Size = new System.Drawing.Size(96, 65);
            this.bnt_Print.TabIndex = 115;
            this.bnt_Print.Text = "Print";
            this.bnt_Print.UseVisualStyleBackColor = true;
            this.bnt_Print.Click += new System.EventHandler(this.bnt_Print_Click);
            // 
            // PrintP_HoaDon
            // 
            this.PrintP_HoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintP_HoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintP_HoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintP_HoaDon.Document = this.Print_HoaDon;
            this.PrintP_HoaDon.Enabled = true;
            this.PrintP_HoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintP_HoaDon.Icon")));
            this.PrintP_HoaDon.Name = "PrintP_HoaDon";
            this.PrintP_HoaDon.Visible = false;
            // 
            // Print_HoaDon
            // 
            this.Print_HoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_HoaDon_PrintPage);
            // 
            // Form_ChiTietNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 817);
            this.Controls.Add(this.bnt_Print);
            this.Controls.Add(this.txtGiaTriDN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvChiTietNH);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoHDNH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNVNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form_ChiTietNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChiTietNH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoHDNH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNVNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.TextBox txtGiaTriDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bnt_Print;
        private System.Windows.Forms.PrintPreviewDialog PrintP_HoaDon;
        private System.Drawing.Printing.PrintDocument Print_HoaDon;
    }
}