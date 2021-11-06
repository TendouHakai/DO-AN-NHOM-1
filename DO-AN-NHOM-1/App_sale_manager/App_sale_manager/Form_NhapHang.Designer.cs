
namespace App_sale_manager
{
    partial class Form_NhapHang
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
            this.lblTenSP = new System.Windows.Forms.Label();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblLoaiID = new System.Windows.Forms.Label();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDoiTac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSLTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(36, 325);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(99, 17);
            this.lblTenSP.TabIndex = 65;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(160, 266);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(421, 24);
            this.cbbLoaiSP.TabIndex = 64;
            this.cbbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSP_SelectedIndexChanged);
            this.cbbLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLoaiSP_KeyPress);
            // 
            // lblLoaiID
            // 
            this.lblLoaiID.AutoSize = true;
            this.lblLoaiID.Location = new System.Drawing.Point(36, 267);
            this.lblLoaiID.Name = "lblLoaiID";
            this.lblLoaiID.Size = new System.Drawing.Size(35, 17);
            this.lblLoaiID.TabIndex = 63;
            this.lblLoaiID.Text = "Loại";
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(162, 323);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(419, 24);
            this.cbbTenSP.TabIndex = 66;
            this.cbbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbbTenSP_SelectedIndexChanged);
            this.cbbTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTenSP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Đối tác cung cấp";
            // 
            // cbbDoiTac
            // 
            this.cbbDoiTac.FormattingEnabled = true;
            this.cbbDoiTac.Location = new System.Drawing.Point(158, 130);
            this.cbbDoiTac.Name = "cbbDoiTac";
            this.cbbDoiTac.Size = new System.Drawing.Size(422, 24);
            this.cbbDoiTac.TabIndex = 68;
            this.cbbDoiTac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDoiTac_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Số lượng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Số lượng tối thiểu";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(162, 373);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 71;
            // 
            // txtSLTT
            // 
            this.txtSLTT.Location = new System.Drawing.Point(162, 429);
            this.txtSLTT.Name = "txtSLTT";
            this.txtSLTT.ReadOnly = true;
            this.txtSLTT.Size = new System.Drawing.Size(100, 22);
            this.txtSLTT.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ngày nhập";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Location = new System.Drawing.Point(162, 78);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dateNgayNhap.TabIndex = 74;
            this.dateNgayNhap.Value = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Số lượng nhập";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(163, 489);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(99, 22);
            this.txtSLNhap.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nhân viên nhập";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 556);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 50);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(186, 556);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xoá sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(334, 556);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(96, 50);
            this.btnHoanTat.TabIndex = 80;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(482, 556);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 50);
            this.btnHuy.TabIndex = 81;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvChiTietNH
            // 
            this.dgvChiTietNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNH.Location = new System.Drawing.Point(671, 119);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(461, 534);
            this.dgvChiTietNH.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Chi tiết đơn nhập";
            // 
            // Form_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvChiTietNH);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSLNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSLTT);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDoiTac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.cbbLoaiSP);
            this.Controls.Add(this.lblLoaiID);
            this.Name = "Form_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Label lblLoaiID;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDoiTac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSLTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
        private System.Windows.Forms.Label label7;
    }
}