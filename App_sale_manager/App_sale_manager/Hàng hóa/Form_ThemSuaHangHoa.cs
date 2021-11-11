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
    public partial class Form_ThemSuaHangHoa : Form
    {
        public string LoaiID;
        public string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null;
        static int ModeHH = 0;
        string linksave=string.Empty;
        public Form_ThemSuaHangHoa(int n)
        {

            InitializeComponent();
            ModeHH = n;
            this.Text = "Thêm hàng hoá";
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            adapter = new SqlDataAdapter("select TENLOAI from [LOAISP] group by TENLOAI", sqlCon);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbLoaiSP.DataSource = table;
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "TenLoai";
            txtSPID.Text = "MBA"; 
            sqlCon.Close();
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public Form_ThemSuaHangHoa(int n, string SPID, string TenSP, string NuocSX, string GiaBan, string GiaNhap, string DVT, string LoaiSP, string MoTa)
        {
            InitializeComponent();
            ModeHH = n;
            txtSPID.Text = SPID;
            txtTenSP.Text = TenSP;
            txtNuocSX.Text = NuocSX;
            txtGiaBan.Text = GiaNhap;
            txtGiaNhap.Text = GiaBan;
            txtDVT.Text = DVT;
            cbLoaiSP.Text = LoaiSP;
            txtMoTa.Text = MoTa;
            if (ModeHH == 2)
                txtSPID.ReadOnly = true;
            this.Text = "Sửa hàng hoá";
            ptrbHinhAnh.Image = Image.FromFile(@"..\..\HangHoa\" + txtSPID.Text + ".jpg");
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "select LOAIID from LOAISP where TENLOAI = N'" + cbLoaiSP.Text + "'";
            sqlCon = new SqlConnection(strCon);
            sqlCmd.Connection = sqlCon;
            sqlCon = new SqlConnection(strCon);
            if (ModeHH == 1)
            {
                if (txtSPID.Text == string.Empty || txtTenSP.Text == string.Empty || txtNuocSX.Text == string.Empty || txtHang.Text == string.Empty || txtGiaNhap.Text == string.Empty || txtGiaBan.Text == string.Empty || txtDVT.Text == string.Empty)
                {
                    MessageBox.Show("Cần nhập đầy đủ thông tin");
                    return;

                }
                else if (linksave != string.Empty)
                {
                    sqlCon.Open();
                    string strquery = "insert into SANPHAM values('" + txtSPID.Text + "',N'" + txtTenSP.Text + "',N'" + LoaiID + "',N'" + txtHang.Text + "',N'" + txtNuocSX.Text + "'," + txtGiaBan.Text + "," + txtGiaNhap.Text
                        + ",N'" + txtDVT.Text + "'," + 0 + "," + 0 + ",N'" + txtMoTa.Text + "')";
                    sqlCmd = new SqlCommand(strquery, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    ptrbHinhAnh.Image.Save(linksave);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else MessageBox.Show("Chưa chọn hình");
            }
            else if (ModeHH == 2)
            {
                if (txtSPID.Text == string.Empty || txtTenSP.Text == string.Empty || txtNuocSX.Text == string.Empty || txtHang.Text == string.Empty || txtGiaNhap.Text == string.Empty || txtGiaBan.Text == string.Empty || txtDVT.Text == string.Empty)
                {
                    MessageBox.Show("Cần nhập đầy đủ thông tin");
                    return;

                }
                else
                {
                    sqlCon.Open();
                    string strquery = "update SANPHAM set TENSP=N'" + txtTenSP.Text + "',LOAIID='" + LoaiID + "',HANGSX='" + txtHang.Text + "',NUOCSX=N'" + txtNuocSX.Text + "',GIANHAP=" + txtGiaNhap.Text + ",GIABAN=" + txtGiaBan.Text
                        + ",DVT=N'" + txtDVT.Text + "',SOLUONG=" + 0 + ",SLTT=" + 0 + ",MOTA=N'" + txtMoTa.Text + "'WHERE SPID='" + txtSPID.Text + "'";
                    sqlCmd = new SqlCommand(strquery, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "select LOAIID from LOAISP where TENLOAI = N'" + cbLoaiSP.Text + "'";
            sqlCon = new SqlConnection(strCon);
            sqlCmd.Connection = sqlCon;
            SqlDataAdapter adapter2 = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
            DataTable tbHH = new DataTable();
            tbHH.Clear();
            adapter2.Fill(tbHH);
            LoaiID = tbHH.Rows[0]["LOAIID"].ToString();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File .jpg (*.jpg)|*.jpg";
            DialogResult result = open.ShowDialog();
            linksave = @"..\..\HangHoa\" + txtSPID.Text + ".jpg";
            if (result == DialogResult.OK)
            {
                ptrbHinhAnh.Image = Image.FromFile(open.FileName);
            }
            else MessageBox.Show("Chưa chọn hình");

        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSP.Text != "Chọn Loại" && cbLoaiSP.Text != "System.Data.DataRowView")
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "select LOAIID from LOAISP where TENLOAI = N'" + cbLoaiSP.Text + "'";
                sqlCon = new SqlConnection(strCon);
                sqlCmd.Connection = sqlCon;
                SqlDataAdapter adapter2 = new SqlDataAdapter(sqlCmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
                DataTable tbHH = new DataTable();
                tbHH.Clear();
                adapter2.Fill(tbHH);
                LoaiID = tbHH.Rows[0]["LOAIID"].ToString();
                txtSPID.Text = LoaiID;
            }
        }
    }
}
