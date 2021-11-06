namespace App_sale_manager
{
    partial class Form_main_NV
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
            this.tab_NV = new System.Windows.Forms.TabControl();
            this.tabP_CaNhan = new System.Windows.Forms.TabPage();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.tabP_Hanghoa = new System.Windows.Forms.TabPage();
            this.tabP_Giaodich = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_NV.SuspendLayout();
            this.tabP_CaNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_NV
            // 
            this.tab_NV.Controls.Add(this.tabP_CaNhan);
            this.tab_NV.Controls.Add(this.tabP_Hanghoa);
            this.tab_NV.Controls.Add(this.tabP_Giaodich);
            this.tab_NV.Controls.Add(this.tabPage2);
            this.tab_NV.Location = new System.Drawing.Point(0, 0);
            this.tab_NV.Name = "tab_NV";
            this.tab_NV.SelectedIndex = 0;
            this.tab_NV.Size = new System.Drawing.Size(1209, 647);
            this.tab_NV.TabIndex = 0;
            // 
            // tabP_CaNhan
            // 
            this.tabP_CaNhan.Controls.Add(this.btn_Thoat);
            this.tabP_CaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabP_CaNhan.Name = "tabP_CaNhan";
            this.tabP_CaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_CaNhan.Size = new System.Drawing.Size(1201, 618);
            this.tabP_CaNhan.TabIndex = 0;
            this.tabP_CaNhan.Text = "Cá nhân";
            this.tabP_CaNhan.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(833, 515);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(324, 70);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoat";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // tabP_Hanghoa
            // 
            this.tabP_Hanghoa.Location = new System.Drawing.Point(4, 25);
            this.tabP_Hanghoa.Name = "tabP_Hanghoa";
            this.tabP_Hanghoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Hanghoa.Size = new System.Drawing.Size(1201, 618);
            this.tabP_Hanghoa.TabIndex = 1;
            this.tabP_Hanghoa.Text = "Hàng hóa";
            this.tabP_Hanghoa.UseVisualStyleBackColor = true;
            // 
            // tabP_Giaodich
            // 
            this.tabP_Giaodich.Location = new System.Drawing.Point(4, 25);
            this.tabP_Giaodich.Name = "tabP_Giaodich";
            this.tabP_Giaodich.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Giaodich.Size = new System.Drawing.Size(1201, 618);
            this.tabP_Giaodich.TabIndex = 2;
            this.tabP_Giaodich.Text = "Giao dịch";
            this.tabP_Giaodich.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 618);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form_main_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 653);
            this.Controls.Add(this.tab_NV);
            this.Name = "Form_main_NV";
            this.Text = "Form_main_NV";
            this.tab_NV.ResumeLayout(false);
            this.tabP_CaNhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_NV;
        private System.Windows.Forms.TabPage tabP_CaNhan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TabPage tabP_Hanghoa;
        private System.Windows.Forms.TabPage tabP_Giaodich;
        private System.Windows.Forms.TabPage tabPage2;
    }
}