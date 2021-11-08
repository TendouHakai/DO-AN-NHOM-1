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
        int MaDonNhap;
        string IDNV=" ";
        string IDDoiTac;
        public string MaSp;
        int TongGia;
        public Form_NhapHang()
        {
            InitializeComponent();
            LoadCBB();
            MaDonNhap = LoadMaDN();
            LoadDonNhap();
        }
        private int LoadMaDN()
        {
            int max;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("select max(SOHD_NH) from HDNH", sqlCon);
            var reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            { max = Convert.ToInt32(reader.GetString(0)); }
            else max = 0;
            sqlCon.Close();
            return max + 1;
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
            adapter = new SqlDataAdapter("select SoLuong,SLTT,SPID from SANPHAM Where TENSP = N'"+cbbTenSP.Text+"'", sqlCon);
            DataTable tableSoLuong = new DataTable();
            adapter.Fill(tableSoLuong);
            txtSoLuong.Text = tableSoLuong.Rows[0][0].ToString();
            txtSLTT.Text = tableSoLuong.Rows[0][1].ToString();
            MaSp = tableSoLuong.Rows[0][2].ToString();
            sqlCon.Close();
        }

        private void cbbDoiTac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar =(char)Keys.None;
            return;
        }

        private void cbbLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
            return;
        }

        private void LoadDonNhap()
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select SPID,SL from CTHDNH where SOHD_NH=" + MaDonNhap, sqlCon);
            DataTable tableNH = new DataTable();
            adapter.Fill(tableNH);
            dgvChiTietNH.DataSource = tableNH;     
            sqlCon.Close();
        }
        private void cbbTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();           
            string strquery ="insert into CTHDNH values('"+MaDonNhap+"','"+MaSp+"',"+txtSLNhap.Text+")";
            SqlCommand sqlCmd;
            sqlCmd = new SqlCommand(strquery, sqlCon);
            try
            { sqlCmd.ExecuteNonQuery(); }
            catch
            {
                MessageBox.Show("Có lỗi sảy ra");
            }
            
            sqlCon.Close();
            
            LoadDonNhap();
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
            LoadDonNhap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
       
                string strquery = "delete from CTHDNH where SOHD_NH ='" + MaDonNhap+ "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            this.Close();
        }
        private string LayIDDoiTac()
        {
            string id = string.Empty;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("select DTID from DTCC where TENDT=N'"+cbbDoiTac.Text+"'", sqlCon);
            var reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            { id = reader.GetString(0); }
            sqlCon.Close();
            return id;
        }
        private int LayGia()
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            int Gia = 0;
            for(int i=0;i<dgvChiTietNH.Rows.Count-1;i++)
            {
                SqlCommand sqlCmd = new SqlCommand("select * from SANPHAM where SPID=N'" +dgvChiTietNH.Rows[i].Cells["SPID"].Value.ToString()+ "'", sqlCon);
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
            return Gia;
        }
        private void ThemSL()
        {
            for (int i = 0; i < dgvChiTietNH.Rows.Count - 1; i++)
            {
                sqlCon.Open();
                string strquery = "update SANPHAM set SoLuong = SoLuong + "+ dgvChiTietNH.Rows[i].Cells["SL"].Value.ToString() + " where SPID=N'" + dgvChiTietNH.Rows[i].Cells["SPID"].Value.ToString() + "'";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            IDDoiTac = LayIDDoiTac();
            TongGia = LayGia();
            ThemSL();
            sqlCon.Open();
                string strquery = "set dateformat dmy insert into HDNH values('" + MaDonNhap + "','"+dateNgayNhap.Text+"','"+IDDoiTac+"','"+IDNV+"',"+TongGia+")";
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                
            sqlCon.Close();
            this.Close();
        }
    }
}
