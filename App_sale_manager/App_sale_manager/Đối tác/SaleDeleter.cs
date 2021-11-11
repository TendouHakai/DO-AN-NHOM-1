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
    public delegate void Sale_delete_EventHandler(object sender, EventArgs e, string deleteObj, string saleState, ComboBox get);
    public delegate void Sale_deleted_EventHandler(object sender, EventArgs e, string deleteObj, string deletedSale);
    public partial class SaleDeleter : Form
    {
        public SaleDeleter()
        {
            InitializeComponent();        
        }
        public event Sale_delete_EventHandler Get_sale_list;
        public event Sale_deleted_EventHandler Delete_sale;
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaleDeleter_Load(object sender, EventArgs e)
        {
            Get_sale_list(this, e, comboBox_deleteObj.Text, comboBox_saleState.Text, comboBox_sale);
        }

        private void comboBox_deleteObj_TextChanged(object sender, EventArgs e)
        {
            Get_sale_list(this, e, comboBox_deleteObj.Text, comboBox_saleState.Text, comboBox_sale);
        }

        private void comboBox_saleState_TextChanged(object sender, EventArgs e)
        {
            Get_sale_list(this, e, comboBox_deleteObj.Text, comboBox_saleState.Text, comboBox_sale);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Chú ý", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Delete_sale(this, e, comboBox_deleteObj.Text, comboBox_sale.Text);
                Close();
            }
        }
    }
}
