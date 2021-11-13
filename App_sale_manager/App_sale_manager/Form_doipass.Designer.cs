
namespace App_sale_manager
{
    partial class Form_doipass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_usr = new System.Windows.Forms.TextBox();
            this.textBox_pass_old = new System.Windows.Forms.TextBox();
            this.textBox_pass_new = new System.Windows.Forms.TextBox();
            this.textBox_pass_new2 = new System.Windows.Forms.TextBox();
            this.btn_hoantat = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "password cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "password mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập lại password";
            // 
            // textBox_usr
            // 
            this.textBox_usr.Location = new System.Drawing.Point(307, 133);
            this.textBox_usr.Name = "textBox_usr";
            this.textBox_usr.Size = new System.Drawing.Size(286, 22);
            this.textBox_usr.TabIndex = 2;
            // 
            // textBox_pass_old
            // 
            this.textBox_pass_old.Location = new System.Drawing.Point(307, 178);
            this.textBox_pass_old.Name = "textBox_pass_old";
            this.textBox_pass_old.PasswordChar = '*';
            this.textBox_pass_old.Size = new System.Drawing.Size(286, 22);
            this.textBox_pass_old.TabIndex = 3;
            // 
            // textBox_pass_new
            // 
            this.textBox_pass_new.Location = new System.Drawing.Point(307, 218);
            this.textBox_pass_new.Name = "textBox_pass_new";
            this.textBox_pass_new.PasswordChar = '*';
            this.textBox_pass_new.Size = new System.Drawing.Size(286, 22);
            this.textBox_pass_new.TabIndex = 3;
            // 
            // textBox_pass_new2
            // 
            this.textBox_pass_new2.Location = new System.Drawing.Point(307, 265);
            this.textBox_pass_new2.Name = "textBox_pass_new2";
            this.textBox_pass_new2.PasswordChar = '*';
            this.textBox_pass_new2.Size = new System.Drawing.Size(286, 22);
            this.textBox_pass_new2.TabIndex = 3;
            // 
            // btn_hoantat
            // 
            this.btn_hoantat.Location = new System.Drawing.Point(216, 316);
            this.btn_hoantat.Name = "btn_hoantat";
            this.btn_hoantat.Size = new System.Drawing.Size(154, 45);
            this.btn_hoantat.TabIndex = 4;
            this.btn_hoantat.Text = "Hoàn tất";
            this.btn_hoantat.UseVisualStyleBackColor = true;
            this.btn_hoantat.Click += new System.EventHandler(this.btn_hoantat_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(439, 316);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(154, 45);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // Form_doipass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_hoantat);
            this.Controls.Add(this.textBox_pass_new2);
            this.Controls.Add(this.textBox_pass_new);
            this.Controls.Add(this.textBox_pass_old);
            this.Controls.Add(this.textBox_usr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_doipass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi password";
            this.Load += new System.EventHandler(this.Form_doipass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_usr;
        private System.Windows.Forms.TextBox textBox_pass_old;
        private System.Windows.Forms.TextBox textBox_pass_new;
        private System.Windows.Forms.TextBox textBox_pass_new2;
        private System.Windows.Forms.Button btn_hoantat;
        private System.Windows.Forms.Button btn_Huy;
    }
}