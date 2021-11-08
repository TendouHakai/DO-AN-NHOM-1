using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace App_sale_manager
{
    public partial class Form_login : Form
    {
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        SqlConnection sqlCon = null;
        
        public Form_login()
        {
            InitializeComponent();
            this.AcceptButton = btn_dangnhap;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(sqlCon==null)
            {
                sqlCon = new SqlConnection(strCon);
            }   
            if(sqlCon.State==ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // tạo ra đối tượng thực thi truy vấn.
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select PASSWD from NHANVIEN where USERNAME = '"+textBox_usr.Text+"'";
            // gửi truy vấn tới kết nối.
            sqlCmd.Connection = sqlCon;
            // nhận kết quả
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string passwd = "";
            if(reader.Read())
            {
                passwd = reader.GetString(0);
            }
            // kiểm tra passwd
            if (passwd == textBox_passwd.Text)
            {
                if(textBox_usr.Text == "admin")
                {
                    Form_main_admin frm = new Form_main_admin();
                    frm.Thoat += Frm_Thoat;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    Form_main_NV frm = new Form_main_NV();
                    frm.Thoat += Frm_Thoat;
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("username hoặc passwd không đúng.");
            }


            sqlCon.Close(); 
        }

        private void Frm_Thoat(object sender, EventArgs e)
        {
            (sender as Form).Close();
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_frm_doipasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_doipass frm = new Form_doipass();
            frm.Thoat += Frm_Thoat;
            frm.Show();
            this.Hide();
            
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }
    }
}