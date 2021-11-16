
namespace App_sale_manager
{
    partial class Sale_viewer
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
            this.button_quit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_forNOR = new System.Windows.Forms.GroupBox();
            this.label_NOR_end = new System.Windows.Forms.Label();
            this.listBox_NOR_ended = new System.Windows.Forms.ListBox();
            this.label_NOR_waiting = new System.Windows.Forms.Label();
            this.listBox_NOR_waiting = new System.Windows.Forms.ListBox();
            this.label_NOR_ongoing = new System.Windows.Forms.Label();
            this.listBox_NOR_ongoing = new System.Windows.Forms.ListBox();
            this.groupBox_forVIP = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_VIP_ongoing = new System.Windows.Forms.ListBox();
            this.listBox_VIP_ended = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_VIP_waiting = new System.Windows.Forms.ListBox();
            this.button_saleDelete = new System.Windows.Forms.Button();
            this.groupBox_forNOR.SuspendLayout();
            this.groupBox_forVIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Location = new System.Drawing.Point(794, 579);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(100, 33);
            this.button_quit.TabIndex = 4;
            this.button_quit.Text = "Thoát";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(652, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm ưu đãi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_forNOR
            // 
            this.groupBox_forNOR.Controls.Add(this.label_NOR_end);
            this.groupBox_forNOR.Controls.Add(this.listBox_NOR_ended);
            this.groupBox_forNOR.Controls.Add(this.label_NOR_waiting);
            this.groupBox_forNOR.Controls.Add(this.listBox_NOR_waiting);
            this.groupBox_forNOR.Controls.Add(this.label_NOR_ongoing);
            this.groupBox_forNOR.Controls.Add(this.listBox_NOR_ongoing);
            this.groupBox_forNOR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_forNOR.Location = new System.Drawing.Point(12, 51);
            this.groupBox_forNOR.Name = "groupBox_forNOR";
            this.groupBox_forNOR.Size = new System.Drawing.Size(450, 506);
            this.groupBox_forNOR.TabIndex = 6;
            this.groupBox_forNOR.TabStop = false;
            this.groupBox_forNOR.Text = "Ưu đãi cho khách thường";
            // 
            // label_NOR_end
            // 
            this.label_NOR_end.AutoSize = true;
            this.label_NOR_end.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NOR_end.Location = new System.Drawing.Point(7, 336);
            this.label_NOR_end.Name = "label_NOR_end";
            this.label_NOR_end.Size = new System.Drawing.Size(122, 17);
            this.label_NOR_end.TabIndex = 6;
            this.label_NOR_end.Text = "Ưu đãi đã kết thúc:";
            // 
            // listBox_NOR_ended
            // 
            this.listBox_NOR_ended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_NOR_ended.FormattingEnabled = true;
            this.listBox_NOR_ended.ItemHeight = 16;
            this.listBox_NOR_ended.Location = new System.Drawing.Point(10, 356);
            this.listBox_NOR_ended.Name = "listBox_NOR_ended";
            this.listBox_NOR_ended.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_NOR_ended.Size = new System.Drawing.Size(398, 84);
            this.listBox_NOR_ended.TabIndex = 5;
            this.listBox_NOR_ended.DoubleClick += new System.EventHandler(this.listBox_NOR_ended_DoubleClick);
            this.listBox_NOR_ended.Leave += new System.EventHandler(this.listBox_NOR_ended_Leave);
            // 
            // label_NOR_waiting
            // 
            this.label_NOR_waiting.AutoSize = true;
            this.label_NOR_waiting.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NOR_waiting.Location = new System.Drawing.Point(7, 185);
            this.label_NOR_waiting.Name = "label_NOR_waiting";
            this.label_NOR_waiting.Size = new System.Drawing.Size(95, 17);
            this.label_NOR_waiting.TabIndex = 4;
            this.label_NOR_waiting.Text = "Ưu đãi sắp tới:";
            // 
            // listBox_NOR_waiting
            // 
            this.listBox_NOR_waiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_NOR_waiting.FormattingEnabled = true;
            this.listBox_NOR_waiting.ItemHeight = 16;
            this.listBox_NOR_waiting.Location = new System.Drawing.Point(10, 205);
            this.listBox_NOR_waiting.Name = "listBox_NOR_waiting";
            this.listBox_NOR_waiting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_NOR_waiting.Size = new System.Drawing.Size(398, 84);
            this.listBox_NOR_waiting.TabIndex = 3;
            this.listBox_NOR_waiting.DoubleClick += new System.EventHandler(this.listBox_NOR_waiting_DoubleClick);
            this.listBox_NOR_waiting.Leave += new System.EventHandler(this.listBox_NOR_waiting_Leave);
            // 
            // label_NOR_ongoing
            // 
            this.label_NOR_ongoing.AutoSize = true;
            this.label_NOR_ongoing.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NOR_ongoing.Location = new System.Drawing.Point(7, 29);
            this.label_NOR_ongoing.Name = "label_NOR_ongoing";
            this.label_NOR_ongoing.Size = new System.Drawing.Size(135, 17);
            this.label_NOR_ongoing.TabIndex = 2;
            this.label_NOR_ongoing.Text = "Ưu đãi đang áp dụng:";
            // 
            // listBox_NOR_ongoing
            // 
            this.listBox_NOR_ongoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_NOR_ongoing.FormattingEnabled = true;
            this.listBox_NOR_ongoing.ItemHeight = 16;
            this.listBox_NOR_ongoing.Location = new System.Drawing.Point(10, 49);
            this.listBox_NOR_ongoing.Name = "listBox_NOR_ongoing";
            this.listBox_NOR_ongoing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_NOR_ongoing.Size = new System.Drawing.Size(398, 84);
            this.listBox_NOR_ongoing.TabIndex = 1;
            this.listBox_NOR_ongoing.DoubleClick += new System.EventHandler(this.listBox_NOR_ongoing_DoubleClick);
            this.listBox_NOR_ongoing.Leave += new System.EventHandler(this.listBox_NOR_ongoing_Leave);
            // 
            // groupBox_forVIP
            // 
            this.groupBox_forVIP.Controls.Add(this.label1);
            this.groupBox_forVIP.Controls.Add(this.listBox_VIP_ongoing);
            this.groupBox_forVIP.Controls.Add(this.listBox_VIP_ended);
            this.groupBox_forVIP.Controls.Add(this.label3);
            this.groupBox_forVIP.Controls.Add(this.label2);
            this.groupBox_forVIP.Controls.Add(this.listBox_VIP_waiting);
            this.groupBox_forVIP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_forVIP.Location = new System.Drawing.Point(468, 51);
            this.groupBox_forVIP.Name = "groupBox_forVIP";
            this.groupBox_forVIP.Size = new System.Drawing.Size(476, 506);
            this.groupBox_forVIP.TabIndex = 7;
            this.groupBox_forVIP.TabStop = false;
            this.groupBox_forVIP.Text = "Ưu đãi cho khách vip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ưu đãi đã kết thúc:";
            // 
            // listBox_VIP_ongoing
            // 
            this.listBox_VIP_ongoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_VIP_ongoing.FormattingEnabled = true;
            this.listBox_VIP_ongoing.ItemHeight = 16;
            this.listBox_VIP_ongoing.Location = new System.Drawing.Point(28, 49);
            this.listBox_VIP_ongoing.Name = "listBox_VIP_ongoing";
            this.listBox_VIP_ongoing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_VIP_ongoing.Size = new System.Drawing.Size(398, 84);
            this.listBox_VIP_ongoing.TabIndex = 7;
            this.listBox_VIP_ongoing.DoubleClick += new System.EventHandler(this.listBox_VIP_ongoing_DoubleClick);
            this.listBox_VIP_ongoing.Leave += new System.EventHandler(this.listBox_VIP_ongoing_Leave);
            // 
            // listBox_VIP_ended
            // 
            this.listBox_VIP_ended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_VIP_ended.FormattingEnabled = true;
            this.listBox_VIP_ended.ItemHeight = 16;
            this.listBox_VIP_ended.Location = new System.Drawing.Point(28, 356);
            this.listBox_VIP_ended.Name = "listBox_VIP_ended";
            this.listBox_VIP_ended.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_VIP_ended.Size = new System.Drawing.Size(398, 84);
            this.listBox_VIP_ended.TabIndex = 11;
            this.listBox_VIP_ended.DoubleClick += new System.EventHandler(this.listBox_VIP_ended_DoubleClick);
            this.listBox_VIP_ended.Leave += new System.EventHandler(this.listBox_VIP_ended_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ưu đãi đang áp dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ưu đãi sắp tới:";
            // 
            // listBox_VIP_waiting
            // 
            this.listBox_VIP_waiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_VIP_waiting.FormattingEnabled = true;
            this.listBox_VIP_waiting.ItemHeight = 16;
            this.listBox_VIP_waiting.Location = new System.Drawing.Point(28, 205);
            this.listBox_VIP_waiting.Name = "listBox_VIP_waiting";
            this.listBox_VIP_waiting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_VIP_waiting.Size = new System.Drawing.Size(398, 84);
            this.listBox_VIP_waiting.TabIndex = 9;
            this.listBox_VIP_waiting.DoubleClick += new System.EventHandler(this.listBox_VIP_waiting_DoubleClick);
            this.listBox_VIP_waiting.Leave += new System.EventHandler(this.listBox_VIP_waiting_Leave);
            // 
            // button_saleDelete
            // 
            this.button_saleDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_saleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saleDelete.Location = new System.Drawing.Point(794, 16);
            this.button_saleDelete.Name = "button_saleDelete";
            this.button_saleDelete.Size = new System.Drawing.Size(110, 29);
            this.button_saleDelete.TabIndex = 8;
            this.button_saleDelete.Text = "Xóa ưu đãi";
            this.button_saleDelete.UseVisualStyleBackColor = false;
            this.button_saleDelete.Click += new System.EventHandler(this.button_saleDelete_Click);
            // 
            // Sale_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.button_saleDelete);
            this.Controls.Add(this.groupBox_forVIP);
            this.Controls.Add(this.groupBox_forNOR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_quit);
            this.Name = "Sale_viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách ưu đãi";
            this.groupBox_forNOR.ResumeLayout(false);
            this.groupBox_forNOR.PerformLayout();
            this.groupBox_forVIP.ResumeLayout(false);
            this.groupBox_forVIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_forNOR;
        private System.Windows.Forms.Label label_NOR_ongoing;
        private System.Windows.Forms.ListBox listBox_NOR_ongoing;
        private System.Windows.Forms.DataGridView dataGridView_sale;
        private System.Windows.Forms.GroupBox groupBox_forVIP;
        private System.Windows.Forms.Label label_NOR_end;
        private System.Windows.Forms.ListBox listBox_NOR_ended;
        private System.Windows.Forms.Label label_NOR_waiting;
        private System.Windows.Forms.ListBox listBox_NOR_waiting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_VIP_ongoing;
        private System.Windows.Forms.ListBox listBox_VIP_ended;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_VIP_waiting;
        private System.Windows.Forms.Button button_saleDelete;
    }
}