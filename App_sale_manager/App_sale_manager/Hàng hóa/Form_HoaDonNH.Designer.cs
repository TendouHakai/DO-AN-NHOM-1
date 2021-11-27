
namespace App_sale_manager
{
    partial class Form_HoaDonNH
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDHN = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.grb_nhomlenh = new System.Windows.Forms.GroupBox();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHang = new System.Windows.Forms.Label();
            this.cbbDoiTac = new System.Windows.Forms.ComboBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtMaHDNH = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiID = new System.Windows.Forms.Label();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).BeginInit();
            this.grb_nhomlenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Danh sách đơn nhập hàng";
            // 
            // dgvHDHN
            // 
            this.dgvHDHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDHN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHDHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDHN.Location = new System.Drawing.Point(16, 337);
            this.dgvHDHN.Name = "dgvHDHN";
            this.dgvHDHN.ReadOnly = true;
            this.dgvHDHN.RowHeadersVisible = false;
            this.dgvHDHN.RowHeadersWidth = 51;
            this.dgvHDHN.RowTemplate.Height = 24;
            this.dgvHDHN.Size = new System.Drawing.Size(769, 376);
            this.dgvHDHN.TabIndex = 86;
            this.dgvHDHN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDHN_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXoa.Location = new System.Drawing.Point(146, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 68);
            this.btnXoa.TabIndex = 89;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnChiTiet.Location = new System.Drawing.Point(146, 104);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(118, 68);
            this.btnChiTiet.TabIndex = 90;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNhapHang.Location = new System.Drawing.Point(4, 21);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(118, 68);
            this.btnNhapHang.TabIndex = 91;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // grb_nhomlenh
            // 
            this.grb_nhomlenh.Controls.Add(this.btnXemTatCa);
            this.grb_nhomlenh.Controls.Add(this.btnNhapHang);
            this.grb_nhomlenh.Controls.Add(this.btnChiTiet);
            this.grb_nhomlenh.Controls.Add(this.btnXoa);
            this.grb_nhomlenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nhomlenh.Location = new System.Drawing.Point(12, 12);
            this.grb_nhomlenh.Name = "grb_nhomlenh";
            this.grb_nhomlenh.Size = new System.Drawing.Size(277, 200);
            this.grb_nhomlenh.TabIndex = 92;
            this.grb_nhomlenh.TabStop = false;
            this.grb_nhomlenh.Text = "Nhóm lệnh thao tác";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXemTatCa.Location = new System.Drawing.Point(4, 104);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(118, 68);
            this.btnXemTatCa.TabIndex = 92;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = false;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // dgvChiTietNH
            // 
            this.dgvChiTietNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNH.Location = new System.Drawing.Point(791, 337);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.ReadOnly = true;
            this.dgvChiTietNH.RowHeadersVisible = false;
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(333, 376);
            this.dgvChiTietNH.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(892, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Chi tiết đơn nhập";
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.Location = new System.Drawing.Point(389, 105);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(72, 17);
            this.lblHang.TabIndex = 101;
            this.lblHang.Text = "Nhân viên";
            // 
            // cbbDoiTac
            // 
            this.cbbDoiTac.FormattingEnabled = true;
            this.cbbDoiTac.Location = new System.Drawing.Point(543, 167);
            this.cbbDoiTac.Name = "cbbDoiTac";
            this.cbbDoiTac.Size = new System.Drawing.Size(240, 24);
            this.cbbDoiTac.TabIndex = 100;
            this.cbbDoiTac.SelectedIndexChanged += new System.EventHandler(this.cbbDoiTac_SelectedIndexChanged);
            this.cbbDoiTac.TextChanged += new System.EventHandler(this.cbbDoiTac_TextChanged);
            this.cbbDoiTac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDoiTac_KeyPress);
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(543, 231);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(240, 22);
            this.txtTriGia.TabIndex = 99;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtTriGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTriGia_KeyPress);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(389, 233);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(100, 17);
            this.lblGiaBan.TabIndex = 98;
            this.lblGiaBan.Text = "Giá trị tối thiểu";
            // 
            // txtMaHDNH
            // 
            this.txtMaHDNH.Location = new System.Drawing.Point(544, 65);
            this.txtMaHDNH.Name = "txtMaHDNH";
            this.txtMaHDNH.Size = new System.Drawing.Size(240, 22);
            this.txtMaHDNH.TabIndex = 96;
            this.txtMaHDNH.TextChanged += new System.EventHandler(this.txtMaHDNH_TextChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(389, 169);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(52, 17);
            this.lblTenSP.TabIndex = 95;
            this.lblTenSP.Text = "Đối tác";
            // 
            // lblLoaiID
            // 
            this.lblLoaiID.AutoSize = true;
            this.lblLoaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiID.Location = new System.Drawing.Point(390, 65);
            this.lblLoaiID.Name = "lblLoaiID";
            this.lblLoaiID.Size = new System.Drawing.Size(127, 17);
            this.lblLoaiID.TabIndex = 93;
            this.lblLoaiID.Text = "Mã đơn nhập hàng";
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(543, 103);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(240, 24);
            this.cbbNhanVien.TabIndex = 102;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            this.cbbNhanVien.TextChanged += new System.EventHandler(this.cbbNhanVien_TextChanged);
            this.cbbNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbNhanVien_KeyPress);
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(543, 136);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.ReadOnly = true;
            this.txtNVID.Size = new System.Drawing.Size(240, 22);
            this.txtNVID.TabIndex = 105;
            this.txtNVID.TextChanged += new System.EventHandler(this.txtNVID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtDTID
            // 
            this.txtDTID.Location = new System.Drawing.Point(543, 200);
            this.txtDTID.Name = "txtDTID";
            this.txtDTID.ReadOnly = true;
            this.txtDTID.Size = new System.Drawing.Size(240, 22);
            this.txtDTID.TabIndex = 107;
            this.txtDTID.TextChanged += new System.EventHandler(this.txtDTID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Mã đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Lọc đơn nhập hàng theo";
            // 
            // Form_HoaDonNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 723);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNVID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbNhanVien);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.cbbDoiTac);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.txtMaHDNH);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblLoaiID);
            this.Controls.Add(this.grb_nhomlenh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHDHN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvChiTietNH);
            this.Name = "Form_HoaDonNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).EndInit();
            this.grb_nhomlenh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHDHN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.GroupBox grb_nhomlenh;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cbbDoiTac;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtMaHDNH;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiID;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}