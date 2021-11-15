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
    public delegate void SaleSaveEvent(object sender, EventArgs e, Sale_manager A);
    public partial class Sale_manager : Form
    {
        void Sale_items_addWithProducts()
        {
            comboBox_Condition.Items.Clear();
            comboBox_Condition.Items.Add("Laptop - Macbook");
            comboBox_Condition.Items.Add("Chuột - Bàn phím");
            comboBox_Condition.Items.Add("Tai nghe");
            comboBox_Condition.Items.Add("Máy chơi game (console)");
            comboBox_Condition.Items.Add("Card màn hình (vga)");
            comboBox_Condition.Items.Add("Ram");
            comboBox_Condition.Items.Add("Bo mạch chủ");
            comboBox_Condition.Items.Add("Ổ cứng SSD");
            comboBox_Condition.Items.Add("Ổ cứng HDD");
        }
        void Sale_items_addWithProducer()
        {
            comboBox_Condition.Items.Clear();
            comboBox_Condition.Items.Add("Apple");
            comboBox_Condition.Items.Add("Asus");
            comboBox_Condition.Items.Add("Corsair");
            comboBox_Condition.Items.Add("DareU");
            comboBox_Condition.Items.Add("Dell");
            comboBox_Condition.Items.Add("Ram");
            comboBox_Condition.Items.Add("Durgodủ");
            comboBox_Condition.Items.Add("E-DRA");
            comboBox_Condition.Items.Add("GIGABYTE");
            comboBox_Condition.Items.Add("GSKILL");
            comboBox_Condition.Items.Add("Kingston");
            comboBox_Condition.Items.Add("Logitech");
            comboBox_Condition.Items.Add("Microsoft");
            comboBox_Condition.Items.Add("MSI");
            comboBox_Condition.Items.Add("OEM");
            comboBox_Condition.Items.Add("Rapoo");
            comboBox_Condition.Items.Add("Razor");
            comboBox_Condition.Items.Add("SeaGate");
            comboBox_Condition.Items.Add("Sony");
            comboBox_Condition.Items.Add("Western Digital");
            comboBox_Condition.Items.Add("Zidli");
        }
        public Sale_manager()
        {
            InitializeComponent();
        }
        public event SaleSaveEvent sale_Save;

        private void comboBox_saleCondition_TextChanged(object sender, EventArgs e)
        {
            label_Condition.Text = comboBox_saleCondition.Text + " ưu đãi:";
            if (comboBox_saleCondition.Text == "Mặt hàng")
                Sale_items_addWithProducts();
            else
                Sale_items_addWithProducer();
        }

        private void comboBox_saleMethod_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_saleMethod.Text == "Giảm giá")
                groupBox_gift.Enabled = false;
            else
                groupBox_gift.Enabled = true;
            if (comboBox_saleMethod.Text == "Tặng kèm")
                groupBox_sale.Enabled = false;
            else
                groupBox_sale.Enabled = true;
        }

        private void numericUpDown_priceReduced_Click(object sender, EventArgs e)
        {
            numericUpDown_priceReduced.Select(0, Convert.ToString(numericUpDown_priceReduced.Value).Length);
        }

        private void numericUpDown_Condition_price_Click(object sender, EventArgs e)
        {
            numericUpDown_Condition_price.Select(0, Convert.ToString(numericUpDown_priceReduced.Value).Length);
        }

        private void numericUpDown_Condition_Quantity_Click(object sender, EventArgs e)
        {
            numericUpDown_Condition_Quantity.Select(0, Convert.ToString(numericUpDown_priceReduced.Value).Length);
        }

        private void checkBox_priceCondition_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox_priceCondition.CheckState==CheckState.Checked)
            {
                label_Condition_price.Enabled = true;
                label_Condition_quantity.Enabled = true;
                numericUpDown_Condition_price.Enabled = true;
                numericUpDown_Condition_Quantity.Enabled = true;
                label1.Enabled = true;
            }
            else
            {
                label_Condition_price.Enabled = false;
                label_Condition_quantity.Enabled = false;
                numericUpDown_Condition_price.Enabled = false;
                numericUpDown_Condition_Quantity.Enabled = false;
                label1.Enabled = false;
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            sale_Save(this, e, this);
            Close();
        }

        private void comboBox_priceMethod_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_priceMethod.Text)
            {
                case "Giảm theo số":
                    label_priceReduced.Text = "Số lượng giảm (VND):";
                    numericUpDown_priceReduced.Minimum = 1000;
                    numericUpDown_priceReduced.Maximum = 1000000;
                    break;
                case "Giảm theo phần trăm":
                    label_priceReduced.Text = "Phần trăm giảm (%): ";
                    numericUpDown_priceReduced.Maximum = 100;
                    numericUpDown_priceReduced.Minimum = 0;
                    break;
            }
        }

        
    }
}
