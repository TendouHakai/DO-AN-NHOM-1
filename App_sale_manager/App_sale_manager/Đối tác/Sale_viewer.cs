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
    public partial class Sale_viewer : Form
    {
        static List<Sale> forNOR = new List<Sale>();
        static List<Sale> forVIP = new List<Sale>();
        public void Sale_save(object sender, EventArgs e, Sale_manager B)
        {
            bool alreadyHaved = false;
            Sale A = Sale_generate(B);
            if (B.comboBox_saleObj.Text == "Tất cả" || B.comboBox_saleObj.Text == "Khách thường")
            {
                for (int i = 0; i < forNOR.Count; i++)
                    if (forNOR[i].saleName == A.saleName)
                    {
                        forNOR[i] = A;
                        alreadyHaved = true;
                        break;
                    }
                if (alreadyHaved == false)
                    forNOR.Add(A);
            }
            alreadyHaved = false;
            if (B.comboBox_saleObj.Text == "Tất cả" || B.comboBox_saleObj.Text == "Khách vip")
            {
                for (int i = 0; i < forVIP.Count; i++)
                    if (forVIP[i].saleName == A.saleName)
                    {
                        forVIP[i] = A;
                        alreadyHaved = true;
                        break;
                    }
                if (alreadyHaved == false)
                    forVIP.Add(A);
            }
            NOR_DataRefresh();
            VIP_DataRefresh();
        }
        public void Sale_select(object sender, EventArgs e, string deleteObj, string saleState, ComboBox sale)
        {
            sale.Items.Clear();
            switch (deleteObj)
            {
                case "Tất cả":
                    switch (saleState)
                    {
                        case "Tất cả":
                            for (int i = 0; i < forNOR.Count; i++)
                                sale.Items.Add(forNOR[i].saleName);
                            for (int i = 0; i < forVIP.Count; i++)
                                sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Đang áp dụng":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].startDate <= DateTime.Now && forNOR[i].endDate >= DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].startDate <= DateTime.Now && forVIP[i].endDate >= DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Sắp diễn ra":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].startDate > DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].startDate > DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Đã kết thúc":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].endDate < DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].endDate < DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                    }
                    break;
                case "Khách thường":
                    switch (saleState)
                    {
                        case "Tất cả":
                            for (int i = 0; i < forNOR.Count; i++)
                                sale.Items.Add(forNOR[i].saleName);
                            break;
                        case "Đang áp dụng":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].startDate <= DateTime.Now && forNOR[i].endDate >= DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            break;
                        case "Sắp diễn ra":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].startDate > DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            break;
                        case "Đã kết thúc":
                            for (int i = 0; i < forNOR.Count; i++)
                                if (forNOR[i].endDate < DateTime.Now)
                                    sale.Items.Add(forNOR[i].saleName);
                            break;
                    }
                    break;
                case "Khách vip":
                    switch (saleState)
                    {
                        case "Tất cả":
                            for (int i = 0; i < forVIP.Count; i++)
                                sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Đang áp dụng":
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].startDate <= DateTime.Now && forVIP[i].endDate >= DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Sắp diễn ra":
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].startDate > DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                        case "Đã kết thúc":
                            for (int i = 0; i < forVIP.Count; i++)
                                if (forVIP[i].endDate < DateTime.Now)
                                    sale.Items.Add(forVIP[i].saleName);
                            break;
                    }
                    break;
            }
        }
        public void Sale_delete(object sender, EventArgs e, string deleteObj, string deletedSale)
        {
            bool is_all = false;
            switch (deleteObj)
            {
                case "Tất cả":
                    is_all = true;
                    goto case "Khách thường";
                case "Khách thường":
                    for (int i = 0; i < forNOR.Count; i++)
                    {
                        if (forNOR[i].saleName == deletedSale)
                            forNOR.RemoveAt(i);
                        break;
                    }
                    if (is_all)
                        goto case "Khách vip";
                    break;
                case "Khách vip":
                    for (int i = 0; i < forVIP.Count; i++)
                    {
                        if (forVIP[i].saleName == deletedSale)
                            forVIP.RemoveAt(i);
                        break;
                    }
                    break;
                case "- Chưa chọn -":
                    MessageBox.Show("Vui lòng chọn đối tượng cần xóa.");
                    return;
                    break;
            }
            NOR_DataRefresh();
            VIP_DataRefresh();
        }
        public Sale Sale_generate(Sale_manager A)
        {
            Sale B = new Sale();
            B.saleName = A.textBox_saleName.Text;
            B.saleMethod = A.comboBox_saleMethod.Text;
            B.saleCondition = A.comboBox_saleCondition.Text;
            B.condition = A.comboBox_Condition.Text;
            B.startDate = A.dateTimePicker_startDate.Value;
            B.endDate = A.dateTimePicker_endDate.Value;
            B.gift = A.textBox_gift.Text;
            B.gift_note = A.textBox_note.Text;
            B.priceMethod = A.comboBox_priceMethod.Text;
            B.priceReduced = A.numericUpDown_priceReduced.Value;
            B.conditionPrice = A.numericUpDown_Condition_price.Value; ;
            B.conditionQuantity = A.numericUpDown_Condition_Quantity.Value;
            if (A.checkBox_autoDelete.CheckState == CheckState.Checked)
                B.is_autoDelete = true;
            else
                B.is_autoDelete = false;
            if (A.checkBox_priceCondition.CheckState == CheckState.Checked)
                B.is_conditioned = true;
            else
                B.is_conditioned = false;
            return B;
        }
        public Sale_manager Sale_get(Sale A)
        {
            Sale_manager B = new Sale_manager();
            B.textBox_saleName.Text = A.saleName;
            B.comboBox_saleMethod.Text = A.saleMethod;
            B.comboBox_saleCondition.Text = A.saleCondition;
            B.comboBox_Condition.Text = A.condition;
            B.dateTimePicker_startDate.Value = A.startDate;
            B.dateTimePicker_endDate.Value = A.endDate;
            B.textBox_gift.Text = A.gift;
            B.textBox_note.Text = A.gift_note;
            B.comboBox_priceMethod.Text = A.priceMethod;
            B.numericUpDown_priceReduced.Value = A.priceReduced;
            B.numericUpDown_Condition_price.Value = A.conditionPrice;
            B.numericUpDown_Condition_Quantity.Value = A.conditionQuantity;
            if (A.is_autoDelete)
                B.checkBox_autoDelete.CheckState = CheckState.Checked;
            if (A.is_conditioned)
                B.checkBox_priceCondition.CheckState = CheckState.Checked;
            return B;
        }
        public void NOR_DataRefresh()
        {
            listBox_NOR_ongoing.Items.Clear();
            listBox_NOR_waiting.Items.Clear();
            listBox_NOR_ended.Items.Clear();
            for (int i = 0; i < forNOR.Count; i++)
            {
                if (forNOR[i].startDate <= DateTime.Now && forNOR[i].endDate >= DateTime.Now)
                    listBox_NOR_ongoing.Items.Add(forNOR[i].saleName);
                if (forNOR[i].endDate < DateTime.Now)
                {
                    if (forNOR[i].is_autoDelete)
                        continue;
                    else
                        listBox_NOR_ended.Items.Add(forNOR[i].saleName);
                }
                if (forNOR[i].startDate > DateTime.Now)
                    listBox_NOR_waiting.Items.Add(forNOR[i].saleName);

            }
        }
        public void VIP_DataRefresh()
        {
            listBox_VIP_ongoing.Items.Clear();
            listBox_VIP_ended.Items.Clear();
            listBox_VIP_waiting.Items.Clear();
            for (int i = 0; i < forVIP.Count; i++)
            {
                if (forVIP[i].startDate <= DateTime.Now && forVIP[i].endDate >= DateTime.Now)
                    listBox_VIP_ongoing.Items.Add(forVIP[i].saleName);
                if (forVIP[i].endDate < DateTime.Now)
                {
                    if (forVIP[i].is_autoDelete)
                        continue;
                    else
                        listBox_VIP_ended.Items.Add(forVIP[i].saleName);
                }
                if (forVIP[i].startDate > DateTime.Now)
                    listBox_VIP_waiting.Items.Add(forVIP[i].saleName);

            }
        }
        public Sale_viewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale_manager A = new Sale_manager();
            A.sale_Save += Sale_save;
            A.Show();
        }

        private void Sale_viewer_Load(object sender, EventArgs e)
        {

        }

        private void button_quit_Click(object sender, EventArgs e)
        {

        }

        private void listBox_NOR_ongoing_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox_NOR_ongoing_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forNOR.Count; i++)
            {
                if (forNOR[i].saleName == listBox_NOR_ongoing.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forNOR[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void listBox_NOR_waiting_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forNOR.Count; i++)
            {
                if (forNOR[i].saleName == listBox_NOR_waiting.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forNOR[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void listBox_NOR_ended_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forNOR.Count; i++)
            {
                if (forNOR[i].saleName == listBox_NOR_ended.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forNOR[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void listBox_VIP_ongoing_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forVIP.Count; i++)
            {
                if (forVIP[i].saleName == listBox_VIP_ongoing.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forVIP[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void listBox_VIP_waiting_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forVIP.Count; i++)
            {
                if (forVIP[i].saleName == listBox_VIP_waiting.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forVIP[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void listBox_VIP_ended_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < forVIP.Count; i++)
            {
                if (forVIP[i].saleName == listBox_VIP_ended.SelectedItem.ToString())
                {
                    Sale_manager A = Sale_get(forVIP[i]);
                    A.textBox_saleName.ReadOnly = true;
                    A.textBox_saleName.Cursor = Cursors.No;
                    A.sale_Save += Sale_save;
                    A.Show();
                }
            }
        }

        private void button_saleDelete_Click(object sender, EventArgs e)
        {
            SaleDeleter A = new SaleDeleter();
            A.Get_sale_list += Sale_select;
            A.Delete_sale += Sale_delete;
            A.Show();
        }

        private void listBox_NOR_ongoing_Layout(object sender, LayoutEventArgs e)
        {

        }
        private void listBox_NOR_ongoing_Leave(object sender, EventArgs e)
        {
            {
                listBox_NOR_ongoing.ClearSelected();
            }
        }

        private void listBox_NOR_waiting_Leave(object sender, EventArgs e)
        {
            listBox_NOR_waiting.ClearSelected();
        }

        private void listBox_NOR_ended_Leave(object sender, EventArgs e)
        {
            listBox_NOR_ended.ClearSelected();
        }

        private void listBox_VIP_ongoing_Leave(object sender, EventArgs e)
        {
            listBox_VIP_ongoing.ClearSelected();
        }

        private void listBox_VIP_waiting_Leave(object sender, EventArgs e)
        {
            listBox_VIP_waiting.ClearSelected();
        }

        private void listBox_VIP_ended_Leave(object sender, EventArgs e)
        {
            listBox_VIP_ended.ClearSelected();
        }
    }
}
