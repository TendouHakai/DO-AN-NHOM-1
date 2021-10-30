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
        public static string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection con = new SqlConnection(strCon);
        public Form_main_admin()
        {
            InitializeComponent();
            DTCC_dataInitialize();
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
        public void DTCC_dataInitialize()
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
        public void DTCC_DataRefresh(object sender, EventArgs e)
        {
            DTCC_dataInitialize();
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
                string filepath = @"Image samples for testing\" + label_TENDTtext.Text + ".jpg";
                if (File.Exists(filepath))
                    pictureBox_Logo.Image = Image.FromFile(filepath);
                else
                    pictureBox_Logo.Image = Image.FromFile(@"Image samples for testing\No Image.jpg");
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
                DTCC_dataInitialize();
            }
        }

        private void button_searchDTCC_Click(object sender, EventArgs e)
        {
            switch (comboBox_searchOption.Text)
            {
                case "Mã đối tác":
                    Search("DTID");
                    break;
                case "Tên đối tác":
                    Search("TENDT");
                    break;
                case "Số điện thoại":
                    textBox_search.Text = "(Nhập 10 chữ số)";
                    if (textBox_search.Text != "(Nhập 10 chữ số)")
                        Search("SDT");
                    else
                        MessageBox.Show("Hãy nhập nội dung cần tìm kiếm", "Thông báo");
                    break;
                case "Địa chỉ":
                    Search("DIACHI");
                    break;
                case "Ngày trở thành đối tác":
                    textBox_search.Text = "(YYYY/MM/DD)";
                    if (textBox_search.Text != "(YYYY/MM/DD)")
                        Search("NGDT");
                    else
                        MessageBox.Show("Hãy nhập nội dung cần tìm kiếm", "Thông báo");
                    break;
            }
        }

        public void Search(string SearchOption)
        {
            string str;
            str = "select * from DTCC where "+SearchOption+" like '%"+textBox_search.Text +"%'";
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
            DTCC_dataInitialize();
        }
    }
}
