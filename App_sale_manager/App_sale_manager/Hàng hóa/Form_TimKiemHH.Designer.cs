
namespace App_sale_manager
{
    partial class Form_TimKiemHH
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblLoaiID = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.cbbNuocSX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(500, 485);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 62);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(327, 483);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(127, 63);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(159, 39);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(277, 24);
            this.cbbLoaiSP.TabIndex = 55;
            // 
            // lblLoaiID
            // 
            this.lblLoaiID.AutoSize = true;
            this.lblLoaiID.Location = new System.Drawing.Point(25, 46);
            this.lblLoaiID.Name = "lblLoaiID";
            this.lblLoaiID.Size = new System.Drawing.Size(35, 17);
            this.lblLoaiID.TabIndex = 54;
            this.lblLoaiID.Text = "Loại";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(156, 100);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(280, 22);
            this.txtTenSP.TabIndex = 57;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(22, 103);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(99, 17);
            this.lblTenSP.TabIndex = 56;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Location = new System.Drawing.Point(22, 163);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(98, 17);
            this.lblNuocSX.TabIndex = 58;
            this.lblNuocSX.Text = "Nước sản xuất";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(156, 220);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(280, 22);
            this.txtGiaBan.TabIndex = 61;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(22, 220);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(58, 17);
            this.lblGiaBan.TabIndex = 60;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // cbbNuocSX
            // 
            this.cbbNuocSX.FormattingEnabled = true;
            this.cbbNuocSX.Location = new System.Drawing.Point(159, 156);
            this.cbbNuocSX.Name = "cbbNuocSX";
            this.cbbNuocSX.Size = new System.Drawing.Size(277, 24);
            this.cbbNuocSX.TabIndex = 62;
            // 
            // Form_TimKiemHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.cbbNuocSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.cbbLoaiSP);
            this.Controls.Add(this.lblLoaiID);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHuy);
            this.Name = "Form_TimKiemHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TimKiemHH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Label lblLoaiID;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.ComboBox cbbNuocSX;
    }
}