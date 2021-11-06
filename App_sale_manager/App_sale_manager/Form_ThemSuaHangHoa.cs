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
        public string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter adapter = null;
        static int ModeHH = 0;
        static int trangthai = 0;
        string linksave;
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
            sqlCon.Close();
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public Form_ThemSuaHangHoa(int n, string SPID, string TenSP, string SL, string NuocSX, string GiaBan, string GiaNhap, string DVT, string SLTT, string LoaiSP, string MoTa)
        {
            InitializeComponent();
            ModeHH = n;
            txtSPID.Text = SPID;
            txtTenSP.Text = TenSP;
            txtSL.Text = SL;
            txtNuocSX.Text = NuocSX;
            txtGiaBan.Text = GiaNhap;
            txtGiaNhap.Text = GiaBan;
            txtDVT.Text = DVT;
            txtSLTT.Text = SLTT;
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
            SqlDataAdapter adapter2 = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
            DataTable tbHH = new DataTable();
            tbHH.Clear();
            adapter2.Fill(tbHH);
            LoaiID = tbHH.Rows[0]["LOAIID"].ToString();
            sqlCon = new SqlConnection(strCon);
            if (ModeHH == 1 && trangthai==1)
            {
                if (txtSPID.Text != string.Empty)
                {
                   
                        sqlCon.Open();
                        string strquery = "insert into SANPHAM values('" + LoaiID + txtSPID.Text + "',N'" + txtTenSP.Text + "',N'" + LoaiID + "',N'" + txtNuocSX.Text + "'," + txtGiaNhap.Text + "," + txtGiaBan.Text
                            + ",N'" + txtDVT.Text + "'," + txtSL.Text + "," + txtSLTT.Text + ",N'" + txtMoTa.Text + "')";
                        sqlCmd = new SqlCommand(strquery, sqlCon);
                        sqlCmd.ExecuteNonQuery();
                        sqlCon.Close();                        
                        ptrbHinhAnh.Image.Save(linksave);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                
            }
            else if (ModeHH == 2)
            {
                sqlCon.Open();
                string strquery = "update SANPHAM set TENSP=N'" + txtTenSP.Text + "',LOAIID='" + LoaiID + "',NUOCSX=N'" + txtNuocSX.Text + "',GIANHAP=" + txtGiaNhap.Text + ",GIABAN=" + txtGiaBan.Text
                    + ",DVT=N'" + txtDVT.Text + "',SOLUONG=" + txtSL.Text + ",SLTT=" + txtSLTT.Text + ",MOTA=N'" + txtMoTa.Text + "'WHERE SPID='" + txtSPID.Text + "'";
                sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Sửa thành công");
                this.Close();
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
            linksave = @"..\..\HangHoa\"+LoaiID+txtSPID.Text+".jpg";
            if (result == DialogResult.OK)
            {
                ptrbHinhAnh.Image = Image.FromFile(open.FileName);
                trangthai = 1;
            }
            else MessageBox.Show("Chưa chọn hình");
           
        }
    }
}