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

    public partial class Form_HoaDonNH : Form
    {
        public string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null;
        string manv = string.Empty;
        string tennv = string.Empty;
        public Form_HoaDonNH(string manv, string tennv)
        {
            this.tennv = tennv;
            this.manv = manv;
            InitializeComponent();
            LoadHDNH();

        }

        private void LoadHDNH()
        {
            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCon.Open();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SOHD_NH,NGNHAP,TENDT,HOTEN,TRIGIA from HDNH,DTCC,NHANVIEN where HDNH.DTID=DTCC.DTID and HDNH.NVID=NHANVIEN.NVID";
            sqlCmd.Connection = sqlCon;
            adapter = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable tbHDNH = new DataTable();
            tbHDNH.Clear();
            adapter.Fill(tbHDNH);
            dgvHDHN.DataSource = tbHDNH;          
            sqlCon.Close();
            dgvHDHN.Columns[0].HeaderText = "Số hoá đơn nhập";
            dgvHDHN.Columns[1].HeaderText = "Ngày nhập";
            dgvHDHN.Columns[2].HeaderText = "Tên đối tác";
            dgvHDHN.Columns[3].HeaderText = "Tên nhân viên nhập";
            dgvHDHN.Columns[4].HeaderText = "Giá trị ";
        }

        private void dgvHDHN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDHN.SelectedRows!= null)
            LoadDonNhap(dgvHDHN.CurrentRow.Cells[0].Value.ToString());
        }
        private void LoadDonNhap(string MaDonNhap)
        {
            if (MaDonNhap != string.Empty)
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                adapter = new SqlDataAdapter("select SPID,SL from CTHDNH where SOHD_NH=" + MaDonNhap, sqlCon);
                DataTable tableSPNH = new DataTable();
                adapter.Fill(tableSPNH);
                dgvChiTietNH.DataSource = tableSPNH;
                dgvChiTietNH.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgvChiTietNH.Columns[1].HeaderText = "Số Lượng Nhập";
                sqlCon.Close();
            }
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhapHang f = new Form_NhapHang(manv, tennv);
            f.ShowDialog();          
            this.Show();
            LoadHDNH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHDHN.CurrentRow != null && dgvHDHN.CurrentRow.Cells["SOHD_NH"].Value.ToString() != string.Empty)
            {
                this.Hide();
                Form_NhapHang f = new Form_NhapHang(dgvHDHN.CurrentRow.Cells["SOHD_NH"].Value.ToString());
                f.ShowDialog();
                this.Show();
                LoadHDNH();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ChiTietNH f = new Form_ChiTietNH(dgvHDHN.CurrentRow.Cells["SOHD_NH"].Value.ToString());
            f.ShowDialog();
            f.Close();
            this.Show();
        }
    }
}
