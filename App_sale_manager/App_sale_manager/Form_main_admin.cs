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
    public partial class Form_main_admin : Form
    {
        public Form_main_admin()
        {
            InitializeComponent();
        }
        public event EventHandler Thoat;

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }

        private void Form_main_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYBANHANG_LTTQDataSet.DTCC' table. You can move, or remove it, as needed.
            this.dTCCTableAdapter.Fill(this.qUANLYBANHANG_LTTQDataSet.DTCC);

        }
    }
}
