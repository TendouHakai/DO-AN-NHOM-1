namespace App_sale_manager
{
    partial class Form_main_admin
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage_tongquan = new System.Windows.Forms.TabPage();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.tabPage_HangHoa = new System.Windows.Forms.TabPage();
            this.btnQLKho = new System.Windows.Forms.Button();
            this.btnQuanLiHH = new System.Windows.Forms.Button();
            this.lblTieuDeHH = new System.Windows.Forms.Label();
            this.lblChuY = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.tabPage_DoiTac = new System.Windows.Forms.TabPage();
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblGhiChu2 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabPage_tongquan.SuspendLayout();
            this.tabPage_HangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage_tongquan);
            this.tabCtrl.Controls.Add(this.tabPage_HangHoa);
            this.tabCtrl.Controls.Add(this.tabPage_DoiTac);
            this.tabCtrl.Controls.Add(this.tabPage_GiaoDich);
            this.tabCtrl.Controls.Add(this.tabPage_NhanVien);
            this.tabCtrl.Controls.Add(this.tabPage_BaoCao);
            this.tabCtrl.Location = new System.Drawing.Point(13, 13);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1204, 679);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPage_tongquan
            // 
            this.tabPage_tongquan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_tongquan.Controls.Add(this.btn_dangxuat);
            this.tabPage_tongquan.Location = new System.Drawing.Point(4, 25);
            this.tabPage_tongquan.Name = "tabPage_tongquan";
            this.tabPage_tongquan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tongquan.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_tongquan.TabIndex = 0;
            this.tabPage_tongquan.Text = "Tổng quan";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(827, 492);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(326, 47);
            this.btn_dangxuat.TabIndex = 0;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            // 
            // tabPage_HangHoa
            // 
            this.tabPage_HangHoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_HangHoa.Controls.Add(this.lblGhiChu2);
            this.tabPage_HangHoa.Controls.Add(this.lblGhiChu);
            this.tabPage_HangHoa.Controls.Add(this.btnQLKho);
            this.tabPage_HangHoa.Controls.Add(this.btnQuanLiHH);
            this.tabPage_HangHoa.Controls.Add(this.lblTieuDeHH);
            this.tabPage_HangHoa.Controls.Add(this.lblChuY);
            this.tabPage_HangHoa.Controls.Add(this.dgvSP);
            this.tabPage_HangHoa.Controls.Add(this.lblLoaiSP);
            this.tabPage_HangHoa.Location = new System.Drawing.Point(4, 25);
            this.tabPage_HangHoa.Name = "tabPage_HangHoa";
            this.tabPage_HangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HangHoa.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            // 
            // btnQLKho
            // 
            this.btnQLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.Location = new System.Drawing.Point(320, 27);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Size = new System.Drawing.Size(157, 88);
            this.btnQLKho.TabIndex = 30;
            this.btnQLKho.Text = "Quản lí kho";
            this.btnQLKho.UseVisualStyleBackColor = true;
            this.btnQLKho.Click += new System.EventHandler(this.btnQLKho_Click);
            // 
            // btnQuanLiHH
            // 
            this.btnQuanLiHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiHH.Location = new System.Drawing.Point(41, 27);
            this.btnQuanLiHH.Name = "btnQuanLiHH";
            this.btnQuanLiHH.Size = new System.Drawing.Size(157, 88);
            this.btnQuanLiHH.TabIndex = 29;
            this.btnQuanLiHH.Text = "Quản lí hàng hoá";
            this.btnQuanLiHH.UseVisualStyleBackColor = true;
            this.btnQuanLiHH.Click += new System.EventHandler(this.btnQuanLiHH_Click);
            // 
            // lblTieuDeHH
            // 
            this.lblTieuDeHH.AutoSize = true;
            this.lblTieuDeHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHH.Location = new System.Drawing.Point(483, 183);
            this.lblTieuDeHH.Name = "lblTieuDeHH";
            this.lblTieuDeHH.Size = new System.Drawing.Size(224, 29);
            this.lblTieuDeHH.TabIndex = 28;
            this.lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
            // 
            // lblChuY
            // 
            this.lblChuY.AutoSize = true;
            this.lblChuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuY.Location = new System.Drawing.Point(446, 16);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(0, 20);
            this.lblChuY.TabIndex = 27;
            // 
            // dgvSP
            // 
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSP.ColumnHeadersHeight = 70;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.Location = new System.Drawing.Point(-4, 230);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1197, 417);
            this.dgvSP.TabIndex = 8;
            this.dgvSP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSP_CellMouseDoubleClick);
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(1220, 47);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(101, 17);
            this.lblLoaiSP.TabIndex = 3;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // tabPage_DoiTac
            // 
            this.tabPage_DoiTac.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DoiTac.Name = "tabPage_DoiTac";
            this.tabPage_DoiTac.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DoiTac.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_DoiTac.TabIndex = 2;
            this.tabPage_DoiTac.Text = "Đối tác";
            this.tabPage_DoiTac.UseVisualStyleBackColor = true;
            // 
            // tabPage_GiaoDich
            // 
            this.tabPage_GiaoDich.Location = new System.Drawing.Point(4, 25);
            this.tabPage_GiaoDich.Name = "tabPage_GiaoDich";
            this.tabPage_GiaoDich.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GiaoDich.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_GiaoDich.TabIndex = 3;
            this.tabPage_GiaoDich.Text = "Giao dịch";
            this.tabPage_GiaoDich.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_BaoCao
            // 
            this.tabPage_BaoCao.Location = new System.Drawing.Point(4, 25);
            this.tabPage_BaoCao.Name = "tabPage_BaoCao";
            this.tabPage_BaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BaoCao.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_BaoCao.TabIndex = 5;
            this.tabPage_BaoCao.Text = "Báo cáo";
            this.tabPage_BaoCao.UseVisualStyleBackColor = true;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(707, 24);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(381, 17);
            this.lblGhiChu.TabIndex = 31;
            this.lblGhiChu.Text = "Quản lí hàng hoá: thêm xoá sửa thông tin hàng hoá";
            // 
            // lblGhiChu2
            // 
            this.lblGhiChu2.AutoSize = true;
            this.lblGhiChu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu2.Location = new System.Drawing.Point(707, 76);
            this.lblGhiChu2.Name = "lblGhiChu2";
            this.lblGhiChu2.Size = new System.Drawing.Size(417, 17);
            this.lblGhiChu2.TabIndex = 32;
            this.lblGhiChu2.Text = "Quản lí kho: tìm kiếm, nhập hàng, xem hàng hoá sắp hết";
            // 
            // Form_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 691);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Form_main_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_admin_FormClosed);
            this.tabCtrl.ResumeLayout(false);
            this.tabPage_tongquan.ResumeLayout(false);
            this.tabPage_HangHoa.ResumeLayout(false);
            this.tabPage_HangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage_tongquan;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.TabPage tabPage_HangHoa;
        private System.Windows.Forms.TabPage tabPage_DoiTac;
        private System.Windows.Forms.TabPage tabPage_GiaoDich;
        private System.Windows.Forms.TabPage tabPage_NhanVien;
        private System.Windows.Forms.TabPage tabPage_BaoCao;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label lblChuY;
        private System.Windows.Forms.Label lblTieuDeHH;
        private System.Windows.Forms.Button btnQLKho;
        private System.Windows.Forms.Button btnQuanLiHH;
        private System.Windows.Forms.Label lblGhiChu2;
        private System.Windows.Forms.Label lblGhiChu;
    }
}