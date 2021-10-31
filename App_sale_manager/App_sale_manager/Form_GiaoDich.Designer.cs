
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CT_HD = new System.Windows.Forms.DataGridView();
            this.SpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_addsp = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bnt_Huy = new System.Windows.Forms.Button();
            this.bnt_tao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_LuaChon = new System.Windows.Forms.DataGridView();
            this.Box_SP = new System.Windows.Forms.TextBox();
            this.Box_IDHD = new System.Windows.Forms.TextBox();
            this.Box_IDNV = new System.Windows.Forms.TextBox();
            this.Box_Tong = new System.Windows.Forms.TextBox();
            this.bnt_removesp = new System.Windows.Forms.Button();
            this.Box_LoaiHD = new System.Windows.Forms.ComboBox();
            this.Box_TrangThai = new System.Windows.Forms.ComboBox();
            this.Box_IDKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 31, 8, 34, 23, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày Tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tổng Trị Giá";
            // 
            // CT_HD
            // 
            this.CT_HD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CT_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CT_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpID,
            this.TriGia,
            this.SL_SP});
            this.CT_HD.Location = new System.Drawing.Point(377, 76);
            this.CT_HD.Name = "CT_HD";
            this.CT_HD.ReadOnly = true;
            this.CT_HD.RowHeadersWidth = 51;
            this.CT_HD.RowTemplate.Height = 24;
            this.CT_HD.Size = new System.Drawing.Size(561, 594);
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
            this.SpID.Width = 125;
            // 
            // TriGia
            // 
            this.TriGia.HeaderText = "Giá (1 SP)";
            this.TriGia.MinimumWidth = 6;
            this.TriGia.Name = "TriGia";
            this.TriGia.ReadOnly = true;
            this.TriGia.Width = 125;
            // 
            // SL_SP
            // 
            this.SL_SP.HeaderText = "Số Lượng";
            this.SL_SP.MinimumWidth = 6;
            this.SL_SP.Name = "SL_SP";
            this.SL_SP.ReadOnly = true;
            this.SL_SP.Width = 125;
            // 
            // bnt_addsp
            // 
            this.bnt_addsp.Location = new System.Drawing.Point(61, 679);
            this.bnt_addsp.Name = "bnt_addsp";
            this.bnt_addsp.Size = new System.Drawing.Size(151, 44);
            this.bnt_addsp.TabIndex = 21;
            this.bnt_addsp.Text = "Thêm sản phẩm vào giỏ hàng";
            this.bnt_addsp.UseVisualStyleBackColor = true;
            this.bnt_addsp.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 365);
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
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // bnt_Huy
            // 
            this.bnt_Huy.Location = new System.Drawing.Point(786, 679);
            this.bnt_Huy.Name = "bnt_Huy";
            this.bnt_Huy.Size = new System.Drawing.Size(152, 44);
            this.bnt_Huy.TabIndex = 23;
            this.bnt_Huy.Text = "Hủy";
            this.bnt_Huy.UseVisualStyleBackColor = true;
            this.bnt_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_tao
            // 
            this.bnt_tao.Location = new System.Drawing.Point(600, 679);
            this.bnt_tao.Name = "bnt_tao";
            this.bnt_tao.Size = new System.Drawing.Size(180, 44);
            this.bnt_tao.TabIndex = 24;
            this.bnt_tao.Text = "Tạo Hóa Đơn";
            this.bnt_tao.UseVisualStyleBackColor = true;
            this.bnt_tao.Click += new System.EventHandler(this.bnt_tao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số Lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Giỏ Hàng";
            // 
            // DGV_LuaChon
            // 
            this.DGV_LuaChon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_LuaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LuaChon.Location = new System.Drawing.Point(61, 405);
            this.DGV_LuaChon.Name = "DGV_LuaChon";
            this.DGV_LuaChon.ReadOnly = true;
            this.DGV_LuaChon.RowHeadersWidth = 51;
            this.DGV_LuaChon.RowTemplate.Height = 24;
            this.DGV_LuaChon.ShowRowErrors = false;
            this.DGV_LuaChon.Size = new System.Drawing.Size(310, 268);
            this.DGV_LuaChon.TabIndex = 28;
            this.DGV_LuaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LuaChon_CellDoubleClick);
            // 
            // Box_SP
            // 
            this.Box_SP.Location = new System.Drawing.Point(143, 318);
            this.Box_SP.Multiline = true;
            this.Box_SP.Name = "Box_SP";
            this.Box_SP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Box_SP.Size = new System.Drawing.Size(228, 32);
            this.Box_SP.TabIndex = 29;
            this.Box_SP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Box_IDHD
            // 
            this.Box_IDHD.Location = new System.Drawing.Point(143, 41);
            this.Box_IDHD.Multiline = true;
            this.Box_IDHD.Name = "Box_IDHD";
            this.Box_IDHD.ReadOnly = true;
            this.Box_IDHD.Size = new System.Drawing.Size(228, 32);
            this.Box_IDHD.TabIndex = 30;
            // 
            // Box_IDNV
            // 
            this.Box_IDNV.Location = new System.Drawing.Point(143, 152);
            this.Box_IDNV.Multiline = true;
            this.Box_IDNV.Name = "Box_IDNV";
            this.Box_IDNV.ReadOnly = true;
            this.Box_IDNV.Size = new System.Drawing.Size(228, 32);
            this.Box_IDNV.TabIndex = 32;
            // 
            // Box_Tong
            // 
            this.Box_Tong.Location = new System.Drawing.Point(143, 280);
            this.Box_Tong.Multiline = true;
            this.Box_Tong.Name = "Box_Tong";
            this.Box_Tong.ReadOnly = true;
            this.Box_Tong.Size = new System.Drawing.Size(228, 32);
            this.Box_Tong.TabIndex = 35;
            this.Box_Tong.Text = "0";
            // 
            // bnt_removesp
            // 
            this.bnt_removesp.Location = new System.Drawing.Point(218, 679);
            this.bnt_removesp.Name = "bnt_removesp";
            this.bnt_removesp.Size = new System.Drawing.Size(153, 44);
            this.bnt_removesp.TabIndex = 36;
            this.bnt_removesp.Text = "Xóa sản phẩm khỏi giỏ hàng";
            this.bnt_removesp.UseVisualStyleBackColor = true;
            this.bnt_removesp.Click += new System.EventHandler(this.bnt_xoaSP_Click);
            // 
            // Box_LoaiHD
            // 
            this.Box_LoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_LoaiHD.FormattingEnabled = true;
            this.Box_LoaiHD.Items.AddRange(new object[] {
            "DTT",
            "DDH"});
            this.Box_LoaiHD.Location = new System.Drawing.Point(143, 202);
            this.Box_LoaiHD.Name = "Box_LoaiHD";
            this.Box_LoaiHD.Size = new System.Drawing.Size(228, 24);
            this.Box_LoaiHD.TabIndex = 37;
            this.Box_LoaiHD.TextChanged += new System.EventHandler(this.Box_LoaiHD_TextChanged);
            // 
            // Box_TrangThai
            // 
            this.Box_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TrangThai.FormattingEnabled = true;
            this.Box_TrangThai.Items.AddRange(new object[] {
            "NHANDON",
            "DANGGIAO",
            "HOANTAT"});
            this.Box_TrangThai.Location = new System.Drawing.Point(143, 244);
            this.Box_TrangThai.Name = "Box_TrangThai";
            this.Box_TrangThai.Size = new System.Drawing.Size(228, 24);
            this.Box_TrangThai.TabIndex = 38;
            // 
            // Box_IDKH
            // 
            this.Box_IDKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Box_IDKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_IDKH.FormattingEnabled = true;
            this.Box_IDKH.Location = new System.Drawing.Point(146, 120);
            this.Box_IDKH.Name = "Box_IDKH";
            this.Box_IDKH.Size = new System.Drawing.Size(224, 24);
            this.Box_IDKH.TabIndex = 39;
            // 
            // Form_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 735);
            this.Controls.Add(this.Box_IDKH);
            this.Controls.Add(this.Box_TrangThai);
            this.Controls.Add(this.Box_LoaiHD);
            this.Controls.Add(this.bnt_removesp);
            this.Controls.Add(this.Box_Tong);
            this.Controls.Add(this.Box_IDNV);
            this.Controls.Add(this.Box_IDHD);
            this.Controls.Add(this.Box_SP);
            this.Controls.Add(this.DGV_LuaChon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bnt_tao);
            this.Controls.Add(this.bnt_Huy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bnt_addsp);
            this.Controls.Add(this.CT_HD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form_GiaoDich";
            this.Text = "Form_GiaoDich";
            ((System.ComponentModel.ISupportInitialize)(this.CT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LuaChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CT_HD;
        private System.Windows.Forms.Button bnt_addsp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bnt_Huy;
        private System.Windows.Forms.Button bnt_tao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGV_LuaChon;
        private System.Windows.Forms.TextBox Box_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_SP;
        private System.Windows.Forms.TextBox Box_IDHD;
        private System.Windows.Forms.TextBox Box_IDNV;
        private System.Windows.Forms.TextBox Box_Tong;
        private System.Windows.Forms.Button bnt_removesp;
        private System.Windows.Forms.ComboBox Box_LoaiHD;
        private System.Windows.Forms.ComboBox Box_TrangThai;
        private System.Windows.Forms.ComboBox Box_IDKH;
    }
}