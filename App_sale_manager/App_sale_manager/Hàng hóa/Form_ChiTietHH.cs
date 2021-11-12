using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_sale_manager
{
    public partial class Form_ChiTietHH : Form
    {
        public Form_ChiTietHH()
        {
            InitializeComponent();
        }
        public Form_ChiTietHH(string SPID, string TenSP, string SL, string NuocSX,string Hang, string GiaBan, string GiaNhap, string DVT, string SLTT, string LoaiSP, string MoTa)
        {
            
            InitializeComponent();
            txtNDMaSP.Text = SPID;
            txtNDTenSP.Text = TenSP;
            txtNDSoLuong.Text = SL;
            txtNDNuocSX.Text = NuocSX;
            txtNDHang.Text = Hang;
            txtNDGiaBan.Text = GiaNhap;
            txtNDGiaNhap.Text = GiaBan;
            txtNDDVT.Text = DVT;
            txtNDSLToiThieu.Text = SLTT;
            txtNDLoaiID.Text = LoaiSP;
            txtNDMoTa.Text = MoTa;
            Image img = GetCopyImage(@"..\..\HangHoa\" + txtNDMaSP.Text + ".jpg");
            ptrbHinhAnh.Image = img;
            System.IO.File.Delete(@"..\..\HangHoa\" + txtNDMaSP.Text + ".jpg");
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Form_ChiTietHH(string SPID, string TenSP, string NuocSX, string Hang, string GiaBan, string GiaNhap, string DVT, string LoaiSP, string MoTa)
        {

            InitializeComponent();
            txtNDMaSP.Text = SPID;
            txtNDTenSP.Text = TenSP;
            lblSoLuong.Visible = false;
            txtNDSoLuong.Visible=false;
            txtNDNuocSX.Text = NuocSX;
            txtNDHang.Text = Hang;
            txtNDGiaBan.Text = GiaNhap;
            txtNDGiaNhap.Text = GiaBan;
            txtNDDVT.Text = DVT;
            lblSLToiThieu.Visible = false;
            txtNDSLToiThieu.Visible = false ;
            txtNDLoaiID.Text = LoaiSP;
            txtNDMoTa.Text = MoTa;
            Image img = GetCopyImage(@"..\..\HangHoa\" + txtNDMaSP.Text + ".jpg");           
            ptrbHinhAnh.Image = img;
            System.IO.File.Delete(@"..\..\HangHoa\" + txtNDMaSP.Text + ".jpg");
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
        private void Form_ChiTietHH_FormClosed(object sender, FormClosedEventArgs e)
        {
            ptrbHinhAnh.Image.Save(@"..\..\HangHoa\" + txtNDMaSP.Text + ".jpg");
            this.Close();
        }
    }
}
