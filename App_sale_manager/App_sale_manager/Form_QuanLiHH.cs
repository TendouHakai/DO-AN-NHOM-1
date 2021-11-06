using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_sale_manager
{
    public partial class Form_QuanLiHH : Form
    {
        public string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null;
        public Form_QuanLiHH()
        {
            InitializeComponent();
            LoadHangHoa();
        }
        public void LoadHangHoa()
        {

            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCon.Open();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP where SANPHAM.LOAIID = LOAISP.LOAIID ";
            sqlCmd.Connection = sqlCon;
            adapter = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable tbHH = new DataTable();
            tbHH.Clear();
            adapter.Fill(tbHH);
            dgvSP.DataSource = tbHH;
            DinhDangdgvHH();
            lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
            sqlCon.Close();
        }
        public void DinhDangdgvHH()
        {
            dgvSP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSP.Columns[0].Width = 60;
            dgvSP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSP.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgvSP.Columns[3].HeaderText = "Nước Sản Xuất";
            dgvSP.Columns[3].Width = 80;
            dgvSP.Columns[4].HeaderText = "Giá Bán";
            dgvSP.Columns[5].HeaderText = "Giá Nhập";
            dgvSP.Columns[6].HeaderText = "Đơn Vị Tính";
            dgvSP.Columns[6].Width = 50;
            dgvSP.Columns[7].HeaderText = "Số Lượng";
            dgvSP.Columns[7].Width = 50;
            dgvSP.Columns[8].HeaderText = "Số Lượng Tối Thiểu";
            dgvSP.Columns[8].Width = 50;
            dgvSP.Columns[9].HeaderText = "Mô Tả";
        }
       
        private void XemChiTiet()

        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xem chi tiết");
                return;
            }
            Form_ChiTietHH f = new Form_ChiTietHH(dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["TENLOAI"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(1);
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();

        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
                return;
            }
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(2, dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["TENLOAI"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();
        }


        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xoá");
                return;
            }           
            string strquery = "delete from SANPHAM where SPID='" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + "'";
            FileInfo info = new FileInfo(@"..\..\..\..\HangHoa\"+ dgvSP.CurrentRow.Cells["SPID"].Value.ToString()+".jpg");
            info.Delete();
            SqlCommand sqlCmd = new SqlCommand(strquery, sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            LoadHangHoa();
            MessageBox.Show("Đã xoá");
        }

        private void btnXemChiTietHH_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void dgvSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XemChiTiet();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLLoaiHH_Click(object sender, EventArgs e)
        {
            Form_QLLoaiHH f = new Form_QLLoaiHH();
            this.Hide();
            f.ShowDialog();            
            this.Show();
        }
    }
}
