
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
            System.Windows.Forms.Label label1_GD;
            System.Windows.Forms.Label label2_GD;
            System.Windows.Forms.Label label3_GD;
            System.Windows.Forms.Label label4_GD;
            System.Windows.Forms.Label label5_GD;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main_admin));
            this.CLB_GD_LoaiDon = new System.Windows.Forms.CheckedListBox();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage_tongquan = new System.Windows.Forms.TabPage();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.tabPage_HangHoa = new System.Windows.Forms.TabPage();
            this.tabPage_DoiTac = new System.Windows.Forms.TabPage();
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.BOX_GD_MaNhanVien = new System.Windows.Forms.TextBox();
            this.Box_GD_MaKhachHang = new System.Windows.Forms.TextBox();
            this.CLB_GD_TrangThai = new System.Windows.Forms.CheckedListBox();
            this.BNT_GD_inDS = new System.Windows.Forms.Button();
            this.Box_GD_MaHoaDon = new System.Windows.Forms.TextBox();
            this.bnt_GD_Timkiem = new System.Windows.Forms.Button();
            this.GridView_Data_GiaoDich = new System.Windows.Forms.DataGridView();
            this.BNT_Refresh_GD = new System.Windows.Forms.Button();
            this.BNT_TaoHoaDon = new System.Windows.Forms.Button();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            label1_GD = new System.Windows.Forms.Label();
            label2_GD = new System.Windows.Forms.Label();
            label3_GD = new System.Windows.Forms.Label();
            label4_GD = new System.Windows.Forms.Label();
            label5_GD = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabPage_tongquan.SuspendLayout();
            this.tabPage_GiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Data_GiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_GD
            // 
            label1_GD.AutoSize = true;
            label1_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_GD.Location = new System.Drawing.Point(34, 320);
            label1_GD.Name = "label1_GD";
            label1_GD.Size = new System.Drawing.Size(72, 18);
            label1_GD.TabIndex = 8;
            label1_GD.Text = " Loại Đơn";
            // 
            // label2_GD
            // 
            label2_GD.AutoSize = true;
            label2_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_GD.Location = new System.Drawing.Point(34, 426);
            label2_GD.Name = "label2_GD";
            label2_GD.Size = new System.Drawing.Size(78, 18);
            label2_GD.TabIndex = 9;
            label2_GD.Text = "Trạng Thái";
            // 
            // label3_GD
            // 
            label3_GD.AutoSize = true;
            label3_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_GD.Location = new System.Drawing.Point(34, 83);
            label3_GD.Name = "label3_GD";
            label3_GD.Size = new System.Drawing.Size(87, 18);
            label3_GD.TabIndex = 10;
            label3_GD.Text = "Mã hóa đơn";
            // 
            // label4_GD
            // 
            label4_GD.AutoSize = true;
            label4_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4_GD.Location = new System.Drawing.Point(34, 163);
            label4_GD.Name = "label4_GD";
            label4_GD.Size = new System.Drawing.Size(109, 18);
            label4_GD.TabIndex = 13;
            label4_GD.Text = "Mã khách hàng";
            // 
            // label5_GD
            // 
            label5_GD.AutoSize = true;
            label5_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5_GD.Location = new System.Drawing.Point(34, 236);
            label5_GD.Name = "label5_GD";
            label5_GD.Size = new System.Drawing.Size(95, 18);
            label5_GD.TabIndex = 14;
            label5_GD.Text = "Mã nhân viên";
            // 
            // CLB_GD_LoaiDon
            // 
            this.CLB_GD_LoaiDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CLB_GD_LoaiDon.CheckOnClick = true;
            this.CLB_GD_LoaiDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLB_GD_LoaiDon.Items.AddRange(new object[] {
            "Đơn đặt hàng",
            "Đơn trực tiếp"});
            this.CLB_GD_LoaiDon.Location = new System.Drawing.Point(37, 350);
            this.CLB_GD_LoaiDon.Name = "CLB_GD_LoaiDon";
            this.CLB_GD_LoaiDon.Size = new System.Drawing.Size(163, 61);
            this.CLB_GD_LoaiDon.TabIndex = 6;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage_tongquan);
            this.tabCtrl.Controls.Add(this.tabPage_HangHoa);
            this.tabCtrl.Controls.Add(this.tabPage_DoiTac);
            this.tabCtrl.Controls.Add(this.tabPage_GiaoDich);
            this.tabCtrl.Controls.Add(this.tabPage_NhanVien);
            this.tabCtrl.Controls.Add(this.tabPage_BaoCao);
            this.tabCtrl.Location = new System.Drawing.Point(3, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1204, 679);
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
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
            this.tabPage_HangHoa.Location = new System.Drawing.Point(4, 25);
            this.tabPage_HangHoa.Name = "tabPage_HangHoa";
            this.tabPage_HangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HangHoa.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            this.tabPage_HangHoa.UseVisualStyleBackColor = true;
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
            this.tabPage_GiaoDich.Controls.Add(label5_GD);
            this.tabPage_GiaoDich.Controls.Add(label4_GD);
            this.tabPage_GiaoDich.Controls.Add(this.BOX_GD_MaNhanVien);
            this.tabPage_GiaoDich.Controls.Add(this.Box_GD_MaKhachHang);
            this.tabPage_GiaoDich.Controls.Add(label3_GD);
            this.tabPage_GiaoDich.Controls.Add(label2_GD);
            this.tabPage_GiaoDich.Controls.Add(label1_GD);
            this.tabPage_GiaoDich.Controls.Add(this.CLB_GD_TrangThai);
            this.tabPage_GiaoDich.Controls.Add(this.CLB_GD_LoaiDon);
            this.tabPage_GiaoDich.Controls.Add(this.BNT_GD_inDS);
            this.tabPage_GiaoDich.Controls.Add(this.Box_GD_MaHoaDon);
            this.tabPage_GiaoDich.Controls.Add(this.bnt_GD_Timkiem);
            this.tabPage_GiaoDich.Controls.Add(this.GridView_Data_GiaoDich);
            this.tabPage_GiaoDich.Controls.Add(this.BNT_Refresh_GD);
            this.tabPage_GiaoDich.Controls.Add(this.BNT_TaoHoaDon);
            this.tabPage_GiaoDich.Location = new System.Drawing.Point(4, 25);
            this.tabPage_GiaoDich.Name = "tabPage_GiaoDich";
            this.tabPage_GiaoDich.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GiaoDich.Size = new System.Drawing.Size(1196, 650);
            this.tabPage_GiaoDich.TabIndex = 3;
            this.tabPage_GiaoDich.Text = "Giao dịch";
            this.tabPage_GiaoDich.UseVisualStyleBackColor = true;
            // 
            // BOX_GD_MaNhanVien
            // 
            this.BOX_GD_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOX_GD_MaNhanVien.Location = new System.Drawing.Point(37, 267);
            this.BOX_GD_MaNhanVien.Name = "BOX_GD_MaNhanVien";
            this.BOX_GD_MaNhanVien.Size = new System.Drawing.Size(163, 28);
            this.BOX_GD_MaNhanVien.TabIndex = 12;
            // 
            // Box_GD_MaKhachHang
            // 
            this.Box_GD_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_GD_MaKhachHang.Location = new System.Drawing.Point(37, 194);
            this.Box_GD_MaKhachHang.Name = "Box_GD_MaKhachHang";
            this.Box_GD_MaKhachHang.Size = new System.Drawing.Size(163, 28);
            this.Box_GD_MaKhachHang.TabIndex = 11;
            // 
            // CLB_GD_TrangThai
            // 
            this.CLB_GD_TrangThai.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CLB_GD_TrangThai.CheckOnClick = true;
            this.CLB_GD_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLB_GD_TrangThai.ForeColor = System.Drawing.Color.Black;
            this.CLB_GD_TrangThai.Items.AddRange(new object[] {
            "Nhận đơn",
            "Đạng giao",
            "Hoàn Thành"});
            this.CLB_GD_TrangThai.Location = new System.Drawing.Point(37, 460);
            this.CLB_GD_TrangThai.Name = "CLB_GD_TrangThai";
            this.CLB_GD_TrangThai.Size = new System.Drawing.Size(163, 80);
            this.CLB_GD_TrangThai.TabIndex = 7;
            // 
            // BNT_GD_inDS
            // 
            this.BNT_GD_inDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_GD_inDS.Location = new System.Drawing.Point(689, 19);
            this.BNT_GD_inDS.Name = "BNT_GD_inDS";
            this.BNT_GD_inDS.Size = new System.Drawing.Size(163, 48);
            this.BNT_GD_inDS.TabIndex = 5;
            this.BNT_GD_inDS.Text = "In Danh Sach";
            this.BNT_GD_inDS.UseVisualStyleBackColor = true;
            this.BNT_GD_inDS.Click += new System.EventHandler(this.bnt_inDS_Click);
            // 
            // Box_GD_MaHoaDon
            // 
            this.Box_GD_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_GD_MaHoaDon.Location = new System.Drawing.Point(37, 117);
            this.Box_GD_MaHoaDon.Name = "Box_GD_MaHoaDon";
            this.Box_GD_MaHoaDon.Size = new System.Drawing.Size(163, 28);
            this.Box_GD_MaHoaDon.TabIndex = 4;
            // 
            // bnt_GD_Timkiem
            // 
            this.bnt_GD_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_GD_Timkiem.Location = new System.Drawing.Point(37, 19);
            this.bnt_GD_Timkiem.Name = "bnt_GD_Timkiem";
            this.bnt_GD_Timkiem.Size = new System.Drawing.Size(163, 48);
            this.bnt_GD_Timkiem.TabIndex = 3;
            this.bnt_GD_Timkiem.Text = "Tìm Kiếm";
            this.bnt_GD_Timkiem.UseVisualStyleBackColor = true;
            this.bnt_GD_Timkiem.Click += new System.EventHandler(this.bnt_Timkiem_Click);
            // 
            // GridView_Data_GiaoDich
            // 
            this.GridView_Data_GiaoDich.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridView_Data_GiaoDich.AllowUserToResizeRows = false;
            this.GridView_Data_GiaoDich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Data_GiaoDich.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridView_Data_GiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Data_GiaoDich.GridColor = System.Drawing.SystemColors.Control;
            this.GridView_Data_GiaoDich.Location = new System.Drawing.Point(232, 73);
            this.GridView_Data_GiaoDich.Name = "GridView_Data_GiaoDich";
            this.GridView_Data_GiaoDich.ReadOnly = true;
            this.GridView_Data_GiaoDich.RowHeadersWidth = 51;
            this.GridView_Data_GiaoDich.RowTemplate.Height = 24;
            this.GridView_Data_GiaoDich.Size = new System.Drawing.Size(958, 571);
            this.GridView_Data_GiaoDich.TabIndex = 2;
            this.GridView_Data_GiaoDich.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Data_GiaoDich_CellDoubleClick);
            // 
            // BNT_Refresh_GD
            // 
            this.BNT_Refresh_GD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_Refresh_GD.Location = new System.Drawing.Point(858, 19);
            this.BNT_Refresh_GD.Name = "BNT_Refresh_GD";
            this.BNT_Refresh_GD.Size = new System.Drawing.Size(163, 48);
            this.BNT_Refresh_GD.TabIndex = 1;
            this.BNT_Refresh_GD.Text = "Làm mới";
            this.BNT_Refresh_GD.UseVisualStyleBackColor = true;
            this.BNT_Refresh_GD.Click += new System.EventHandler(this.BNT_Refresh_GD_Click);
            // 
            // BNT_TaoHoaDon
            // 
            this.BNT_TaoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_TaoHoaDon.Location = new System.Drawing.Point(1030, 19);
            this.BNT_TaoHoaDon.Name = "BNT_TaoHoaDon";
            this.BNT_TaoHoaDon.Size = new System.Drawing.Size(163, 48);
            this.BNT_TaoHoaDon.TabIndex = 0;
            this.BNT_TaoHoaDon.Text = "Tạo Hóa Đơn";
            this.BNT_TaoHoaDon.UseVisualStyleBackColor = true;
            this.BNT_TaoHoaDon.Click += new System.EventHandler(this.BNT_TaoHoaDon_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_GD);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 691);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Form_main_admin";
            this.Text = "Form_main";
            this.tabCtrl.ResumeLayout(false);
            this.tabPage_tongquan.ResumeLayout(false);
            this.tabPage_GiaoDich.ResumeLayout(false);
            this.tabPage_GiaoDich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Data_GiaoDich)).EndInit();
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
        private System.Windows.Forms.Button BNT_Refresh_GD;
        private System.Windows.Forms.Button BNT_TaoHoaDon;
        private System.Windows.Forms.DataGridView GridView_Data_GiaoDich;
        private System.Windows.Forms.TextBox Box_GD_MaHoaDon;
        private System.Windows.Forms.Button bnt_GD_Timkiem;
        private System.Windows.Forms.Button BNT_GD_inDS;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.CheckedListBox CLB_GD_TrangThai;
        private System.Windows.Forms.CheckedListBox CLB_GD_LoaiDon;
        private System.Windows.Forms.TextBox BOX_GD_MaNhanVien;
        private System.Windows.Forms.TextBox Box_GD_MaKhachHang;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}