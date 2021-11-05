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
        string strCon = "Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        Bitmap bmp;
        public Form_CTHD()
        {
            InitializeComponent();
        }
        
        public Form_CTHD(string mahoadon,string makhachhang,string manhanvien,string loaihd,string trangthai, string tong)
        {           
            InitializeComponent();


            l_MaHoadon.Text = mahoadon;
            l_MaKhachhang.Text = makhachhang;
            l_MaNhanVien.Text = manhanvien;
            l_LoaiHoaDon.Text = loaihd;
            l_TrangThai.Text = trangthai;
            l_Tong.Text =tong;

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            cmd = sqlCon.CreateCommand();


            cmd.CommandText = "select CTHDBH.SPID,SL,GIABAN from CTHDBH, SANPHAM where SOHD_BH = '"+mahoadon+"' and SANPHAM.SPID = CTHDBH.SPID " ;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            DGV_CTHD.DataSource = table;
        }

        private void bnt_trangthai_Click(object sender, EventArgs e)
        {
            
            if (l_TrangThai.Text == "NHANDON")
            {
                cmd.CommandText = "update HDBH set TRANGTHAI = 'DANGGIAO' where SOHD_BH = '"+l_MaHoadon.Text+"' ";
                adapter.UpdateCommand = cmd;
                l_TrangThai.Text = "DANGGIAO";
            }
            if (l_TrangThai.Text == "DANGGIAO")
            {
                l_TrangThai.Text = "HOANTAT";
                cmd.CommandText = "update HDBH set TRANGTHAI = 'HOANTAT' where SOHD_BH  = '"+l_MaHoadon.Text+"' ";
                cmd.ExecuteNonQuery();               
            }
        }

        private void Form_CTHD_Load(object sender, EventArgs e)
        {
            if(DGV_CTHD.CurrentRow != null)
            DGV_CTHD.CurrentRow.Selected = false;
        }

        private void bnt_Print_Click(object sender, EventArgs e)
        {
            int height = DGV_CTHD.Height;
            DGV_CTHD.Height = DGV_CTHD.RowCount  * DGV_CTHD.RowTemplate.Height + 2*DGV_CTHD.RowTemplate.Height;
            bmp = new Bitmap(DGV_CTHD.Width, DGV_CTHD.Height );
            DGV_CTHD.DrawToBitmap(bmp, new Rectangle(0, 0, DGV_CTHD.Width, DGV_CTHD.Height));
            DGV_CTHD.Height = height;
            PrintP_HoaDon.ShowDialog();
        }

        
        private void Print_HoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("HOA DON THANH TOAN ", drawFont, drawBrush, 90, 10);

            drawFont = new Font("Arial", 12);

            e.Graphics.DrawString("************************************************************************", drawFont, drawBrush, 0, 100);

            e.Graphics.DrawString("Ma hoa don ", drawFont,drawBrush,30, 125);
            e.Graphics.DrawString(l_MaHoadon.Text, drawFont, drawBrush, 250, 125);

            e.Graphics.DrawString("Ma khach hang ", drawFont, drawBrush, 30, 150);
            e.Graphics.DrawString(l_MaKhachhang.Text, drawFont, drawBrush, 250, 150);

            e.Graphics.DrawString("Ma nhan vien ", drawFont, drawBrush, 30, 175);
            e.Graphics.DrawString(l_MaNhanVien.Text, drawFont, drawBrush, 250, 175);

            e.Graphics.DrawString("Loai hoa don ", drawFont, drawBrush, 30, 200);
            e.Graphics.DrawString(l_LoaiHoaDon.Text, drawFont, drawBrush, 250, 200);

            e.Graphics.DrawString("Trang thai ", drawFont, drawBrush, 30, 225);
            e.Graphics.DrawString(l_TrangThai.Text, drawFont, drawBrush, 250, 225);


            e.Graphics.DrawString("************************************************************************", drawFont, drawBrush, 0, 250);


            e.Graphics.DrawImage(bmp, 20, 275);

            e.Graphics.DrawString("Tong  ", drawFont, drawBrush, 275, 290 + bmp.Height);
            e.Graphics.DrawString(l_Tong.Text, drawFont, drawBrush, 325, 290 + bmp.Height);
        }
    }
}
