
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
            this.tabControl_DTCC_in = new System.Windows.Forms.TabControl();
            this.tabPage__DTCC_DTGD = new System.Windows.Forms.TabPage();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage_DTCC_Guest = new System.Windows.Forms.TabPage();
            this.button_sale = new System.Windows.Forms.Button();
            this.label_guestSpec_Text = new System.Windows.Forms.Label();
            this.label_guestSpec = new System.Windows.Forms.Label();
            this.label_guestMoney_Text = new System.Windows.Forms.Label();
            this.label_dtcc_guestMoney = new System.Windows.Forms.Label();
            this.button_guest_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_guest_filter = new System.Windows.Forms.ComboBox();
            this.label_name_guest = new System.Windows.Forms.Label();
            this.textBox_guest_search = new System.Windows.Forms.TextBox();
            this.button_guest_search = new System.Windows.Forms.Button();
            this.button_guest_delete = new System.Windows.Forms.Button();
            this.button_guest_mod = new System.Windows.Forms.Button();
            this.button_guest_add = new System.Windows.Forms.Button();
            this.label_guestAddress_Text = new System.Windows.Forms.Label();
            this.label_dtcc_guestAddr = new System.Windows.Forms.Label();
            this.label_guestReg_Text = new System.Windows.Forms.Label();
            this.label_dtcc_guestReg = new System.Windows.Forms.Label();
            this.label_guestSDT_Text = new System.Windows.Forms.Label();
            this.label_dtcc_guestPhone = new System.Windows.Forms.Label();
            this.label_guestName_Text = new System.Windows.Forms.Label();
            this.label_DTCC_guestName = new System.Windows.Forms.Label();
            this.label_guestID_Text = new System.Windows.Forms.Label();
            this.label__dtcc_guestId = new System.Windows.Forms.Label();
            this.pictureBox_dtcc_guestFace = new System.Windows.Forms.PictureBox();
            this.dataGridView_dtcc_guest = new System.Windows.Forms.DataGridView();
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.dTCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYBANHANG_LTTQDataSet = new App_sale_manager.QUANLYBANHANG_LTTQDataSet();
            this.dTCCTableAdapter = new App_sale_manager.QUANLYBANHANG_LTTQDataSetTableAdapters.DTCCTableAdapter();
            this.tabCtrl.SuspendLayout();
            this.tabPage_tongquan.SuspendLayout();
            this.tabPage_DoiTac.SuspendLayout();
            this.tabControl_DTCC_in.SuspendLayout();
            this.tabPage__DTCC_DTGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DTCC)).BeginInit();
            this.tabPage_DTCC_Guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dtcc_guestFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dtcc_guest)).BeginInit();
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
            this.tabCtrl.Location = new System.Drawing.Point(24, 11);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(889, 552);
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
            this.tabPage_tongquan.Size = new System.Drawing.Size(881, 526);
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
            this.tabPage_HangHoa.Size = new System.Drawing.Size(881, 526);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            this.tabPage_HangHoa.UseVisualStyleBackColor = true;
            // 
            // tabPage_DoiTac
            // 
            this.tabPage_DoiTac.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_DoiTac.Controls.Add(this.tabControl_DTCC_in);
            this.tabPage_DoiTac.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoiTac.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_DoiTac.Name = "tabPage_DoiTac";
            this.tabPage_DoiTac.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_DoiTac.Size = new System.Drawing.Size(881, 526);
            this.tabPage_DoiTac.TabIndex = 2;
            this.tabPage_DoiTac.Text = "Đối tác";
            this.tabPage_DoiTac.Click += new System.EventHandler(this.tabPage_DoiTac_Click);
            // 
            // tabControl_DTCC_in
            // 
            this.tabControl_DTCC_in.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_DTCC_in.Controls.Add(this.tabPage__DTCC_DTGD);
            this.tabControl_DTCC_in.Controls.Add(this.tabPage_DTCC_Guest);
            this.tabControl_DTCC_in.Location = new System.Drawing.Point(0, 0);
            this.tabControl_DTCC_in.Multiline = true;
            this.tabControl_DTCC_in.Name = "tabControl_DTCC_in";
            this.tabControl_DTCC_in.SelectedIndex = 0;
            this.tabControl_DTCC_in.Size = new System.Drawing.Size(885, 530);
            this.tabControl_DTCC_in.TabIndex = 0;
            this.tabControl_DTCC_in.TabStop = false;
            // 
            // tabPage__DTCC_DTGD
            // 
            this.tabPage__DTCC_DTGD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage__DTCC_DTGD.Controls.Add(this.button_refresh);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label1);
            this.tabPage__DTCC_DTGD.Controls.Add(this.comboBox_searchOption);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_listname);
            this.tabPage__DTCC_DTGD.Controls.Add(this.textBox_search);
            this.tabPage__DTCC_DTGD.Controls.Add(this.button_searchDTCC);
            this.tabPage__DTCC_DTGD.Controls.Add(this.button_deleteDTCC);
            this.tabPage__DTCC_DTGD.Controls.Add(this.button_modDTCC);
            this.tabPage__DTCC_DTGD.Controls.Add(this.button_addDTCC);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_DIACHItext);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_DIACHI);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_NGDTtext);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_NGDT);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_SDTtext);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_SDT);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_TENDTtext);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_TENDT);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_IDtext);
            this.tabPage__DTCC_DTGD.Controls.Add(this.label_ID);
            this.tabPage__DTCC_DTGD.Controls.Add(this.pictureBox_Logo);
            this.tabPage__DTCC_DTGD.Controls.Add(this.dataGridView_DTCC);
            this.tabPage__DTCC_DTGD.Location = new System.Drawing.Point(23, 4);
            this.tabPage__DTCC_DTGD.Name = "tabPage__DTCC_DTGD";
            this.tabPage__DTCC_DTGD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage__DTCC_DTGD.Size = new System.Drawing.Size(858, 522);
            this.tabPage__DTCC_DTGD.TabIndex = 0;
            this.tabPage__DTCC_DTGD.Text = "Đối tác giao dịch";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_refresh.Location = new System.Drawing.Point(268, 236);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 52);
            this.button_refresh.TabIndex = 41;
            this.button_refresh.Text = "Làm mới";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tìm theo:";
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
            this.comboBox_searchOption.Location = new System.Drawing.Point(407, 56);
            this.comboBox_searchOption.Name = "comboBox_searchOption";
            this.comboBox_searchOption.Size = new System.Drawing.Size(126, 21);
            this.comboBox_searchOption.TabIndex = 39;
            this.comboBox_searchOption.Text = "Chưa chọn";
            // 
            // label_listname
            // 
            this.label_listname.AutoSize = true;
            this.label_listname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listname.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_listname.Location = new System.Drawing.Point(32, 41);
            this.label_listname.Name = "label_listname";
            this.label_listname.Size = new System.Drawing.Size(231, 31);
            this.label_listname.TabIndex = 38;
            this.label_listname.Text = "Danh sách đối tác";
            this.label_listname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(539, 56);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(229, 20);
            this.textBox_search.TabIndex = 37;
            this.textBox_search.Click += new System.EventHandler(this.textBox_search_Click);
            // 
            // button_searchDTCC
            // 
            this.button_searchDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_searchDTCC.Location = new System.Drawing.Point(774, 53);
            this.button_searchDTCC.Name = "button_searchDTCC";
            this.button_searchDTCC.Size = new System.Drawing.Size(75, 23);
            this.button_searchDTCC.TabIndex = 36;
            this.button_searchDTCC.Text = "Tìm";
            this.button_searchDTCC.UseVisualStyleBackColor = false;
            this.button_searchDTCC.Click += new System.EventHandler(this.button_searchDTCC_Click);
            // 
            // button_deleteDTCC
            // 
            this.button_deleteDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_deleteDTCC.Location = new System.Drawing.Point(724, 439);
            this.button_deleteDTCC.Name = "button_deleteDTCC";
            this.button_deleteDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_deleteDTCC.TabIndex = 35;
            this.button_deleteDTCC.Text = "Xóa";
            this.button_deleteDTCC.UseVisualStyleBackColor = false;
            this.button_deleteDTCC.Click += new System.EventHandler(this.button_deleteDTCC_Click);
            // 
            // button_modDTCC
            // 
            this.button_modDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modDTCC.Location = new System.Drawing.Point(539, 439);
            this.button_modDTCC.Name = "button_modDTCC";
            this.button_modDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_modDTCC.TabIndex = 34;
            this.button_modDTCC.Text = "Sửa";
            this.button_modDTCC.UseVisualStyleBackColor = false;
            this.button_modDTCC.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_addDTCC
            // 
            this.button_addDTCC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addDTCC.Location = new System.Drawing.Point(349, 439);
            this.button_addDTCC.Name = "button_addDTCC";
            this.button_addDTCC.Size = new System.Drawing.Size(97, 38);
            this.button_addDTCC.TabIndex = 33;
            this.button_addDTCC.Text = "Thêm";
            this.button_addDTCC.UseVisualStyleBackColor = false;
            this.button_addDTCC.Click += new System.EventHandler(this.button_addDTCC_Click);
            // 
            // label_DIACHItext
            // 
            this.label_DIACHItext.Location = new System.Drawing.Point(114, 395);
            this.label_DIACHItext.Name = "label_DIACHItext";
            this.label_DIACHItext.Size = new System.Drawing.Size(194, 82);
            this.label_DIACHItext.TabIndex = 32;
            // 
            // label_DIACHI
            // 
            this.label_DIACHI.AutoSize = true;
            this.label_DIACHI.Location = new System.Drawing.Point(65, 395);
            this.label_DIACHI.Name = "label_DIACHI";
            this.label_DIACHI.Size = new System.Drawing.Size(43, 13);
            this.label_DIACHI.TabIndex = 31;
            this.label_DIACHI.Text = "Địa chỉ:";
            // 
            // label_NGDTtext
            // 
            this.label_NGDTtext.AutoSize = true;
            this.label_NGDTtext.Location = new System.Drawing.Point(114, 359);
            this.label_NGDTtext.Name = "label_NGDTtext";
            this.label_NGDTtext.Size = new System.Drawing.Size(0, 13);
            this.label_NGDTtext.TabIndex = 30;
            // 
            // label_NGDT
            // 
            this.label_NGDT.AutoSize = true;
            this.label_NGDT.Location = new System.Drawing.Point(52, 359);
            this.label_NGDT.Name = "label_NGDT";
            this.label_NGDT.Size = new System.Drawing.Size(56, 13);
            this.label_NGDT.TabIndex = 29;
            this.label_NGDT.Text = "Đối tác từ:";
            // 
            // label_SDTtext
            // 
            this.label_SDTtext.AutoSize = true;
            this.label_SDTtext.Location = new System.Drawing.Point(114, 325);
            this.label_SDTtext.Name = "label_SDTtext";
            this.label_SDTtext.Size = new System.Drawing.Size(0, 13);
            this.label_SDTtext.TabIndex = 28;
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Location = new System.Drawing.Point(35, 325);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(73, 13);
            this.label_SDT.TabIndex = 27;
            this.label_SDT.Text = "Số điện thoại:";
            // 
            // label_TENDTtext
            // 
            this.label_TENDTtext.AutoSize = true;
            this.label_TENDTtext.Location = new System.Drawing.Point(114, 290);
            this.label_TENDTtext.Name = "label_TENDTtext";
            this.label_TENDTtext.Size = new System.Drawing.Size(0, 13);
            this.label_TENDTtext.TabIndex = 26;
            // 
            // label_TENDT
            // 
            this.label_TENDT.AutoSize = true;
            this.label_TENDT.Location = new System.Drawing.Point(43, 290);
            this.label_TENDT.Name = "label_TENDT";
            this.label_TENDT.Size = new System.Drawing.Size(65, 13);
            this.label_TENDT.TabIndex = 25;
            this.label_TENDT.Text = "Tên đối tác:";
            // 
            // label_IDtext
            // 
            this.label_IDtext.AutoSize = true;
            this.label_IDtext.Location = new System.Drawing.Point(151, 236);
            this.label_IDtext.Name = "label_IDtext";
            this.label_IDtext.Size = new System.Drawing.Size(0, 13);
            this.label_IDtext.TabIndex = 24;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(91, 236);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(64, 13);
            this.label_ID.TabIndex = 23;
            this.label_ID.Text = "Mã đối tác: ";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Logo.Location = new System.Drawing.Point(71, 102);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(148, 128);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 22;
            this.pictureBox_Logo.TabStop = false;
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
            this.dataGridView_DTCC.Location = new System.Drawing.Point(349, 102);
            this.dataGridView_DTCC.MultiSelect = false;
            this.dataGridView_DTCC.Name = "dataGridView_DTCC";
            this.dataGridView_DTCC.ReadOnly = true;
            this.dataGridView_DTCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DTCC.Size = new System.Drawing.Size(491, 296);
            this.dataGridView_DTCC.TabIndex = 21;
            this.dataGridView_DTCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DTCC_CellClick);
            // 
            // tabPage_DTCC_Guest
            // 
            this.tabPage_DTCC_Guest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_DTCC_Guest.Controls.Add(this.button_sale);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestSpec_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestSpec);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestMoney_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_dtcc_guestMoney);
            this.tabPage_DTCC_Guest.Controls.Add(this.button_guest_refresh);
            this.tabPage_DTCC_Guest.Controls.Add(this.label2);
            this.tabPage_DTCC_Guest.Controls.Add(this.comboBox_guest_filter);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_name_guest);
            this.tabPage_DTCC_Guest.Controls.Add(this.textBox_guest_search);
            this.tabPage_DTCC_Guest.Controls.Add(this.button_guest_search);
            this.tabPage_DTCC_Guest.Controls.Add(this.button_guest_delete);
            this.tabPage_DTCC_Guest.Controls.Add(this.button_guest_mod);
            this.tabPage_DTCC_Guest.Controls.Add(this.button_guest_add);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestAddress_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_dtcc_guestAddr);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestReg_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_dtcc_guestReg);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestSDT_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_dtcc_guestPhone);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestName_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_DTCC_guestName);
            this.tabPage_DTCC_Guest.Controls.Add(this.label_guestID_Text);
            this.tabPage_DTCC_Guest.Controls.Add(this.label__dtcc_guestId);
            this.tabPage_DTCC_Guest.Controls.Add(this.pictureBox_dtcc_guestFace);
            this.tabPage_DTCC_Guest.Controls.Add(this.dataGridView_dtcc_guest);
            this.tabPage_DTCC_Guest.Location = new System.Drawing.Point(23, 4);
            this.tabPage_DTCC_Guest.Name = "tabPage_DTCC_Guest";
            this.tabPage_DTCC_Guest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DTCC_Guest.Size = new System.Drawing.Size(858, 522);
            this.tabPage_DTCC_Guest.TabIndex = 1;
            this.tabPage_DTCC_Guest.Text = "Khách hàng thành viên";
            this.tabPage_DTCC_Guest.Click += new System.EventHandler(this.tabPage_DTCC_Guest_Click);
            // 
            // button_sale
            // 
            this.button_sale.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sale.Location = new System.Drawing.Point(6, 481);
            this.button_sale.Name = "button_sale";
            this.button_sale.Size = new System.Drawing.Size(139, 31);
            this.button_sale.TabIndex = 67;
            this.button_sale.Text = "Xem ưu đãi";
            this.button_sale.UseVisualStyleBackColor = false;
            this.button_sale.Click += new System.EventHandler(this.button_sale_Click);
            // 
            // label_guestSpec_Text
            // 
            this.label_guestSpec_Text.AutoSize = true;
            this.label_guestSpec_Text.Location = new System.Drawing.Point(131, 387);
            this.label_guestSpec_Text.Name = "label_guestSpec_Text";
            this.label_guestSpec_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestSpec_Text.TabIndex = 66;
            // 
            // label_guestSpec
            // 
            this.label_guestSpec.AutoSize = true;
            this.label_guestSpec.Location = new System.Drawing.Point(35, 387);
            this.label_guestSpec.Name = "label_guestSpec";
            this.label_guestSpec.Size = new System.Drawing.Size(90, 13);
            this.label_guestSpec.TabIndex = 65;
            this.label_guestSpec.Text = "Loại khách hàng:";
            // 
            // label_guestMoney_Text
            // 
            this.label_guestMoney_Text.AutoSize = true;
            this.label_guestMoney_Text.Location = new System.Drawing.Point(131, 364);
            this.label_guestMoney_Text.Name = "label_guestMoney_Text";
            this.label_guestMoney_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestMoney_Text.TabIndex = 64;
            // 
            // label_dtcc_guestMoney
            // 
            this.label_dtcc_guestMoney.AutoSize = true;
            this.label_dtcc_guestMoney.Location = new System.Drawing.Point(69, 364);
            this.label_dtcc_guestMoney.Name = "label_dtcc_guestMoney";
            this.label_dtcc_guestMoney.Size = new System.Drawing.Size(56, 13);
            this.label_dtcc_guestMoney.TabIndex = 63;
            this.label_dtcc_guestMoney.Text = "Doanh số:";
            // 
            // button_guest_refresh
            // 
            this.button_guest_refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_guest_refresh.Location = new System.Drawing.Point(268, 236);
            this.button_guest_refresh.Name = "button_guest_refresh";
            this.button_guest_refresh.Size = new System.Drawing.Size(75, 52);
            this.button_guest_refresh.TabIndex = 62;
            this.button_guest_refresh.Text = "Làm mới";
            this.button_guest_refresh.UseVisualStyleBackColor = false;
            this.button_guest_refresh.Click += new System.EventHandler(this.button_guest_refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tìm theo:";
            // 
            // comboBox_guest_filter
            // 
            this.comboBox_guest_filter.FormattingEnabled = true;
            this.comboBox_guest_filter.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Địa chỉ",
            "Số điện thoại",
            "Loại khách hàng",
            "Ngày đăng kí"});
            this.comboBox_guest_filter.Location = new System.Drawing.Point(407, 56);
            this.comboBox_guest_filter.Name = "comboBox_guest_filter";
            this.comboBox_guest_filter.Size = new System.Drawing.Size(126, 21);
            this.comboBox_guest_filter.TabIndex = 60;
            this.comboBox_guest_filter.Text = "Chưa chọn";
            // 
            // label_name_guest
            // 
            this.label_name_guest.AutoSize = true;
            this.label_name_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_guest.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_name_guest.Location = new System.Drawing.Point(19, 41);
            this.label_name_guest.Name = "label_name_guest";
            this.label_name_guest.Size = new System.Drawing.Size(291, 31);
            this.label_name_guest.TabIndex = 59;
            this.label_name_guest.Text = "Danh sách khách hàng";
            this.label_name_guest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guest_search
            // 
            this.textBox_guest_search.Location = new System.Drawing.Point(539, 56);
            this.textBox_guest_search.Name = "textBox_guest_search";
            this.textBox_guest_search.Size = new System.Drawing.Size(229, 20);
            this.textBox_guest_search.TabIndex = 58;
            this.textBox_guest_search.Click += new System.EventHandler(this.textBox_guest_search_Click);
            this.textBox_guest_search.TextChanged += new System.EventHandler(this.textBox_guest_search_TextChanged);
            // 
            // button_guest_search
            // 
            this.button_guest_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_guest_search.Location = new System.Drawing.Point(774, 53);
            this.button_guest_search.Name = "button_guest_search";
            this.button_guest_search.Size = new System.Drawing.Size(75, 23);
            this.button_guest_search.TabIndex = 57;
            this.button_guest_search.Text = "Tìm";
            this.button_guest_search.UseVisualStyleBackColor = false;
            this.button_guest_search.Click += new System.EventHandler(this.button_guest_search_Click);
            // 
            // button_guest_delete
            // 
            this.button_guest_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_guest_delete.Location = new System.Drawing.Point(724, 439);
            this.button_guest_delete.Name = "button_guest_delete";
            this.button_guest_delete.Size = new System.Drawing.Size(97, 38);
            this.button_guest_delete.TabIndex = 56;
            this.button_guest_delete.Text = "Xóa";
            this.button_guest_delete.UseVisualStyleBackColor = false;
            this.button_guest_delete.Click += new System.EventHandler(this.button_guest_delete_Click);
            // 
            // button_guest_mod
            // 
            this.button_guest_mod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_guest_mod.Location = new System.Drawing.Point(539, 439);
            this.button_guest_mod.Name = "button_guest_mod";
            this.button_guest_mod.Size = new System.Drawing.Size(97, 38);
            this.button_guest_mod.TabIndex = 55;
            this.button_guest_mod.Text = "Sửa";
            this.button_guest_mod.UseVisualStyleBackColor = false;
            this.button_guest_mod.Click += new System.EventHandler(this.button_guest_mod_Click);
            // 
            // button_guest_add
            // 
            this.button_guest_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_guest_add.Location = new System.Drawing.Point(349, 439);
            this.button_guest_add.Name = "button_guest_add";
            this.button_guest_add.Size = new System.Drawing.Size(97, 38);
            this.button_guest_add.TabIndex = 54;
            this.button_guest_add.Text = "Thêm";
            this.button_guest_add.UseVisualStyleBackColor = false;
            this.button_guest_add.Click += new System.EventHandler(this.button_guest_add_Click);
            // 
            // label_guestAddress_Text
            // 
            this.label_guestAddress_Text.Location = new System.Drawing.Point(131, 411);
            this.label_guestAddress_Text.Name = "label_guestAddress_Text";
            this.label_guestAddress_Text.Size = new System.Drawing.Size(179, 67);
            this.label_guestAddress_Text.TabIndex = 53;
            // 
            // label_dtcc_guestAddr
            // 
            this.label_dtcc_guestAddr.AutoSize = true;
            this.label_dtcc_guestAddr.Location = new System.Drawing.Point(82, 411);
            this.label_dtcc_guestAddr.Name = "label_dtcc_guestAddr";
            this.label_dtcc_guestAddr.Size = new System.Drawing.Size(43, 13);
            this.label_dtcc_guestAddr.TabIndex = 52;
            this.label_dtcc_guestAddr.Text = "Địa chỉ:";
            // 
            // label_guestReg_Text
            // 
            this.label_guestReg_Text.AutoSize = true;
            this.label_guestReg_Text.Location = new System.Drawing.Point(131, 340);
            this.label_guestReg_Text.Name = "label_guestReg_Text";
            this.label_guestReg_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestReg_Text.TabIndex = 51;
            // 
            // label_dtcc_guestReg
            // 
            this.label_dtcc_guestReg.AutoSize = true;
            this.label_dtcc_guestReg.Location = new System.Drawing.Point(49, 340);
            this.label_dtcc_guestReg.Name = "label_dtcc_guestReg";
            this.label_dtcc_guestReg.Size = new System.Drawing.Size(76, 13);
            this.label_dtcc_guestReg.TabIndex = 50;
            this.label_dtcc_guestReg.Text = "Ngày đăng kí:";
            // 
            // label_guestSDT_Text
            // 
            this.label_guestSDT_Text.AutoSize = true;
            this.label_guestSDT_Text.Location = new System.Drawing.Point(131, 316);
            this.label_guestSDT_Text.Name = "label_guestSDT_Text";
            this.label_guestSDT_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestSDT_Text.TabIndex = 49;
            // 
            // label_dtcc_guestPhone
            // 
            this.label_dtcc_guestPhone.AutoSize = true;
            this.label_dtcc_guestPhone.Location = new System.Drawing.Point(52, 316);
            this.label_dtcc_guestPhone.Name = "label_dtcc_guestPhone";
            this.label_dtcc_guestPhone.Size = new System.Drawing.Size(73, 13);
            this.label_dtcc_guestPhone.TabIndex = 48;
            this.label_dtcc_guestPhone.Text = "Số điện thoại:";
            // 
            // label_guestName_Text
            // 
            this.label_guestName_Text.AutoSize = true;
            this.label_guestName_Text.Location = new System.Drawing.Point(131, 292);
            this.label_guestName_Text.Name = "label_guestName_Text";
            this.label_guestName_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestName_Text.TabIndex = 47;
            // 
            // label_DTCC_guestName
            // 
            this.label_DTCC_guestName.AutoSize = true;
            this.label_DTCC_guestName.Location = new System.Drawing.Point(60, 292);
            this.label_DTCC_guestName.Name = "label_DTCC_guestName";
            this.label_DTCC_guestName.Size = new System.Drawing.Size(65, 13);
            this.label_DTCC_guestName.TabIndex = 46;
            this.label_DTCC_guestName.Text = "Tên đối tác:";
            // 
            // label_guestID_Text
            // 
            this.label_guestID_Text.AutoSize = true;
            this.label_guestID_Text.Location = new System.Drawing.Point(151, 236);
            this.label_guestID_Text.Name = "label_guestID_Text";
            this.label_guestID_Text.Size = new System.Drawing.Size(0, 13);
            this.label_guestID_Text.TabIndex = 45;
            // 
            // label__dtcc_guestId
            // 
            this.label__dtcc_guestId.AutoSize = true;
            this.label__dtcc_guestId.Location = new System.Drawing.Point(60, 236);
            this.label__dtcc_guestId.Name = "label__dtcc_guestId";
            this.label__dtcc_guestId.Size = new System.Drawing.Size(85, 13);
            this.label__dtcc_guestId.TabIndex = 44;
            this.label__dtcc_guestId.Text = "Mã khách hàng:";
            // 
            // pictureBox_dtcc_guestFace
            // 
            this.pictureBox_dtcc_guestFace.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox_dtcc_guestFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_dtcc_guestFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_dtcc_guestFace.Location = new System.Drawing.Point(71, 102);
            this.pictureBox_dtcc_guestFace.Name = "pictureBox_dtcc_guestFace";
            this.pictureBox_dtcc_guestFace.Size = new System.Drawing.Size(148, 128);
            this.pictureBox_dtcc_guestFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dtcc_guestFace.TabIndex = 43;
            this.pictureBox_dtcc_guestFace.TabStop = false;
            // 
            // dataGridView_dtcc_guest
            // 
            this.dataGridView_dtcc_guest.AllowUserToAddRows = false;
            this.dataGridView_dtcc_guest.AllowUserToDeleteRows = false;
            this.dataGridView_dtcc_guest.AllowUserToResizeRows = false;
            this.dataGridView_dtcc_guest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_dtcc_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dtcc_guest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_dtcc_guest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_dtcc_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dtcc_guest.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_dtcc_guest.Location = new System.Drawing.Point(349, 102);
            this.dataGridView_dtcc_guest.MultiSelect = false;
            this.dataGridView_dtcc_guest.Name = "dataGridView_dtcc_guest";
            this.dataGridView_dtcc_guest.ReadOnly = true;
            this.dataGridView_dtcc_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_dtcc_guest.Size = new System.Drawing.Size(491, 313);
            this.dataGridView_dtcc_guest.TabIndex = 42;
            this.dataGridView_dtcc_guest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dtcc_guest_CellClick);
            // 
            // tabPage_GiaoDich
            // 
            this.tabPage_GiaoDich.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_GiaoDich.Name = "tabPage_GiaoDich";
            this.tabPage_GiaoDich.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_GiaoDich.Size = new System.Drawing.Size(881, 526);
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
            this.tabPage_NhanVien.Size = new System.Drawing.Size(881, 526);
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
            this.tabPage_BaoCao.Size = new System.Drawing.Size(881, 526);
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
            this.tabControl_DTCC_in.ResumeLayout(false);
            this.tabPage__DTCC_DTGD.ResumeLayout(false);
            this.tabPage__DTCC_DTGD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DTCC)).EndInit();
            this.tabPage_DTCC_Guest.ResumeLayout(false);
            this.tabPage_DTCC_Guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dtcc_guestFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dtcc_guest)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl_DTCC_in;
        private System.Windows.Forms.TabPage tabPage__DTCC_DTGD;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_searchOption;
        private System.Windows.Forms.Label label_listname;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_searchDTCC;
        private System.Windows.Forms.Button button_deleteDTCC;
        private System.Windows.Forms.Button button_modDTCC;
        private System.Windows.Forms.Button button_addDTCC;
        private System.Windows.Forms.Label label_DIACHItext;
        private System.Windows.Forms.Label label_DIACHI;
        private System.Windows.Forms.Label label_NGDTtext;
        private System.Windows.Forms.Label label_NGDT;
        private System.Windows.Forms.Label label_SDTtext;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.Label label_TENDTtext;
        private System.Windows.Forms.Label label_TENDT;
        private System.Windows.Forms.Label label_IDtext;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        public System.Windows.Forms.DataGridView dataGridView_DTCC;
        private System.Windows.Forms.TabPage tabPage_DTCC_Guest;
        private System.Windows.Forms.Button button_guest_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_guest_filter;
        private System.Windows.Forms.Label label_name_guest;
        private System.Windows.Forms.TextBox textBox_guest_search;
        private System.Windows.Forms.Button button_guest_search;
        private System.Windows.Forms.Button button_guest_delete;
        private System.Windows.Forms.Button button_guest_mod;
        private System.Windows.Forms.Button button_guest_add;
        private System.Windows.Forms.Label label_guestAddress_Text;
        private System.Windows.Forms.Label label_dtcc_guestAddr;
        private System.Windows.Forms.Label label_guestReg_Text;
        private System.Windows.Forms.Label label_dtcc_guestReg;
        private System.Windows.Forms.Label label_guestSDT_Text;
        private System.Windows.Forms.Label label_dtcc_guestPhone;
        private System.Windows.Forms.Label label_guestName_Text;
        private System.Windows.Forms.Label label_DTCC_guestName;
        private System.Windows.Forms.Label label_guestID_Text;
        private System.Windows.Forms.Label label__dtcc_guestId;
        private System.Windows.Forms.PictureBox pictureBox_dtcc_guestFace;
        public System.Windows.Forms.DataGridView dataGridView_dtcc_guest;
        private System.Windows.Forms.Label label_guestMoney_Text;
        private System.Windows.Forms.Label label_dtcc_guestMoney;
        private System.Windows.Forms.Label label_guestSpec_Text;
        private System.Windows.Forms.Label label_guestSpec;
        private System.Windows.Forms.Button button_sale;
    }
}