using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace App_sale_manager
{
    public partial class DTCC_form : Form
    {
        public static string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection con = new SqlConnection(strCon);
        private void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public event EventHandler RefreshData;
        private void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        
        public DTCC_form()
        {
            InitializeComponent();
            dateTimePicker_NGDT_z.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NGDT_z.CustomFormat = "yyyy/MM/dd";
            pictureBox_image_import.Image = Image.FromFile(@"Image samples for testing\Khách hàng đăng kí\No Image.jpg");
        }
        private void DTCC_form_Load(object sender, EventArgs e)
        {

        }

        private void button_DTCC_Reject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DTCC_Accept_Click(object sender, EventArgs e)
        {
            if (exedata("insert into DTCC values('" + textBox_ID_z.Text + "', N'" + textBox_TENDT_z.Text + "', '" + textBox_SDT_z.Text + "', '" + dateTimePicker_NGDT_z.Value + "', N'" + textBox_DIACHI_z.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công!");
                SaveFileDialog Save = new SaveFileDialog();
                Save.FileName = @"Image samples for testing\Đối tác giao dịch\"+textBox_TENDT_z.Text+".jpg";
                pictureBox_image_import.Image.Save(Save.FileName);
                RefreshData(this, new EventArgs());
                Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }                  
        }

        private void label_Picture_z_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Image_import_Click(object sender, EventArgs e)
        {
            string filepath;
            OpenFileDialog Open1 = new OpenFileDialog();
            Open1.Filter = " Image file (*.BMP,*.JPG,*.JPEG)|*.bmp;*.jpg;*.jpeg ";
            Open1.Multiselect = false;
            if (Open1.ShowDialog() == DialogResult.OK)
            {
                filepath = Open1.FileName;
                pictureBox_image_import.Image = Image.FromFile(filepath);
                this.label_image_name.Text = filepath;
            }           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker_NGDT_z_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
