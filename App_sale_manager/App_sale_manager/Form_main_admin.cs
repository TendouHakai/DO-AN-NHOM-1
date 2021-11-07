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
using System.Text.RegularExpressions;
using System.IO;

namespace App_sale_manager
{
    public partial class Form_main_admin : Form
    {
        public string filepath = "";
        SqlConnection AAA;
        SqlCommand command;
        String strcon = @"Data Source=DESKTOP-LCG6NPQ;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlDataAdapter ADT = new SqlDataAdapter();
        DataTable table_nv_infonv = new DataTable();
        
        DataTable table_nv_bangluong = new DataTable();

        void LoadData_nv_infonv()
        {
            command = AAA.CreateCommand();
            command.CommandText = "SELECT NVID,HOTEN,SDT,NGVL,NGSINH,CV,USERNAME,PASSWD FROM NHANVIEN";
            ADT.SelectCommand = command;
            table_nv_infonv.Clear();
            ADT.Fill(table_nv_infonv);
            dgv_nv_infonv.DataSource = table_nv_infonv;
        }
       
        void LoadData_nv_bangluong()
        {
            command = AAA.CreateCommand();
            command.CommandText = "SELECT NVID,HOTEN,LUONG,HESO FROM NHANVIEN";
            ADT.SelectCommand = command;
            table_nv_bangluong.Clear();
            ADT.Fill(table_nv_bangluong);
            dgv_nv_bangluong.DataSource = table_nv_bangluong;
        }
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
            AAA = new SqlConnection(strcon);
            AAA.Open();
            LoadData_nv_infonv();
            LoadData_nv_bangluong();
        }
       
        private void tb_SDT_nv_infonv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_SDT_nv_infonv_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_SDT_nv_infonv.Text, @"^\d+$"))
            {
                tb_SDT_nv_infonv.ForeColor = Color.Red;
            }
            else
            {
                tb_SDT_nv_infonv.ForeColor = Color.Black;
            }
        }
        private void tb_SDT_nv_infonv_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_SDT_nv_infonv.Text, @"^\d+$"))
            {
                tb_SDT_nv_infonv.Text = "";
            }
        }
        private void tb_matkhau_nv_infonv_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_matkhau_nv_infonv.Text, @"\s"))
            {
                tb_matkhau_nv_infonv.ForeColor = Color.Red;
            }
            else
            {
                tb_matkhau_nv_infonv.ForeColor = Color.Black;
            }
        }

        private void tb_matkhau_nv_infonv_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_matkhau_nv_infonv.Text, @"\s"))
            {
                tb_matkhau_nv_infonv.Text = "";
            }
        }
        private void bt_Them_nv_infonv_Click(object sender, EventArgs e)
        {
            command = AAA.CreateCommand();
            try
            {
                command.CommandText = "set dateformat dmy " + "insert into NHANVIEN values('" + tb_MaNV_nv_infonv.Text + "',N'" + tb_TenNV_nv_infonv.Text + "','" + tb_SDT_nv_infonv.Text + "',' " + dt_NgayVaoLam_nv_infonv.Text + " ','" + dt_NgaySinh_nv_infonv.Text + "',N'" + tb_ChucVu_nv_infonv.Text + "',N'" + tb_username_nv_infonv.Text + "','" + tb_matkhau_nv_infonv.Text + "','" + 0 + "','" + 0 + "')";
                command.ExecuteNonQuery();
                SaveFileDialog Save = new SaveFileDialog();
                if (filepath != "")
                {
                    Save.FileName = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                    pictureBox_image_import_nv.Image.Save(Save.FileName);
                    filepath = "";
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Nhập không đúng dữ liệu hoặc MANV đã có!");
            }
            LoadData_nv_infonv();
            LoadData_nv_bangluong();
        }

        private void bt_nv_infonv_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                filepath = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                command = AAA.CreateCommand();
                command.CommandText = "delete from NHANVIEN where NVID='" + tb_MaNV_nv_infonv.Text + "'";
                command.ExecuteNonQuery();
                pictureBox_image_import_nv.Image = null;
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }
                filepath = "";
                LoadData_nv_infonv();
                LoadData_nv_bangluong();
            }
        }

        private void bt_nv_infonv_Sua_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Sửa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                command = AAA.CreateCommand();
                command.CommandText = "set dateformat dmy " + "update NHANVIEN set HOTEN=N'" + tb_TenNV_nv_infonv.Text + "',SDT='" + tb_SDT_nv_infonv.Text + "',NGVL='" + dt_NgayVaoLam_nv_infonv.Text + "',NGSINH='" + dt_NgaySinh_nv_infonv.Text + "',CV=N'" + tb_ChucVu_nv_infonv.Text + "',USERNAME=N'" + tb_username_nv_infonv.Text + "',PASSWD='" + tb_matkhau_nv_infonv.Text + "' where NVID='" + tb_MaNV_nv_infonv.Text + "'";
                SaveFileDialog Save = new SaveFileDialog();
                if (filepath != "")
                {
                    Save.FileName = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                    pictureBox_image_import_nv.Image.Save(Save.FileName);
                    filepath = "";
                }
                command.ExecuteNonQuery();
                LoadData_nv_infonv();
                LoadData_nv_bangluong();
            }
        }
        private void bt_nv_infonv_Khoitao_Click(object sender, EventArgs e)
        {
            tb_MaNV_nv_infonv.Text = "";
            tb_TenNV_nv_infonv.Text = "";
            tb_SDT_nv_infonv.Text = "";
            dt_NgaySinh_nv_infonv.Text = "1/1/1900";
            dt_NgayVaoLam_nv_infonv.Text = "1/1/1900";
            tb_ChucVu_nv_infonv.Text = "";
            tb_username_nv_infonv.Text = "";
            tb_matkhau_nv_infonv.Text = "";
            tb_MaNV_nv_infonv.ReadOnly = false;
            (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            pictureBox_image_import_nv.Image = null;
        }

        private void bt_nv_infonv_Tracuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search_nv_infonv.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm.");
                tb_search_nv_infonv.Focus();
                return;
            }
            if (cb_searchoption_nv_infonv.Text == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn trường cần tìm");
                cb_searchoption_nv_infonv.Focus();
                return;
            }
            switch (cb_searchoption_nv_infonv.Text)
            {
                case "Mã NV":
                    {
                        (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format("NVID ='{0}'", tb_search_nv_infonv.Text);
                        break;
                    }
                case "Họ Tên":
                    {
                        (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format("HOTEN LIKE'%{0}%'", tb_search_nv_infonv.Text);
                        break;
                    }
                case "Số điện thoại":
                    {
                       
                        if (Regex.IsMatch(tb_search_nv_infonv.Text, @"^\d+$"))
                        {
                            (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format(" SDT LIKE'{0}%' ", tb_search_nv_infonv.Text);
                        }
                        else
                        {
                            MessageBox.Show("vui long nhap 1 so dien thoai");
                            tb_search_nv_infonv.Focus();
                        }
                        break;
                    }
                case "Ngày sinh":
                    {
                        try
                        {
                            (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format("NGSINH='{0}' ", tb_search_nv_infonv.Text);
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Bạn không nhập đúng format ngày");
                            tb_search_nv_infonv.Focus();
                        }
                        break;
                    }
                case "Ngày vào làm":
                    {
                        try
                        {
                            (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format(" NGVL = '{0}' ", tb_search_nv_infonv.Text);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bạn không nhập đúng format ngày");
                            tb_search_nv_infonv.Focus();
                        }
                        break;
                    }
                case "Chức vụ":
                    {
                        (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format(" CV LIKE'%{0}%' ", tb_search_nv_infonv.Text);
                        break;
                    }
            }
            
        }



        
        private void bt_Sua_nv_bangluong_Click(object sender, EventArgs e)
        {
            command = AAA.CreateCommand();
            command.CommandText = "update NHANVIEN set LUONG='"+nud_Luong_nv_bangluong.Value.ToString()+"',HESO='"+float.Parse(nud_Heso_nv_bangluong.Value.ToString())+"' WHERE NVID='"+tb_MaNV_nv_bangluong.Text+"'";
            command.ExecuteNonQuery();
            LoadData_nv_bangluong();
        }
        private void bt_Khoitao_nv_bangluong_Click(object sender, EventArgs e)
        {
            tb_MaNV_nv_bangluong.ReadOnly = false;
            tb_TenNV_nv_bangluong.ReadOnly = false;
            tb_MaNV_nv_bangluong.Text = "";
            tb_TenNV_nv_bangluong.Text = "";
            nud_Luong_nv_bangluong.Value = 0;
            nud_Heso_nv_bangluong.Value = 0;

            (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

        }
        private void bt_Tracuu_nv_bangluong_Click(object sender, EventArgs e)
        {
            (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            if (string.IsNullOrEmpty(tb_search_nv_bangluong.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm.");
                tb_search_nv_bangluong.Focus();
                return;
            }
            if (cb_searchoption_nv_bangluong.Text == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn trường cần tìm");
                cb_searchoption_nv_bangluong.Focus();
                return;
            }
            switch (cb_searchoption_nv_bangluong.Text)
            {
                case "Mã NV":
                    {
                        (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format("NVID ='{0}'", tb_search_nv_bangluong.Text);
                        break;
                    }
                case "Họ Tên":
                    {
                        (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format("HOTEN LIKE'%{0}%'", tb_search_nv_bangluong.Text);
                        break;
                    }
                case "Lương":
                    {
                        if (cb_LocLuong_nv_bangluong.Text == "Lọc")
                        {
                            MessageBox.Show("Vui lòng chọn mức lương cần lọc");
                            cb_LocLuong_nv_bangluong.Focus();
                        }
                        else
                        {
                            if (decimal.TryParse(tb_search_nv_bangluong.Text, out decimal result))
                            {
                                if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(0))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" LUONG = '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(1))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" LUONG > '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(2))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" LUONG < '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                            }
                            else
                            {
                                MessageBox.Show("vui lòng nhập một số tiền");
                                tb_search_nv_bangluong.Focus();
                            }
                        }
                        break;
                    }
                case "Hệ số":
                    {
                        if (decimal.TryParse(tb_search_nv_bangluong.Text, out decimal result))
                        {
                            (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format("HESO = '{0}'", tb_search_nv_bangluong.Text);
                        }
                        else
                        {
                            MessageBox.Show("vui lòng nhập một số");
                            tb_search_nv_bangluong.Focus();
                        }
                        break;
                    }
            }
            }

        private void Form_main_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            AAA.Close();
        }

        private void button_Image_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open1 = new OpenFileDialog();
            Open1.Filter = " Image file (*.BMP,*.JPG,*.JPEG)|*.bmp;*.jpg;*.jpeg ";
            Open1.Multiselect = false;
            if (Open1.ShowDialog() == DialogResult.OK)
            {
                filepath = Open1.FileName;
                pictureBox_image_import_nv.Image = Image.FromFile(filepath);
            }
        }

        private void cb_ThutuLuong_nv_bangluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(0))
                (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "LUONG ASC";
            else if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(1))
                (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "LUONG DESC";
            else if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(2))
                (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "NVID ASC";
        }

        private void dgv_nv_infonv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNV_nv_infonv.ReadOnly = true;
            int i;
            i = dgv_nv_infonv.CurrentRow.Index;
            tb_MaNV_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[0].Value.ToString();
            tb_TenNV_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[1].Value.ToString();
            tb_SDT_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[2].Value.ToString();
            dt_NgayVaoLam_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[3].Value.ToString();
            dt_NgaySinh_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[4].Value.ToString();
            tb_ChucVu_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[5].Value.ToString();
            tb_username_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[6].Value.ToString();
            tb_matkhau_nv_infonv.Text = dgv_nv_infonv.Rows[i].Cells[7].Value.ToString();


            if (File.Exists(@"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg"))
            {
                Image image1 = null;
                using (FileStream stream = new FileStream(@"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg", FileMode.Open))
                {
                    image1 = Image.FromStream(stream);
                }

                pictureBox_image_import_nv.Image = image1;
            }
            else pictureBox_image_import_nv.Image = null;

        }

        private void dgv_nv_bangluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNV_nv_bangluong.ReadOnly = true;
            tb_TenNV_nv_bangluong.ReadOnly = true;
            int i;
            i = dgv_nv_bangluong.CurrentRow.Index;
            tb_MaNV_nv_bangluong.Text = dgv_nv_bangluong.Rows[i].Cells[0].Value.ToString();
            tb_TenNV_nv_bangluong.Text = dgv_nv_bangluong.Rows[i].Cells[1].Value.ToString();
            nud_Luong_nv_bangluong.Value = Convert.ToDecimal(dgv_nv_bangluong.Rows[i].Cells[2].Value.ToString());
            nud_Heso_nv_bangluong.Value = Convert.ToDecimal(dgv_nv_bangluong.Rows[i].Cells[3].Value.ToString());

        }

        private void cb_searchoption_nv_bangluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_searchoption_nv_bangluong.Text == "Lương")
            {
                cb_LocLuong_nv_bangluong.Visible = true;
            }
            else
            {
                cb_LocLuong_nv_bangluong.Visible = false;
            }
        }

       
    }
}
