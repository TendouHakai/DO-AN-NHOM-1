
namespace App_sale_manager
{
    partial class Form_QuanLiHH
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
            this.lblTieuDeHH = new System.Windows.Forms.Label();
            this.btnXemChiTietHH = new System.Windows.Forms.Button();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnQLLoaiHH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDeHH
            // 
            this.lblTieuDeHH.AutoSize = true;
            this.lblTieuDeHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHH.Location = new System.Drawing.Point(488, 214);
            this.lblTieuDeHH.Name = "lblTieuDeHH";
            this.lblTieuDeHH.Size = new System.Drawing.Size(191, 20);
            this.lblTieuDeHH.TabIndex = 35;
            this.lblTieuDeHH.Text = "Danh Sách Hàng Hoá";
            // 
            // btnXemChiTietHH
            // 
            this.btnXemChiTietHH.Location = new System.Drawing.Point(449, 42);
            this.btnXemChiTietHH.Name = "btnXemChiTietHH";
            this.btnXemChiTietHH.Size = new System.Drawing.Size(101, 66);
            this.btnXemChiTietHH.TabIndex = 33;
            this.btnXemChiTietHH.Text = "Xem chi tiết";
            this.btnXemChiTietHH.UseVisualStyleBackColor = true;
            this.btnXemChiTietHH.Click += new System.EventHandler(this.btnXemChiTietHH_Click);
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.Location = new System.Drawing.Point(162, 41);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(103, 67);
            this.btnXoaHH.TabIndex = 32;
            this.btnXoaHH.Text = "Xoá";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.Location = new System.Drawing.Point(296, 41);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(98, 67);
            this.btnSuaHH.TabIndex = 31;
            this.btnSuaHH.Text = "Sửa";
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.Location = new System.Drawing.Point(6, 41);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(108, 67);
            this.btnThemHH.TabIndex = 30;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSP.ColumnHeadersHeight = 70;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.Location = new System.Drawing.Point(12, 252);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1116, 384);
            this.dgvSP.TabIndex = 29;
            this.dgvSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellDoubleClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(913, 58);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 62);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnQLLoaiHH
            // 
            this.btnQLLoaiHH.Location = new System.Drawing.Point(594, 43);
            this.btnQLLoaiHH.Name = "btnQLLoaiHH";
            this.btnQLLoaiHH.Size = new System.Drawing.Size(122, 63);
            this.btnQLLoaiHH.TabIndex = 46;
            this.btnQLLoaiHH.Text = "Thêm,Xoá,Sửa Loại hàng hoá";
            this.btnQLLoaiHH.UseVisualStyleBackColor = true;
            this.btnQLLoaiHH.Click += new System.EventHandler(this.btnQLLoaiHH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemChiTietHH);
            this.groupBox1.Controls.Add(this.btnQLLoaiHH);
            this.groupBox1.Controls.Add(this.btnXoaHH);
            this.groupBox1.Controls.Add(this.btnSuaHH);
            this.groupBox1.Controls.Add(this.btnThemHH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 153);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng với hàng hoá";
            // 
            // Form_QuanLiHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDeHH);
            this.Controls.Add(this.dgvSP);
            this.Name = "Form_QuanLiHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QuanLiHH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDeHH;
        private System.Windows.Forms.Button btnXemChiTietHH;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnQLLoaiHH;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}