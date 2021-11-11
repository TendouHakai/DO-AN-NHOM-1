
namespace App_sale_manager
{
    partial class Form_QLKho
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHangSapHet = new System.Windows.Forms.Button();
            this.lblChuY = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_XemHH = new System.Windows.Forms.Button();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDeHH
            // 
            this.lblTieuDeHH.AutoSize = true;
            this.lblTieuDeHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHH.Location = new System.Drawing.Point(478, 166);
            this.lblTieuDeHH.Name = "lblTieuDeHH";
            this.lblTieuDeHH.Size = new System.Drawing.Size(99, 20);
            this.lblTieuDeHH.TabIndex = 30;
            this.lblTieuDeHH.Text = "Hàng Hoá ";
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSP.ColumnHeadersHeight = 70;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.Location = new System.Drawing.Point(12, 205);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1108, 437);
            this.dgvSP.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(35, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 60);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHangSapHet
            // 
            this.btnHangSapHet.Location = new System.Drawing.Point(247, 60);
            this.btnHangSapHet.Name = "btnHangSapHet";
            this.btnHangSapHet.Size = new System.Drawing.Size(113, 60);
            this.btnHangSapHet.TabIndex = 32;
            this.btnHangSapHet.Text = "Hàng Hoá Sắp Hết";
            this.btnHangSapHet.UseVisualStyleBackColor = true;
            this.btnHangSapHet.Click += new System.EventHandler(this.btnHangSapHet_Click);
            // 
            // lblChuY
            // 
            this.lblChuY.AutoSize = true;
            this.lblChuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuY.ForeColor = System.Drawing.Color.Red;
            this.lblChuY.Location = new System.Drawing.Point(682, 22);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(0, 20);
            this.lblChuY.TabIndex = 34;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(645, 58);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 62);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_XemHH
            // 
            this.btn_XemHH.Location = new System.Drawing.Point(51, 157);
            this.btn_XemHH.Name = "btn_XemHH";
            this.btn_XemHH.Size = new System.Drawing.Size(114, 42);
            this.btn_XemHH.TabIndex = 47;
            this.btn_XemHH.Text = "Xem tất cả";
            this.btn_XemHH.UseVisualStyleBackColor = true;
            this.btn_XemHH.Click += new System.EventHandler(this.btn_XemHH_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Location = new System.Drawing.Point(458, 59);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(119, 61);
            this.btnHoaDonNhap.TabIndex = 48;
            this.btnHoaDonNhap.Text = "Hoá đơn nhập hàng";
            this.btnHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // Form_QLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btnHoaDonNhap);
            this.Controls.Add(this.btn_XemHH);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblChuY);
            this.Controls.Add(this.btnHangSapHet);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblTieuDeHH);
            this.Controls.Add(this.dgvSP);
            this.Name = "Form_QLKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QLKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDeHH;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHangSapHet;
        private System.Windows.Forms.Label lblChuY;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btn_XemHH;
        private System.Windows.Forms.Button btnHoaDonNhap;
    }
}