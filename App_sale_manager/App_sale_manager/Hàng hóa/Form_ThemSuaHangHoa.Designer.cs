﻿namespace App_sale_manager
{
    partial class Form_ThemSuaHangHoa
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
            this.lblLoaiID = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSPID = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.ptrbHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.lblHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoaiID
            // 
            this.lblLoaiID.AutoSize = true;
            this.lblLoaiID.Location = new System.Drawing.Point(22, 38);
            this.lblLoaiID.Name = "lblLoaiID";
            this.lblLoaiID.Size = new System.Drawing.Size(35, 17);
            this.lblLoaiID.TabIndex = 39;
            this.lblLoaiID.Text = "Loại";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(22, 392);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(58, 17);
            this.lblGiaBan.TabIndex = 28;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(22, 274);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(75, 17);
            this.lblDVT.TabIndex = 27;
            this.lblDVT.Text = "Đơn vị tính";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Location = new System.Drawing.Point(22, 451);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(66, 17);
            this.lblGiaNhap.TabIndex = 26;
            this.lblGiaNhap.Text = "Giá nhập";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Location = new System.Drawing.Point(22, 333);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(98, 17);
            this.lblNuocSX.TabIndex = 24;
            this.lblNuocSX.Text = "Nước sản xuất";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(22, 156);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(99, 17);
            this.lblTenSP.TabIndex = 23;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(22, 97);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(93, 17);
            this.lblMaSP.TabIndex = 22;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(481, 22);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(43, 17);
            this.lblMoTa.TabIndex = 40;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(484, 42);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(643, 153);
            this.txtMoTa.TabIndex = 41;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(25, 542);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(111, 55);
            this.btnHoanTat.TabIndex = 42;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(219, 542);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 55);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSPID
            // 
            this.txtSPID.Location = new System.Drawing.Point(156, 92);
            this.txtSPID.Name = "txtSPID";
            this.txtSPID.Size = new System.Drawing.Size(280, 22);
            this.txtSPID.TabIndex = 44;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(156, 151);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(280, 22);
            this.txtTenSP.TabIndex = 45;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(156, 269);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(280, 22);
            this.txtDVT.TabIndex = 46;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(156, 328);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(280, 22);
            this.txtNuocSX.TabIndex = 47;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(156, 387);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(280, 22);
            this.txtGiaBan.TabIndex = 51;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(156, 446);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(280, 22);
            this.txtGiaNhap.TabIndex = 52;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(156, 31);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(277, 24);
            this.cbLoaiSP.TabIndex = 53;
            this.cbLoaiSP.Text = "Chọn Loại";
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            // 
            // ptrbHinhAnh
            // 
            this.ptrbHinhAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptrbHinhAnh.Location = new System.Drawing.Point(484, 243);
            this.ptrbHinhAnh.Name = "ptrbHinhAnh";
            this.ptrbHinhAnh.Size = new System.Drawing.Size(643, 320);
            this.ptrbHinhAnh.TabIndex = 63;
            this.ptrbHinhAnh.TabStop = false;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(481, 223);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(69, 17);
            this.lblHinhAnh.TabIndex = 62;
            this.lblHinhAnh.Text = "Hình ảnh ";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(556, 201);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(97, 41);
            this.btnChonHinh.TabIndex = 64;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(156, 210);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(280, 22);
            this.txtHang.TabIndex = 66;
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(22, 215);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(42, 17);
            this.lblHang.TabIndex = 65;
            this.lblHang.Text = "Hãng";
            // 
            // Form_ThemSuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.ptrbHinhAnh);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtSPID);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblLoaiID);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Name = "Form_ThemSuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemXoaSuaHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.ptrbHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiID;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSPID;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.PictureBox ptrbHinhAnh;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label lblHang;
    }
}