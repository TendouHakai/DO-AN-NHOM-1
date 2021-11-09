
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
            this.SpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_addsp = new System.Windows.Forms.Button();
            this.bnt_Huy = new System.Windows.Forms.Button();
            this.bnt_tao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_LuaChon = new System.Windows.Forms.DataGridView();
            this.bnt_removesp = new System.Windows.Forms.Button();
            this.DTP_NGHD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Box_MASP = new System.Windows.Forms.TextBox();
            this.Box_IDHD = new System.Windows.Forms.TextBox();
            this.Box_IDNV = new System.Windows.Forms.TextBox();
            this.Box_Tong = new System.Windows.Forms.TextBox();
            this.Box_LoaiHD = new System.Windows.Forms.ComboBox();
            this.Box_TrangThai = new System.Windows.Forms.ComboBox();
            this.Box_IDKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box_TenKH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Box_TenSP = new System.Windows.Forms.TextBox();
            this.PTX_SanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTX_SanPham)).BeginInit();
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
            this.CT_HD.Location = new System.Drawing.Point(815, 86);
            this.CT_HD.Name = "CT_HD";
            this.CT_HD.ReadOnly = true;
            this.CT_HD.RowHeadersWidth = 51;
            this.CT_HD.RowTemplate.Height = 24;
            this.CT_HD.Size = new System.Drawing.Size(525, 587);
            this.CT_HD.TabIndex = 19;
            this.CT_HD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CT_HD_CellDoubleClick);
            this.CT_HD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CT_HD_RowsAdded);
            this.CT_HD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.CT_HD_RowsRemoved);
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
            this.TriGia.HeaderText = "Giá (1 SP)";
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
            // bnt_addsp
            // 
            this.bnt_addsp.BackColor = System.Drawing.SystemColors.Control;
            this.bnt_addsp.Location = new System.Drawing.Point(423, 674);
            this.bnt_addsp.Name = "bnt_addsp";
            this.bnt_addsp.Size = new System.Drawing.Size(151, 44);
            this.bnt_addsp.TabIndex = 21;
            this.bnt_addsp.Text = "Thêm sản phẩm vào giỏ hàng";
            this.bnt_addsp.UseVisualStyleBackColor = false;
            this.bnt_addsp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_Huy
            // 
            this.bnt_Huy.BackColor = System.Drawing.SystemColors.Control;
            this.bnt_Huy.Location = new System.Drawing.Point(1116, 679);
            this.bnt_Huy.Name = "bnt_Huy";
            this.bnt_Huy.Size = new System.Drawing.Size(152, 44);
            this.bnt_Huy.TabIndex = 23;
            this.bnt_Huy.Text = "Hủy";
            this.bnt_Huy.UseVisualStyleBackColor = false;
            this.bnt_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_tao
            // 
            this.bnt_tao.BackColor = System.Drawing.SystemColors.Control;
            this.bnt_tao.Location = new System.Drawing.Point(875, 679);
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
            this.label10.Location = new System.Drawing.Point(809, 44);
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
            this.DGV_LuaChon.Location = new System.Drawing.Point(370, 192);
            this.DGV_LuaChon.Name = "DGV_LuaChon";
            this.DGV_LuaChon.ReadOnly = true;
            this.DGV_LuaChon.RowHeadersWidth = 51;
            this.DGV_LuaChon.RowTemplate.Height = 24;
            this.DGV_LuaChon.ShowRowErrors = false;
            this.DGV_LuaChon.Size = new System.Drawing.Size(419, 476);
            this.DGV_LuaChon.TabIndex = 28;
            this.DGV_LuaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LuaChon_CellDoubleClick);
            this.DGV_LuaChon.SelectionChanged += new System.EventHandler(this.DGV_LuaChon_SelectionChanged);
            // 
            // bnt_removesp
            // 
            this.bnt_removesp.BackColor = System.Drawing.SystemColors.Control;
            this.bnt_removesp.Location = new System.Drawing.Point(583, 674);
            this.bnt_removesp.Name = "bnt_removesp";
            this.bnt_removesp.Size = new System.Drawing.Size(153, 44);
            this.bnt_removesp.TabIndex = 36;
            this.bnt_removesp.Text = "Xóa sản phẩm khỏi giỏ hàng";
            this.bnt_removesp.UseVisualStyleBackColor = false;
            this.bnt_removesp.Click += new System.EventHandler(this.bnt_xoaSP_Click);
            // 
            // DTP_NGHD
            // 
            this.DTP_NGHD.Location = new System.Drawing.Point(159, 118);
            this.DTP_NGHD.Name = "DTP_NGHD";
            this.DTP_NGHD.Size = new System.Drawing.Size(179, 22);
            this.DTP_NGHD.TabIndex = 1;
            this.DTP_NGHD.Value = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại Hóa Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày Tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tổng Trị Giá";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(172, 759);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(228, 22);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 763);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số Lượng";
            // 
            // Box_MASP
            // 
            this.Box_MASP.Location = new System.Drawing.Point(555, 115);
            this.Box_MASP.Name = "Box_MASP";
            this.Box_MASP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Box_MASP.Size = new System.Drawing.Size(212, 22);
            this.Box_MASP.TabIndex = 29;
            this.Box_MASP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Box_IDHD
            // 
            this.Box_IDHD.BackColor = System.Drawing.Color.White;
            this.Box_IDHD.Location = new System.Drawing.Point(160, 63);
            this.Box_IDHD.Name = "Box_IDHD";
            this.Box_IDHD.ReadOnly = true;
            this.Box_IDHD.Size = new System.Drawing.Size(178, 22);
            this.Box_IDHD.TabIndex = 30;
            // 
            // Box_IDNV
            // 
            this.Box_IDNV.BackColor = System.Drawing.Color.White;
            this.Box_IDNV.Location = new System.Drawing.Point(159, 266);
            this.Box_IDNV.Name = "Box_IDNV";
            this.Box_IDNV.ReadOnly = true;
            this.Box_IDNV.Size = new System.Drawing.Size(179, 22);
            this.Box_IDNV.TabIndex = 32;
            // 
            // Box_Tong
            // 
            this.Box_Tong.BackColor = System.Drawing.Color.White;
            this.Box_Tong.Location = new System.Drawing.Point(159, 428);
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
            this.Box_LoaiHD.FormattingEnabled = true;
            this.Box_LoaiHD.Items.AddRange(new object[] {
            "DTT",
            "DDH"});
            this.Box_LoaiHD.Location = new System.Drawing.Point(159, 324);
            this.Box_LoaiHD.Name = "Box_LoaiHD";
            this.Box_LoaiHD.Size = new System.Drawing.Size(179, 24);
            this.Box_LoaiHD.TabIndex = 37;
            this.Box_LoaiHD.TextChanged += new System.EventHandler(this.Box_LoaiHD_TextChanged);
            // 
            // Box_TrangThai
            // 
            this.Box_TrangThai.BackColor = System.Drawing.Color.White;
            this.Box_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TrangThai.FormattingEnabled = true;
            this.Box_TrangThai.Items.AddRange(new object[] {
            "NHANDON",
            "DANGGIAO",
            "HOANTAT"});
            this.Box_TrangThai.Location = new System.Drawing.Point(160, 375);
            this.Box_TrangThai.Name = "Box_TrangThai";
            this.Box_TrangThai.Size = new System.Drawing.Size(178, 24);
            this.Box_TrangThai.TabIndex = 38;
            // 
            // Box_IDKH
            // 
            this.Box_IDKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Box_IDKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_IDKH.FormattingEnabled = true;
            this.Box_IDKH.Location = new System.Drawing.Point(160, 171);
            this.Box_IDKH.Name = "Box_IDKH";
            this.Box_IDKH.Size = new System.Drawing.Size(178, 24);
            this.Box_IDKH.TabIndex = 39;
            this.Box_IDKH.SelectedIndexChanged += new System.EventHandler(this.Box_IDKH_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box_TenKH);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Box_IDKH);
            this.groupBox1.Controls.Add(this.Box_TrangThai);
            this.groupBox1.Controls.Add(this.Box_LoaiHD);
            this.groupBox1.Controls.Add(this.Box_Tong);
            this.groupBox1.Controls.Add(this.Box_IDNV);
            this.groupBox1.Controls.Add(this.Box_IDHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DTP_NGHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 465);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // Box_TenKH
            // 
            this.Box_TenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Box_TenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_TenKH.FormattingEnabled = true;
            this.Box_TenKH.Location = new System.Drawing.Point(159, 222);
            this.Box_TenKH.Name = "Box_TenKH";
            this.Box_TenKH.Size = new System.Drawing.Size(178, 24);
            this.Box_TenKH.TabIndex = 43;
            this.Box_TenKH.SelectedIndexChanged += new System.EventHandler(this.Box_TenKH_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(416, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 502);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "Mã Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 40;
            this.label14.Text = "Trạng Thái";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NHANDON",
            "DANGGIAO",
            "HOANTAT"});
            this.comboBox2.Location = new System.Drawing.Point(160, 375);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 24);
            this.comboBox2.TabIndex = 38;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DTT",
            "DDH"});
            this.comboBox3.Location = new System.Drawing.Point(159, 324);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 24);
            this.comboBox3.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(159, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(159, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(160, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(227, 22);
            this.textBox3.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Mã Khách Hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "Tổng Trị Giá";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(65, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 18);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ngày Tạo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 18);
            this.label18.TabIndex = 15;
            this.label18.Text = "Mã Nhân Viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 31, 8, 34, 23, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(37, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 18);
            this.label19.TabIndex = 13;
            this.label19.Text = "Loại Hóa Đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(46, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 18);
            this.label20.TabIndex = 10;
            this.label20.Text = "Số Hóa Đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Tên Khách Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Trạng Thái";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(402, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 18);
            this.label21.TabIndex = 41;
            this.label21.Text = "Tìm kiếm sản phẩm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(402, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 18);
            this.label22.TabIndex = 42;
            this.label22.Text = "Tên sản phẩm";
            // 
            // Box_TenSP
            // 
            this.Box_TenSP.Location = new System.Drawing.Point(555, 151);
            this.Box_TenSP.Name = "Box_TenSP";
            this.Box_TenSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Box_TenSP.Size = new System.Drawing.Size(212, 22);
            this.Box_TenSP.TabIndex = 43;
            this.Box_TenSP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PTX_SanPham
            // 
            this.PTX_SanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PTX_SanPham.Location = new System.Drawing.Point(56, 493);
            this.PTX_SanPham.Name = "PTX_SanPham";
            this.PTX_SanPham.Size = new System.Drawing.Size(288, 225);
            this.PTX_SanPham.TabIndex = 44;
            this.PTX_SanPham.TabStop = false;
            // 
            // Form_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 735);
            this.Controls.Add(this.PTX_SanPham);
            this.Controls.Add(this.Box_TenSP);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnt_removesp);
            this.Controls.Add(this.DGV_LuaChon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_tao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bnt_Huy);
            this.Controls.Add(this.Box_MASP);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bnt_addsp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CT_HD);
            this.Controls.Add(this.label3);
            this.Name = "Form_GiaoDich";
            this.Text = "Form_GiaoDich";
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTX_SanPham)).EndInit();
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
        private System.Windows.Forms.DateTimePicker DTP_NGHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Box_MASP;
        private System.Windows.Forms.TextBox Box_IDHD;
        private System.Windows.Forms.TextBox Box_IDNV;
        private System.Windows.Forms.TextBox Box_Tong;
        private System.Windows.Forms.ComboBox Box_LoaiHD;
        private System.Windows.Forms.ComboBox Box_TrangThai;
        private System.Windows.Forms.ComboBox Box_IDKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_SP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Box_TenSP;
        private System.Windows.Forms.ComboBox Box_TenKH;
        private System.Windows.Forms.PictureBox PTX_SanPham;
    }
}