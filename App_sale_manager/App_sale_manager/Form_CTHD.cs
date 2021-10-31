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
    public partial class Form_CTHD : Form
    {
        public Form_CTHD()
        {
            InitializeComponent();
        }
        string strcon = "Data Source=DESKTOP-BQASASP;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection AAA;
        SqlCommand command;
        SqlDataAdapter ADT = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form_CTHD(string mahoadon,string makhachhang,string manhanvien,string loaihd,string trangthai)
        {
            InitializeComponent();
            l_MaHoadon.Text = mahoadon;
            l_MaKhachhang.Text = makhachhang;
            l_MaNhanVien.Text = manhanvien;
            l_LoaiHoaDon.Text = loaihd;
            l_TrangThai.Text = trangthai;

            AAA = new SqlConnection(strcon);
            AAA.Open();
            command = AAA.CreateCommand();


            command.CommandText = "select CTHDBH.SPID,SL,GIABAN from CTHDBH, SANPHAM where SOHD_BH = '"+mahoadon+"' and SANPHAM.SPID = CTHDBH.SPID " ;
            ADT.SelectCommand = command;
            ADT.Fill(table);
            DGV_CTHD.DataSource = table;

        }

        private void bnt_trangthai_Click(object sender, EventArgs e)
        {
            if (l_TrangThai.Text == "NHANDON")
            {
                command.CommandText = "update HDBH set TRANGTHAI = 'DANGGIAO' where SOHD_BH = '"+l_MaHoadon.Text+"' ";
                ADT.UpdateCommand = command;
                l_TrangThai.Text = "DANGGIAO";
            }
            if (l_TrangThai.Text == "DANGGIAO")
            {
                l_TrangThai.Text = "HOANTAT";
                command.CommandText = "update HDBH set TRANGTHAI = 'HOANTAT' where SOHD_BH  = '"+l_MaHoadon.Text+"' ";
                command.ExecuteNonQuery();               
            }
        }
    }
}
