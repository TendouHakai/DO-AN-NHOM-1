﻿
namespace App_sale_manager
{
    partial class DTCC_modifier
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
        public void InitializeComponent()
        {
            this.label_image_name = new System.Windows.Forms.Label();
            this.button_Image_import = new System.Windows.Forms.Button();
            this.label_Picture_z = new System.Windows.Forms.Label();
            this.button_DTCC_Reject = new System.Windows.Forms.Button();
            this.button_DTCC_Accept = new System.Windows.Forms.Button();
            this.textBox_DIACHI_z = new System.Windows.Forms.TextBox();
            this.label_DIACHI_z = new System.Windows.Forms.Label();
            this.label_NGDT_z = new System.Windows.Forms.Label();
            this.textBox_SDT_z = new System.Windows.Forms.TextBox();
            this.label_SDT_z = new System.Windows.Forms.Label();
            this.textBox_TENDT_z = new System.Windows.Forms.TextBox();
            this.label_TENDT_z = new System.Windows.Forms.Label();
            this.textBox_ID_z = new System.Windows.Forms.TextBox();
            this.label_ID_z = new System.Windows.Forms.Label();
            this.pictureBox_image_import = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_NGDT_z = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_import)).BeginInit();
            this.SuspendLayout();
            // 
            // label_image_name
            // 
            this.label_image_name.Location = new System.Drawing.Point(216, 203);
            this.label_image_name.Name = "label_image_name";
            this.label_image_name.Size = new System.Drawing.Size(227, 84);
            this.label_image_name.TabIndex = 31;
            this.label_image_name.Text = "Chưa thêm ảnh.";
            // 
            // button_Image_import
            // 
            this.button_Image_import.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_Image_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Image_import.Location = new System.Drawing.Point(216, 167);
            this.button_Image_import.Name = "button_Image_import";
            this.button_Image_import.Size = new System.Drawing.Size(75, 33);
            this.button_Image_import.TabIndex = 30;
            this.button_Image_import.Text = "Chọn ảnh";
            this.button_Image_import.UseVisualStyleBackColor = false;
            this.button_Image_import.Click += new System.EventHandler(this.button_Image_import_Click);
            // 
            // label_Picture_z
            // 
            this.label_Picture_z.AutoSize = true;
            this.label_Picture_z.Location = new System.Drawing.Point(20, 140);
            this.label_Picture_z.Name = "label_Picture_z";
            this.label_Picture_z.Size = new System.Drawing.Size(75, 13);
            this.label_Picture_z.TabIndex = 28;
            this.label_Picture_z.Text = "Ảnh minh họa:";
            this.label_Picture_z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_DTCC_Reject
            // 
            this.button_DTCC_Reject.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_DTCC_Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DTCC_Reject.Location = new System.Drawing.Point(385, 463);
            this.button_DTCC_Reject.Name = "button_DTCC_Reject";
            this.button_DTCC_Reject.Size = new System.Drawing.Size(75, 35);
            this.button_DTCC_Reject.TabIndex = 27;
            this.button_DTCC_Reject.Text = "Hủy";
            this.button_DTCC_Reject.UseVisualStyleBackColor = false;
            this.button_DTCC_Reject.Click += new System.EventHandler(this.button_DTCC_Reject_Click);
            // 
            // button_DTCC_Accept
            // 
            this.button_DTCC_Accept.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_DTCC_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DTCC_Accept.Location = new System.Drawing.Point(293, 463);
            this.button_DTCC_Accept.Name = "button_DTCC_Accept";
            this.button_DTCC_Accept.Size = new System.Drawing.Size(75, 35);
            this.button_DTCC_Accept.TabIndex = 26;
            this.button_DTCC_Accept.Text = "Đồng Ý";
            this.button_DTCC_Accept.UseVisualStyleBackColor = false;
            this.button_DTCC_Accept.Click += new System.EventHandler(this.button_DTCC_Accept_Click);
            // 
            // textBox_DIACHI_z
            // 
            this.textBox_DIACHI_z.Location = new System.Drawing.Point(23, 346);
            this.textBox_DIACHI_z.Multiline = true;
            this.textBox_DIACHI_z.Name = "textBox_DIACHI_z";
            this.textBox_DIACHI_z.Size = new System.Drawing.Size(420, 86);
            this.textBox_DIACHI_z.TabIndex = 25;
            // 
            // label_DIACHI_z
            // 
            this.label_DIACHI_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DIACHI_z.AutoSize = true;
            this.label_DIACHI_z.Location = new System.Drawing.Point(20, 330);
            this.label_DIACHI_z.Name = "label_DIACHI_z";
            this.label_DIACHI_z.Size = new System.Drawing.Size(43, 13);
            this.label_DIACHI_z.TabIndex = 24;
            this.label_DIACHI_z.Text = "Địa chỉ:";
            // 
            // label_NGDT_z
            // 
            this.label_NGDT_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NGDT_z.AutoSize = true;
            this.label_NGDT_z.Location = new System.Drawing.Point(213, 84);
            this.label_NGDT_z.Name = "label_NGDT_z";
            this.label_NGDT_z.Size = new System.Drawing.Size(56, 13);
            this.label_NGDT_z.TabIndex = 22;
            this.label_NGDT_z.Text = "Đối tác từ:";
            // 
            // textBox_SDT_z
            // 
            this.textBox_SDT_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SDT_z.Location = new System.Drawing.Point(23, 100);
            this.textBox_SDT_z.Name = "textBox_SDT_z";
            this.textBox_SDT_z.Size = new System.Drawing.Size(153, 20);
            this.textBox_SDT_z.TabIndex = 21;
            // 
            // label_SDT_z
            // 
            this.label_SDT_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SDT_z.AutoSize = true;
            this.label_SDT_z.Location = new System.Drawing.Point(20, 84);
            this.label_SDT_z.Name = "label_SDT_z";
            this.label_SDT_z.Size = new System.Drawing.Size(73, 13);
            this.label_SDT_z.TabIndex = 20;
            this.label_SDT_z.Text = "Số điện thoại:";
            // 
            // textBox_TENDT_z
            // 
            this.textBox_TENDT_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TENDT_z.Location = new System.Drawing.Point(216, 40);
            this.textBox_TENDT_z.Name = "textBox_TENDT_z";
            this.textBox_TENDT_z.Size = new System.Drawing.Size(236, 20);
            this.textBox_TENDT_z.TabIndex = 19;
            // 
            // label_TENDT_z
            // 
            this.label_TENDT_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TENDT_z.AutoSize = true;
            this.label_TENDT_z.Location = new System.Drawing.Point(213, 24);
            this.label_TENDT_z.Name = "label_TENDT_z";
            this.label_TENDT_z.Size = new System.Drawing.Size(65, 13);
            this.label_TENDT_z.TabIndex = 18;
            this.label_TENDT_z.Text = "Tên đối tác:";
            // 
            // textBox_ID_z
            // 
            this.textBox_ID_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID_z.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_ID_z.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_ID_z.Location = new System.Drawing.Point(23, 40);
            this.textBox_ID_z.Name = "textBox_ID_z";
            this.textBox_ID_z.ReadOnly = true;
            this.textBox_ID_z.Size = new System.Drawing.Size(153, 20);
            this.textBox_ID_z.TabIndex = 17;
            // 
            // label_ID_z
            // 
            this.label_ID_z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID_z.AutoSize = true;
            this.label_ID_z.Location = new System.Drawing.Point(20, 24);
            this.label_ID_z.Name = "label_ID_z";
            this.label_ID_z.Size = new System.Drawing.Size(61, 13);
            this.label_ID_z.TabIndex = 16;
            this.label_ID_z.Text = "Mã đối tác:";
            // 
            // pictureBox_image_import
            // 
            this.pictureBox_image_import.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image_import.InitialImage = null;
            this.pictureBox_image_import.Location = new System.Drawing.Point(21, 167);
            this.pictureBox_image_import.Name = "pictureBox_image_import";
            this.pictureBox_image_import.Size = new System.Drawing.Size(140, 120);
            this.pictureBox_image_import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image_import.TabIndex = 29;
            this.pictureBox_image_import.TabStop = false;
            // 
            // dateTimePicker_NGDT_z
            // 
            this.dateTimePicker_NGDT_z.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_NGDT_z.Location = new System.Drawing.Point(216, 100);
            this.dateTimePicker_NGDT_z.Name = "dateTimePicker_NGDT_z";
            this.dateTimePicker_NGDT_z.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_NGDT_z.TabIndex = 32;
            // 
            // DTCC_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 523);
            this.Controls.Add(this.dateTimePicker_NGDT_z);
            this.Controls.Add(this.label_image_name);
            this.Controls.Add(this.button_Image_import);
            this.Controls.Add(this.pictureBox_image_import);
            this.Controls.Add(this.label_Picture_z);
            this.Controls.Add(this.button_DTCC_Reject);
            this.Controls.Add(this.button_DTCC_Accept);
            this.Controls.Add(this.textBox_DIACHI_z);
            this.Controls.Add(this.label_DIACHI_z);
            this.Controls.Add(this.label_NGDT_z);
            this.Controls.Add(this.textBox_SDT_z);
            this.Controls.Add(this.label_SDT_z);
            this.Controls.Add(this.textBox_TENDT_z);
            this.Controls.Add(this.label_TENDT_z);
            this.Controls.Add(this.textBox_ID_z);
            this.Controls.Add(this.label_ID_z);
            this.Name = "DTCC_modifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_import)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_image_name;
        public System.Windows.Forms.Button button_Image_import;
        public System.Windows.Forms.PictureBox pictureBox_image_import;
        public System.Windows.Forms.Label label_Picture_z;
        public System.Windows.Forms.Button button_DTCC_Reject;
        public System.Windows.Forms.Button button_DTCC_Accept;
        public System.Windows.Forms.TextBox textBox_DIACHI_z;
        public System.Windows.Forms.Label label_DIACHI_z;
        public System.Windows.Forms.Label label_NGDT_z;
        public System.Windows.Forms.TextBox textBox_SDT_z;
        public System.Windows.Forms.Label label_SDT_z;
        public System.Windows.Forms.TextBox textBox_TENDT_z;
        public System.Windows.Forms.Label label_TENDT_z;
        public System.Windows.Forms.TextBox textBox_ID_z;
        public System.Windows.Forms.Label label_ID_z;
        public System.Windows.Forms.DateTimePicker dateTimePicker_NGDT_z;
    }
}