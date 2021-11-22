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
using System.Text.RegularExpressions;
using System.Configuration;

namespace App_sale_manager
{
    public partial class Form_main_admin : Form
    {
        public string filepath = "";
        string manv = string.Empty;
        string tennv = string.Empty;
        SqlConnection sqlCon = null;
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        bool canExit;      
        DataTable table = new DataTable();
        DataTable table_nv_bangluong = new DataTable();

        DataTable table_nv_infonv = new DataTable();
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
            button_refresh.BackgroundImage = Image.FromFile(@"Image samples for testing\Đối tác giao dịch\refresh.jpg");
        }
        public Form_main_admin(string manv,string tennv)
        {
            this.manv = manv;
            this.tennv = tennv;
            sqlCon = new SqlConnection(strCon);
            cmd = sqlCon.CreateCommand();
            InitializeComponent();
            DTCC_dtgd_dataInitialize();
            DTCC_guest_dataInitialize();
            canExit = true;
            pictureBox_Logo.Image = Image.FromFile(@"Image samples for testing\Đối tác giao dịch\No Image.jpg");
            pictureBox_dtcc_guestFace.Image = Image.FromFile(@"Image samples for testing\\Khách hàng đăng kí\No Image.jpg");
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
                LoadCBBHH();
                LoadHangHoa();
            }
            else if(tabCtrl.SelectedIndex==4)
            {
                LoadData_nv_infonv();
                LoadData_nv_bangluong();
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
            string day = date.ToString("MM/dd/yyyy");
            cmd.CommandText = "SELECT COUNT(SOHD_BH) as SoHoaDon, SUM(TRIGIA) as DoanhThu FROM HDBH WHERE lOAIHD = 'DTT' AND NGHD ='" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            txtSoHD.Text = table.Rows[0]["SoHoaDon"].ToString();
            if (table.Rows[0]["DoanhThu"].ToString() == "")
                txtTrigiaHD.Text = "0";
            else
                txtTrigiaHD.Text = String.Format("{0:0,0}", Convert.ToDouble(table.Rows[0]["DoanhThu"]));
            sqlCon.Close();
        }
        void load_gv_DonDatHang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            string day = date.ToString("MM/dd/yyyy");
            cmd.CommandText = "SELECT COUNT(SOHD_BH) as SoDonDatHang, SUM(TRIGIA) as DoanhThu FROM HDBH WHERE LOAIHD = 'DDH'AND NGHD ='" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            txtSoDDH.Text = table.Rows[0]["SoDonDatHang"].ToString();
            if (table.Rows[0]["DoanhThu"].ToString() == "")
                txtTrigiaDDH.Text = "0";
            else
                txtTrigiaDDH.Text = String.Format("{0:0,0}", Convert.ToDouble(table.Rows[0]["DoanhThu"].ToString()));
            sqlCon.Close();
        }
        void load_chart_doanhthuthang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)=" + date.Month + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + date.Month + " GROUP BY NGNHAP) AS K GROUP BY NGAY";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_doanhthuthang.DataSource = table;
            chart_doanhthuthang.Titles["Title1"].Text = "Doanh thu tháng " + date.Month + "";
            chart_doanhthuthang.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_doanhthuthang.ChartAreas["ChartArea1"].AxisY.Title = "Triệu";
            chart_doanhthuthang.Series["Series_Thu"].Points.Clear();
            chart_doanhthuthang.Series["Series_Chi"].Points.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_doanhthuthang.Series["Series_Thu"].Points.AddXY(table.Rows[i]["NGAY"], (Convert.ToDouble(table.Rows[i]["TONGTHU"]) / 1000000));
                chart_doanhthuthang.Series["Series_Chi"].Points.AddXY(table.Rows[i]["NGAY"], (Convert.ToDouble(table.Rows[i]["TONGCHI"]) / 1000000));
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
            chart_hangbanchay.ChartAreas["ChartArea1"].AxisY.Title = " Triệu";
            chart_hangbanchay.Series["Series_hanghoa"].Points.Clear();
            int j = 4;
            if(table.Rows.Count<=4)
            {
                j = table.Rows.Count-1;
            }    
            for (int i = j; i >= 0; i--)
            {
                chart_hangbanchay.Series["Series_hanghoa"].Points.AddXY(table.Rows[i]["SPID"], (Convert.ToDouble(table.Rows[i]["DOANHTHU"]) / 1000000));
            }
            sqlCon.Close();
        }
        void load_list_hanhdong()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT NHANVIEN.HOTEN, HDBH.SOHD_BH, NGHD, TRIGIA, LOAIHD FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID WHERE NGHD>='" + date.AddDays(-5).ToString("MM/dd/yyyy") +"'"
                            + " UNION"
                            + " SELECT NHANVIEN.HOTEN, HDNH.SOHD_NH, NGNHAP, TRIGIA, LOAIHD = 'DNH' FROM HDNH INNER JOIN NHANVIEN ON HDNH.NVID = NHANVIEN.NVID WHERE NGNHAP>='" + date.AddDays(-5).ToString("MM/dd/yyyy") + "'"
                            + " ORDER BY NGHD DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            listView_hanhdong.Clear();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string Trigia = String.Format("{0:0,0}", Convert.ToInt32(table.Rows[i]["TRIGIA"]));
                if (table.Rows[i]["LOAIHD"].Equals("DTT"))
                    listView_hanhdong.Items.Add("- " + table.Rows[i]["HOTEN"] + " vừa bán được 1 đơn hàng " + table.Rows[i]["SOHD_BH"] + " trị giá " + Trigia + " vào ngày " + table.Rows[i]["NGHD"]);
                else if(table.Rows[i]["LOAIHD"].Equals("DDH"))
                    listView_hanhdong.Items.Add("- " + table.Rows[i]["HOTEN"] + " vừa bán được 1 đơn đặt hàng " + table.Rows[i]["SOHD_BH"] + " trị giá " + Trigia + " vào ngày " + table.Rows[i]["NGHD"]);
                else
                    listView_hanhdong.Items.Add("- " + table.Rows[i]["HOTEN"] + " vừa nhập 1 đơn hàng " + table.Rows[i]["SOHD_BH"] + " trị giá " + Trigia + " vào ngày " + table.Rows[i]["NGHD"]);
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
            string day = dtp_bc_time.Value.ToString("MM/dd/yyyy");
            cmd.CommandText = "SELECT SOHD_BH AS 'Số hóa đơn', NGHD as 'Ngày mua', KHID as 'Mã khách hàng', NVID as 'Mã nhân viên', REPLACE(CONVERT(varchar(20), TRIGIA, 1), '.00', '') as 'Trị giá', LOAIHD as 'Loại hóa đơn', TRANGTHAI as 'Trạng thái' FROM HDBH WHERE HDBH.NGHD='" + day + "' ORDER BY HDBH.LOAIHD DESC";
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
                textBox_bcCuoingay1.Text = Convert.ToDouble(table1.Rows[0]["TONGTIEN"]).ToString();
            else
            {
                textBox_bcCuoingay1.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[0]["TONGTIEN"]).ToString()); 
                textBox_bcCuoingay2.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[1]["TONGTIEN"]).ToString());
            }
            cmd.CommandText = "SELECT SUM(TRIGIA) AS TONG FROM HDBH WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='HOANTAT')) AND NGHD='" + day + "'";
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
                textBox_bcCuoingay3.Text = String.Format("{0:0,0}", Convert.ToDouble(table2.Rows[0]["TONG"]).ToString());
            }

            sqlCon.Close();
        }
        void event_Cuoingay_radio2()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            string day = dtp_bc_time.Value.ToString("MM/dd/yyyy");
            cmd.CommandText = "SELECT SOHD_NH as 'Số hóa đơn', NGNHAP as 'Ngày nhập', DTID as 'Mã đối tác', NVID as 'Mã nhân viên', REPLACE(CONVERT(varchar(20), TRIGIA, 1), '.00', '') as 'Trị giá' FROM HDNH WHERE NGNHAP= '" + day + "'";
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
                textBox_bcCuoingay1.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[0]["TONG"]));
            }
            sqlCon.Close();
        }
        void event_Cuoingay_radio3()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            string day = dtp_bc_time.Value.ToString("MM/dd/yyyy");
            cmd.CommandText = "SELECT SOHD_BH AS SOHD, NGHD, KHID AS DOITAC, NVID, TRIGIA FROM HDBH WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND NGHD = '" + day + "' UNION SELECT* FROM HDNH WHERE NGNHAP = '" + day + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT (THU-CHI) AS DOANHTHU FROM (SELECT SUM(THU) AS THU, SUM(CHI) AS CHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND NGHD='" + day + "' GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE NGNHAP='" + day + "' GROUP BY NGNHAP) AS K) AS H";
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
            else textBox_bcCuoingay1.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[0]["DOANHTHU"]));
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
            cmd.CommandText = "SELECT DAY(NGAY) AS NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + "AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K GROUP BY DAY(NGAY)";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_Doanhthu.Titles["Title_chart_bc_Doanhthu"].Text = "Biểu đồ doanh thu tháng " + comboBox_bc_Doanhthu_nhap1.Text + " năm " + textBox_bc_DoanhThu_nhap2.Text;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Maximum = DateTime.DaysInMonth(Convert.ToInt32(textBox_bc_DoanhThu_nhap2.Text), Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text)) + 1;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisY.Title = "Triệu";
            chart_bc_Doanhthu.Series["Series_Thu"].Points.Clear();
            chart_bc_Doanhthu.Series["Series_Chi"].Points.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_bc_Doanhthu.Series["Series_Thu"].Points.AddXY(table.Rows[i]["NGAY"], (Convert.ToDouble(table.Rows[i]["TONGTHU"])/1000000));
                chart_bc_Doanhthu.Series["Series_Chi"].Points.AddXY(table.Rows[i]["NGAY"], (Convert.ToDouble(table.Rows[i]["TONGCHI"])/1000000));
            }
            cmd.CommandText = "SELECT SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K ";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            if (table1.Rows[0]["TONGTHU"].ToString() == "")
                textBox_bc_Doanhthu_thu.Text = "0";
            else textBox_bc_Doanhthu_thu.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[0]["TONGTHU"]));
            if (table1.Rows[0]["TONGCHI"].ToString() == "")
                textBox_bc_Doanhthu_chi.Text = "0";
            else textBox_bc_Doanhthu_chi.Text = String.Format("{0:0,0}", Convert.ToDouble(table1.Rows[0]["TONGCHI"]));
            cmd.CommandText = "SELECT (TONGTHU-TONGCHI) AS DOANHTHU FROM (SELECT SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)=" + textBox_bc_DoanhThu_nhap2.Text + " UNION SELECT THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGNHAP)=" + textBox_bc_DoanhThu_nhap2.Text + " GROUP BY NGNHAP) AS K) AS H";
            adapter.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            table2.Clear();
            adapter.Fill(table2);
            if (table2.Rows[0]["DOANHTHU"].ToString() == "")
                textBox_bc_Doanhthu_doanhthu.Text = "0";
            else textBox_bc_Doanhthu_doanhthu.Text = String.Format("{0:0,0}", Convert.ToDouble(table2.Rows[0]["DOANHTHU"]));
            sqlCon.Close();
        }
        void event_bc_DoanhThu_TheoQuy()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            int Quy = Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text);
            cmd.CommandText = "SELECT THANG, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT MONTH(NGHD) AS THANG, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD) BETWEEN (" + Quy * 3 + "-2) AND " + Quy * 3 + " GROUP BY MONTH(NGHD) UNION SELECT MONTH(NGNHAP), THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP) BETWEEN (" + Quy * 3 + " -2) AND " + Quy * 3 + " GROUP BY NGNHAP) AS K GROUP BY THANG";
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
                chart_bc_Doanhthu.Series["Series_Thu"].Points.AddXY(table.Rows[i]["THANG"], (Convert.ToDouble(table.Rows[i]["TONGTHU"])/1000000));
                chart_bc_Doanhthu.Series["Series_Chi"].Points.AddXY(table.Rows[i]["THANG"], (Convert.ToDouble(table.Rows[i]["TONGCHI"])/1000000));
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
            cmd.CommandText = "SELECT HDBH.NVID AS MANV, SUM(TRIGIA)AS DOANHSO, HOTEN FROM HDBH inner join NHANVIEN on HDBH.NVID=NHANVIEN.NVID WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='HOANTAT')) AND MONTH(NGHD)=" + comboBox_bc_nv_nhap1.Text + " GROUP BY HDBH.NVID, HOTEN ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            chart_bc_nv.Titles["Title1"].Text = "Biểu đồ daonh số bán hàng nhân viên tháng " + comboBox_bc_nv_nhap1.Text;
            chart_bc_nv.ChartAreas["ChartArea1"].AxisX.Title = "Tên NV";
            chart_bc_nv.ChartAreas["ChartArea1"].AxisY.Title = "Triệu";
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
                chart_bc_nv.Series["Series1"].Points.AddXY(table.Rows[i]["HOTEN"], (Convert.ToDouble(table.Rows[i]["DOANHSO"])/1000000));
            }

            textBox_bc_nv_kq1.Text = table.Rows[0]["MANV"].ToString();
            textBox_bc_nv_kq2.Text = table.Rows[0]["HOTEN"].ToString();
            textBox_bc_nv_kq3.Text = String.Format("{0:0,0}", Convert.ToDouble(table.Rows[0]["DOANHSO"]));

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
            chart_bc_nv.ChartAreas["ChartArea1"].AxisY.Title = "Triệu";
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
                chart_bc_nv.Series["Series1"].Points.AddXY(table.Rows[i]["HOTEN"], (Convert.ToDouble(table.Rows[i]["DOANHSO"])/1000000));
            }
            textBox_bc_nv_kq1.Text = table.Rows[0]["MANV"].ToString();
            textBox_bc_nv_kq2.Text = table.Rows[0]["HOTEN"].ToString();
            textBox_bc_nv_kq3.Text = String.Format("{0:0,0}", Convert.ToDouble(table.Rows[0]["DOANHSO"]).ToString());

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
        private void tab_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_nv.SelectedIndex == 0)
            {

            }
            else if (tab_nv.SelectedIndex == 1)
            {

                load_tabpage_phancong();
            }
            else if(tab_nv.SelectedIndex==2)
            {

            }    
        }
        void LoadData_nv_infonv()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT NVID,HOTEN,SDT,NGVL,NGSINH,CV,USERNAME,PASSWD FROM NHANVIEN";
            adapter.SelectCommand = cmd;
            table_nv_infonv.Clear();
            adapter.Fill(table_nv_infonv);
            dgv_nv_infonv.DataSource = table_nv_infonv;
            sqlCon.Close();
        }

        void LoadData_nv_bangluong()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT NVID,HOTEN,LUONG,THUONG,HESO FROM NHANVIEN";
            adapter.SelectCommand = cmd;
            table_nv_bangluong.Clear();
            adapter.Fill(table_nv_bangluong);
            dgv_nv_bangluong.DataSource = table_nv_bangluong;
            sqlCon.Close();
        }
        // nhóm hàm tabpage danh mục nhân viên
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
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            try
            {
                cmd.CommandText = "set dateformat dmy " + "insert into NHANVIEN values('" + tb_MaNV_nv_infonv.Text + "',N'" + tb_TenNV_nv_infonv.Text + "','" + tb_SDT_nv_infonv.Text + "',' " + dt_NgayVaoLam_nv_infonv.Text + " ','" + dt_NgaySinh_nv_infonv.Text + "','" + 0 + "',N'" + tb_ChucVu_nv_infonv.Text + "',N'" + tb_username_nv_infonv.Text + "','" + tb_matkhau_nv_infonv.Text + "','" + 0 + "','" + 0 + "')";
                cmd.ExecuteNonQuery();
                SaveFileDialog Save = new SaveFileDialog();
                if (filepath != "")
                {
                    Save.FileName = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                    pictureBox_image_import_nv.Image.Save(Save.FileName);
                    filepath = "";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Nhập không đúng dữ liệu hoặc MANV đã có!");
            }
            LoadData_nv_infonv();
            LoadData_nv_bangluong();
            sqlCon.Close();
        }

        private void bt_nv_infonv_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                filepath = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                cmd = sqlCon.CreateCommand();
                cmd.CommandText = "delete from NHANVIEN where NVID='" + tb_MaNV_nv_infonv.Text + "'";
                cmd.ExecuteNonQuery();
                pictureBox_image_import_nv.Image = null;
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }
                filepath = "";
                LoadData_nv_infonv();
                LoadData_nv_bangluong();
                sqlCon.Close();
            }
        }

        private void bt_nv_infonv_Sua_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Sửa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                cmd = sqlCon.CreateCommand();
                try
                {
                    cmd.CommandText = "set dateformat dmy " + "update NHANVIEN set HOTEN=N'" + tb_TenNV_nv_infonv.Text + "',SDT='" + tb_SDT_nv_infonv.Text + "',NGVL='" + dt_NgayVaoLam_nv_infonv.Text + "',NGSINH='" + dt_NgaySinh_nv_infonv.Text + "',CV=N'" + tb_ChucVu_nv_infonv.Text + "',USERNAME=N'" + tb_username_nv_infonv.Text + "',PASSWD='" + tb_matkhau_nv_infonv.Text + "' where NVID='" + tb_MaNV_nv_infonv.Text + "'";
                    cmd.ExecuteNonQuery();
                    if (filepath != "")
                    {
                        SaveFileDialog Save = new SaveFileDialog();
                        Save.FileName = @"Image samples for testing\Nhân viên\" + tb_MaNV_nv_infonv.Text + ".jpg";
                        pictureBox_image_import_nv.Image.Save(Save.FileName);
                        filepath = "";
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Dữ liệu bạn sử không đúng!");
                }



                LoadData_nv_infonv();
                LoadData_nv_bangluong();
                sqlCon.Close();
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
                        catch (Exception)
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
        // nhóm hàm tabpage phân công
        private void event_load_tabp_phancong(object sender, EventArgs e)
        {
            (sender as Form).Close();
            this.load_tabpage_phancong();
        }
        void load_tabpage_phancong()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT CT_LAMVIEC.NVID, HOTEN, CV, CAID, TIEUDE, CHEDO FROM CT_LAMVIEC INNER JOIN NHANVIEN ON CT_LAMVIEC.NVID = NHANVIEN.NVID WHERE NGAYLAM = '" + mon_nv_phancong_lich.SelectionRange.Start.ToString("MM/dd/yyyy") + "' "
                                + "UNION "
                                + "SELECT CT_LAMVIEC_HANGTUAN.NVID, HOTEN, CV, CT_LAMVIEC_HANGTUAN.CAID, TIEUDE, CHEDO = N'Lặp lại' "
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
                dgv_nv_phancong_lich.Rows.Add(table.Rows[i]["NVID"], table.Rows[i]["HOTEN"], table.Rows[i]["CV"], false, false, false, table.Rows[i]["TIEUDE"], table.Rows[i]["CHEDO"]);
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
            dgvID.HeaderText = "Mã NV";
            dgvID.Frozen = true;
            dgvID.Width = 50;
            DataGridViewTextBoxColumn dgvTen = new DataGridViewTextBoxColumn();
            dgvTen.HeaderText = "Họ tên";
            dgvTen.Frozen = true;
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
        

        private void mon_nv_phancong_lich_DateChanged(object sender, DateRangeEventArgs e)
        {
            load_tabpage_phancong();
        }

        private void btn_nv_phancong_luu_Click(object sender, EventArgs e)
        {
            if (mon_nv_phancong_lich.SelectionRange.Start < DateTime.Today)
            {
                MessageBox.Show("Bạn không thể thay đổi lịch trong quá khứ");
                return;
            }
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "DELETE FROM CT_LAMVIEC WHERE NGAYLAM = '" + mon_nv_phancong_lich.SelectionRange.Start.ToString() + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM CT_LAMVIEC_HANGTUAN WHERE SUBSTRING(CAID,2,1)= '" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek)+"'";
            cmd.ExecuteNonQuery();
            for (int i = 0; i < dgv_nv_phancong_lich.Rows.Count - 1; i++)
            {
                if (dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() == "Lặp lại")
                {
                    if (dgv_nv_phancong_lich.Rows[i].Cells[3].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "S', N'Lịch làm việc hàng tuần')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[4].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "C', N'Lịch làm việc hàng tuần')";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[5].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC_HANGTUAN VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "T', N'Lịch làm việc hàng tuần')";
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (dgv_nv_phancong_lich.Rows[i].Cells[3].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "S', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString("d") + "', N'Chưa điểm danh', N'" + dgv_nv_phancong_lich.Rows[i].Cells[7].Value.ToString() + "',N'"+dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString()+"' )";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[4].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "C', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString("d") + "', N'Chưa điểm danh', N'" + dgv_nv_phancong_lich.Rows[i].Cells[7].Value.ToString() + "',N'" + dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() + "' )";
                        cmd.ExecuteNonQuery();
                    }
                    if (dgv_nv_phancong_lich.Rows[i].Cells[5].Value.ToString() == "True")
                    {
                        cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + dgv_nv_phancong_lich.Rows[i].Cells[0].Value.ToString() + "', 'C" + ((int)mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek).ToString() + "T', '" + mon_nv_phancong_lich.SelectionRange.Start.ToString("d") + "', N'Chưa điểm danh', N'" + dgv_nv_phancong_lich.Rows[i].Cells[7].Value.ToString() + "', N'" + dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            MessageBox.Show("Đã lưu thành công");
            sqlCon.Close();
        }
        private void btn_nv_phancong_xoa_Click(object sender, EventArgs e)
        {
            if(mon_nv_phancong_lich.SelectionRange.Start <=DateTime.Today)
            {
                MessageBox.Show("Bạn không thể xóa lịch trong quá khứ và ngày hôm nay", "Thông báo");
            }    
            dgv_nv_phancong_lich.Rows.RemoveAt(dgv_nv_phancong_lich.CurrentRow.Index);
        }
        private void btn_nv_phancong_them_Click(object sender, EventArgs e)
        {
            Form_nv_phancong_themlich Frm = new Form_nv_phancong_themlich();
            Frm.Load_frm_main += event_load_tabp_phancong;
            Frm.ShowDialog();
        }

        private void btn_nv_phancong_tuan_Click(object sender, EventArgs e)
        {
            Form_lichhangtuan frm = new Form_lichhangtuan();
            frm.Load_form_main += event_load_tabp_phancong;
            frm.ShowDialog();
        }
        private void btn_nv_phancong_chamcong_Click(object sender, EventArgs e)
        {
            Form_nv_phancong_chamcong frm = new Form_nv_phancong_chamcong();
            frm.ShowDialog();
        }
        //nhóm tabpage bảng lương nhân viên
        private void bt_Sua_nv_bangluong_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Sửa dữ liệu", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                cmd = sqlCon.CreateCommand();
                cmd.CommandText = "update NHANVIEN set LUONG='" + nud_Luong_nv_bangluong.Value.ToString() + "',HESO='" + float.Parse(nud_Heso_nv_bangluong.Value.ToString()) + "',THUONG='" + nud_Thuong_nv_bangluong.Value.ToString() + "' WHERE NVID='" + tb_MaNV_nv_bangluong.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData_nv_bangluong();
                sqlCon.Close();
            }
        }
        private void bt_Khoitao_nv_bangluong_Click(object sender, EventArgs e)
        {
            tb_MaNV_nv_bangluong.ReadOnly = false;
            tb_TenNV_nv_bangluong.ReadOnly = false;
            tb_MaNV_nv_bangluong.Text = "";
            tb_TenNV_nv_bangluong.Text = "";
            nud_Luong_nv_bangluong.Value = 0;
            nud_Heso_nv_bangluong.Value = 0;
            nud_Thuong_nv_bangluong.Value = 0;
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
                            MessageBox.Show("Vui lòng chọn miền lương cần lọc");
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
                        if (cb_LocLuong_nv_bangluong.Text == "Lọc")
                        {
                            MessageBox.Show("Vui lòng chọn miền lương cần lọc");
                            cb_LocLuong_nv_bangluong.Focus();
                        }
                        else
                        {
                            if (decimal.TryParse(tb_search_nv_bangluong.Text, out decimal result))
                            {
                                if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(0))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" HESO = '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(1))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" HESO > '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(2))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" HESO < '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                            }
                            else
                            {
                                MessageBox.Show("vui lòng nhập một số thập phân");
                                tb_search_nv_bangluong.Focus();
                            }
                        }
                        break;
                    }
                case "Thưởng":
                    {
                        if (cb_LocLuong_nv_bangluong.Text == "Lọc")
                        {
                            MessageBox.Show("Vui lòng chọn miền thưởng cần lọc");
                            cb_LocLuong_nv_bangluong.Focus();
                        }
                        else
                        {
                            if (decimal.TryParse(tb_search_nv_bangluong.Text, out decimal result))
                            {
                                if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(0))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" THUONG = '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(1))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" THUONG > '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                                else if (cb_LocLuong_nv_bangluong.SelectedIndex.Equals(2))
                                    (dgv_nv_bangluong.DataSource as DataTable).DefaultView.RowFilter = string.Format(" THUONG < '{0}'", Convert.ToDecimal(tb_search_nv_bangluong.Text));
                            }
                            else
                            {
                                MessageBox.Show("vui lòng nhập một số tiền");
                                tb_search_nv_bangluong.Focus();
                            }
                        }
                        break;
                    }
            }
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
            nud_Thuong_nv_bangluong.Value = Convert.ToDecimal(dgv_nv_bangluong.Rows[i].Cells[3].Value.ToString());
            nud_Heso_nv_bangluong.Value = Convert.ToDecimal(dgv_nv_bangluong.Rows[i].Cells[4].Value.ToString());

        }

        private void cb_searchoption_nv_bangluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_searchoption_nv_bangluong.Text == "Lương" || cb_searchoption_nv_bangluong.Text == "Hệ số" || cb_searchoption_nv_bangluong.Text == "Thưởng")
            {
                cb_LocLuong_nv_bangluong.Visible = true;
            }
            else
            {
                cb_LocLuong_nv_bangluong.Visible = false;
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            DTCC_modifier A = new DTCC_modifier();
            A.textBox_ID_z.Text = label_IDtext.Text;
            A.dateTimePicker_NGDT_z.Text = label_NGDTtext.Text;
            A.textBox_DIACHI_z.Text = label_DIACHItext.Text;
            A.textBox_SDT_z.Text = label_SDTtext.Text;
            A.textBox_TENDT_z.Text = label_TENDTtext.Text;
            using (FileStream stream = new FileStream(@"Image samples for testing\Đối tác giao dịch\" + label_TENDTtext.Text + ".jpg", FileMode.Open, FileAccess.Read))
            {
                A.pictureBox_image_import.Image = Image.FromStream(stream);
                stream.Dispose();
            }
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

        private void button_addDTCC_Click(object sender, EventArgs e)
        {
            DTCC_form A = new DTCC_form();
            A.RefreshData += DTCC_DataRefresh;
            A.Show();
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
                /*if(file.exists(@"\image samples for testing\đối tác giao dịch\"+label_tendttext.text+".jpg"))
                {
                    system.gc.collect();
                    system.gc.waitforpendingfinalizers();
                    file.delete(@"\image samples for testing\đối tác giao dịch\" + label_tendttext.text + ".jpg");
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
                case "Năm trở thành đối tác":
                    Search("Year(NGDT)");
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
            if (SearchOption=="NGDT")
            {
                cmd.CommandText = "set dateformat dmy";
                cmd.ExecuteNonQuery();
            }
            cmd.CommandText = str;
            Adapter.SelectCommand = cmd;
            Table.Clear();
            Adapter.Fill(Table);
            dataGridView_DTCC.DataSource = Table;
            button_modDTCC.Enabled = false;
            button_deleteDTCC.Enabled = false;
            sqlCon.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DTCC_dtgd_dataInitialize();
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
                case "Năm đăng kí":
                    Search_guest("Year(NGDK)");
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
            this.AcceptButton = button_searchDTCC;
        }

        private void textBox_guest_search_Click(object sender, EventArgs e)
        {
            textBox_guest_search.SelectAll();
        }

        private void button_sale_Click(object sender, EventArgs e)
        {
            Sale_viewer A = new Sale_viewer();
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
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.HANGSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP where SANPHAM.LOAIID = LOAISP.LOAIID ";
            sqlCmd.Connection = sqlCon;
            adapter = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable tbHH = new DataTable();
            tbHH.Clear();
            adapter.Fill(tbHH);
            dgvSP.DataSource = tbHH;
            HH_DinhDangdgv();
            lblTieuDeHH.Text = "Hàng Hoá Còn Lại";
            sqlCon.Close();
        }
        private void LoadCBBHH()
        {

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            adapter = new SqlDataAdapter("select TENLOAI from [LOAISP] group by TENLOAI", sqlCon);
            DataTable tableLoai = new DataTable();
            adapter.Fill(tableLoai);
            cbbLoaiSP.DataSource = tableLoai;
            cbbLoaiSP.DisplayMember = "TenLoai";
            cbbLoaiSP.ValueMember = "TenLoai";
            adapter = new SqlDataAdapter("select NUOCSX from [SANPHAM] group by NUOCSX", sqlCon);
            DataTable tableNuoc = new DataTable();
            adapter.Fill(tableNuoc);
            cbbNuocSX.DataSource = tableNuoc;
            cbbNuocSX.DisplayMember = "NUOCSX";
            cbbNuocSX.ValueMember = "NUOCSX";
            adapter = new SqlDataAdapter("select HANGSX from [SANPHAM] group by HANGSX", sqlCon);
            DataTable tableHang = new DataTable();
            adapter.Fill(tableHang);
            cbbHang.DataSource = tableHang;
            cbbHang.DisplayMember = "HANGSX";
            cbbHang.ValueMember = "HANGSX";           
            sqlCon.Close();
            HH_ClearCBBTB();
        }
        public void HH_ClearCBBTB()
        {
            cbbLoaiSP.Text = "";
            cbbHang.Text = "";
            cbbNuocSX.Text = "";
            cbbChonGia.Text = "";
            txtTenSP.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
        }
        public void HH_DinhDangdgv()
        {
            dgvSP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSP.Columns[0].Width = 60;
            dgvSP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSP.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgvSP.Columns[3].HeaderText = "Nước Sản Xuất";
            dgvSP.Columns[3].Width = 80;
            dgvSP.Columns[4].HeaderText = "Hãng";
            dgvSP.Columns[5].HeaderText = "Giá Bán";
            dgvSP.Columns[6].HeaderText = "Giá Nhập";
            dgvSP.Columns[7].HeaderText = "Đơn Vị Tính";
            dgvSP.Columns[7].Width = 50;
            dgvSP.Columns[8].HeaderText = "Số Lượng";
            dgvSP.Columns[8].Width = 50;
            dgvSP.Columns[9].HeaderText = "Số Lượng Tối Thiểu";
            dgvSP.Columns[9].Width = 50;
            dgvSP.Columns[10].HeaderText = "Mô Tả";
            for(int i=0;i<dgvSP.RowCount-1;i++)
            {
                
                    dgvSP.Rows[i].Cells["GIABAN"].Value = double.Parse(dgvSP.Rows[i].Cells["GIABAN"].Value.ToString());
                    dgvSP.Rows[i].Cells["GIANHAP"].Value = double.Parse(dgvSP.Rows[i].Cells["GIANHAP"].Value.ToString());
                   
            }    
        }
        private void XemChiTiet()

        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xem chi tiết");
                return;
            }
            Form_ChiTietHH f = new Form_ChiTietHH(dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["SOLUONG"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["HANGSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(), dgvSP.CurrentRow.Cells["TENLOAI"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
            f.Close();
            this.Show();
        }
        public DataTable HH_TimKiem()
        {
            DataTable tb = new DataTable();
            string query = string.Empty;
            if (txtGiaBan.Text != string.Empty)
            {
                switch (cbbChonGia.SelectedIndex)
                {
                    case 0:
                        {
                            query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                         " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%' and GIABAN = " + txtGiaBan.Text + " and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%'" + " and HANGSX Like N'%" + cbbHang.Text + "%')";
                            break;
                        }
                    case 1:
                        {
                            query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                               " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%' and GIABAN < " + txtGiaBan.Text + " and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%'" + " and HANGSX Like N'%" + cbbHang.Text + "%')";
                            break;

                        }
                    case 2:
                        {
                            query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                            " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%' and GIABAN > " + txtGiaBan.Text + " and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%'" + " and HANGSX Like N'%" + cbbHang.Text + "%')";
                            break;
                        }
                    default:
                        {
                            query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.HANGSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                                " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%'" + " and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%'" + " and HANGSX Like N'%" + cbbHang.Text + "%')";
                            break;
                        }
                }

            }
            else query = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.HANGSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP" +
                 " where (SANPHAM.LOAIID = LOAISP.LOAIID and LOAISP.TENLOAI like N'%" + cbbLoaiSP.Text + "%'" + " and  TENSP Like N'%" + txtTenSP.Text + "%' and NUOCSX Like N'%" + cbbNuocSX.Text + "%'" + " and HANGSX Like N'%" + cbbHang.Text + "%')";

            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(tb);
            sqlCon.Close();
            return tb;
        }
        private void dgvSP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XemChiTiet();
        }
           
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(1);
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để xoá");
                return;
            }
            DialogResult dar = MessageBox.Show("Xoá sản phẩm sẽ làm thông tin liên quan bị xoá.Ví dụ các hoá đơn.\nBạn có chắc chắn xoá ", "Chú ý", MessageBoxButtons.YesNo);
            if (dar == DialogResult.Yes)
            {
                string strquery = "delete CTHDNH where SPID in (select SPID from SANPHAM where LOAIID = '" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + "')" +
                              "delete CTHDBH where SPID in (select SPID from SANPHAM where LOAIID = '" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + "')" +
                              "delete from SANPHAM where SPID='" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + "'";
                FileInfo info = new FileInfo(@"..\..\HangHoa\" + dgvSP.CurrentRow.Cells["SPID"].Value.ToString() + ".jpg");
                info.Delete();
                SqlCommand sqlCmd = new SqlCommand(strquery, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                LoadHangHoa();
                MessageBox.Show("Đã xoá");
            }
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (dgvSP.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
                return;
            }
            Form_ThemSuaHangHoa f = new Form_ThemSuaHangHoa(2, dgvSP.CurrentRow.Cells["SPID"].Value.ToString(), dgvSP.CurrentRow.Cells["TENSP"].Value.ToString(), dgvSP.CurrentRow.Cells["NUOCSX"].Value.ToString(), dgvSP.CurrentRow.Cells["HANGSX"].Value.ToString(), dgvSP.CurrentRow.Cells["GIABAN"].Value.ToString(), dgvSP.CurrentRow.Cells["GIANHAP"].Value.ToString(), dgvSP.CurrentRow.Cells["SLTT"].Value.ToString(),  dgvSP.CurrentRow.Cells["DVT"].Value.ToString(), dgvSP.CurrentRow.Cells["TENLOAI"].Value.ToString(), dgvSP.CurrentRow.Cells["MoTa"].Value.ToString());
            this.Hide();
            f.ShowDialog();
            LoadHangHoa();
            this.Show();
        }
        private void btnQLLoaiHH_Click(object sender, EventArgs e)
        {
            Form_QLLoaiHH f = new Form_QLLoaiHH();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadHangHoa();
        }

        private void btnHangSapHet_Click(object sender, EventArgs e)
        {
            
            sqlCon = new SqlConnection(strCon);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select SANPHAM.SPID,SANPHAM.TENSP,LOAISP.TENLOAI,SANPHAM.NUOCSX,SANPHAM.HANGSX,SANPHAM.GIABAN,SANPHAM.GIANHAP,SANPHAM.DVT,SANPHAM.SOLUONG,SANPHAM.SLTT,SANPHAM.MOTA from SANPHAM,LOAISP where SANPHAM.LOAIID = LOAISP.LOAIID and SoLuong<SLTT";
            // gửi truy vấn tới kết nối.
            sqlCmd.Connection = sqlCon;
            adapter = new SqlDataAdapter(sqlCmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable tbHHSH = new DataTable();
            tbHHSH.Clear();
            adapter.Fill(tbHHSH);
            dgvSP.DataSource = tbHHSH;
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_HoaDonNH f = new Form_HoaDonNH(manv, tennv);            
            f.ShowDialog();
            this.Show();
            LoadHangHoa();
        }

        private void btnXemChiTietHH_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }
      
        private void cbbLoaiSP_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {  
                e.Handled = true;                
            }
            if(Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số");
            }    
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void cbbChonGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void cbbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void cbbNuocSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = HH_TimKiem();
            HH_DinhDangdgv();
        }

        private void btn_XemHH_Click(object sender, EventArgs e)
        { 
            HH_ClearCBBTB();
            LoadHangHoa();
           
        }

        private void cbbLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbNuocSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbChonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}