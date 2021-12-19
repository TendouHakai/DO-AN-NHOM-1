namespace App_sale_manager
{
    partial class Form_UpdateNV_admin
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
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Image_import = new System.Windows.Forms.Button();
            this.label_manv_nv_infonv = new System.Windows.Forms.Label();
            this.label_tennv_nv_infonv = new System.Windows.Forms.Label();
            this.label_sdt_nv_infonv = new System.Windows.Forms.Label();
            this.label_ngaysinh_nv_infonv = new System.Windows.Forms.Label();
            this.label_chucvu_nv_infonv = new System.Windows.Forms.Label();
            this.label_ngayvl_nv_infonv = new System.Windows.Forms.Label();
            this.tb_MaNV_nv_infonv = new System.Windows.Forms.TextBox();
            this.tb_TenNV_nv_infonv = new System.Windows.Forms.TextBox();
            this.tb_SDT_nv_infonv = new System.Windows.Forms.TextBox();
            this.dt_NgaySinh_nv_infonv = new System.Windows.Forms.DateTimePicker();
            this.tb_ChucVu_nv_infonv = new System.Windows.Forms.TextBox();
            this.dt_NgayVaoLam_nv_infonv = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_image_import_nv = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_import_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(423, 445);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(115, 39);
            this.bt_Huy.TabIndex = 15;
            this.bt_Huy.Text = "Thoát";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(239, 445);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(115, 39);
            this.bt_Sua.TabIndex = 11;
            this.bt_Sua.Text = "Xác nhận";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // button_Image_import
            // 
            this.button_Image_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(85)))));
            this.button_Image_import.FlatAppearance.BorderSize = 0;
            this.button_Image_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Image_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Image_import.ForeColor = System.Drawing.Color.White;
            this.button_Image_import.Location = new System.Drawing.Point(42, 231);
            this.button_Image_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Image_import.Name = "button_Image_import";
            this.button_Image_import.Size = new System.Drawing.Size(125, 34);
            this.button_Image_import.TabIndex = 27;
            this.button_Image_import.Text = "Chọn ảnh";
            this.button_Image_import.UseVisualStyleBackColor = false;
            this.button_Image_import.Click += new System.EventHandler(this.button_Image_import_Click);
            // 
            // label_manv_nv_infonv
            // 
            this.label_manv_nv_infonv.AutoSize = true;
            this.label_manv_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_manv_nv_infonv.Location = new System.Drawing.Point(230, 148);
            this.label_manv_nv_infonv.Name = "label_manv_nv_infonv";
            this.label_manv_nv_infonv.Size = new System.Drawing.Size(58, 18);
            this.label_manv_nv_infonv.TabIndex = 29;
            this.label_manv_nv_infonv.Text = "Mã NV";
            // 
            // label_tennv_nv_infonv
            // 
            this.label_tennv_nv_infonv.AutoSize = true;
            this.label_tennv_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tennv_nv_infonv.Location = new System.Drawing.Point(230, 178);
            this.label_tennv_nv_infonv.Name = "label_tennv_nv_infonv";
            this.label_tennv_nv_infonv.Size = new System.Drawing.Size(63, 18);
            this.label_tennv_nv_infonv.TabIndex = 30;
            this.label_tennv_nv_infonv.Text = "Tên NV";
            // 
            // label_sdt_nv_infonv
            // 
            this.label_sdt_nv_infonv.AutoSize = true;
            this.label_sdt_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_sdt_nv_infonv.Location = new System.Drawing.Point(230, 215);
            this.label_sdt_nv_infonv.Name = "label_sdt_nv_infonv";
            this.label_sdt_nv_infonv.Size = new System.Drawing.Size(107, 18);
            this.label_sdt_nv_infonv.TabIndex = 31;
            this.label_sdt_nv_infonv.Text = "Số diện thoại";
            // 
            // label_ngaysinh_nv_infonv
            // 
            this.label_ngaysinh_nv_infonv.AutoSize = true;
            this.label_ngaysinh_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ngaysinh_nv_infonv.Location = new System.Drawing.Point(230, 261);
            this.label_ngaysinh_nv_infonv.Name = "label_ngaysinh_nv_infonv";
            this.label_ngaysinh_nv_infonv.Size = new System.Drawing.Size(82, 18);
            this.label_ngaysinh_nv_infonv.TabIndex = 32;
            this.label_ngaysinh_nv_infonv.Text = "Ngày sinh";
            // 
            // label_chucvu_nv_infonv
            // 
            this.label_chucvu_nv_infonv.AutoSize = true;
            this.label_chucvu_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_chucvu_nv_infonv.Location = new System.Drawing.Point(230, 341);
            this.label_chucvu_nv_infonv.Name = "label_chucvu_nv_infonv";
            this.label_chucvu_nv_infonv.Size = new System.Drawing.Size(69, 18);
            this.label_chucvu_nv_infonv.TabIndex = 33;
            this.label_chucvu_nv_infonv.Text = "Chức vụ";
            // 
            // label_ngayvl_nv_infonv
            // 
            this.label_ngayvl_nv_infonv.AutoSize = true;
            this.label_ngayvl_nv_infonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ngayvl_nv_infonv.Location = new System.Drawing.Point(230, 297);
            this.label_ngayvl_nv_infonv.Name = "label_ngayvl_nv_infonv";
            this.label_ngayvl_nv_infonv.Size = new System.Drawing.Size(110, 18);
            this.label_ngayvl_nv_infonv.TabIndex = 34;
            this.label_ngayvl_nv_infonv.Text = "Ngày vào làm";
            // 
            // tb_MaNV_nv_infonv
            // 
            this.tb_MaNV_nv_infonv.Location = new System.Drawing.Point(390, 144);
            this.tb_MaNV_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaNV_nv_infonv.Name = "tb_MaNV_nv_infonv";
            this.tb_MaNV_nv_infonv.ReadOnly = true;
            this.tb_MaNV_nv_infonv.Size = new System.Drawing.Size(177, 22);
            this.tb_MaNV_nv_infonv.TabIndex = 35;
            // 
            // tb_TenNV_nv_infonv
            // 
            this.tb_TenNV_nv_infonv.Location = new System.Drawing.Point(390, 177);
            this.tb_TenNV_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenNV_nv_infonv.Name = "tb_TenNV_nv_infonv";
            this.tb_TenNV_nv_infonv.Size = new System.Drawing.Size(177, 22);
            this.tb_TenNV_nv_infonv.TabIndex = 36;
            // 
            // tb_SDT_nv_infonv
            // 
            this.tb_SDT_nv_infonv.Location = new System.Drawing.Point(390, 212);
            this.tb_SDT_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SDT_nv_infonv.Name = "tb_SDT_nv_infonv";
            this.tb_SDT_nv_infonv.Size = new System.Drawing.Size(177, 22);
            this.tb_SDT_nv_infonv.TabIndex = 37;
            this.tb_SDT_nv_infonv.TextChanged += new System.EventHandler(this.tb_SDT_nv_infonv_TextChanged);
            this.tb_SDT_nv_infonv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SDT_nv_infonv_KeyPress);
            this.tb_SDT_nv_infonv.Leave += new System.EventHandler(this.tb_SDT_nv_infonv_Leave);
            // 
            // dt_NgaySinh_nv_infonv
            // 
            this.dt_NgaySinh_nv_infonv.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh_nv_infonv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh_nv_infonv.Location = new System.Drawing.Point(390, 257);
            this.dt_NgaySinh_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_NgaySinh_nv_infonv.Name = "dt_NgaySinh_nv_infonv";
            this.dt_NgaySinh_nv_infonv.Size = new System.Drawing.Size(103, 22);
            this.dt_NgaySinh_nv_infonv.TabIndex = 39;
            this.dt_NgaySinh_nv_infonv.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // tb_ChucVu_nv_infonv
            // 
            this.tb_ChucVu_nv_infonv.Location = new System.Drawing.Point(390, 337);
            this.tb_ChucVu_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ChucVu_nv_infonv.Name = "tb_ChucVu_nv_infonv";
            this.tb_ChucVu_nv_infonv.Size = new System.Drawing.Size(177, 22);
            this.tb_ChucVu_nv_infonv.TabIndex = 38;
            // 
            // dt_NgayVaoLam_nv_infonv
            // 
            this.dt_NgayVaoLam_nv_infonv.CustomFormat = "dd/MM/yyyy";
            this.dt_NgayVaoLam_nv_infonv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayVaoLam_nv_infonv.Location = new System.Drawing.Point(390, 292);
            this.dt_NgayVaoLam_nv_infonv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_NgayVaoLam_nv_infonv.Name = "dt_NgayVaoLam_nv_infonv";
            this.dt_NgayVaoLam_nv_infonv.Size = new System.Drawing.Size(103, 22);
            this.dt_NgayVaoLam_nv_infonv.TabIndex = 40;
            this.dt_NgayVaoLam_nv_infonv.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBox_image_import_nv
            // 
            this.pictureBox_image_import_nv.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_image_import_nv.Location = new System.Drawing.Point(27, 58);
            this.pictureBox_image_import_nv.Name = "pictureBox_image_import_nv";
            this.pictureBox_image_import_nv.Size = new System.Drawing.Size(140, 126);
            this.pictureBox_image_import_nv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image_import_nv.TabIndex = 28;
            this.pictureBox_image_import_nv.TabStop = false;
            // 
            // Form_UpdateNV_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 586);
            this.Controls.Add(this.label_manv_nv_infonv);
            this.Controls.Add(this.label_tennv_nv_infonv);
            this.Controls.Add(this.label_sdt_nv_infonv);
            this.Controls.Add(this.label_ngaysinh_nv_infonv);
            this.Controls.Add(this.label_chucvu_nv_infonv);
            this.Controls.Add(this.label_ngayvl_nv_infonv);
            this.Controls.Add(this.tb_MaNV_nv_infonv);
            this.Controls.Add(this.tb_TenNV_nv_infonv);
            this.Controls.Add(this.tb_SDT_nv_infonv);
            this.Controls.Add(this.dt_NgaySinh_nv_infonv);
            this.Controls.Add(this.tb_ChucVu_nv_infonv);
            this.Controls.Add(this.dt_NgayVaoLam_nv_infonv);
            this.Controls.Add(this.pictureBox_image_import_nv);
            this.Controls.Add(this.button_Image_import);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.label1);
            this.Name = "Form_UpdateNV_admin";
            this.Text = "Sửa thông tin nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UpdateNV_admin_FormClosed);
            this.Load += new System.EventHandler(this.Form_UpdateNV_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_import_nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Label label1;
        private OvalPictureBox pictureBox_image_import_nv;
        private System.Windows.Forms.Button button_Image_import;
        private System.Windows.Forms.Label label_manv_nv_infonv;
        private System.Windows.Forms.Label label_tennv_nv_infonv;
        private System.Windows.Forms.Label label_sdt_nv_infonv;
        private System.Windows.Forms.Label label_ngaysinh_nv_infonv;
        private System.Windows.Forms.Label label_chucvu_nv_infonv;
        private System.Windows.Forms.Label label_ngayvl_nv_infonv;
        private System.Windows.Forms.TextBox tb_MaNV_nv_infonv;
        private System.Windows.Forms.TextBox tb_TenNV_nv_infonv;
        private System.Windows.Forms.TextBox tb_SDT_nv_infonv;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh_nv_infonv;
        private System.Windows.Forms.TextBox tb_ChucVu_nv_infonv;
        private System.Windows.Forms.DateTimePicker dt_NgayVaoLam_nv_infonv;
    }
}