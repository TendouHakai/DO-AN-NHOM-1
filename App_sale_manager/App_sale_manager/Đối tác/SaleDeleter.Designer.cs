
namespace App_sale_manager
{
    partial class SaleDeleter
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
            this.label_deleteObj = new System.Windows.Forms.Label();
            this.comboBox_deleteObj = new System.Windows.Forms.ComboBox();
            this.comboBox_saleState = new System.Windows.Forms.ComboBox();
            this.label_saleState = new System.Windows.Forms.Label();
            this.comboBox_sale = new System.Windows.Forms.ComboBox();
            this.label_sale = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_deleteObj
            // 
            this.label_deleteObj.AutoSize = true;
            this.label_deleteObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deleteObj.Location = new System.Drawing.Point(22, 47);
            this.label_deleteObj.Name = "label_deleteObj";
            this.label_deleteObj.Size = new System.Drawing.Size(106, 16);
            this.label_deleteObj.TabIndex = 0;
            this.label_deleteObj.Text = "Đối tượng ưu đãi:";
            // 
            // comboBox_deleteObj
            // 
            this.comboBox_deleteObj.FormattingEnabled = true;
            this.comboBox_deleteObj.Items.AddRange(new object[] {
            "Tất cả",
            "Khách thường",
            "Khách vip"});
            this.comboBox_deleteObj.Location = new System.Drawing.Point(25, 67);
            this.comboBox_deleteObj.Name = "comboBox_deleteObj";
            this.comboBox_deleteObj.Size = new System.Drawing.Size(292, 21);
            this.comboBox_deleteObj.TabIndex = 1;
            this.comboBox_deleteObj.Text = "Tất cả";
            this.comboBox_deleteObj.TextChanged += new System.EventHandler(this.comboBox_deleteObj_TextChanged);
            // 
            // comboBox_saleState
            // 
            this.comboBox_saleState.FormattingEnabled = true;
            this.comboBox_saleState.Items.AddRange(new object[] {
            "Tất cả",
            "Đang áp dụng",
            "Sắp diễn ra",
            "Đã kết thúc"});
            this.comboBox_saleState.Location = new System.Drawing.Point(25, 125);
            this.comboBox_saleState.Name = "comboBox_saleState";
            this.comboBox_saleState.Size = new System.Drawing.Size(292, 21);
            this.comboBox_saleState.TabIndex = 3;
            this.comboBox_saleState.Text = "Tất cả";
            this.comboBox_saleState.TextChanged += new System.EventHandler(this.comboBox_saleState_TextChanged);
            // 
            // label_saleState
            // 
            this.label_saleState.AutoSize = true;
            this.label_saleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleState.Location = new System.Drawing.Point(22, 105);
            this.label_saleState.Name = "label_saleState";
            this.label_saleState.Size = new System.Drawing.Size(110, 16);
            this.label_saleState.TabIndex = 2;
            this.label_saleState.Text = "Trạng thái ưu đãi:";
            // 
            // comboBox_sale
            // 
            this.comboBox_sale.FormattingEnabled = true;
            this.comboBox_sale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_sale.Location = new System.Drawing.Point(25, 189);
            this.comboBox_sale.Name = "comboBox_sale";
            this.comboBox_sale.Size = new System.Drawing.Size(292, 21);
            this.comboBox_sale.TabIndex = 5;
            this.comboBox_sale.Text = "- Chưa chọn -";
            this.comboBox_sale.TextChanged += new System.EventHandler(this.comboBox_sale_TextChanged);
            // 
            // label_sale
            // 
            this.label_sale.AutoSize = true;
            this.label_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sale.Location = new System.Drawing.Point(22, 169);
            this.label_sale.Name = "label_sale";
            this.label_sale.Size = new System.Drawing.Size(111, 16);
            this.label_sale.TabIndex = 4;
            this.label_sale.Text = "Ưu đãi muốn xóa:";
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Location = new System.Drawing.Point(169, 237);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Xóa";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(267, 237);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Hủy";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // SaleDeleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 281);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_sale);
            this.Controls.Add(this.label_sale);
            this.Controls.Add(this.comboBox_saleState);
            this.Controls.Add(this.label_saleState);
            this.Controls.Add(this.comboBox_deleteObj);
            this.Controls.Add(this.label_deleteObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaleDeleter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa ưu đãi";
            this.Load += new System.EventHandler(this.SaleDeleter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_deleteObj;
        private System.Windows.Forms.ComboBox comboBox_deleteObj;
        private System.Windows.Forms.ComboBox comboBox_saleState;
        private System.Windows.Forms.Label label_saleState;
        private System.Windows.Forms.ComboBox comboBox_sale;
        private System.Windows.Forms.Label label_sale;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}