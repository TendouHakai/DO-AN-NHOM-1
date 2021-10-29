
namespace App_sale_manager
{
    partial class Form_login
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
            this.label_tiltle_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_usr = new System.Windows.Forms.Label();
            this.textBox_usr = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.link_frm_doipasswd = new System.Windows.Forms.LinkLabel();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tiltle_login
            // 
            this.label_tiltle_login.AutoSize = true;
            this.label_tiltle_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiltle_login.Location = new System.Drawing.Point(134, 89);
            this.label_tiltle_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tiltle_login.Name = "label_tiltle_login";
            this.label_tiltle_login.Size = new System.Drawing.Size(176, 20);
            this.label_tiltle_login.TabIndex = 0;
            this.label_tiltle_login.Text = "Đăng nhập tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "password";
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usr.Location = new System.Drawing.Point(135, 132);
            this.label_usr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(31, 15);
            this.label_usr.TabIndex = 1;
            this.label_usr.Text = "user";
            // 
            // textBox_usr
            // 
            this.textBox_usr.Location = new System.Drawing.Point(210, 132);
            this.textBox_usr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_usr.Name = "textBox_usr";
            this.textBox_usr.Size = new System.Drawing.Size(192, 20);
            this.textBox_usr.TabIndex = 2;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Location = new System.Drawing.Point(210, 162);
            this.textBox_passwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(192, 20);
            this.textBox_passwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nếu bạn muốn đổi mật khẩu mới hãy nhấn";
            // 
            // link_frm_doipasswd
            // 
            this.link_frm_doipasswd.AutoSize = true;
            this.link_frm_doipasswd.Location = new System.Drawing.Point(346, 202);
            this.link_frm_doipasswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_frm_doipasswd.Name = "link_frm_doipasswd";
            this.link_frm_doipasswd.Size = new System.Drawing.Size(23, 13);
            this.link_frm_doipasswd.TabIndex = 4;
            this.link_frm_doipasswd.TabStop = true;
            this.link_frm_doipasswd.Text = "link";
            this.link_frm_doipasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_frm_doipasswd_LinkClicked);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(137, 244);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(129, 36);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(271, 244);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(129, 36);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 331);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.link_frm_doipasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_usr);
            this.Controls.Add(this.label_usr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_tiltle_login);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tiltle_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.TextBox textBox_usr;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_frm_doipasswd;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}

