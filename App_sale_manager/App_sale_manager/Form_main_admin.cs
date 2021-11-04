using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace App_sale_manager
{
    public partial class Form_main_admin : Form
    {
        Sale_viewer A = new Sale_viewer();
        public static string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection con = new SqlConnection(strCon);
        public Form_main_admin()
        {
            InitializeComponent();
            DTCC_dtgd_dataInitialize();
            DTCC_guest_dataInitialize();
            pictureBox_Logo.Image = Image.FromFile(@"Image samples for testing\Đối tác giao dịch\No Image.jpg");
            pictureBox_dtcc_guestFace.Image = Image.FromFile(@"Image samples for testing\\Khách hàng đăng kí\No Image.jpg");
        }
        public event EventHandler Thoat;

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }

        private void Form_main_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYBANHANG_LTTQDataSet.DTCC' table. You can move, or remove it, as needed.
            //this.dTCCTableAdapter.Fill(this.qUANLYBANHANG_LTTQDataSet.DTCC);

        }
        public void DTCC_dtgd_dataInitialize()
        {
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DTCC";
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_DTCC.DataSource = Table;
            button_modDTCC.Enabled = false;
            button_deleteDTCC.Enabled = false;
            con.Close();
        }
        public void DTCC_guest_dataInitialize()
        {
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from KHACHHANG";
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_dtcc_guest.DataSource = Table;
            button_guest_mod.Enabled = false;
            button_guest_delete.Enabled = false;
            con.Close();
        }
        public void DTCC_DataRefresh(object sender, EventArgs e)
        {
            DTCC_dtgd_dataInitialize();
        }
        public void Guest_DataRefresh(object sender, EventArgs e)
        {
            DTCC_guest_dataInitialize();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_SDT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage_DoiTac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTCC_modifier A = new DTCC_modifier();
            A.textBox_ID_z.Text = label_IDtext.Text;
            A.dateTimePicker_NGDT_z.Text = label_NGDTtext.Text;
            A.textBox_DIACHI_z.Text = label_DIACHItext.Text;
            A.textBox_SDT_z.Text = label_SDTtext.Text;
            A.textBox_TENDT_z.Text = label_TENDTtext.Text;
            A.pictureBox_image_import.Image = pictureBox_Logo.Image;
            A.RefreshData += DTCC_DataRefresh;
            A.Show();
        }

        private void dataGridView_DTCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_DTCC.Rows[e.RowIndex];
                label_IDtext.Text = row.Cells[0].Value.ToString();
                label_TENDTtext.Text = row.Cells[1].Value.ToString();
                label_SDTtext.Text = row.Cells[2].Value.ToString();
                label_NGDTtext.Text = row.Cells[3].Value.ToString();
                label_DIACHItext.Text = row.Cells[4].Value.ToString();
                string filepath = @"Image samples for testing\Đối tác giao dịch\" + label_TENDTtext.Text + ".jpg";
                if (File.Exists(filepath))
                    pictureBox_Logo.Image = Image.FromFile(filepath);
                else
                    pictureBox_Logo.Image = Image.FromFile(@"Image samples for testing\Đối tác giao dịch\No Image.jpg");
                button_modDTCC.Enabled = true;
                button_deleteDTCC.Enabled = true;
            }
        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {

        }

        private void button_addDTCC_Click(object sender, EventArgs e)
        {
            DTCC_form A = new DTCC_form();
            A.RefreshData += DTCC_DataRefresh;
            A.Show();            
        }

        private void dataGridView_DTCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteDTCC_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.YesNo);
            if(Result==DialogResult.Yes)
            {
                string str;
                str = "delete from DTCC where DTID = '"+ label_IDtext.Text+"'";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand newcmd = new SqlCommand(str, con);
                newcmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo");
                /*if(File.Exists(@"\Image samples for testing\Đối tác giao dịch\"+label_TENDTtext.Text+".jpg"))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(@"\Image samples for testing\Đối tác giao dịch\" + label_TENDTtext.Text + ".jpg");
                }    
                */
                DTCC_dtgd_dataInitialize();
            }
        }

        private void button_searchDTCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_search.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm.");
                textBox_search.Focus();
                return;
            }
            if(comboBox_searchOption.Text=="Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn trường cần tìm");
                comboBox_searchOption.Focus();
                return;
            }
            switch (comboBox_searchOption.Text)
            {
                case "Mã đối tác":
                    Search("DTID");
                    break;
                case "Tên đối tác":
                    Search("TENDT");
                    break;
                case "Số điện thoại":
                    Search("SDT");
                    break;
                case "Địa chỉ":
                    Search("DIACHI");
                    break;
                case "Ngày trở thành đối tác":
                    Search("NGDT");
                    break;
            }
        }

        public void Search(string SearchOption)
        {
            string str;
            str = "select * from DTCC where " + SearchOption + " like '%" + textBox_search.Text + "%'";
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = str;
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_DTCC.DataSource = Table;
            button_modDTCC.Enabled = false;
            button_deleteDTCC.Enabled = false;
            con.Close();
        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DTCC_dtgd_dataInitialize();
        }

        private void tabPage_DTCC_Guest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_dtcc_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                
                DataGridViewRow row = this.dataGridView_dtcc_guest.Rows[e.RowIndex];
                string loaiKH = row.Cells[6].Value.ToString();
                if (string.IsNullOrEmpty(loaiKH)!=true)
                    if (loaiKH == "NOR")
                        label_guestSpec_Text.Text = "Khách thường";
                    else
                        label_guestSpec_Text.Text = "Khách vip";
                label_guestID_Text.Text = row.Cells[0].Value.ToString();
                label_guestName_Text.Text = row.Cells[1].Value.ToString();
                label_guestSDT_Text.Text = row.Cells[3].Value.ToString();
                label_guestReg_Text.Text = row.Cells[4].Value.ToString();
                label_guestAddress_Text.Text = row.Cells[2].Value.ToString();
                label_guestMoney_Text.Text = row.Cells[5].Value.ToString();
                string filepath = @"Image samples for testing\Khách hàng đăng kí\" + label_guestName_Text.Text + ".jpg";
                if (File.Exists(filepath))
                    pictureBox_dtcc_guestFace.Image = Image.FromFile(filepath);
                else
                    pictureBox_dtcc_guestFace.Image = Image.FromFile(@"Image samples for testing\Khách hàng đăng kí\No Image.jpg");
                button_guest_mod.Enabled = true;
                button_guest_delete.Enabled = true;
            }
        }

        private void button_guest_refresh_Click(object sender, EventArgs e)
        {
            DTCC_guest_dataInitialize();
        }

        private void button_guest_add_Click(object sender, EventArgs e)
        {
            DTCC_guest_form A = new DTCC_guest_form();
            A.RefreshData += Guest_DataRefresh;
            A.Show();
        }

        private void button_guest_mod_Click(object sender, EventArgs e)
        {
            DTCC_guest_modifier A = new DTCC_guest_modifier();
            A.textBox_ID_z.Text = label_guestID_Text.Text;
            A.dateTimePicker_NGDT_z.Text = label_guestReg_Text.Text;
            A.textBox_DIACHI_z.Text = label_guestAddress_Text.Text;
            A.textBox_SDT_z.Text = label_guestSDT_Text.Text;
            A.textBox_TENDT_z.Text = label_guestName_Text.Text;
            A.textBox_budget_z.Text = label_guestMoney_Text.Text;
            A.comboBox_loaiKH.Text = label_guestSpec_Text.Text;
            A.pictureBox_image_import.Image = pictureBox_dtcc_guestFace.Image;
            A.RefreshData += Guest_DataRefresh;
            A.Show();
        }

        private void button_guest_delete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                string str;
                str = "delete from KHACHHANG where KHID = '" + label_guestID_Text.Text + "'";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand newcmd = new SqlCommand(str, con);
                newcmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo");
                /*if(File.Exists(@"\Image samples for testing\Đối tác giao dịch\"+label_TENDTtext.Text+".jpg"))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(@"\Image samples for testing\Đối tác giao dịch\" + label_TENDTtext.Text + ".jpg");
                }    
                */
                DTCC_guest_dataInitialize();
            }
        }

        private void button_guest_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_guest_search.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm.");
                textBox_search.Focus();
                return;
            }
            if (comboBox_guest_filter.Text == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn trường cần tìm.");
                comboBox_searchOption.Focus();
                return;
            }
            switch (comboBox_guest_filter.Text)
            {
                case "Mã khách hàng":
                    Search_guest("KHID");
                    break;
                case "Tên khách hàng":
                    Search_guest("HOTEN");
                    break;
                case "Số điện thoại":
                    Search_guest("SDT");
                    break;
                case "Địa chỉ":
                    Search_guest("DIACHI");
                    break;
                case "Ngày đăng kí":
                    Search_guest("NGDK");
                    break;
                case "Loại khách hàng":
                    Search_guest("LOAIKH");
                    break;                
            }
        }
        public void Search_guest(string SearchOption)
        {
            string str;
            str = "select * from KHACHHANG where " + SearchOption + " like '%" + textBox_guest_search.Text + "%'";
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = str;
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_dtcc_guest.DataSource = Table;
            button_guest_mod.Enabled = false;
            button_guest_delete.Enabled = false;
            con.Close();
        }

        private void textBox_search_Click(object sender, EventArgs e)
        {
            textBox_guest_search.SelectAll();
        }

        private void textBox_guest_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_guest_search_Click(object sender, EventArgs e)
        {
            textBox_guest_search.SelectAll();
        }

        private void button_sale_Click(object sender, EventArgs e)
        {           
            A.Show();
        }
    }
}
