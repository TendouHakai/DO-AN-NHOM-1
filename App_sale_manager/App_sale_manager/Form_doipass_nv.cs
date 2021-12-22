using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_sale_manager
{
    public partial class Form_doipass_nv : System.Windows.Forms.Form
    {
        string NVID;
        public string nvid
        {
            set { NVID = value; }
        }
        SqlConnection sqlCon = null;
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        SqlCommand cmd;
        public event EventHandler Thoat;
        public Form_doipass_nv(string NVID)
        {
            InitializeComponent();
            this.NVID = NVID;
            sqlCon = new SqlConnection(strCon);
        }

        private void bt_hoantat_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu?", "Đổi mật khẩu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (tb_matkhaumoi_nv.Text == tb_xacnhan_nv.Text)
                {
                    cmd = sqlCon.CreateCommand();
                    cmd.CommandText = "SELECT PASSWD FROM NHANVIEN WHERE NVID='" + this.NVID.ToString() + "'";
                    cmd.Connection = sqlCon;
                    SqlDataReader reader = cmd.ExecuteReader();
                    string matkhau = null;
                    if (reader.Read())
                    {
                        matkhau = reader.GetString(0);

                    }
                    reader.Close();
                    if (tb_matkhaucu_nv.Text == matkhau)
                    {
                        cmd.CommandText = "update NHANVIEN set PASSWD='" + tb_matkhaumoi_nv.Text + "' WHERE NVID='" + this.NVID.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!");
                        tb_matkhaucu_nv.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                    tb_xacnhan_nv.Focus();
                }
                sqlCon.Close();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_doipass_nv_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thoat(this, new EventArgs());
        }

        private void tb_matkhaumoi_nv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}