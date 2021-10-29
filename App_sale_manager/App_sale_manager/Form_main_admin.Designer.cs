
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
            this.components = new System.ComponentModel.Container();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage_tongquan = new System.Windows.Forms.TabPage();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.tabPage_HangHoa = new System.Windows.Forms.TabPage();
            this.tabPage_DoiTac = new System.Windows.Forms.TabPage();
            this.comboBox_searchOption = new System.Windows.Forms.ComboBox();
            this.label_listname = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_searchDTCC = new System.Windows.Forms.Button();
            this.button_deleteDTCC = new System.Windows.Forms.Button();
            this.button_modDTCC = new System.Windows.Forms.Button();
            this.button_addDTCC = new System.Windows.Forms.Button();
            this.label_DIACHItext = new System.Windows.Forms.Label();
            this.label_DIACHI = new System.Windows.Forms.Label();
            this.label_NGDTtext = new System.Windows.Forms.Label();
            this.label_NGDT = new System.Windows.Forms.Label();
            this.label_SDTtext = new System.Windows.Forms.Label();
            this.label_SDT = new System.Windows.Forms.Label();
            this.label_TENDTtext = new System.Windows.Forms.Label();
            this.label_TENDT = new System.Windows.Forms.Label();
            this.label_IDtext = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.dataGridView_DTCC = new System.Windows.Forms.DataGridView();
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.dTCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYBANHANG_LTTQDataSet = new App_sale_manager.QUANLYBANHANG_LTTQDataSet();
            this.dTCCTableAdapter = new App_sale_manager.QUANLYBANHANG_LTTQDataSetTableAdapters.DTCCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.tabCtrl.SuspendLayout();
            this.tabPage_tongquan.SuspendLayout();
            this.tabPage_DoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DTCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG_LTTQDataSet)).BeginInit();
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
            this.tabCtrl.Location = new System.Drawing.Point(10, 11);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(903, 552);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPage_tongquan
            // 
            this.tabPage_tongquan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_tongquan.Controls.Add(this.btn_dangxuat);
            this.tabPage_tongquan.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tongquan.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_tongquan.Name = "tabPage_tongquan";
            this.tabPage_tongquan.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_tongquan.Size = new System.Drawing.Size(895, 526);
            this.tabPage_tongquan.TabIndex = 0;
            this.tabPage_tongquan.Text = "Tổng quan";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(620, 400);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(244, 38);
            this.btn_dangxuat.TabIndex = 0;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // tabPage_HangHoa
            // 
            this.tabPage_HangHoa.Location = new System.Drawing.Point(4, 22);
            this.tabPage_HangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_HangHoa.Name = "tabPage_HangHoa";
            this.tabPage_HangHoa.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_HangHoa.Size = new System.Drawing.Size(895, 526);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            this.tabPage_HangHoa.UseVisualStyleBackColor = true;
            // 
            // tabPage_DoiTac
            // 
            this.tabPage_DoiTac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_DoiTac.Controls.Add(this.button_refresh);
            this.tabPage_DoiTac.Controls.Add(this.label1);
            this.tabPage_DoiTac.Controls.Add(this.comboBox_searchOption);
            this.tabPage_DoiTac.Controls.Add(this.label_listname);
            this.tabPage_DoiTac.Controls.Add(this.textBox_search);
            this.tabPage_DoiTac.Controls.Add(this.button_searchDTCC);
            this.tabPage_DoiTac.Controls.Add(this.button_deleteDTCC);
            this.tabPage_DoiTac.Controls.Add(this.button_modDTCC);
            this.tabPage_DoiTac.Controls.Add(this.button_addDTCC);
            this.tabPage_DoiTac.Controls.Add(this.label_DIACHItext);
            this.tabPage_DoiTac.Controls.Add(this.label_DIACHI);
            this.tabPage_DoiTac.Controls.Add(this.label_NGDTtext);
            this.tabPage_DoiTac.Controls.Add(this.label_NGDT);
            this.tabPage_DoiTac.Controls.Add(this.label_SDTtext);
            this.tabPage_DoiTac.Controls.Add(this.label_SDT);
            this.tabPage_DoiTac.Controls.Add(this.label_TENDTtext);
            this.tabPage_DoiTac.Controls.Add(this.label_TENDT);
            this.tabPage_DoiTac.Controls.Add(this.label_IDtext);
            this.tabPage_DoiTac.Controls.Add(this.label_ID);
            this.tabPage_DoiTac.Controls.Add(this.pictureBox_Logo);
            this.tabPage_DoiTac.Controls.Add(this.dataGridView_DTCC);
            this.tabPage_DoiTac.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoiTac.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_DoiTac.Name = "tabPage_DoiTac";
            this.tabPage_DoiTac.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_DoiTac.Size = new System.Drawing.Size(895, 526);
            this.tabPage_DoiTac.TabIndex = 2;
            this.tabPage_DoiTac.Text = "Đối tác";
            this.tabPage_DoiTac.Click += new System.EventHandler(this.tabPage_DoiTac_Click);
            // 
            // comboBox_searchOption
            // 
            this.comboBox_searchOption.FormattingEnabled = true;
            this.comboBox_searchOption.Items.AddRange(new object[] {
            "Mã đối tác",
            "Tên đối tác",
            "Số điện thoại",
            "Ngày trở thành đối tác",
            "Địa chỉ"});
            this.comboBox_searchOption.Location = new System.Drawing.Point(435, 39);
            this.comboBox_searchOption.Name = "comboBox_searchOption";
            this.comboBox_searchOption.Size = new System.Drawing.Size(126, 21);
            this.comboBox_searchOption.TabIndex = 18;
            this.comboBox_searchOption.Text = "Chưa chọn";
            this.comboBox_searchOption.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_listname
            // 
            this.label_listname.AutoSize = true;
            this.label_listname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listname.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_listname.Location = new System.Drawing.Point(60, 24);
            this.label_listname.Name = "label_listname";
            this.label_listname.Size = new System.Drawing.Size(231, 31);
            this.label_listname.TabIndex = 17;
            this.label_listname.Text = "Danh sách đối tác";
            this.label_listname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(567, 39);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(229, 20);
            this.textBox_search.TabIndex = 16;
            // 
            // button_searchDTCC
            // 
            this.button_searchDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_searchDTCC.Location = new System.Drawing.Point(802, 36);
            this.button_searchDTCC.Name = "button_searchDTCC";
            this.button_searchDTCC.Size = new System.Drawing.Size(75, 23);
            this.button_searchDTCC.TabIndex = 15;
            this.button_searchDTCC.Text = "Tìm";
            this.button_searchDTCC.UseVisualStyleBackColor = false;
            this.button_searchDTCC.Click += new System.EventHandler(this.button_searchDTCC_Click);
            // 
            // button_deleteDTCC
            // 
            this.button_deleteDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_deleteDTCC.Location = new System.Drawing.Point(752, 422);
            this.button_deleteDTCC.Name = "button_deleteDTCC";
            this.button_deleteDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_deleteDTCC.TabIndex = 14;
            this.button_deleteDTCC.Text = "Xóa";
            this.button_deleteDTCC.UseVisualStyleBackColor = false;
            this.button_deleteDTCC.Click += new System.EventHandler(this.button_deleteDTCC_Click);
            // 
            // button_modDTCC
            // 
            this.button_modDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modDTCC.Location = new System.Drawing.Point(567, 422);
            this.button_modDTCC.Name = "button_modDTCC";
            this.button_modDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_modDTCC.TabIndex = 13;
            this.button_modDTCC.Text = "Sửa";
            this.button_modDTCC.UseVisualStyleBackColor = false;
            this.button_modDTCC.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_addDTCC
            // 
            this.button_addDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addDTCC.Location = new System.Drawing.Point(377, 422);
            this.button_addDTCC.Name = "button_addDTCC";
            this.button_addDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_addDTCC.TabIndex = 12;
            this.button_addDTCC.Text = "Thêm";
            this.button_addDTCC.UseVisualStyleBackColor = false;
            this.button_addDTCC.Click += new System.EventHandler(this.button_addDTCC_Click);
            // 
            // label_DIACHItext
            // 
            this.label_DIACHItext.AutoSize = true;
            this.label_DIACHItext.Location = new System.Drawing.Point(125, 379);
            this.label_DIACHItext.Name = "label_DIACHItext";
            this.label_DIACHItext.Size = new System.Drawing.Size(48, 13);
            this.label_DIACHItext.TabIndex = 11;
            this.label_DIACHItext.Text = "text here";
            // 
            // label_DIACHI
            // 
            this.label_DIACHI.AutoSize = true;
            this.label_DIACHI.Location = new System.Drawing.Point(76, 379);
            this.label_DIACHI.Name = "label_DIACHI";
            this.label_DIACHI.Size = new System.Drawing.Size(43, 13);
            this.label_DIACHI.TabIndex = 10;
            this.label_DIACHI.Text = "Địa chỉ:";
            // 
            // label_NGDTtext
            // 
            this.label_NGDTtext.AutoSize = true;
            this.label_NGDTtext.Location = new System.Drawing.Point(125, 343);
            this.label_NGDTtext.Name = "label_NGDTtext";
            this.label_NGDTtext.Size = new System.Drawing.Size(48, 13);
            this.label_NGDTtext.TabIndex = 9;
            this.label_NGDTtext.Text = "text here";
            // 
            // label_NGDT
            // 
            this.label_NGDT.AutoSize = true;
            this.label_NGDT.Location = new System.Drawing.Point(63, 343);
            this.label_NGDT.Name = "label_NGDT";
            this.label_NGDT.Size = new System.Drawing.Size(56, 13);
            this.label_NGDT.TabIndex = 8;
            this.label_NGDT.Text = "Đối tác từ:";
            this.label_NGDT.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_SDTtext
            // 
            this.label_SDTtext.AutoSize = true;
            this.label_SDTtext.Location = new System.Drawing.Point(125, 309);
            this.label_SDTtext.Name = "label_SDTtext";
            this.label_SDTtext.Size = new System.Drawing.Size(48, 13);
            this.label_SDTtext.TabIndex = 7;
            this.label_SDTtext.Text = "text here";
            this.label_SDTtext.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Location = new System.Drawing.Point(46, 309);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(73, 13);
            this.label_SDT.TabIndex = 6;
            this.label_SDT.Text = "Số điện thoại:";
            this.label_SDT.Click += new System.EventHandler(this.label_SDT_Click);
            // 
            // label_TENDTtext
            // 
            this.label_TENDTtext.AutoSize = true;
            this.label_TENDTtext.Location = new System.Drawing.Point(125, 274);
            this.label_TENDTtext.Name = "label_TENDTtext";
            this.label_TENDTtext.Size = new System.Drawing.Size(48, 13);
            this.label_TENDTtext.TabIndex = 5;
            this.label_TENDTtext.Text = "text here";
            this.label_TENDTtext.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_TENDT
            // 
            this.label_TENDT.AutoSize = true;
            this.label_TENDT.Location = new System.Drawing.Point(54, 274);
            this.label_TENDT.Name = "label_TENDT";
            this.label_TENDT.Size = new System.Drawing.Size(65, 13);
            this.label_TENDT.TabIndex = 4;
            this.label_TENDT.Text = "Tên đối tác:";
            // 
            // label_IDtext
            // 
            this.label_IDtext.AutoSize = true;
            this.label_IDtext.Location = new System.Drawing.Point(179, 219);
            this.label_IDtext.Name = "label_IDtext";
            this.label_IDtext.Size = new System.Drawing.Size(48, 13);
            this.label_IDtext.TabIndex = 3;
            this.label_IDtext.Text = "text here";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(119, 219);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(64, 13);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "Mã đối tác: ";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Logo.Image = global::App_sale_manager.Properties.Resources.No_Image;
            this.pictureBox_Logo.Location = new System.Drawing.Point(99, 85);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(148, 128);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.Click += new System.EventHandler(this.pictureBox_Logo_Click);
            // 
            // dataGridView_DTCC
            // 
            this.dataGridView_DTCC.AllowUserToAddRows = false;
            this.dataGridView_DTCC.AllowUserToDeleteRows = false;
            this.dataGridView_DTCC.AllowUserToResizeRows = false;
            this.dataGridView_DTCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DTCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DTCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_DTCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DTCC.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_DTCC.Location = new System.Drawing.Point(377, 85);
            this.dataGridView_DTCC.MultiSelect = false;
            this.dataGridView_DTCC.Name = "dataGridView_DTCC";
            this.dataGridView_DTCC.ReadOnly = true;
            this.dataGridView_DTCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DTCC.Size = new System.Drawing.Size(500, 293);
            this.dataGridView_DTCC.TabIndex = 0;
            this.dataGridView_DTCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DTCC_CellClick);
            this.dataGridView_DTCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DTCC_CellContentClick);
            // 
            // tabPage_GiaoDich
            // 
            this.tabPage_GiaoDich.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_GiaoDich.Name = "tabPage_GiaoDich";
            this.tabPage_GiaoDich.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_GiaoDich.Size = new System.Drawing.Size(895, 526);
            this.tabPage_GiaoDich.TabIndex = 3;
            this.tabPage_GiaoDich.Text = "Giao dịch";
            this.tabPage_GiaoDich.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(895, 526);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_BaoCao
            // 
            this.tabPage_BaoCao.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_BaoCao.Name = "tabPage_BaoCao";
            this.tabPage_BaoCao.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_BaoCao.Size = new System.Drawing.Size(895, 526);
            this.tabPage_BaoCao.TabIndex = 5;
            this.tabPage_BaoCao.Text = "Báo cáo";
            this.tabPage_BaoCao.UseVisualStyleBackColor = true;
            // 
            // dTCCBindingSource
            // 
            this.dTCCBindingSource.DataMember = "DTCC";
            this.dTCCBindingSource.DataSource = this.qUANLYBANHANG_LTTQDataSet;
            // 
            // qUANLYBANHANG_LTTQDataSet
            // 
            this.qUANLYBANHANG_LTTQDataSet.DataSetName = "QUANLYBANHANG_LTTQDataSet";
            this.qUANLYBANHANG_LTTQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTCCTableAdapter
            // 
            this.dTCCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tìm theo:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_refresh.Location = new System.Drawing.Point(296, 219);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 52);
            this.button_refresh.TabIndex = 20;
            this.button_refresh.Text = "Làm mới";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Form_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabCtrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_main_admin";
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_admin_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPage_tongquan.ResumeLayout(false);
            this.tabPage_DoiTac.ResumeLayout(false);
            this.tabPage_DoiTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DTCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG_LTTQDataSet)).EndInit();
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
        private QUANLYBANHANG_LTTQDataSet qUANLYBANHANG_LTTQDataSet;
        private System.Windows.Forms.BindingSource dTCCBindingSource;
        private QUANLYBANHANG_LTTQDataSetTableAdapters.DTCCTableAdapter dTCCTableAdapter;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_TENDTtext;
        private System.Windows.Forms.Label label_TENDT;
        private System.Windows.Forms.Label label_IDtext;
        private System.Windows.Forms.Label label_SDTtext;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.Label label_NGDTtext;
        private System.Windows.Forms.Label label_NGDT;
        private System.Windows.Forms.Label label_DIACHItext;
        private System.Windows.Forms.Label label_DIACHI;
        private System.Windows.Forms.Label label_listname;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_searchDTCC;
        private System.Windows.Forms.Button button_deleteDTCC;
        private System.Windows.Forms.Button button_modDTCC;
        private System.Windows.Forms.Button button_addDTCC;
        public System.Windows.Forms.DataGridView dataGridView_DTCC;
        private System.Windows.Forms.ComboBox comboBox_searchOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_refresh;
    }
}