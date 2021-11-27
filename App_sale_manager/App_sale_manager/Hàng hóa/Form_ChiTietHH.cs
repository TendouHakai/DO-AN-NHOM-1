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
        public Form_ChiTietHH(string SPID, string TenSP, string SL, string NuocSX, string Hang, string GiaBan, string GiaNhap, string DVT, string SLTT, string LoaiSP, string MoTa)
        {

            InitializeComponent();
            txtMaSP.Text = SPID;
            txtTenSP.Text = TenSP;
            txtSoLuong.Text = SL;
            txtNuocSX.Text = NuocSX;
            txtHang.Text = Hang;
            txtGiaBan.Text = GiaNhap;
            txtGiaBan.Text = string.Format("{0:0,0}", float.Parse(txtGiaBan.Text));
            txtGiaNhap.Text = GiaBan;
            txtGiaNhap.Text = string.Format("{0:0,0}", float.Parse(txtGiaNhap.Text));
            txtDVT.Text = DVT;
            txtSLToiThieu.Text = SLTT;
            txtLoaiID.Text = LoaiSP;
            txtMoTa.Text = MoTa;
            Image img = GetCopyImage(@"..\..\HangHoa\" + txtMaSP.Text + ".jpg");
            ptrbHinhAnh.Image = img;
            System.IO.File.Delete(@"..\..\HangHoa\" + txtMaSP.Text + ".jpg");
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
      
        private Image GetCopyImage(string path)
        {
            try
            {
                using (Image image = Image.FromFile(path))
                {
                    Bitmap bitmap = new Bitmap(image);
                    return bitmap;
                }
            }
            catch
            {
                using (Image image = Image.FromFile(@"..\..\HangHoa\No image.jpg"))
                {
                    Bitmap bitmap = new Bitmap(image);
                    return bitmap;
                }
            }
        }
        private void Form_ChiTietHH_FormClosed(object sender, FormClosedEventArgs e)
        {
            ptrbHinhAnh.Image.Save(@"..\..\HangHoa\" + txtMaSP.Text + ".jpg");
            this.Close();
        }
    }
}
