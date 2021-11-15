
namespace App_sale_manager
{
    partial class Form_NV_chamcong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_danhmuc = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_songaylam = new System.Windows.Forms.Label();
            this.lbl_songaynghi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ptb_ngaynghi = new System.Windows.Forms.PictureBox();
            this.ptb_ngaylam = new System.Windows.Forms.PictureBox();
            this.grb_thongtinNV = new System.Windows.Forms.GroupBox();
            this.lbl_tenNV = new System.Windows.Forms.Label();
            this.lbl_maNV = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_soDT = new System.Windows.Forms.Label();
            this.lbl_CV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.calam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_danhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ngaynghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ngaylam)).BeginInit();
            this.grb_thongtinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_danhmuc
            // 
            this.grb_danhmuc.Controls.Add(this.dataGridView1);
            this.grb_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_danhmuc.Location = new System.Drawing.Point(356, 13);
            this.grb_danhmuc.Name = "grb_danhmuc";
            this.grb_danhmuc.Size = new System.Drawing.Size(1118, 268);
            this.grb_danhmuc.TabIndex = 0;
            this.grb_danhmuc.TabStop = false;
            this.grb_danhmuc.Text = "Danh mục chấm công";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calam});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_songaylam
            // 
            this.lbl_songaylam.AutoSize = true;
            this.lbl_songaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_songaylam.Location = new System.Drawing.Point(580, 301);
            this.lbl_songaylam.Name = "lbl_songaylam";
            this.lbl_songaylam.Size = new System.Drawing.Size(116, 20);
            this.lbl_songaylam.TabIndex = 1;
            this.lbl_songaylam.Text = "số ngày làm:";
            // 
            // lbl_songaynghi
            // 
            this.lbl_songaynghi.AutoSize = true;
            this.lbl_songaynghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_songaynghi.Location = new System.Drawing.Point(1047, 301);
            this.lbl_songaynghi.Name = "lbl_songaynghi";
            this.lbl_songaynghi.Size = new System.Drawing.Size(121, 20);
            this.lbl_songaynghi.TabIndex = 1;
            this.lbl_songaynghi.Text = "số ngày nghỉ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1204, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 2;
            // 
            // ptb_ngaynghi
            // 
            this.ptb_ngaynghi.BackgroundImage = global::App_sale_manager.Properties.Resources.dấu_X;
            this.ptb_ngaynghi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_ngaynghi.Location = new System.Drawing.Point(992, 287);
            this.ptb_ngaynghi.Name = "ptb_ngaynghi";
            this.ptb_ngaynghi.Size = new System.Drawing.Size(49, 46);
            this.ptb_ngaynghi.TabIndex = 3;
            this.ptb_ngaynghi.TabStop = false;
            // 
            // ptb_ngaylam
            // 
            this.ptb_ngaylam.BackgroundImage = global::App_sale_manager.Properties.Resources.Dấu_tick;
            this.ptb_ngaylam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_ngaylam.Location = new System.Drawing.Point(525, 288);
            this.ptb_ngaylam.Name = "ptb_ngaylam";
            this.ptb_ngaylam.Size = new System.Drawing.Size(49, 46);
            this.ptb_ngaylam.TabIndex = 3;
            this.ptb_ngaylam.TabStop = false;
            // 
            // grb_thongtinNV
            // 
            this.grb_thongtinNV.Controls.Add(this.textBox7);
            this.grb_thongtinNV.Controls.Add(this.textBox6);
            this.grb_thongtinNV.Controls.Add(this.textBox5);
            this.grb_thongtinNV.Controls.Add(this.textBox4);
            this.grb_thongtinNV.Controls.Add(this.textBox3);
            this.grb_thongtinNV.Controls.Add(this.pictureBox1);
            this.grb_thongtinNV.Controls.Add(this.label1);
            this.grb_thongtinNV.Controls.Add(this.lbl_CV);
            this.grb_thongtinNV.Controls.Add(this.lbl_tenNV);
            this.grb_thongtinNV.Controls.Add(this.lbl_soDT);
            this.grb_thongtinNV.Controls.Add(this.lbl_maNV);
            this.grb_thongtinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongtinNV.Location = new System.Drawing.Point(13, 13);
            this.grb_thongtinNV.Name = "grb_thongtinNV";
            this.grb_thongtinNV.Size = new System.Drawing.Size(337, 354);
            this.grb_thongtinNV.TabIndex = 4;
            this.grb_thongtinNV.TabStop = false;
            this.grb_thongtinNV.Text = "Thông tin nhân viên";
            // 
            // lbl_tenNV
            // 
            this.lbl_tenNV.AutoSize = true;
            this.lbl_tenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNV.Location = new System.Drawing.Point(28, 167);
            this.lbl_tenNV.Name = "lbl_tenNV";
            this.lbl_tenNV.Size = new System.Drawing.Size(60, 17);
            this.lbl_tenNV.TabIndex = 0;
            this.lbl_tenNV.Text = "Tên NV:";
            // 
            // lbl_maNV
            // 
            this.lbl_maNV.AutoSize = true;
            this.lbl_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maNV.Location = new System.Drawing.Point(28, 124);
            this.lbl_maNV.Name = "lbl_maNV";
            this.lbl_maNV.Size = new System.Drawing.Size(54, 17);
            this.lbl_maNV.TabIndex = 0;
            this.lbl_maNV.Text = "Mã NV:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_soDT
            // 
            this.lbl_soDT.AutoSize = true;
            this.lbl_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDT.Location = new System.Drawing.Point(28, 210);
            this.lbl_soDT.Name = "lbl_soDT";
            this.lbl_soDT.Size = new System.Drawing.Size(52, 17);
            this.lbl_soDT.TabIndex = 0;
            this.lbl_soDT.Text = "Số DT:";
            // 
            // lbl_CV
            // 
            this.lbl_CV.AutoSize = true;
            this.lbl_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CV.Location = new System.Drawing.Point(28, 253);
            this.lbl_CV.Name = "lbl_CV";
            this.lbl_CV.Size = new System.Drawing.Size(63, 17);
            this.lbl_CV.TabIndex = 0;
            this.lbl_CV.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(128, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(128, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(128, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 22);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(128, 253);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 22);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(128, 296);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 22);
            this.textBox7.TabIndex = 2;
            // 
            // calam
            // 
            this.calam.HeaderText = "Ca làm";
            this.calam.MinimumWidth = 6;
            this.calam.Name = "calam";
            this.calam.ReadOnly = true;
            this.calam.Width = 125;
            // 
            // Form_NV_chamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 400);
            this.Controls.Add(this.grb_thongtinNV);
            this.Controls.Add(this.ptb_ngaynghi);
            this.Controls.Add(this.ptb_ngaylam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_songaynghi);
            this.Controls.Add(this.lbl_songaylam);
            this.Controls.Add(this.grb_danhmuc);
            this.Name = "Form_NV_chamcong";
            this.Text = "Form_chamcong";
            this.grb_danhmuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ngaynghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ngaylam)).EndInit();
            this.grb_thongtinNV.ResumeLayout(false);
            this.grb_thongtinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_danhmuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_songaylam;
        private System.Windows.Forms.Label lbl_songaynghi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox ptb_ngaylam;
        private System.Windows.Forms.PictureBox ptb_ngaynghi;
        private System.Windows.Forms.GroupBox grb_thongtinNV;
        private System.Windows.Forms.Label lbl_tenNV;
        private System.Windows.Forms.Label lbl_maNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_CV;
        private System.Windows.Forms.Label lbl_soDT;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calam;
    }
}