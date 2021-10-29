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
        public string strCon = @"Data Source=LAPTOP-4KM350G8;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter ADT =null;
        static DataTable tbHH = new DataTable();      
        public Form_main_admin()
        {
            InitializeComponent();
            LoadHangHoa();
   
        }
        public event EventHandler Thoat;

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }
       

        public void LoadHangHoa()
        {
            
            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCon.Open();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from SANPHAM ";
            
            sqlCmd.Connection = sqlCon;
            ADT = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(ADT);
            tbHH.Clear();
            ADT.Fill(tbHH);
            dgvSP.DataSource = tbHH;
            if (KiemTraHangSapHet())
                lblChuY.Text = "Chú ý có hàng hoá sắp hết";
            else lblChuY.Text = string.Empty;
            lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
            sqlCon.Close();
        }

        

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(1);
            this.Hide();
            f.ShowDialog();
            
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
                return;
            }
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(2, dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["LOAIID"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
          
        }
        

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            if(dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xoá");
                return;
            }    
            string strquery = "delete from SANPHAM where SPID='" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + "'";
            SqlCommand sqlCmd = new SqlCommand(strquery, sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            LoadHangHoa();                       
        }

        private void Form_main_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void XemChiTiet()

        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xem chi tiết");
                return;
            }
            Form_ChiTietHH f = new Form_ChiTietHH(dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["LOAIID"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
        }
        private void btnXemChiTietHH_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void dgvSP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XemChiTiet();
        }

        private void btnHangSapHet_Click(object sender, EventArgs e)
        {
            lblTieuDeHH.Text = "Hàng Hoá Sắp H";
            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from SANPHAM where SoLuong<SLTT";
            // gửi truy vấn tới kết nối.
            sqlCmd.Connection = sqlCon;
            ADT = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(ADT);
            tbHH.Clear();
            ADT.Fill(tbHH);
            dgvSP.DataSource = tbHH;
        }
        private bool KiemTraHangSapHet()
        {
            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from SANPHAM where SoLuong<SLTT";
            // gửi truy vấn tới kết nối.
            sqlCmd.Connection = sqlCon;
            sqlCon.Open();
            var r = sqlCmd.ExecuteReader();
            if (r.HasRows)
                return true;
            return false;

        }
     
    }
}
