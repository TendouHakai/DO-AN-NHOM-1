
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
            this.tabPage_GiaoDich = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_BaoCao = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qUANLYBANHANG_LTTQDataSet = new App_sale_manager.QUANLYBANHANG_LTTQDataSet();
            this.dTCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTCCTableAdapter = new App_sale_manager.QUANLYBANHANG_LTTQDataSetTableAdapters.DTCCTableAdapter();
            this.dTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_DTID = new System.Windows.Forms.Label();
            this.label_TENDT = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabPage_tongquan.SuspendLayout();
            this.tabPage_DoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG_LTTQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPage_tongquan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_tongquan.Name = "tabPage_tongquan";
            this.tabPage_tongquan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_tongquan.Size = new System.Drawing.Size(895, 526);
            this.tabPage_tongquan.TabIndex = 0;
            this.tabPage_tongquan.Text = "Tổng quan";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(620, 400);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPage_HangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_HangHoa.Name = "tabPage_HangHoa";
            this.tabPage_HangHoa.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_HangHoa.Size = new System.Drawing.Size(895, 526);
            this.tabPage_HangHoa.TabIndex = 1;
            this.tabPage_HangHoa.Text = "Hàng hóa";
            this.tabPage_HangHoa.UseVisualStyleBackColor = true;
            // 
            // tabPage_DoiTac
            // 
            this.tabPage_DoiTac.Controls.Add(this.label_TENDT);
            this.tabPage_DoiTac.Controls.Add(this.label_DTID);
            this.tabPage_DoiTac.Controls.Add(this.pictureBox1);
            this.tabPage_DoiTac.Controls.Add(this.dataGridView1);
            this.tabPage_DoiTac.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoiTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_DoiTac.Name = "tabPage_DoiTac";
            this.tabPage_DoiTac.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_DoiTac.Size = new System.Drawing.Size(895, 526);
            this.tabPage_DoiTac.TabIndex = 2;
            this.tabPage_DoiTac.Text = "Đối tác";
            this.tabPage_DoiTac.UseVisualStyleBackColor = true;
            // 
            // tabPage_GiaoDich
            // 
            this.tabPage_GiaoDich.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_GiaoDich.Name = "tabPage_GiaoDich";
            this.tabPage_GiaoDich.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_GiaoDich.Size = new System.Drawing.Size(895, 526);
            this.tabPage_GiaoDich.TabIndex = 3;
            this.tabPage_GiaoDich.Text = "Giao dịch";
            this.tabPage_GiaoDich.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(895, 526);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_BaoCao
            // 
            this.tabPage_BaoCao.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_BaoCao.Name = "tabPage_BaoCao";
            this.tabPage_BaoCao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_BaoCao.Size = new System.Drawing.Size(895, 526);
            this.tabPage_BaoCao.TabIndex = 5;
            this.tabPage_BaoCao.Text = "Báo cáo";
            this.tabPage_BaoCao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dTIDDataGridViewTextBoxColumn,
            this.tENDTDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.nGDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTCCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(388, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // qUANLYBANHANG_LTTQDataSet
            // 
            this.qUANLYBANHANG_LTTQDataSet.DataSetName = "QUANLYBANHANG_LTTQDataSet";
            this.qUANLYBANHANG_LTTQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTCCBindingSource
            // 
            this.dTCCBindingSource.DataMember = "DTCC";
            this.dTCCBindingSource.DataSource = this.qUANLYBANHANG_LTTQDataSet;
            // 
            // dTCCTableAdapter
            // 
            this.dTCCTableAdapter.ClearBeforeFill = true;
            // 
            // dTIDDataGridViewTextBoxColumn
            // 
            this.dTIDDataGridViewTextBoxColumn.DataPropertyName = "DTID";
            this.dTIDDataGridViewTextBoxColumn.HeaderText = "DTID";
            this.dTIDDataGridViewTextBoxColumn.Name = "dTIDDataGridViewTextBoxColumn";
            // 
            // tENDTDataGridViewTextBoxColumn
            // 
            this.tENDTDataGridViewTextBoxColumn.DataPropertyName = "TENDT";
            this.tENDTDataGridViewTextBoxColumn.HeaderText = "TENDT";
            this.tENDTDataGridViewTextBoxColumn.Name = "tENDTDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // nGDTDataGridViewTextBoxColumn
            // 
            this.nGDTDataGridViewTextBoxColumn.DataPropertyName = "NGDT";
            this.nGDTDataGridViewTextBoxColumn.HeaderText = "NGDT";
            this.nGDTDataGridViewTextBoxColumn.Name = "nGDTDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_DTID
            // 
            this.label_DTID.AutoSize = true;
            this.label_DTID.Location = new System.Drawing.Point(110, 237);
            this.label_DTID.Name = "label_DTID";
            this.label_DTID.Size = new System.Drawing.Size(64, 13);
            this.label_DTID.TabIndex = 2;
            this.label_DTID.Text = "Mã đối tác: ";
            // 
            // label_TENDT
            // 
            this.label_TENDT.AutoSize = true;
            this.label_TENDT.Location = new System.Drawing.Point(48, 296);
            this.label_TENDT.Name = "label_TENDT";
            this.label_TENDT.Size = new System.Drawing.Size(64, 13);
            this.label_TENDT.TabIndex = 3;
            this.label_TENDT.Text = "Mã đối tác: ";
            // 
            // Form_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabCtrl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_main_admin";
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_admin_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPage_tongquan.ResumeLayout(false);
            this.tabPage_DoiTac.ResumeLayout(false);
            this.tabPage_DoiTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG_LTTQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private QUANLYBANHANG_LTTQDataSet qUANLYBANHANG_LTTQDataSet;
        private System.Windows.Forms.BindingSource dTCCBindingSource;
        private QUANLYBANHANG_LTTQDataSetTableAdapters.DTCCTableAdapter dTCCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_TENDT;
        private System.Windows.Forms.Label label_DTID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}