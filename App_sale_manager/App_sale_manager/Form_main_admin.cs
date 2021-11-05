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
    public partial class Form_main_admin : Form
    {
        string manv = "nv01";
        public event EventHandler Thoat;

        string strCon = "Data Source=DESKTOP-BQASASP;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form_main_admin()
        {
            sqlCon = new SqlConnection(strCon);
            cmd = sqlCon.CreateCommand();
            InitializeComponent();
        }

        public Form_main_admin(string manv)
        {
            this.manv = manv;
            sqlCon = new SqlConnection(strCon);
            cmd = sqlCon.CreateCommand();

            InitializeComponent();
            
            
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }

        private void BNT_TaoHoaDon_Click(object sender, EventArgs e)
        {
            Form_GiaoDich F_GD = new Form_GiaoDich(manv);
            F_GD.Show();

        }

        private void BNT_Refresh_GD_Click(object sender, EventArgs e)
        {
            this.Refresh_data_GD();
        }

        private  void Refresh_data_GD()
        {
            sqlCon.Open();   
            cmd.CommandText = "select * from HDBH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();
            CLB_GD_TrangThai.SetItemChecked(0, true);
            CLB_GD_TrangThai.SetItemChecked(1, true);
            CLB_GD_TrangThai.SetItemChecked(2, true);
            CLB_GD_LoaiDon.SetItemChecked(0, true);
            CLB_GD_LoaiDon.SetItemChecked(1, true);
            Box_GD_MaHoaDon.Text = "";
            Box_GD_MaKhachHang.Text = "";
            BOX_GD_MaNhanVien.Text = "";
        }

        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh_data_GD();
        }

        private void bnt_Timkiem_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            cmd.CommandText = "select * from HDBH where (SOHD_BH like '%"+Box_GD_MaHoaDon.Text+ "%' and KHID like '%" + Box_GD_MaKhachHang.Text + "%'AND NVID like '%" + BOX_GD_MaNhanVien.Text + "%'  ";
            if(CLB_GD_LoaiDon.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and LOAIHD != 'DDH'";
            }
            if (CLB_GD_LoaiDon.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and LOAIHD != 'DTT'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'NHANDON'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'DANGGIAO'";
            }

            if (CLB_GD_TrangThai.CheckedIndices.Contains(2) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'HOANTAT'";
            }

            cmd.CommandText += ") ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();
        }

        private void GridView_Data_GiaoDich_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Form_CTHD cthd = new Form_CTHD((string)GridView_Data_GiaoDich.CurrentRow.Cells[0].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[2].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[3].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[5].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[6].Value, Convert.ToString( GridView_Data_GiaoDich.CurrentRow.Cells[4].Value));
            cthd.Show();
        }

        Bitmap bmp;
        private void bnt_inDS_Click(object sender, EventArgs e)
        {
            int height = GridView_Data_GiaoDich.Height;
            GridView_Data_GiaoDich.Height = GridView_Data_GiaoDich.RowCount  * GridView_Data_GiaoDich.RowTemplate.Height + 2* GridView_Data_GiaoDich.RowTemplate.Height;
            GridView_Data_GiaoDich.CurrentRow.Selected = false;
            bmp = new Bitmap(GridView_Data_GiaoDich.Width, GridView_Data_GiaoDich.Height);
            GridView_Data_GiaoDich.DrawToBitmap(bmp, new Rectangle(0, 0, GridView_Data_GiaoDich.Width, GridView_Data_GiaoDich.Height));
            GridView_Data_GiaoDich.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_GD(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,30,0);
        }
    }
}
