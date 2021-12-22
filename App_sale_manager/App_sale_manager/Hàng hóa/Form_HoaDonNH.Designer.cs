
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HoaDonNH));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDHN = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnXemchitiet = new System.Windows.Forms.RadioButton();
            this.rbtnXemtatca = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThongTinNV_Tim = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "DANH SÁCH ĐƠN NHẬP HÀNG";
            // 
            // dgvHDHN
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvHDHN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDHN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHDHN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHDHN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHDHN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDHN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDHN.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDHN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHDHN.EnableHeadersVisualStyles = false;
            this.dgvHDHN.Location = new System.Drawing.Point(651, 67);
            this.dgvHDHN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHDHN.Name = "dgvHDHN";
            this.dgvHDHN.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDHN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHDHN.RowHeadersWidth = 51;
            this.dgvHDHN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHDHN.RowTemplate.Height = 24;
            this.dgvHDHN.Size = new System.Drawing.Size(424, 485);
            this.dgvHDHN.TabIndex = 86;
            this.dgvHDHN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDHN_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(986, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 33);
            this.btnXoa.TabIndex = 89;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnChiTiet.Location = new System.Drawing.Point(149, 424);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(142, 38);
            this.btnChiTiet.TabIndex = 90;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(893, 23);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(88, 32);
            this.btnNhapHang.TabIndex = 91;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXemTatCa.Location = new System.Drawing.Point(149, 368);
            this.btnXemTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(142, 38);
            this.btnXemTatCa.TabIndex = 92;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = false;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // dgvChiTietNH
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvChiTietNH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTietNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietNH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietNH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietNH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietNH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietNH.ColumnHeadersHeight = 29;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietNH.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChiTietNH.EnableHeadersVisualStyles = false;
            this.dgvChiTietNH.Location = new System.Drawing.Point(340, 67);
            this.dgvChiTietNH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietNH.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(294, 398);
            this.dgvChiTietNH.TabIndex = 84;
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.Location = new System.Drawing.Point(15, 52);
            this.lblHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(68, 16);
            this.lblHang.TabIndex = 101;
            this.lblHang.Text = "Nhân viên";
            // 
            // cbbDoiTac
            // 
            this.cbbDoiTac.FormattingEnabled = true;
            this.cbbDoiTac.Location = new System.Drawing.Point(139, 103);
            this.cbbDoiTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDoiTac.Name = "cbbDoiTac";
            this.cbbDoiTac.Size = new System.Drawing.Size(162, 21);
            this.cbbDoiTac.TabIndex = 100;
            this.cbbDoiTac.SelectedIndexChanged += new System.EventHandler(this.cbbDoiTac_SelectedIndexChanged);
            this.cbbDoiTac.TextChanged += new System.EventHandler(this.cbbDoiTac_TextChanged);
            this.cbbDoiTac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDoiTac_KeyPress);
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(139, 155);
            this.txtTriGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(162, 20);
            this.txtTriGia.TabIndex = 99;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtTriGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTriGia_KeyPress);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(15, 156);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(90, 16);
            this.lblGiaBan.TabIndex = 98;
            this.lblGiaBan.Text = "Giá trị tối thiểu";
            // 
            // txtMaHDNH
            // 
            this.txtMaHDNH.Location = new System.Drawing.Point(140, 21);
            this.txtMaHDNH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHDNH.Name = "txtMaHDNH";
            this.txtMaHDNH.Size = new System.Drawing.Size(162, 20);
            this.txtMaHDNH.TabIndex = 96;
            this.txtMaHDNH.TextChanged += new System.EventHandler(this.txtMaHDNH_TextChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(15, 104);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(49, 16);
            this.lblTenSP.TabIndex = 95;
            this.lblTenSP.Text = "Đối tác";
            // 
            // lblLoaiID
            // 
            this.lblLoaiID.AutoSize = true;
            this.lblLoaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiID.Location = new System.Drawing.Point(16, 20);
            this.lblLoaiID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiID.Name = "lblLoaiID";
            this.lblLoaiID.Size = new System.Drawing.Size(119, 16);
            this.lblLoaiID.TabIndex = 93;
            this.lblLoaiID.Text = "Mã đơn nhập hàng";
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(139, 51);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(162, 21);
            this.cbbNhanVien.TabIndex = 102;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            this.cbbNhanVien.TextChanged += new System.EventHandler(this.cbbNhanVien_TextChanged);
            this.cbbNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbNhanVien_KeyPress);
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(139, 78);
            this.txtNVID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.ReadOnly = true;
            this.txtNVID.Size = new System.Drawing.Size(162, 20);
            this.txtNVID.TabIndex = 105;
            this.txtNVID.TextChanged += new System.EventHandler(this.txtNVID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtDTID
            // 
            this.txtDTID.Location = new System.Drawing.Point(139, 130);
            this.txtDTID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDTID.Name = "txtDTID";
            this.txtDTID.ReadOnly = true;
            this.txtDTID.Size = new System.Drawing.Size(162, 20);
            this.txtDTID.TabIndex = 107;
            this.txtDTID.TextChanged += new System.EventHandler(this.txtDTID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Mã đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "CHI TIẾT ĐƠN NHẬP HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbtnXemchitiet);
            this.panel1.Controls.Add(this.rbtnXemtatca);
            this.panel1.Controls.Add(this.btnXemTatCa);
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnThongTinNV_Tim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 583);
            this.panel1.TabIndex = 109;
            // 
            // rbtnXemchitiet
            // 
            this.rbtnXemchitiet.AutoSize = true;
            this.rbtnXemchitiet.Location = new System.Drawing.Point(17, 403);
            this.rbtnXemchitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnXemchitiet.Name = "rbtnXemchitiet";
            this.rbtnXemchitiet.Size = new System.Drawing.Size(80, 17);
            this.rbtnXemchitiet.TabIndex = 93;
            this.rbtnXemchitiet.TabStop = true;
            this.rbtnXemchitiet.Text = "Xem chi tiết";
            this.rbtnXemchitiet.UseVisualStyleBackColor = true;
            // 
            // rbtnXemtatca
            // 
            this.rbtnXemtatca.AutoSize = true;
            this.rbtnXemtatca.Location = new System.Drawing.Point(18, 368);
            this.rbtnXemtatca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnXemtatca.Name = "rbtnXemtatca";
            this.rbtnXemtatca.Size = new System.Drawing.Size(76, 17);
            this.rbtnXemtatca.TabIndex = 93;
            this.rbtnXemtatca.TabStop = true;
            this.rbtnXemtatca.Text = "Xem tất cả";
            this.rbtnXemtatca.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 44);
            this.button1.TabIndex = 7;
            this.button1.Tag = "0";
            this.button1.Text = "     Chế độ xem";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaHDNH);
            this.panel3.Controls.Add(this.lblLoaiID);
            this.panel3.Controls.Add(this.txtDTID);
            this.panel3.Controls.Add(this.lblTenSP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblGiaBan);
            this.panel3.Controls.Add(this.txtNVID);
            this.panel3.Controls.Add(this.txtTriGia);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbbDoiTac);
            this.panel3.Controls.Add(this.cbbNhanVien);
            this.panel3.Controls.Add(this.lblHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 197);
            this.panel3.TabIndex = 6;
            // 
            // btnThongTinNV_Tim
            // 
            this.btnThongTinNV_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btnThongTinNV_Tim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinNV_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinNV_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinNV_Tim.ForeColor = System.Drawing.Color.White;
            this.btnThongTinNV_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinNV_Tim.Location = new System.Drawing.Point(0, 64);
            this.btnThongTinNV_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongTinNV_Tim.Name = "btnThongTinNV_Tim";
            this.btnThongTinNV_Tim.Size = new System.Drawing.Size(314, 44);
            this.btnThongTinNV_Tim.TabIndex = 5;
            this.btnThongTinNV_Tim.Tag = "0";
            this.btnThongTinNV_Tim.Text = "     Tìm kiếm";
            this.btnThongTinNV_Tim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinNV_Tim.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 64);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(340, 470);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 81);
            this.panel4.TabIndex = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(176, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(100, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // Form_HoaDonNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1084, 587);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHDHN);
            this.Controls.Add(this.dgvChiTietNH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_HoaDonNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHDHN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThongTinNV_Tim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnXemchitiet;
        private System.Windows.Forms.RadioButton rbtnXemtatca;
    }
}