
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
            this.label_deleteObj.Location = new System.Drawing.Point(29, 58);
            this.label_deleteObj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deleteObj.Name = "label_deleteObj";
            this.label_deleteObj.Size = new System.Drawing.Size(135, 20);
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
            this.comboBox_deleteObj.Location = new System.Drawing.Point(33, 82);
            this.comboBox_deleteObj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_deleteObj.Name = "comboBox_deleteObj";
            this.comboBox_deleteObj.Size = new System.Drawing.Size(388, 24);
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
            this.comboBox_saleState.Location = new System.Drawing.Point(33, 154);
            this.comboBox_saleState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_saleState.Name = "comboBox_saleState";
            this.comboBox_saleState.Size = new System.Drawing.Size(388, 24);
            this.comboBox_saleState.TabIndex = 3;
            this.comboBox_saleState.Text = "Tất cả";
            this.comboBox_saleState.TextChanged += new System.EventHandler(this.comboBox_saleState_TextChanged);
            // 
            // label_saleState
            // 
            this.label_saleState.AutoSize = true;
            this.label_saleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleState.Location = new System.Drawing.Point(29, 129);
            this.label_saleState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleState.Name = "label_saleState";
            this.label_saleState.Size = new System.Drawing.Size(139, 20);
            this.label_saleState.TabIndex = 2;
            this.label_saleState.Text = "Trạng thái ưu đãi:";
            // 
            // comboBox_sale
            // 
            this.comboBox_sale.FormattingEnabled = true;
            this.comboBox_sale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_sale.Location = new System.Drawing.Point(33, 233);
            this.comboBox_sale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_sale.Name = "comboBox_sale";
            this.comboBox_sale.Size = new System.Drawing.Size(388, 24);
            this.comboBox_sale.TabIndex = 5;
            this.comboBox_sale.Text = "- Chưa chọn -";
            // 
            // label_sale
            // 
            this.label_sale.AutoSize = true;
            this.label_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sale.Location = new System.Drawing.Point(29, 208);
            this.label_sale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sale.Name = "label_sale";
            this.label_sale.Size = new System.Drawing.Size(139, 20);
            this.label_sale.TabIndex = 4;
            this.label_sale.Text = "Ưu đãi muốn xóa:";
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(225, 292);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 28);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Xóa";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(356, 292);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 28);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Hủy";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // SaleDeleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 346);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_sale);
            this.Controls.Add(this.label_sale);
            this.Controls.Add(this.comboBox_saleState);
            this.Controls.Add(this.label_saleState);
            this.Controls.Add(this.comboBox_deleteObj);
            this.Controls.Add(this.label_deleteObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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