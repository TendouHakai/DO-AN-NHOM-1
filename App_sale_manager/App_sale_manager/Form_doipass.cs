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

namespace App_sale_manager
{
    public partial class Form_doipass : Form
    {
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form_doipass()
        {
            InitializeComponent();
        }

        private void Form_doipass_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
           
        }
        public event EventHandler Thoat;
        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            cmd = sqlCon.CreateCommand();
            if (textBox_usr.Text == "" || textBox_pass_old.Text == "" || textBox_pass_new.Text == "" || textBox_pass_new2.Text == "")
            {
                MessageBox.Show("Ban chua dien du thong tin");
                return;
            }
            cmd.CommandText = "select PASSWD from NHANVIEN where USERNAME = '"+textBox_usr.Text+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DataTableReader reader = new DataTableReader(table);
            string passwd="";
            if(reader.Read())
            {
                passwd = reader.GetString(0);
            }
            if(passwd != textBox_pass_old.Text)
            {
                MessageBox.Show("user hay mật khẩu nhập không đúng.");
                return;
            }    
            if(textBox_pass_new.Text==passwd)
            {
                MessageBox.Show("mật khẩu mới giống mật khẩu cũ.");
                return;
            }  
            if(textBox_pass_new.Text!=textBox_pass_new2.Text)
            {
                MessageBox.Show("mật khẩu lặp lại không đúng.");
                return;
            }
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "update NHANVIEN set PASSWD = '" + textBox_pass_new.Text + "' where USERNAME = '" + textBox_usr.Text + "'";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            Thoat(this, new EventArgs());
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }
    }
}
