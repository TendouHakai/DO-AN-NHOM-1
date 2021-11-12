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
using System.Configuration;

namespace App_sale_manager
{
    public partial class Form_NhapHang : Form
    {

        public string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null;
        int trangthai = -1;
        public Form_NhapHang(string manv, string tennv)
        {

            InitializeComponent();
            LoadCBB();
            trangthai = 1;
            txtSoHDNH.Text = LoadMaDN();
            txtNVNhap.Text = tennv;
            txtMaNV.Text = manv;
            txtMaDT.Text = LayIDDoiTac();
            txtSLNhap.ReadOnly = false;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            string strquery = "set dateformat dmy insert into HDNH values('" + txtSoHDNH.Text + "',null,null,null,null)";
            SqlCommand sqlCmd;
            sqlCmd = new SqlCommand(strquery, sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        public Form_NhapHang(string sohd)
        {
            trangthai = 1;
            InitializeComponent();
            LoadCBB();
            LoadDonNhap();
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select HDNH.SOHD_NH,NGNHAP,HDNH.DTID,DTCC.TENDT,HDNH.NVID,NHANVIEN.HOTEN,TRIGIA from HDNH,DTCC,NHANVIEN where DTCC.DTID=HDNH.DTID and NHANVIEN.NVID=HDNH.NVID and HDNH.SOHD_NH='" + sohd + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            
            if (reader.Read())
            {
                txtSoHDNH.Text = reader.GetString(0);
                dateNgayNhap.Text = reader.GetDateTime(1).ToString();
                txtMaDT.Text = reader.GetString(2);
                cbbDoiTac.Text = reader.GetString(3);
                txtMaNV.Text = reader.GetString(4);
                txtNVNhap.Text = reader.GetString(5);
                reader.Close();
            }
            sqlCon.Close();
            LoadDonNhap();
            txtGiaTriDN.Text = LayGia();
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
        private string LoadMaDN()
        {
            string max;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand(" delete HDNH where  TRIGIA is Null or NVID is null or NGNHAP is null or DTID is null select max(SOHD_NH) from HDNH", sqlCon);
            var reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    max = "0";
                }
                else max = reader.GetString(0);
            }
            else max = "0";
            sqlCon.Close();
            return (Convert.ToInt32(max) + 1).ToString();
        }
        private void LoadCBB()
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select TENLOAI from [LOAISP] group by TENLOAI", sqlCon);
            DataTable tableLoai = new DataTable();
            adapter.Fill(tableLoai);
            cbbLoaiSP.DataSource = tableLoai;
            cbbLoaiSP.DisplayMember = "TenLoai";
            cbbLoaiSP.ValueMember = "TenLoai";
            adapter = new SqlDataAdapter("select TENDT from [DTCC] group by TENDT", sqlCon);
            DataTable tableDoiTac = new DataTable();
            adapter.Fill(tableDoiTac);
            cbbDoiTac.DataSource = tableDoiTac;
            cbbDoiTac.DisplayMember = "TENDT";
            cbbDoiTac.ValueMember = "TENDT";
            adapter = new SqlDataAdapter("select TENSP from SANPHAM,LOAISP where SANPHAM.LOAIID=LOAISP.LOAIID and LOAISP.TENLOAI='" + cbbLoaiSP.Text + "'", sqlCon);
            DataTable tableTenSP = new DataTable();
            adapter.Fill(tableTenSP);
            cbbTenSP.DataSource = tableTenSP;
            cbbTenSP.DisplayMember = "TENSP";
            cbbTenSP.ValueMember = "TENSP";
            sqlCon.Close();
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select TENSP from SANPHAM,LOAISP where SANPHAM.LOAIID=LOAISP.LOAIID and LOAISP.TENLOAI=N'" + cbbLoaiSP.Text + "'", sqlCon);
            DataTable tableTenSP = new DataTable();
            adapter.Fill(tableTenSP);
            cbbTenSP.DataSource = tableTenSP;
            cbbTenSP.DisplayMember = "TENSP";
            cbbTenSP.ValueMember = "TENSP";
            sqlCon.Close();
        }

        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select SoLuong,SPID,GIANHAP from SANPHAM Where TENSP = N'" + cbbTenSP.Text + "'", sqlCon);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtSoLuong.Text = table.Rows[0][0].ToString();
            txtMaSP.Text = table.Rows[0][1].ToString();
            txtGiaNhap.Text = table.Rows[0][2].ToString();
            sqlCon.Close();
            Image img = GetCopyImage(@"..\..\HangHoa\" + txtMaSP.Text + ".jpg");
           
            ptrbHinhAnh.Image = img; 
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private Image GetCopyImage(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                Bitmap bitmap = new Bitmap(image);
                return bitmap;
            }
        }
        private void dgvChiTietNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("select LOAISP.TENLOAI,SANPHAM.TENSP,SANPHAM.SPID,SANPHAM.SOLUONG,SANPHAM.GIANHAP,CTHDNH.SL from SANPHAM,CTHDNH,LOAISP where SANPHAM.SPID=N'" + dgvChiTietNH.CurrentRow.Cells["SPID"].Value.ToString() + "' and SANPHAM.SPID =CTHDNH.SPID and LOAISP.LOAIID=SANPHAM.LOAIID", sqlCon);
            var reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                cbbLoaiSP.Text = reader.GetString(0);
                cbbTenSP.Text = reader.GetString(1);
                txtMaSP.Text = reader.GetString(2);
                txtSoLuong.Text = reader.GetInt32(3).ToString();
                txtGiaNhap.Text = reader.GetSqlMoney(4).ToString();
                txtSLNhap.Text = Convert.ToInt32(reader.GetByte(5)).ToString();
            }
            ptrbHinhAnh.Image = Image.FromFile(@"..\..\HangHoa\" + txtMaSP.Text + ".jpg");
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            sqlCon.Close();
            txtGiaTriDN.Text = LayGia();
        }

       
        private void LoadDonNhap()
        {
            if (txtSoHDNH.Text != string.Empty)
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                adapter = new SqlDataAdapter("select SPID,SL from CTHDNH where SOHD_NH=" + txtSoHDNH.Text, sqlCon);
                DataTable tableSPNH = new DataTable();
                adapter.Fill(tableSPNH);
                dgvChiTietNH.DataSource = tableSPNH;
                dgvChiTietNH.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgvChiTietNH.Columns[1].HeaderText = "Số Lượng Nhập";
                sqlCon.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            try
            {
                if (txtSLNhap.Text != string.Empty && txtMaSP.Text != string.Empty && txtSLNhap.Text != string.Empty)
                {
                    string strquery = "insert into CTHDNH values('" + txtSoHDNH.Text + "','" + txtMaSP.Text + "'," + txtSLNhap.Text + ")";
                    SqlCommand sqlCmd;
                    sqlCmd = new SqlCommand(strquery, sqlCon);

                    sqlCmd.ExecuteNonQuery();
                }
                else MessageBox.Show("Chưa nhập đủ thông tin");
            }
            catch
            {
                MessageBox.Show("Lỗi trong đơn nhập đã có sản phẩm này");
            }
            sqlCon.Close();
            LoadDonNhap();
            txtGiaTriDN.Text = LayGia();
            Them1SL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            if (dgvChiTietNH.CurrentRow != null)
            {
                string strquery = "delete from CTHDNH where SPID ='" + dgvChiTietNH.CurrentRow.Cells["SPID"].Value.ToString() + "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);

                sqlCmd.ExecuteNonQuery();
            }
            else MessageBox.Show("Chưa chọn hàng để xoá");
            sqlCon.Close();
            txtGiaTriDN.Text = LayGia();
            LoadDonNhap();
            Giam1SL();
        }
        private void GiamSLAll()
        {
            for (int i = 0; i < dgvChiTietNH.Rows.Count - 1; i++)
            {
                sqlCon.Open();
                string strquery = "update SANPHAM set SoLuong = SoLuong - " + dgvChiTietNH.Rows[i].Cells["SL"].Value.ToString() + " where SPID=N'" + dgvChiTietNH.Rows[i].Cells["SPID"].Value.ToString() + "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                sqlCon.Open();
                string strquery = "delete from CTHDNH where SOHD_NH ='" + txtSoHDNH.Text + "' delete from HDNH where SOHD_NH ='" + txtSoHDNH.Text + "' ";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                trangthai = 0;
                this.Close();
                GiamSLAll();
            }
        }
        private string LayIDDoiTac()
        {
            string id = string.Empty;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("select DTID from DTCC where TENDT=N'" + cbbDoiTac.Text + "'", sqlCon);
            var reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            { id = reader.GetString(0); }
            sqlCon.Close();
            return id;
        }
        private string LayGia()
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            int Gia = 0;
            for (int i = 0; i < dgvChiTietNH.Rows.Count - 1; i++)
            {
                SqlCommand sqlCmd = new SqlCommand("select * from SANPHAM where SPID=N'" + dgvChiTietNH.Rows[i].Cells["SPID"].Value.ToString() + "'", sqlCon);
                var reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    int dongia = Convert.ToInt32(reader["GIANHAP"]);
                    int sl = Convert.ToInt32(dgvChiTietNH.Rows[i].Cells[1].Value);
                    Gia = Gia + dongia * sl;
                    reader.Close();
                }
            }
            sqlCon.Close();
            return Gia.ToString();
        }
        private void Them1SL()
        {          
                sqlCon.Open();
                string strquery = "update SANPHAM set SoLuong = SoLuong + " + dgvChiTietNH.CurrentRow.Cells["SL"].Value.ToString() + " where SPID=N'" + txtMaSP.Text + "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();            
        }

        private void Giam1SL()
        {
            {
                sqlCon.Open();
                string strquery = "update SANPHAM set SoLuong = SoLuong - " + dgvChiTietNH.CurrentRow.Cells["SL"].Value.ToString() + " where SPID=N'" + txtMaSP.Text + "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text == string.Empty || txtMaNV.Text == string.Empty || txtGiaTriDN.Text == string.Empty)
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            else
            {                
                sqlCon.Open();
                string strquery = "set dateformat dmy update HDNH set NGNHAP='" + dateNgayNhap.Text + "',DTID='" + txtMaDT.Text + "',NVID='" + txtMaNV.Text + "',TRIGIA=" + txtGiaTriDN.Text + " where SOHD_NH=" + txtSoHDNH.Text;
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                this.Close();
                trangthai = 0;
            }
        }

        private void Form_NhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (trangthai == -1)
            {
                sqlCon.Open();
                string strquery = "delete from CTHDNH where SOHD_NH ='" + txtSoHDNH.Text + "' delete from HDNH where SOHD_NH ='" + txtSoHDNH.Text + "' ";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                this.Close();
            }
        }

        private void cbbDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDT.Text = LayIDDoiTac();
        }

      
     
    }
}
