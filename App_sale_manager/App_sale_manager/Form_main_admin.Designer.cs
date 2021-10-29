
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
            this.lblChuY = new System.Windows.Forms.Label();
            this.btnHangSapHet = new System.Windows.Forms.Button();
            this.btnXemChiTietHH = new System.Windows.Forms.Button();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.tabPage_DoiTac = new System.Windows.Forms.TabPage();
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.lblTieuDeHH = new System.Windows.Forms.Label();
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
            this.tabCtrl.Location = new System.Drawing.Point(3, 12);
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
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // tabPage_HangHoa
            // 
            this.tabPage_HangHoa.Controls.Add(this.lblTieuDeHH);
            this.tabPage_HangHoa.Controls.Add(this.lblChuY);
            this.tabPage_HangHoa.Controls.Add(this.btnHangSapHet);
            this.tabPage_HangHoa.Controls.Add(this.btnXemChiTietHH);
            this.tabPage_HangHoa.Controls.Add(this.btnXoaHH);
            this.tabPage_HangHoa.Controls.Add(this.btnSuaHH);
            this.tabPage_HangHoa.Controls.Add(this.btnThemHH);
            this.tabPage_HangHoa.Controls.Add(this.dgvSP);
            this.tabPage_HangHoa.Controls.Add(this.lblLoaiSP);
            this.tabPage_HangHoa.Location = new System.Drawing.Point(4, 25);
            this.tabPage_HangHoa.Name = "tabPage_HangHoa";
            this.tabPage_HangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HangHoa.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            this.tabPage_HangHoa.UseVisualStyleBackColor = true;
            // 
            // lblChuY
            // 
            this.lblChuY.AutoSize = true;
            this.lblChuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuY.Location = new System.Drawing.Point(427, 105);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(0, 20);
            this.lblChuY.TabIndex = 27;
            // 
            // btnHangSapHet
            // 
            this.btnHangSapHet.Location = new System.Drawing.Point(252, 167);
            this.btnHangSapHet.Name = "btnHangSapHet";
            this.btnHangSapHet.Size = new System.Drawing.Size(90, 46);
            this.btnHangSapHet.TabIndex = 26;
            this.btnHangSapHet.Text = "Hàng sắp hết";
            this.btnHangSapHet.UseVisualStyleBackColor = true;
            this.btnHangSapHet.Click += new System.EventHandler(this.btnHangSapHet_Click);
            // 
            // btnXemChiTietHH
            // 
            this.btnXemChiTietHH.Location = new System.Drawing.Point(148, 167);
            this.btnXemChiTietHH.Name = "btnXemChiTietHH";
            this.btnXemChiTietHH.Size = new System.Drawing.Size(90, 45);
            this.btnXemChiTietHH.TabIndex = 25;
            this.btnXemChiTietHH.Text = "Xem chi tiết";
            this.btnXemChiTietHH.UseVisualStyleBackColor = true;
            this.btnXemChiTietHH.Click += new System.EventHandler(this.btnXemChiTietHH_Click);
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.Location = new System.Drawing.Point(148, 105);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(90, 45);
            this.btnXoaHH.TabIndex = 24;
            this.btnXoaHH.Text = "Xoá";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.Location = new System.Drawing.Point(29, 166);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(90, 46);
            this.btnSuaHH.TabIndex = 23;
            this.btnSuaHH.Text = "Sửa";
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.Location = new System.Drawing.Point(29, 105);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(90, 45);
            this.btnThemHH.TabIndex = 22;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(6, 264);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1194, 386);
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
            // lblTieuDeHH
            // 
            this.lblTieuDeHH.AutoSize = true;
            this.lblTieuDeHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHH.Location = new System.Drawing.Point(486, 241);
            this.lblTieuDeHH.Name = "lblTieuDeHH";
            this.lblTieuDeHH.Size = new System.Drawing.Size(164, 20);
            this.lblTieuDeHH.TabIndex = 28;
            this.lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
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
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Button btnXemChiTietHH;
        private System.Windows.Forms.Button btnHangSapHet;
        private System.Windows.Forms.Label lblChuY;
        private System.Windows.Forms.Label lblTieuDeHH;
    }
}