namespace App_sale_manager
{
    partial class Form_UpdateNV_NV
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_Hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(63, 403);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(115, 39);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Xác nhận";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dt_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Ngaysinh.Location = new System.Drawing.Point(194, 193);
            this.dt_Ngaysinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(195, 22);
            this.dt_Ngaysinh.TabIndex = 2;
            this.dt_Ngaysinh.Value = new System.DateTime(1900, 1, 1, 22, 9, 0, 0);
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(194, 131);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Size = new System.Drawing.Size(195, 22);
            this.tb_Hoten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(194, 252);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(195, 22);
            this.tb_sdt.TabIndex = 3;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_KeyPress);
            this.tb_sdt.Leave += new System.EventHandler(this.tb_sdt_Leave);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(247, 403);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(115, 39);
            this.bt_Huy.TabIndex = 4;
            this.bt_Huy.Text = "Thoát";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(60, 319);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(77, 17);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(194, 314);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(195, 22);
            this.tb_username.TabIndex = 6;
            // 
            // Form_UpdateNV_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 537);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_Hoten);
            this.Controls.Add(this.dt_Ngaysinh);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_UpdateNV_NV";
            this.Text = "Chỉnh sửa thông tin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UpdateNV_NV_FormClosed);
            this.Load += new System.EventHandler(this.Form_UpdateNV_NV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh;
        private System.Windows.Forms.TextBox tb_Hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_username;
    }
}