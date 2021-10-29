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
        public string strCon = @"Data Source=LAPTOP-4KM350G8;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        public SqlConnection sqlCon = null;
        static public SqlDataAdapter ADT = null;
        static int ModeHH = 0;
        private void ClearAll()
        {
            txtSPID.Text = String.Empty;
            txtTenSP.Text = String.Empty;
            txtLoaiSP.Text = String.Empty;
            txtDVT.Text = String.Empty;
            txtNuocSX.Text = String.Empty;
            txtGiaNhap.Text = String.Empty;
            txtGiaBan.Text = String.Empty;
            txtSL.Text = String.Empty;
            txtSLTT.Text = String.Empty;
            txtMoTa.Text = String.Empty;
        }
        public Form_ThemSuaHangHoa(int n)
        {

            InitializeComponent();
            ModeHH = n;
            this.Text = "Thêm hàng hoá";
        }
        public Form_ThemSuaHangHoa(int n,string SPID,string TenSP,string SL,string NuocSX,string GiaBan,string GiaNhap,string DVT,string SLTT,string LoaiSP,string MoTa)
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
            txtLoaiSP.Text = LoaiSP;
            txtMoTa.Text = MoTa;            
            if (ModeHH == 2)
                txtSPID.ReadOnly = true;
            this.Text = "Sửa hàng hoá";
        }        

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            if (ModeHH == 1)
            {

                if (txtSPID.Text != string.Empty)
                {
                    sqlCon.Open();
                    string strquery = "insert into SANPHAM values('" + txtSPID.Text + "','" + txtTenSP.Text + "','" + txtLoaiSP.Text + "','" + txtNuocSX.Text + "'," + txtGiaNhap.Text + "," + txtGiaBan.Text
                        + ",'" + txtDVT.Text + "'," + txtSL.Text + "," + txtSLTT.Text + ",'" + txtMoTa.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(strquery, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Thêm thành công");
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Phai co ID san pham");
                    this.Close(); }
            }
            else if (ModeHH == 2)
            {
                sqlCon.Open();
                string strquery = "update SANPHAM set TENSP='" + txtTenSP.Text + "',LOAIID='" + txtLoaiSP.Text + "',NUOCSX='" + txtNuocSX.Text + "',GIANHAP=" + txtGiaNhap.Text + ",GIABAN=" + txtGiaBan.Text
                    + ",DVT='" + txtDVT.Text + "',SOLUONG=" + txtSL.Text + ",SLTT=" + txtSLTT.Text + ",MOTA='" + txtMoTa.Text + "'WHERE SPID='"+ txtSPID.Text+"'";
                SqlCommand sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
           
            
        }

        private void Form_ThemSuaHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_main_admin frm = new Form_main_admin();
            
            frm.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
