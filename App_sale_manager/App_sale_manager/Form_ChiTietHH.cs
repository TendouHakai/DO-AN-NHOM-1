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
        public Form_ChiTietHH( string SPID, string TenSP, string SL, string NuocSX, string GiaBan, string GiaNhap, string DVT, string SLTT, string LoaiSP, string MoTa)
        {
            InitializeComponent();
            
            lblNDMaSP.Text = SPID;
            lblNDTenSP.Text = TenSP;
            lblNDSoLuong.Text = SL;
            lblNDNuocSX.Text = NuocSX;
            lblNDGiaBan.Text = GiaNhap;
            lblNDGiaNhap.Text = GiaBan;
            lblNDDVT.Text = DVT;
            lblNDSLToiThieu.Text = SLTT;
            lblNDLoaiID.Text = LoaiSP;
            lblNDMoTa.Text = MoTa;
           
        }

        private void Form_ChiTietHH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_main_admin frm = new Form_main_admin();

            frm.Show();
        }
    }
}
