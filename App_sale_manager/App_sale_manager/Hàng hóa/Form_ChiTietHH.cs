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
        public Form_ChiTietHH(string SPID, string TenSP, string SL, string NuocSX, string GiaBan, string GiaNhap, string DVT, string SLTT, string LoaiSP, string MoTa)
        {
            InitializeComponent();
            txtNDMaSP.Text = SPID;
            txtNDTenSP.Text = TenSP;
            txtNDSoLuong.Text = SL;
            txtNDNuocSX.Text = NuocSX;
            txtNDGiaBan.Text = GiaNhap;
            txtNDGiaNhap.Text = GiaBan;
            txtNDDVT.Text = DVT;
            txtNDSLToiThieu.Text = SLTT;
            txtNDLoaiID.Text = LoaiSP;
            txtNDMoTa.Text = MoTa;
            ptrbHinhAnh.Image = Image.FromFile(@"..\..\HangHoa\"+txtNDMaSP.Text + ".jpg");
            ptrbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
    }
}
