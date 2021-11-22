
namespace App_sale_manager
{
    partial class Form_GiaoDich
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
            this.CT_HD = new System.Windows.Forms.DataGridView();
            this.bnt_addsp = new System.Windows.Forms.Button();
            this.bnt_Huy = new System.Windows.Forms.Button();
            this.bnt_tao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_LuaChon = new System.Windows.Forms.DataGridView();
            this.bnt_removesp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Box_MASP = new System.Windows.Forms.TextBox();
            this.Box_IDHD = new System.Windows.Forms.TextBox();
            this.Box_IDNV = new System.Windows.Forms.TextBox();
            this.Box_Tong = new System.Windows.Forms.TextBox();
            this.Box_LoaiHD = new System.Windows.Forms.ComboBox();
            this.Box_TrangThai = new System.Windows.Forms.ComboBox();
            this.Box_IDKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box_TenKH = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Box_TenSP = new System.Windows.Forms.TextBox();
            this.PTX_SanPham = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grb_hoadon_themsp = new System.Windows.Forms.GroupBox();
            this.SpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTX_SanPham)).BeginInit();
            this.grb_hoadon_themsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // CT_HD
            // 
            this.CT_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CT_HD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CT_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CT_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpID,
            this.Column1,
            this.TriGia,
            this.SL_SP});
            this.CT_HD.Location = new System.Drawing.Point(893, 86);
            this.CT_HD.Name = "CT_HD";
            this.CT_HD.ReadOnly = true;
            this.CT_HD.RowHeadersWidth = 51;
            this.CT_HD.RowTemplate.Height = 24;
            this.CT_HD.Size = new System.Drawing.Size(593, 598);
            this.CT_HD.TabIndex = 19;
            this.CT_HD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CT_HD_CellDoubleClick);
            this.CT_HD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CT_HD_RowsAdded);
            this.CT_HD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.CT_HD_RowsRemoved);
            // 
            // bnt_addsp
            // 
            this.bnt_addsp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnt_addsp.Location = new System.Drawing.Point(39, 173);
            this.bnt_addsp.Name = "bnt_addsp";
            this.bnt_addsp.Size = new System.Drawing.Size(165, 68);
            this.bnt_addsp.TabIndex = 21;
            this.bnt_addsp.Text = "Thêm sản phẩm vào giỏ hàng";
            this.bnt_addsp.UseVisualStyleBackColor = false;
            this.bnt_addsp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_Huy
            // 
            this.bnt_Huy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnt_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Huy.Location = new System.Drawing.Point(1113, 728);
            this.bnt_Huy.Name = "bnt_Huy";
            this.bnt_Huy.Size = new System.Drawing.Size(152, 44);
            this.bnt_Huy.TabIndex = 23;
            this.bnt_Huy.Text = "Hủy";
            this.bnt_Huy.UseVisualStyleBackColor = false;
            this.bnt_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_tao
            // 
            this.bnt_tao.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnt_tao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_tao.Location = new System.Drawing.Point(880, 728);
            this.bnt_tao.Name = "bnt_tao";
            this.bnt_tao.Size = new System.Drawing.Size(180, 44);
            this.bnt_tao.TabIndex = 24;
            this.bnt_tao.Text = "Tạo Hóa Đơn";
            this.bnt_tao.UseVisualStyleBackColor = false;
            this.bnt_tao.Click += new System.EventHandler(this.bnt_tao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(925, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Giỏ Hàng";
            // 
            // DGV_LuaChon
            // 
            this.DGV_LuaChon.AllowUserToResizeColumns = false;
            this.DGV_LuaChon.AllowUserToResizeRows = false;
            this.DGV_LuaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LuaChon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_LuaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LuaChon.Location = new System.Drawing.Point(370, 268);
            this.DGV_LuaChon.Name = "DGV_LuaChon";
            this.DGV_LuaChon.ReadOnly = true;
            this.DGV_LuaChon.RowHeadersWidth = 51;
            this.DGV_LuaChon.RowTemplate.Height = 24;
            this.DGV_LuaChon.ShowRowErrors = false;
            this.DGV_LuaChon.Size = new System.Drawing.Size(517, 416);
            this.DGV_LuaChon.TabIndex = 28;
            this.DGV_LuaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LuaChon_CellDoubleClick);
            this.DGV_LuaChon.SelectionChanged += new System.EventHandler(this.DGV_LuaChon_SelectionChanged);
            // 
            // bnt_removesp
            // 
            this.bnt_removesp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnt_removesp.Location = new System.Drawing.Point(222, 173);
            this.bnt_removesp.Name = "bnt_removesp";
            this.bnt_removesp.Size = new System.Drawing.Size(160, 67);
            this.bnt_removesp.TabIndex = 36;
            this.bnt_removesp.Text = "Xóa sản phẩm khỏi giỏ hàng";
            this.bnt_removesp.UseVisualStyleBackColor = false;
            this.bnt_removesp.Click += new System.EventHandler(this.bnt_xoaSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại Hóa Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1204, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tổng Trị Giá";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(189, 137);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(212, 22);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // Box_MASP
            // 
            this.Box_MASP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_MASP.Location = new System.Drawing.Point(189, 62);
            this.Box_MASP.Name = "Box_MASP";
            this.Box_MASP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Box_MASP.Size = new System.Drawing.Size(212, 22);
            this.Box_MASP.TabIndex = 29;
            this.Box_MASP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Box_IDHD
            // 
            this.Box_IDHD.BackColor = System.Drawing.Color.White;
            this.Box_IDHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_IDHD.Location = new System.Drawing.Point(160, 63);
            this.Box_IDHD.Name = "Box_IDHD";
            this.Box_IDHD.ReadOnly = true;
            this.Box_IDHD.Size = new System.Drawing.Size(178, 22);
            this.Box_IDHD.TabIndex = 30;
            // 
            // Box_IDNV
            // 
            this.Box_IDNV.BackColor = System.Drawing.Color.White;
            this.Box_IDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_IDNV.Location = new System.Drawing.Point(160, 200);
            this.Box_IDNV.Name = "Box_IDNV";
            this.Box_IDNV.ReadOnly = true;
            this.Box_IDNV.Size = new System.Drawing.Size(179, 22);
            this.Box_IDNV.TabIndex = 32;
            // 
            // Box_Tong
            // 
            this.Box_Tong.BackColor = System.Drawing.Color.White;
            this.Box_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Tong.Location = new System.Drawing.Point(1298, 691);
            this.Box_Tong.Name = "Box_Tong";
            this.Box_Tong.ReadOnly = true;
            this.Box_Tong.Size = new System.Drawing.Size(179, 22);
            this.Box_Tong.TabIndex = 35;
            this.Box_Tong.Text = "0";
            // 
            // Box_LoaiHD
            // 
            this.Box_LoaiHD.BackColor = System.Drawing.Color.White;
            this.Box_LoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_LoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_LoaiHD.FormattingEnabled = true;
            this.Box_LoaiHD.Items.AddRange(new object[] {
            "Đơn trực tiếp",
            "Đơn đặt hàng"});
            this.Box_LoaiHD.Location = new System.Drawing.Point(160, 258);
            this.Box_LoaiHD.Name = "Box_LoaiHD";
            this.Box_LoaiHD.Size = new System.Drawing.Size(179, 24);
            this.Box_LoaiHD.TabIndex = 37;
            this.Box_LoaiHD.TextChanged += new System.EventHandler(this.Box_LoaiHD_TextChanged);
            // 
            // Box_TrangThai
            // 
            this.Box_TrangThai.BackColor = System.Drawing.Color.White;
            this.Box_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TrangThai.FormattingEnabled = true;
            this.Box_TrangThai.Items.AddRange(new object[] {
            "Nhận đơn",
            "Đang giao",
            "Hoàn thành"});
            this.Box_TrangThai.Location = new System.Drawing.Point(161, 310);
            this.Box_TrangThai.Name = "Box_TrangThai";
            this.Box_TrangThai.Size = new System.Drawing.Size(178, 24);
            this.Box_TrangThai.TabIndex = 38;
            // 
            // Box_IDKH
            // 
            this.Box_IDKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Box_IDKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_IDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_IDKH.FormattingEnabled = true;
            this.Box_IDKH.Location = new System.Drawing.Point(161, 105);
            this.Box_IDKH.Name = "Box_IDKH";
            this.Box_IDKH.Size = new System.Drawing.Size(178, 24);
            this.Box_IDKH.TabIndex = 39;
            this.Box_IDKH.SelectedIndexChanged += new System.EventHandler(this.Box_IDKH_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box_TenKH);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Box_IDKH);
            this.groupBox1.Controls.Add(this.Box_TrangThai);
            this.groupBox1.Controls.Add(this.Box_LoaiHD);
            this.groupBox1.Controls.Add(this.Box_IDNV);
            this.groupBox1.Controls.Add(this.Box_IDHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 465);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // Box_TenKH
            // 
            this.Box_TenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Box_TenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TenKH.FormattingEnabled = true;
            this.Box_TenKH.Location = new System.Drawing.Point(160, 156);
            this.Box_TenKH.Name = "Box_TenKH";
            this.Box_TenKH.Size = new System.Drawing.Size(178, 24);
            this.Box_TenKH.TabIndex = 43;
            this.Box_TenKH.SelectedIndexChanged += new System.EventHandler(this.Box_TenKH_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Tên Khách Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Trạng Thái";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(36, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = "Tìm kiếm sản phẩm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(36, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 17);
            this.label22.TabIndex = 42;
            this.label22.Text = "Tên sản phẩm";
            // 
            // Box_TenSP
            // 
            this.Box_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TenSP.Location = new System.Drawing.Point(189, 98);
            this.Box_TenSP.Name = "Box_TenSP";
            this.Box_TenSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Box_TenSP.Size = new System.Drawing.Size(212, 22);
            this.Box_TenSP.TabIndex = 43;
            this.Box_TenSP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PTX_SanPham
            // 
            this.PTX_SanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PTX_SanPham.Location = new System.Drawing.Point(58, 384);
            this.PTX_SanPham.Name = "PTX_SanPham";
            this.PTX_SanPham.Size = new System.Drawing.Size(300, 300);
            this.PTX_SanPham.TabIndex = 44;
            this.PTX_SanPham.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Số lượng";
            // 
            // grb_hoadon_themsp
            // 
            this.grb_hoadon_themsp.Controls.Add(this.label21);
            this.grb_hoadon_themsp.Controls.Add(this.label13);
            this.grb_hoadon_themsp.Controls.Add(this.label8);
            this.grb_hoadon_themsp.Controls.Add(this.bnt_removesp);
            this.grb_hoadon_themsp.Controls.Add(this.numericUpDown1);
            this.grb_hoadon_themsp.Controls.Add(this.Box_TenSP);
            this.grb_hoadon_themsp.Controls.Add(this.Box_MASP);
            this.grb_hoadon_themsp.Controls.Add(this.label22);
            this.grb_hoadon_themsp.Controls.Add(this.bnt_addsp);
            this.grb_hoadon_themsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_hoadon_themsp.Location = new System.Drawing.Point(371, 22);
            this.grb_hoadon_themsp.Name = "grb_hoadon_themsp";
            this.grb_hoadon_themsp.Size = new System.Drawing.Size(432, 240);
            this.grb_hoadon_themsp.TabIndex = 46;
            this.grb_hoadon_themsp.TabStop = false;
            this.grb_hoadon_themsp.Text = "Thêm sản phẩm";
            // 
            // SpID
            // 
            this.SpID.HeaderText = "ID Sản Phẩm";
            this.SpID.MinimumWidth = 6;
            this.SpID.Name = "SpID";
            this.SpID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TriGia
            // 
            this.TriGia.HeaderText = "Giá (VNĐ)";
            this.TriGia.MinimumWidth = 6;
            this.TriGia.Name = "TriGia";
            this.TriGia.ReadOnly = true;
            // 
            // SL_SP
            // 
            this.SL_SP.HeaderText = "Số Lượng";
            this.SL_SP.MinimumWidth = 6;
            this.SL_SP.Name = "SL_SP";
            this.SL_SP.ReadOnly = true;
            // 
            // Form_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1489, 784);
            this.Controls.Add(this.grb_hoadon_themsp);
            this.Controls.Add(this.PTX_SanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_LuaChon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_tao);
            this.Controls.Add(this.Box_Tong);
            this.Controls.Add(this.bnt_Huy);
            this.Controls.Add(this.CT_HD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_GiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GiaoDich";
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTX_SanPham)).EndInit();
            this.grb_hoadon_themsp.ResumeLayout(false);
            this.grb_hoadon_themsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CT_HD;
        private System.Windows.Forms.Button bnt_addsp;
        private System.Windows.Forms.Button bnt_Huy;
        private System.Windows.Forms.Button bnt_tao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGV_LuaChon;
        private System.Windows.Forms.Button bnt_removesp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Box_MASP;
        private System.Windows.Forms.TextBox Box_IDHD;
        private System.Windows.Forms.TextBox Box_IDNV;
        private System.Windows.Forms.TextBox Box_Tong;
        private System.Windows.Forms.ComboBox Box_LoaiHD;
        private System.Windows.Forms.ComboBox Box_TrangThai;
        private System.Windows.Forms.ComboBox Box_IDKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Box_TenSP;
        private System.Windows.Forms.ComboBox Box_TenKH;
        private System.Windows.Forms.PictureBox PTX_SanPham;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grb_hoadon_themsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_SP;
    }
}