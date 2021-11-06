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
        string manv = "nv01";
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        bool canExit;
        Sale_viewer A = new Sale_viewer();
        DataTable table = new DataTable();
        public Form_main_admin()
        {
            sqlCon = new SqlConnection(strCon);
            cmd = sqlCon.CreateCommand();
            InitializeComponent();
            DTCC_dtgd_dataInitialize();
            DTCC_guest_dataInitialize();
            canExit = true;
            pictureBox_Logo.Image = Image.FromFile(@"Image samples for testing\Đối tác giao dịch\No Image.jpg");
            pictureBox_dtcc_guestFace.Image = Image.FromFile(@"Image samples for testing\\Khách hàng đăng kí\No Image.jpg");
        }
        public Form_main_admin(string manv)
        {
            this.manv = manv;
            sqlCon = new SqlConnection(strCon);
            cmd = sqlCon.CreateCommand();
            InitializeComponent();
        }
        public event EventHandler Thoat;
        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl.SelectedIndex == 0)
            {
                load_tab_Tongquan();
            }
            else if (tabCtrl.SelectedIndex == 5)
            {
                tabControl_Baocao.SelectedIndex = 0;
                tabControl_Baocao_SelectedIndexChanged(tabControl_Baocao, new EventArgs());
            }
            else if (tabCtrl.SelectedIndex == 3)
            {
                this.Refresh_data_GD();
            }
            else if(tabCtrl.SelectedIndex==1)
            {
                LoadHangHoa();
            }
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            canExit = false;
            Thoat(this, new EventArgs());
        }
        private void Form_main_admin_Load(object sender, EventArgs e)
        {

            load_tab_Tongquan();
            tao_datgridview_lich_lamviec();
        }
        private void Form_main_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (canExit == true)
                Application.Exit();
        }
        // NHÓM HÀM TABPAGE TỔNG QUAN
        void load_gdv_HoaDon()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            string day = date.ToString("d");
            cmd.CommandText = "SELECT COUNT(SOHD_BH) as SoHoaDon, SUM(TRIGIA) as DoanhThu FROM HDBH WHERE lOAIHD = 'DTT' AND NGHD ='" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_HoaDon.DataSource = table;
            sqlCon.Close();
        }
        void load_gv_DonDatHang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            string day = date.ToString("d");
            cmd.CommandText = "SELECT COUNT(SOHD_BH) as SoDonDatHang, SUM(TRIGIA) as DoanhThu FROM HDBH WHERE LOAIHD = 'DDH'AND NGHD ='" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_DonDatHang.DataSource = table;
            sqlCon.Close();
        }
        void load_chart_doanhthuthang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)=" + date.Month + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + date.Month + " GROUP BY NGNHAP) AS K GROUP BY NGAY";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_doanhthuthang.DataSource = table;
            chart_doanhthuthang.Titles["Title1"].Text = "Doanh thu tháng " + date.Month + "";
            chart_doanhthuthang.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_doanhthuthang.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_doanhthuthang.Series["Series_Thu"].Points.Clear();
            chart_doanhthuthang.Series["Series_Chi"].Points.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_doanhthuthang.Series["Series_Thu"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGTHU"]);
                chart_doanhthuthang.Series["Series_Chi"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGCHI"]);
            }
            sqlCon.Close();
        }
        void load_chart_hangbanchay()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT CTHDBH.SPID, SUM(CTHDBH.SL*SANPHAM.GIABAN) AS DOANHTHU FROM HDBH, CTHDBH, SANPHAM WHERE HDBH.SOHD_BH = CTHDBH.SOHD_BH AND CTHDBH.SPID = SANPHAM.SPID AND MONTH(HDBH.NGHD)=" + date.Month + " GROUP BY CTHDBH.SPID ORDER BY DOANHTHU DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_hangbanchay.DataSource = table;
            chart_hangbanchay.Titles["Title_hangbanchay"].Text = "Danh sách hàng hóa bán chạy trong tháng " + date.Month;
            chart_hangbanchay.ChartAreas["ChartArea1"].AxisX.Title = "Hàng hóa";
            chart_hangbanchay.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_hangbanchay.Series["Series_hanghoa"].Points.Clear();
            int j = 4;
            if(table.Rows.Count<=4)
            {
                j = table.Rows.Count-1;
            }    
            for (int i = j; i >= 0; i--)
            {
                chart_hangbanchay.Series["Series_hanghoa"].Points.AddXY(table.Rows[i]["SPID"], table.Rows[i]["DOANHTHU"]);
            }
            sqlCon.Close();
        }
        void load_list_hanhdong()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT NHANVIEN.HOTEN, HDBH.SOHD_BH, NGHD, TRIGIA, LOAIHD FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID WHERE NGHD>='" + date.AddDays(-5).ToString("d") + "' ORDER BY NGHD DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            listView_hanhdong.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["LOAIHD"].Equals("DTT"))
                    listView_hanhdong.Items.Add("- " + table.Rows[i]["HOTEN"] + " vừa bán được 1 đơn hàng " + table.Rows[i]["SOHD_BH"] + " trị giá " + table.Rows[i]["TRIGIA"] + " vào ngày " + table.Rows[i]["NGHD"]);
                else
                    listView_hanhdong.Items.Add("- " + table.Rows[i]["HOTEN"] + " vừa bán được 1 đơn đặt hàng " + table.Rows[i]["SOHD_BH"] + " trị giá " + table.Rows[i]["TRIGIA"] + " vào ngày " + table.Rows[i]["NGHD"]);
            }
        }
        void load_tab_Tongquan()
        {
            load_gdv_HoaDon();
            load_gv_DonDatHang();
            load_chart_doanhthuthang();
            load_chart_hangbanchay();
            load_list_hanhdong();
        }
        
        //
        // NHÓM HÀM TABPAGE BÁO CÁO
        private void tabControl_Baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Baocao.SelectedIndex == 0)
            {
                rBtn_bc_qt1_CheckedChanged(rBtn_bc_qt1, new EventArgs());
            }
            else if (tabControl_Baocao.SelectedIndex == 1)
            {
                // đặt mặc định cho biến.
                comboBox_bc_Doanhthu_kieutinh.SelectedIndex = 0;
                comboBox_bc_Doanhthu_kieutinh_SelectedIndexChanged(comboBox_bc_Doanhthu_kieutinh, new EventArgs());
            }
            else if (tabControl_Baocao.SelectedIndex == 2)
            {
                comboBox_bc_Nv_kieutinh.SelectedIndex = 0;
                comboBox_bc_Nv_kieutinh_SelectedIndexChanged(comboBox_bc_Nv_kieutinh, new EventArgs());
            }
        }
        // nhóm hàm tabpage Báo cáo cuối ngày
        void event_Cuoingay_radio1()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            string day = dtp_bc_time.Value.ToString("d");
            cmd.CommandText = "SELECT * FROM HDBH WHERE HDBH.NGHD='" + day + "' ORDER BY HDBH.LOAIHD DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT LOAIHD, SUM(TRIGIA) AS TONGTIEN FROM HDBH WHERE NGHD='" + day + "' GROUP BY LOAIHD ORDER BY LOAIHD DESC";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            if (table1.Rows.Count == 0)
            {
                textBox_bcCuoingay1.Text = "0";
                textBox_bcCuoingay2.Text = "0";
            }
            else if (table1.Rows.Count == 1)
                textBox_bcCuoingay1.Text = table1.Rows[0]["TONGTIEN"].ToString();
            else
            {
                textBox_bcCuoingay1.Text = table1.Rows[0]["TONGTIEN"].ToString();
                textBox_bcCuoingay2.Text = table1.Rows[1]["TONGTIEN"].ToString();
            }
            cmd.CommandText = "SELECT SUM(TRIGIA) AS TONG FROM HDBH WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='Da thanh toan')) AND NGHD='" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            table2.Clear();
            adapter.Fill(table2);
            label_bcCuoingay2.Show();
            label_bcCuoingay3.Show();
            textBox_bcCuoingay2.Show();
            textBox_bcCuoingay3.Show();
            if (table2.Rows[0]["TONG"].ToString() == "")
            {
                textBox_bcCuoingay3.Text = "0";
            }
            else
            {
                textBox_bcCuoingay3.Text = table2.Rows[0]["TONG"].ToString();
            }

            sqlCon.Close();
        }
        void event_Cuoingay_radio2()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            string day = dtp_bc_time.Value.ToString("d");
            cmd.CommandText = "SELECT * FROM HDNH WHERE NGNHAP= '" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT SUM(TRIGIA) AS TONG FROM HDNH WHERE NGNHAP= '" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            label_bcCuoingay1.Text = "Tong Chi";
            label_bcCuoingay2.Hide();
            label_bcCuoingay3.Hide();
            textBox_bcCuoingay2.Hide();
            textBox_bcCuoingay3.Hide();
            if (table1.Rows[0]["TONG"].ToString() == "")
            {
                textBox_bcCuoingay1.Text = "0";
            }
            else
            {
                textBox_bcCuoingay1.Text = table1.Rows[0]["TONG"].ToString();
            }
            sqlCon.Close();
        }
        void event_Cuoingay_radio3()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            string day = dtp_bc_time.Value.ToString("d");
            cmd.CommandText = "SELECT SOHD_BH AS SOHD, NGHD, KHID AS DOITAC, NVID, TRIGIA FROM HDBH WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND NGHD = '" + day + "' UNION SELECT* FROM HDNH WHERE NGNHAP = '" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT (THU-CHI) AS DOANHTHU FROM (SELECT SUM(THU) AS THU, SUM(CHI) AS CHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND NGHD='" + day + "' GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE NGNHAP='" + day + "' GROUP BY NGNHAP) AS K) AS H";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            label_bcCuoingay1.Text = "Doanh Thu";
            label_bcCuoingay2.Hide();
            label_bcCuoingay3.Hide();
            textBox_bcCuoingay2.Hide();
            textBox_bcCuoingay3.Hide();
            if (table1.Rows[0]["DOANHTHU"].ToString() == "")
                textBox_bcCuoingay1.Text = "0";
            else textBox_bcCuoingay1.Text = table1.Rows[0]["DOANHTHU"].ToString();
            sqlCon.Close();
        }
        private void rBtn_bc_qt1_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_bc_qt1.Checked)
            {
                event_Cuoingay_radio1();
            }
            else if (rBtn_bc_qt2.Checked)
            {
                event_Cuoingay_radio2();
            }
            else if (rBtn_bc_qt3.Checked)
            {
                event_Cuoingay_radio3();
            }
        }
        private void dtp_bc_time_ValueChanged(object sender, EventArgs e)
        {
            rBtn_bc_qt1_CheckedChanged(rBtn_bc_qt1, new EventArgs());
        }
        // Nhóm hàm tabpage Báo cáo doanh thu
        void event_bc_DoanhThu_TheoThang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT DAY(NGAY) AS NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + "AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K GROUP BY DAY(NGAY)";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_Doanhthu.Titles["Title_chart_bc_Doanhthu"].Text = "Biểu đồ doanh thu tháng " + comboBox_bc_Doanhthu_nhap1.Text + " năm " + textBox_bc_DoanhThu_nhap2.Text;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Maximum = DateTime.DaysInMonth(Convert.ToInt32(textBox_bc_DoanhThu_nhap2.Text), Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text)) + 1;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_bc_Doanhthu.Series["Series_Thu"].Points.Clear();
            chart_bc_Doanhthu.Series["Series_Chi"].Points.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_bc_Doanhthu.Series["Series_Thu"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGTHU"]);
                chart_bc_Doanhthu.Series["Series_Chi"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGCHI"]);
            }
            cmd.CommandText = "SELECT SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K ";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            if (table1.Rows[0]["TONGTHU"].ToString() == "")
                textBox_bc_Doanhthu_thu.Text = "0";
            else textBox_bc_Doanhthu_thu.Text = table1.Rows[0]["TONGTHU"].ToString();
            if (table1.Rows[0]["TONGCHI"].ToString() == "")
                textBox_bc_Doanhthu_chi.Text = "0";
            else textBox_bc_Doanhthu_chi.Text = table1.Rows[0]["TONGCHI"].ToString();
            cmd.CommandText = "SELECT (TONGTHU-TONGCHI) AS DOANHTHU FROM (SELECT SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " UNION SELECT THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K) AS H";
            adapter.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            table2.Clear();
            adapter.Fill(table2);
            if (table2.Rows[0]["DOANHTHU"].ToString() == "")
                textBox_bc_Doanhthu_doanhthu.Text = "0";
            else textBox_bc_Doanhthu_doanhthu.Text = table2.Rows[0]["DOANHTHU"].ToString();
            sqlCon.Close();
        }
        void event_bc_DoanhThu_TheoQuy()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            int Quy = Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text);
            cmd.CommandText = "SELECT THANG, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT MONTH(NGHD) AS THANG, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD) BETWEEN (" + Quy * 3 + "-2) AND " + Quy * 3 + " GROUP BY MONTH(NGHD) UNION SELECT MONTH(NGNHAP), THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP) BETWEEN (" + Quy * 3 + " -2) AND " + Quy * 3 + " GROUP BY NGNHAP) AS K GROUP BY THANG";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_Doanhthu.Titles["Title_chart_bc_Doanhthu"].Text = "Biểu đồ doanh thu quý " + comboBox_bc_Doanhthu_nhap1.Text;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Minimum = Quy * 3 - 3;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Maximum = Quy * 3 + 1;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_bc_Doanhthu.Series["Series_Thu"].Points.Clear();
            chart_bc_Doanhthu.Series["Series_Chi"].Points.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_bc_Doanhthu.Series["Series_Thu"].Points.AddXY(table.Rows[i]["THANG"], table.Rows[i]["TONGTHU"]);
                chart_bc_Doanhthu.Series["Series_Chi"].Points.AddXY(table.Rows[i]["THANG"], table.Rows[i]["TONGCHI"]);
            }

            sqlCon.Close();
        }
        private void comboBox_bc_Doanhthu_kieutinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_bc_Doanhthu_kieutinh.SelectedIndex == 0)
            {
                label_bc_Doanhthu_nhap1.Text = "Nhập tháng";
                DateTime date = DateTime.Today;
                comboBox_bc_Doanhthu_nhap1.Items.Clear();
                comboBox_bc_Doanhthu_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                comboBox_bc_Doanhthu_nhap1.Text = date.Month.ToString();
                textBox_bc_DoanhThu_nhap2.Text = date.Year.ToString();
                event_bc_DoanhThu_TheoThang();
            }
            else if (comboBox_bc_Doanhthu_kieutinh.SelectedIndex == 1)
            {
                label_bc_Doanhthu_nhap1.Text = "Nhập Quý";
                DateTime date = DateTime.Today;
                comboBox_bc_Doanhthu_nhap1.Items.Clear();
                comboBox_bc_Doanhthu_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4" });
                if (date.Month <= 3)
                    comboBox_bc_Doanhthu_nhap1.Text = "1";
                else if (date.Month <= 6)
                    comboBox_bc_Doanhthu_nhap1.Text = "2";
                else if (date.Month <= 9)
                    comboBox_bc_Doanhthu_nhap1.Text = "3";
                else comboBox_bc_Doanhthu_nhap1.Text = "4";
                textBox_bc_DoanhThu_nhap2.Text = date.Year.ToString();
                event_bc_DoanhThu_TheoQuy();
            }
        }
        private void btn_bc_Doanhthu_Click(object sender, EventArgs e)
        {
            if (comboBox_bc_Doanhthu_kieutinh.SelectedIndex == 0)
            {
                try
                {
                    if (comboBox_bc_Doanhthu_nhap1.Text == "" || textBox_bc_DoanhThu_nhap2.Text == "")
                    {
                        MessageBox.Show("Bạn vẫn chưa nhập xong", "Thông báo");
                        return;
                    }
                    else if (Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text) < 1 || Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text) > 12 || Convert.ToInt32(textBox_bc_DoanhThu_nhap2.Text) < 1)
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                        return;
                    }
                    else
                    {
                        event_bc_DoanhThu_TheoThang();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                }
            }
            else if (comboBox_bc_Doanhthu_kieutinh.SelectedIndex == 1)
            {
                try
                {
                    if (comboBox_bc_Doanhthu_nhap1.Text == "" || textBox_bc_DoanhThu_nhap2.Text == "")
                    {
                        MessageBox.Show("Bạn vẫn chưa nhập xong", "Thông báo");
                        return;
                    }
                    else if (Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text) < 1 || Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text) > 4 || Convert.ToInt32(textBox_bc_DoanhThu_nhap2.Text) < 1)
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                        return;
                    }
                    else
                    {
                        event_bc_DoanhThu_TheoQuy();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                }
            }
        }
        // nhóm hàm tabpage báo cáo nhân viên
        void event_bc_nv_TheoThang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT HDBH.NVID AS MANV, SUM(TRIGIA)AS DOANHSO, HOTEN FROM HDBH inner join NHANVIEN on HDBH.NVID=NHANVIEN.NVID WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='Da thanh toan')) AND MONTH(NGHD)=" + comboBox_bc_nv_nhap1.Text + " GROUP BY HDBH.NVID, HOTEN ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            chart_bc_nv.Titles["Title1"].Text = "Biểu đồ daonh số bán hàng nhân viên tháng " + comboBox_bc_nv_nhap1.Text;
            chart_bc_nv.ChartAreas["ChartArea1"].AxisX.Title = "Tên NV";
            chart_bc_nv.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_bc_nv.Series["Series1"].Points.Clear();
            if (table.Rows.Count == 0)
            {
                textBox_bc_nv_kq1.Text = "0";
                textBox_bc_nv_kq2.Text = "0";
                textBox_bc_nv_kq3.Text = "0";
                return;
            }
            int i = 4;
            if (table.Rows.Count < 5)
            {
                i = table.Rows.Count - 1;
            }
            for (; i >= 0; i--)
            {
                chart_bc_nv.Series["Series1"].Points.AddXY(table.Rows[i]["HOTEN"], table.Rows[i]["DOANHSO"]);
            }

            textBox_bc_nv_kq1.Text = table.Rows[0]["MANV"].ToString();
            textBox_bc_nv_kq2.Text = table.Rows[0]["HOTEN"].ToString();
            textBox_bc_nv_kq3.Text = table.Rows[0]["DOANHSO"].ToString();

            sqlCon.Close();
        }
        void event_bc_nv_TheoQuy()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            int Quy = Convert.ToInt32(comboBox_bc_nv_nhap1.Text);
            cmd.CommandText = "SELECT HDBH.NVID AS MANV, HOTEN, SUM(TRIGIA) AS DOANHSO FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID WHERE MONTH(NGHD) BETWEEN " + (Quy * 3 - 2) + " AND " + Quy * 3 + " AND YEAR(NGHD)= " + textBox_bc_nv_nhap2.Text + " GROUP BY HDBH.NVID, HOTEN ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_nv.Titles["Title1"].Text = "Biểu đồ doanh số bán hàng nhân viên quý " + comboBox_bc_nv_nhap1.Text;
            chart_bc_nv.ChartAreas["ChartArea1"].AxisX.Title = "Tên NV";
            chart_bc_nv.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_bc_nv.Series["Series1"].Points.Clear();
            if (table.Rows.Count == 0)
            {
                textBox_bc_nv_kq1.Text = "0";
                textBox_bc_nv_kq2.Text = "0";
                textBox_bc_nv_kq3.Text = "0";
                return;
            }
            int i = 4;
            if (table.Rows.Count < 5)
            {
                i = table.Rows.Count - 1;
            }
            for (; i >= 0; i--)
            {
                chart_bc_nv.Series["Series1"].Points.AddXY(table.Rows[i]["HOTEN"], table.Rows[i]["DOANHSO"]);
            }
            textBox_bc_nv_kq1.Text = table.Rows[0]["MANV"].ToString();
            textBox_bc_nv_kq2.Text = table.Rows[0]["HOTEN"].ToString();
            textBox_bc_nv_kq3.Text = table.Rows[0]["DOANHSO"].ToString();

            sqlCon.Close();
        }
        private void comboBox_bc_Nv_kieutinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_bc_Nv_kieutinh.SelectedIndex == 0)
            {
                label_bc_nv_nhap1.Text = "Nhập tháng";
                DateTime date = DateTime.Today;
                comboBox_bc_nv_nhap1.Items.Clear();
                comboBox_bc_nv_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                comboBox_bc_nv_nhap1.Text = date.Month.ToString();
                textBox_bc_nv_nhap2.Text = date.Year.ToString();
                event_bc_nv_TheoThang();
            }
            else if (comboBox_bc_Nv_kieutinh.SelectedIndex == 1)
            {
                label_bc_nv_nhap1.Text = "Nhập quý";
                DateTime date = DateTime.Today;
                comboBox_bc_nv_nhap1.Items.Clear();
                comboBox_bc_nv_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4" });
                if (date.Month <= 3)
                    comboBox_bc_nv_nhap1.Text = "1";
                else if (date.Month <= 6)
                    comboBox_bc_nv_nhap1.Text = "2";
                else if (date.Month <= 9)
                    comboBox_bc_nv_nhap1.Text = "3";
                else comboBox_bc_nv_nhap1.Text = "4";
                textBox_bc_nv_nhap2.Text = date.Year.ToString();
                event_bc_nv_TheoQuy();
            }
        }
        private void btn_bc_nv_xem_Click(object sender, EventArgs e)
        {
            if (comboBox_bc_Nv_kieutinh.SelectedIndex == 0)
            {

                try
                {
                    if (comboBox_bc_nv_nhap1.Text == "" || textBox_bc_nv_nhap2.Text == "")
                    {
                        MessageBox.Show("Bạn vẫn chưa nhập xong", "Thông báo");
                        return;
                    }
                    else if (Convert.ToInt32(comboBox_bc_nv_nhap1.Text) < 1 || Convert.ToInt32(comboBox_bc_nv_nhap1.Text) > 12 || Convert.ToInt32(textBox_bc_nv_nhap2.Text) < 1)
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                        return;
                    }
                    else
                    {
                        event_bc_nv_TheoThang();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                }
            }
            else if (comboBox_bc_Nv_kieutinh.SelectedIndex == 1)
            {
                try
                {
                    if (comboBox_bc_nv_nhap1.Text == "" || textBox_bc_nv_nhap2.Text == "")
                    {
                        MessageBox.Show("Bạn vẫn chưa nhập xong", "Thông báo");
                        return;
                    }
                    else if (Convert.ToInt32(comboBox_bc_nv_nhap1.Text) < 1 || Convert.ToInt32(comboBox_bc_nv_nhap1.Text) > 4 || Convert.ToInt32(textBox_bc_nv_nhap2.Text) < 1)
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                        return;
                    }
                    else
                    {
                        event_bc_nv_TheoQuy();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                }
            }
        }
        // NHÓM HÀM TABPAGE NHÂN VIÊN
        // nhóm hàm tabpage phân công
        private void load_tabp_phancong(object sender, EventArgs e)
        {
            (sender as Form).Close();
            this.load_tabpage_phancong();
        }
        void load_tabpage_phancong()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT CT_LAMVIEC.NVID, HOTEN, CV, CAID, CHEDO FROM CT_LAMVIEC INNER JOIN NHANVIEN ON CT_LAMVIEC.NVID = NHANVIEN.NVID WHERE NGAYLAM = '" + mon_nv_phancong_lich.SelectionRange.Start.ToString("d") + "' "
                                + "UNION "
                                + "SELECT CT_LAMVIEC_HANGTUAN.NVID, HOTEN, CV, CT_LAMVIEC_HANGTUAN.CAID, CHEDO = 'Lap lai' "
                                + "FROM CT_LAMVIEC_HANGTUAN, NHANVIEN, CALAMVIEC "
                                + "WHERE CT_LAMVIEC_HANGTUAN.NVID = NHANVIEN.NVID AND CT_LAMVIEC_HANGTUAN.CAID = CALAMVIEC.CAID AND THU = '"+mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek.ToString()+"' "
                                + "order by NVID";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            lbl_nv_phancong_lich.Text = mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek.ToString();
            dgv_nv_phancong_lich.Rows.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgv_nv_phancong_lich.Rows.Add(table.Rows[i]["NVID"], table.Rows[i]["HOTEN"], table.Rows[i]["CV"], false, false, false, table.Rows[i]["CHEDO"]);
                string NVID = table.Rows[i]["NVID"].ToString();

                while (table.Rows[i]["NVID"].ToString() == NVID)
                {
                    switch (table.Rows[i]["CAID"].ToString().Substring(2))
                    {
                        case "S":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count - 2].Cells[3].Value = true;
                            break;
                        case "C":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count - 2].Cells[4].Value = true;
                            break;
                        case "T":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count - 2].Cells[5].Value = true;
                            break;
                    }

                    i++;
                    if (i >= table.Rows.Count)
                        return;
                }
                i--;
            }

            sqlCon.Close();
        }
        void tao_datgridview_lich_lamviec()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT GIO_BD, GIO_NGHI FROM CALAMVIEC WHERE THU = '" + mon_nv_phancong_lich.SelectionStart.DayOfWeek.ToString() + "' ORDER BY GIO_NGHI";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            // tạo bảng dữ liệu.
            DataGridViewTextBoxColumn dgvID = new DataGridViewTextBoxColumn();
            dgvID.HeaderText = "Mã nhân viên";
            DataGridViewTextBoxColumn dgvTen = new DataGridViewTextBoxColumn();
            dgvTen.HeaderText = "Họ tên";
            DataGridViewTextBoxColumn dgvChucvu = new DataGridViewTextBoxColumn();
            dgvChucvu.HeaderText = "Chức vụ";

            DataGridViewCheckBoxColumn dgvSang = new DataGridViewCheckBoxColumn();
            dgvSang.HeaderText = "Ca sáng(" + table1.Rows[0]["GIO_BD"] + " - " + table1.Rows[0]["GIO_NGHI"] + ")";
            DataGridViewCheckBoxColumn dgvChieu = new DataGridViewCheckBoxColumn();
            dgvChieu.HeaderText = "Ca chiều(" + table1.Rows[1]["GIO_BD"] + " - " + table1.Rows[1]["GIO_NGHI"] + ")";
            DataGridViewCheckBoxColumn dgvToi = new DataGridViewCheckBoxColumn();
            dgvToi.HeaderText = "Ca tối(" + table1.Rows[2]["GIO_BD"] + " - " + table1.Rows[2]["GIO_NGHI"] + ")";

            DataGridViewTextBoxColumn dgvChedo = new DataGridViewTextBoxColumn();
            dgvChedo.HeaderText = "Chế độ";


            dgv_nv_phancong_lich.Columns.AddRange(dgvID, dgvTen, dgvChucvu, dgvSang, dgvChieu, dgvToi, dgvChedo);
            sqlCon.Close();
        }
        private void tab_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_nv.SelectedIndex == 0)
            {

            }
            else if (tab_nv.SelectedIndex == 1)
            {

                load_tabpage_phancong();
            }
        }

        private void mon_nv_phancong_lich_DateChanged(object sender, DateRangeEventArgs e)
        {
            load_tabpage_phancong();
        }

        private void btn_nv_phancong_luu_Click(object sender, EventArgs e)
        {
            if (mon_nv_phancong_lich.SelectionRange.Start < DateTime.Today)
                return;
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "DELETE FROM CT_LAMVIEC WHERE NGAYLAM = '" + mon_nv_phancong_lich.SelectionRange.Start.ToString() + "'";
            cmd.ExecuteNonQuery();
            for (int i = 0; i < dgv_nv_phancong_lich.Rows.Count - 1; i++)
            {
                if (dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() == "Lap lai")
                {
                    if (dgv_nv_phancong_lich.Rows[i].Cells[3].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "S')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[4].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "C')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[5].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "T')";
                        MessageBox.Show(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (dgv_nv_phancong_lich.Rows[i].Cells[3].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "S', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString() + "', null, '" + dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[4].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "C', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString() + "', null, '" + dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[5].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "T', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString() + "', null, '" + dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() + "')";
                        MessageBox.Show(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            sqlCon.Close();
        }
        private void btn_nv_phancong_xoa_Click(object sender, EventArgs e)
        {
            if(mon_nv_phancong_lich.SelectionRange.Start <DateTime.Today)
            {
                MessageBox.Show("Bạn không thể xóa lịch trong quá khứ", "Thông báo");
            }    
            dgv_nv_phancong_lich.Rows.RemoveAt(dgv_nv_phancong_lich.CurrentRow.Index);
        }
        private void btn_nv_phancong_them_Click(object sender, EventArgs e)
        {
            Form_nv_phancong_themlich Frm = new Form_nv_phancong_themlich();
            Frm.Load_frm_main += load_tabp_phancong;
            Frm.ShowDialog();
        }

        private void btn_nv_phancong_tuan_Click(object sender, EventArgs e)
        {
            Form_lichhangtuan frm = new Form_lichhangtuan();
            frm.Load_form_main += load_tabp_phancong;
            frm.ShowDialog();
        }
        //

        // TabPage_Đối tác
        public void DTCC_dtgd_dataInitialize()
        {
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "Select * from DTCC";
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_DTCC.DataSource = Table;
            button_modDTCC.Enabled = false;
            button_deleteDTCC.Enabled = false;
            sqlCon.Close();
        }
        public void DTCC_guest_dataInitialize()
        {
            SqlCommand cmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "Select * from KHACHHANG";
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_dtcc_guest.DataSource = Table;
            button_guest_mod.Enabled = false;
            button_guest_delete.Enabled = false;
            sqlCon.Close();
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
            if (Result == DialogResult.Yes)
            {
                string str;
                str = "delete from DTCC where DTID = '" + label_IDtext.Text + "'";
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand newcmd = new SqlCommand(str, sqlCon);
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
            if (comboBox_searchOption.Text == "Chưa chọn")
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
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = str;
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_DTCC.DataSource = Table;
            button_modDTCC.Enabled = false;
            button_deleteDTCC.Enabled = false;
            sqlCon.Close();
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
                if (string.IsNullOrEmpty(loaiKH) != true)
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
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand newcmd = new SqlCommand(str, sqlCon);
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
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = str;
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_dtcc_guest.DataSource = Table;
            button_guest_mod.Enabled = false;
            button_guest_delete.Enabled = false;
            sqlCon.Close();
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
        //
        // TabPage Giao dịch
        //
        private void BNT_TaoHoaDon_Click(object sender, EventArgs e)
        {
            Form_GiaoDich F_GD = new Form_GiaoDich(manv);
            F_GD.Show();

        }

        private void BNT_Refresh_GD_Click(object sender, EventArgs e)
        {
            this.Refresh_data_GD();
        }

        private void Refresh_data_GD()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd.CommandText = "select * from HDBH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();
            CLB_GD_TrangThai.SetItemChecked(0, true);
            CLB_GD_TrangThai.SetItemChecked(1, true);
            CLB_GD_TrangThai.SetItemChecked(2, true);
            CLB_GD_LoaiDon.SetItemChecked(0, true);
            CLB_GD_LoaiDon.SetItemChecked(1, true);
            Box_GD_MaHoaDon.Text = "";
            Box_GD_MaKhachHang.Text = "";
            BOX_GD_MaNhanVien.Text = "";
        }

        private void bnt_Timkiem_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd.CommandText = "select * from HDBH where (SOHD_BH like '%" + Box_GD_MaHoaDon.Text + "%' and KHID like '%" + Box_GD_MaKhachHang.Text + "%'AND NVID like '%" + BOX_GD_MaNhanVien.Text + "%'  ";
            if (CLB_GD_LoaiDon.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and LOAIHD != 'DDH'";
            }
            if (CLB_GD_LoaiDon.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and LOAIHD != 'DTT'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'NHANDON'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'DANGGIAO'";
            }

            if (CLB_GD_TrangThai.CheckedIndices.Contains(2) == false)
            {
                cmd.CommandText += " and TRANGTHAI != 'HOANTAT'";
            }

            cmd.CommandText += ") ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();
        }

        private void GridView_Data_GiaoDich_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_CTHD cthd = new Form_CTHD((string)GridView_Data_GiaoDich.CurrentRow.Cells[0].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[2].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[3].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[5].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[6].Value, Convert.ToString(GridView_Data_GiaoDich.CurrentRow.Cells[4].Value));
            cthd.Show();
        }

        Bitmap bmp;
        private void bnt_inDS_Click(object sender, EventArgs e)
        {
            int height = GridView_Data_GiaoDich.Height;
            GridView_Data_GiaoDich.Height = GridView_Data_GiaoDich.RowCount * GridView_Data_GiaoDich.RowTemplate.Height + 2 * GridView_Data_GiaoDich.RowTemplate.Height;
            GridView_Data_GiaoDich.CurrentRow.Selected = false;
            bmp = new Bitmap(GridView_Data_GiaoDich.Width, GridView_Data_GiaoDich.Height);
            GridView_Data_GiaoDich.DrawToBitmap(bmp, new Rectangle(0, 0, GridView_Data_GiaoDich.Width, GridView_Data_GiaoDich.Height));
            GridView_Data_GiaoDich.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_GD(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 30, 0);
        }
        //TabPage Hàng hóa
        public void LoadHangHoa()
        {

            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCon.Open();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP where SANPHAM.LOAIID = LOAISP.LOAIID ";
            sqlCmd.Connection = sqlCon;
            adapter = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable tbHH = new DataTable();
            tbHH.Clear();
            adapter.Fill(tbHH);
            dgvSP.DataSource = tbHH;
            DinhDangdgvHH();
            lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
            sqlCon.Close();
        }
        public void DinhDangdgvHH()
        {
            dgvSP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSP.Columns[0].Width = 60;
            dgvSP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSP.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgvSP.Columns[3].HeaderText = "Nước Sản Xuất";
            dgvSP.Columns[3].Width = 80;
            dgvSP.Columns[4].HeaderText = "Giá Bán";
            dgvSP.Columns[5].HeaderText = "Giá Nhập";
            dgvSP.Columns[6].HeaderText = "Đơn Vị Tính";
            dgvSP.Columns[6].Width = 50;
            dgvSP.Columns[7].HeaderText = "Số Lượng";
            dgvSP.Columns[7].Width = 50;
            dgvSP.Columns[8].HeaderText = "Số Lượng Tối Thiểu";
            dgvSP.Columns[8].Width = 50;
            dgvSP.Columns[9].HeaderText = "Mô Tả";
        }
        private void dgvSP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XemChiTiet();
        }
        private void XemChiTiet()

        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xem chi tiết");
                return;
            }
            Form_ChiTietHH f = new Form_ChiTietHH(dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["TENLOAI"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQuanLiHH_Click(object sender, EventArgs e)
        {
            Form_QuanLiHH f = new Form_QuanLiHH();
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();
        }
        private void btnQLKho_Click(object sender, EventArgs e)
        {
            Form_QLKho f = new Form_QLKho();
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();
        }
    }
}