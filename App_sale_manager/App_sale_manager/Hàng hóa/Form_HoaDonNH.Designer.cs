
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvChiTietNH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDHN = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.grb_nhomlenh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).BeginInit();
            this.grb_nhomlenh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Chi tiết đơn nhập";
            // 
            // dgvChiTietNH
            // 
            this.dgvChiTietNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNH.Location = new System.Drawing.Point(746, 138);
            this.dgvChiTietNH.Name = "dgvChiTietNH";
            this.dgvChiTietNH.RowHeadersWidth = 51;
            this.dgvChiTietNH.RowTemplate.Height = 24;
            this.dgvChiTietNH.Size = new System.Drawing.Size(386, 503);
            this.dgvChiTietNH.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Danh sách đơn nhập hàng";
            // 
            // dgvHDHN
            // 
            this.dgvHDHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDHN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHDHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDHN.Location = new System.Drawing.Point(12, 138);
            this.dgvHDHN.Name = "dgvHDHN";
            this.dgvHDHN.RowHeadersWidth = 51;
            this.dgvHDHN.RowTemplate.Height = 24;
            this.dgvHDHN.Size = new System.Drawing.Size(646, 503);
            this.dgvHDHN.TabIndex = 86;
            this.dgvHDHN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDHN_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSua.Location = new System.Drawing.Point(183, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 44);
            this.btnSua.TabIndex = 88;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXoa.Location = new System.Drawing.Point(317, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 44);
            this.btnXoa.TabIndex = 89;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnChiTiet.Location = new System.Drawing.Point(459, 21);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(115, 44);
            this.btnChiTiet.TabIndex = 90;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNhapHang.Location = new System.Drawing.Point(50, 21);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(112, 44);
            this.btnNhapHang.TabIndex = 91;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // grb_nhomlenh
            // 
            this.grb_nhomlenh.Controls.Add(this.btnNhapHang);
            this.grb_nhomlenh.Controls.Add(this.btnChiTiet);
            this.grb_nhomlenh.Controls.Add(this.btnSua);
            this.grb_nhomlenh.Controls.Add(this.btnXoa);
            this.grb_nhomlenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nhomlenh.Location = new System.Drawing.Point(12, 12);
            this.grb_nhomlenh.Name = "grb_nhomlenh";
            this.grb_nhomlenh.Size = new System.Drawing.Size(646, 73);
            this.grb_nhomlenh.TabIndex = 92;
            this.grb_nhomlenh.TabStop = false;
            this.grb_nhomlenh.Text = "Nhóm lệnh thao tác";
            // 
            // Form_HoaDonNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.grb_nhomlenh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHDHN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvChiTietNH);
            this.Name = "Form_HoaDonNH";
            this.Text = "Form_HoaDonNH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDHN)).EndInit();
            this.grb_nhomlenh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvChiTietNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHDHN;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.GroupBox grb_nhomlenh;
    }
}