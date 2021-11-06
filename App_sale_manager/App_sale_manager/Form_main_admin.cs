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
        private void dgv_nv_infonv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            /*filepath = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
             { if (File.Exists(@"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg"))
                {
                    pictureBox_image_import.Image = Image.FromFile(filepath) ;
                 
                }

                else pictureBox_image_import.Image = null;
            };*/
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
                MessageBox.Show("Nhap dung du lieu!");
            }
            LoadData_nv_infonv();
            LoadData_nv_bangluong();
        }

        private void bt_nv_infonv_Xoa_Click(object sender, EventArgs e)
        {
            filepath = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
            command = AAA.CreateCommand();
            command.CommandText = "delete from NHANVIEN where NVID='" + tb_MaNV_nv_infonv.Text + "'";
            command.ExecuteNonQuery();
            pictureBox_image_import_nv.Image= null;
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            filepath = "";
            LoadData_nv_infonv();
            LoadData_nv_bangluong();
        }

        private void bt_nv_infonv_Sua_Click(object sender, EventArgs e)
        {
            command = AAA.CreateCommand();
            command.CommandText = "set dateformat dmy "+ "update NHANVIEN set HOTEN=N'" + tb_TenNV_nv_infonv.Text + "',SDT='" + tb_SDT_nv_infonv.Text + "',NGVL='" + dt_NgayVaoLam_nv_infonv.Text + "',NGSINH='" + dt_NgaySinh_nv_infonv.Text + "',CV=N'" + tb_ChucVu_nv_infonv.Text + "',USERNAME=N'" + tb_username_nv_infonv.Text + "',PASSWD='" + tb_matkhau_nv_infonv.Text + "' where NVID='" + tb_MaNV_nv_infonv.Text + "'";
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
            (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            if (!string.IsNullOrEmpty(tb_MaNV_nv_infonv.Text))
            {
                (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = string.Format("NVID ='{0}'", tb_MaNV_nv_infonv.Text);
            }
            else
            {
                string str_RowFilter = null;
                if (!string.IsNullOrEmpty(tb_TenNV_nv_infonv.Text))
                {
                    str_RowFilter = string.Format("HOTEN LIKE'%{0}%'", tb_TenNV_nv_infonv.Text);
                }
                if (!string.IsNullOrEmpty(tb_SDT_nv_infonv.Text))
                {
                    if (!string.IsNullOrEmpty(str_RowFilter))
                        str_RowFilter += string.Format("AND SDT LIKE'{0}%' ", tb_SDT_nv_infonv.Text);
                    else
                        str_RowFilter = string.Format("SDT LIKE'{0}%' ", tb_SDT_nv_infonv.Text);
                }
                DateTime minDate = new DateTime(1900, 01, 01);
                if (dt_NgaySinh_nv_infonv.Value.Date > minDate.Date)
                {
                    if (!string.IsNullOrEmpty(str_RowFilter))
                        str_RowFilter += string.Format("AND NGSINH='{0}' ", dt_NgaySinh_nv_infonv.Text);
                    else
                        str_RowFilter = string.Format("NGSINH ='{0}' ", dt_NgaySinh_nv_infonv.Text);
                }
                if (dt_NgayVaoLam_nv_infonv.Value.Date > minDate.Date)
                {
                    if (!string.IsNullOrEmpty(str_RowFilter))
                        str_RowFilter += string.Format("AND NGVL='{0}' ", dt_NgayVaoLam_nv_infonv.Text);
                    else
                        str_RowFilter = string.Format("NGVL ='{0}' ", dt_NgayVaoLam_nv_infonv.Text);
                }
                if (!string.IsNullOrEmpty(tb_ChucVu_nv_infonv.Text))
                {
                    if (!string.IsNullOrEmpty(str_RowFilter))
                        str_RowFilter += string.Format("AND CV LIKE'%{0}%' ", tb_ChucVu_nv_infonv.Text);
                    else
                        str_RowFilter = string.Format("CV LIKE'%{0}%' ", tb_ChucVu_nv_infonv.Text);
                }

                (dgv_nv_infonv.DataSource as DataTable).DefaultView.RowFilter = str_RowFilter;
            }
        }



        private void dgv_nv_bangluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (!string.IsNullOrEmpty(tb_MaNV_nv_bangluong.Text))
            {
                (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format("NVID ='{0}'", tb_MaNV_nv_bangluong.Text);
            }
            else
            {
                string str_RowFilter = null;
                if (!string.IsNullOrEmpty(tb_TenNV_nv_bangluong.Text))
                {
                    str_RowFilter = string.Format("HOTEN LIKE'%{0}%'", tb_TenNV_nv_bangluong.Text);
                }
                if (!(nud_Luong_nv_bangluong.Value==0))
                {
                    if (!string.IsNullOrEmpty(str_RowFilter))
                    {
                        if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(0))
                            str_RowFilter += string.Format(" AND LUONG = '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                        else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(1))
                            str_RowFilter += string.Format(" AND LUONG > '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                        else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(2))
                            str_RowFilter += string.Format(" AND LUONG < '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                    }
                    else
                    {
                        if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(0))
                            str_RowFilter += string.Format(" LUONG = '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                        else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(1))
                            str_RowFilter += string.Format(" LUONG > '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                        else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(2))
                            str_RowFilter += string.Format(" LUONG < '{0}'", Convert.ToDecimal(nud_Luong_nv_bangluong.Value));
                    }
                }
                (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = str_RowFilter;
                if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(0))
                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "LUONG ASC";
                else if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(1))
                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "LUONG DESC";
                else if (cb_ThutuLuong_nv_bangluong.SelectedIndex.Equals(2))
                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.Sort = "NVID ASC";
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

        
    }
}
