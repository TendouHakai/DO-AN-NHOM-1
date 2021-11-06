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
    public partial class Form_TimKiemHH : Form
    {
        public string strCon = @"Data Source=LAPTOP-4KM350G8;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null; 
        public Form_TimKiemHH()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select TENLOAI from [LOAISP] group by TENLOAI", sqlCon);
            DataTable tableLoai = new DataTable();
            adapter.Fill(tableLoai);
            cbbLoaiSP.DataSource = tableLoai;
            cbbLoaiSP.DisplayMember = "TenLoai";
            cbbLoaiSP.ValueMember = "TenLoai";
            adapter = new SqlDataAdapter("select NUOCSX from [SANPHAM] group by NUOCSX", sqlCon);
            DataTable tableNuoc = new DataTable();
            adapter.Fill(tableNuoc);
            cbbNuocSX.DataSource = tableNuoc;
            cbbNuocSX.DisplayMember = "NUOCSX";
            cbbNuocSX.ValueMember = "NUOCSX";
            sqlCon.Close();
        }
        
        public DataTable TimKiem()
        {
            DataTable tb = new DataTable();
            if (txtGiaBan.Text == String.Empty)
            {
                txtGiaBan.Text = "999999999999999999";
            }
            string query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%' and GIABAN < " + txtGiaBan.Text + "and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%')";
            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(tb);
            sqlCon.Close();
            return tb;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
