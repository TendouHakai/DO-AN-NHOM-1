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

namespace App_sale_manager
{
    public partial class Form_main_admin : Form
    {
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=DESKTOP-7DBJ8OV;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        bool canExit;
        public Form_main_admin()
        {
            InitializeComponent();
            canExit = true;
        }
        public event EventHandler Thoat;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            canExit = false;
            Thoat(this, new EventArgs());
        }
        private void Form_main_admin_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
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
            cmd.CommandText = "SELECT COUNT(SOHD_BH) as SoHoaDon, SUM(TRIGIA) as DoanhThu FROM HDBH WHERE lOAIHD = 'DTT' AND NGHD ='"+day+"'";
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
            cmd.CommandText = "SELECT NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)="+date.Month+" GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)="+date.Month+" GROUP BY NGNHAP) AS K GROUP BY NGAY";
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
            for (int i =0; i< table.Rows.Count; i++)
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
            for (int i =4; i>=0; i--)
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
            cmd.CommandText = "SELECT NHANVIEN.HOTEN, HDBH.SOHD_BH, NGHD, TRIGIA, LOAIHD FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID WHERE NGHD>='"+date.AddDays(-5).ToString("d")+"' ORDER BY NGHD DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            listView_hanhdong.Clear();
            for(int i = 0; i<table.Rows.Count; i++)
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
        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrl.SelectedIndex==0)
            {
                load_tab_Tongquan();
            } 
            else if(tabCtrl.SelectedIndex==5)
            {
                tabControl_Baocao.SelectedIndex = 0;
                tabControl_Baocao_SelectedIndexChanged(tabControl_Baocao, new EventArgs());
                
            }    
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
            if(table1.Rows.Count==0)
            {
                textBox_bcCuoingay1.Text = "0";
                textBox_bcCuoingay2.Text = "0";
            }    
            else if(table1.Rows.Count==1)
                textBox_bcCuoingay1.Text = table1.Rows[0]["TONGTIEN"].ToString();
            else
            {
                textBox_bcCuoingay1.Text = table1.Rows[0]["TONGTIEN"].ToString();
                textBox_bcCuoingay2.Text = table1.Rows[1]["TONGTIEN"].ToString();
            }
            cmd.CommandText = "SELECT SUM(TRIGIA) AS TONG FROM HDBH WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='Da thanh toan')) AND NGHD='"+day+"'";
            adapter.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            table2.Clear();
            adapter.Fill(table2);
            label_bcCuoingay2.Show();
            label_bcCuoingay3.Show();
            textBox_bcCuoingay2.Show();
            textBox_bcCuoingay3.Show();
            if(table2.Rows[0]["TONG"].ToString()=="")
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
            cmd.CommandText = "SELECT * FROM HDNH WHERE NGNHAP= '"+day+"'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT SUM(TRIGIA) AS TONG FROM HDNH WHERE NGNHAP= '" + day+"'";
            adapter.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            label_bcCuoingay1.Text = "Tong Chi";
            label_bcCuoingay2.Hide();
            label_bcCuoingay3.Hide();
            textBox_bcCuoingay2.Hide();
            textBox_bcCuoingay3.Hide();
            if(table1.Rows[0]["TONG"].ToString()=="")
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
            cmd.CommandText = "SELECT SOHD_BH AS SOHD, NGHD, KHID AS DOITAC, NVID, TRIGIA FROM HDBH WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND NGHD = '"+day+"' UNION SELECT* FROM HDNH WHERE NGNHAP = '"+day+"'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_bc_cuoingay.DataSource = table;
            cmd.CommandText = "SELECT (THU-CHI) AS DOANHTHU FROM (SELECT SUM(THU) AS THU, SUM(CHI) AS CHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND NGHD='"+day+"' GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE NGNHAP='"+day+"' GROUP BY NGNHAP) AS K) AS H";
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
            if(rBtn_bc_qt1.Checked)
            {
                event_Cuoingay_radio1();
            }  
            else if (rBtn_bc_qt2.Checked)
            {
                event_Cuoingay_radio2();
            }  
            else if(rBtn_bc_qt3.Checked)
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
            cmd.CommandText = "SELECT DAY(NGAY) AS NGAY, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)=" + comboBox_bc_Doanhthu_nhap1.Text + " AND YEAR(NGHD)="+textBox_bc_DoanhThu_nhap2.Text+" GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)=" + comboBox_bc_Doanhthu_nhap1.Text + "AND YEAR(NGNHAP)="+textBox_bc_DoanhThu_nhap2.Text+" GROUP BY NGNHAP) AS K GROUP BY DAY(NGAY)";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_Doanhthu.Titles["Title_chart_bc_Doanhthu"].Text = "Biểu đồ doanh thu tháng " + comboBox_bc_Doanhthu_nhap1.Text + " năm " + textBox_bc_DoanhThu_nhap2.Text;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Maximum = DateTime.DaysInMonth(Convert.ToInt32(textBox_bc_DoanhThu_nhap2.Text),Convert.ToInt32(comboBox_bc_Doanhthu_nhap1.Text))+1;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart_bc_Doanhthu.Series["Series_Thu"].Points.Clear();
            chart_bc_Doanhthu.Series["Series_Chi"].Points.Clear();
            for(int i =0; i<table.Rows.Count; i++)
            {
                chart_bc_Doanhthu.Series["Series_Thu"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGTHU"]);
                chart_bc_Doanhthu.Series["Series_Chi"].Points.AddXY(table.Rows[i]["NGAY"], table.Rows[i]["TONGCHI"]);
            }
            cmd.CommandText = "SELECT SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT NGHD AS NGAY, SUM(HDBH.TRIGIA) AS THU, CHI = NULL FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD)="+comboBox_bc_Doanhthu_nhap1.Text+" AND YEAR(NGHD)="+textBox_bc_DoanhThu_nhap2.Text+" GROUP BY NGHD UNION SELECT NGNHAP AS NGAY, THU = NULL, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP)="+comboBox_bc_Doanhthu_nhap1.Text+" AND YEAR(NGNHAP)="+textBox_bc_DoanhThu_nhap2.Text+" GROUP BY NGNHAP) AS K ";
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
            cmd.CommandText = "SELECT THANG, SUM(THU) AS TONGTHU, SUM(CHI) AS TONGCHI FROM( SELECT MONTH(NGHD) AS THANG, SUM(HDBH.TRIGIA) AS THU, CHI = 0 FROM HDBH WHERE (LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'Da thanh toan')) AND MONTH(NGHD) BETWEEN ("+Quy*3+"-2) AND "+Quy*3+" GROUP BY MONTH(NGHD) UNION SELECT MONTH(NGNHAP), THU = 0, SUM(HDNH.TRIGIA) AS CHI FROM HDNH WHERE MONTH(NGNHAP) BETWEEN ("+Quy*3+" -2) AND "+Quy*3+" GROUP BY NGNHAP) AS K GROUP BY THANG";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_bc_Doanhthu.Titles["Title_chart_bc_Doanhthu"].Text = "Biểu đồ doanh thu quý " + comboBox_bc_Doanhthu_nhap1.Text;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Minimum = Quy * 3 - 3;
            chart_bc_Doanhthu.ChartAreas["ChartArea1"].AxisX.Maximum = Quy * 3+1;
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
            if(comboBox_bc_Doanhthu_kieutinh.SelectedIndex==0)
            {
                label_bc_Doanhthu_nhap1.Text = "Nhập tháng";
                DateTime date = DateTime.Today;
                comboBox_bc_Doanhthu_nhap1.Items.Clear();
                comboBox_bc_Doanhthu_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                comboBox_bc_Doanhthu_nhap1.Text = date.Month.ToString();
                textBox_bc_DoanhThu_nhap2.Text = date.Year.ToString();
                event_bc_DoanhThu_TheoThang();
            } 
            else if(comboBox_bc_Doanhthu_kieutinh.SelectedIndex==1)
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
            if(comboBox_bc_Doanhthu_kieutinh.SelectedIndex==0)
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
                catch(Exception)
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
                }     
            }
            else if(comboBox_bc_Doanhthu_kieutinh.SelectedIndex ==1)
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
            cmd.CommandText = "SELECT HDBH.NVID AS MANV, SUM(TRIGIA)AS DOANHSO, HOTEN FROM HDBH inner join NHANVIEN on HDBH.NVID=NHANVIEN.NVID WHERE (LOAIHD='DTT' OR (LOAIHD='DDH' AND TRANGTHAI='Da thanh toan')) AND MONTH(NGHD)="+comboBox_bc_nv_nhap1.Text+" GROUP BY HDBH.NVID, HOTEN ORDER BY DOANHSO DESC";
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
                i = table.Rows.Count-1;
            }
            for (; i>=0; i--)
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
            if(table.Rows.Count==0)
            {
                textBox_bc_nv_kq1.Text = "0";
                textBox_bc_nv_kq2.Text = "0";
                textBox_bc_nv_kq3.Text = "0";
                return;
            }
            int i=4;
            if(table.Rows.Count<5)
            {
                i = table.Rows.Count-1;
            }    
            for(; i>=0; i--)
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
            if(comboBox_bc_Nv_kieutinh.SelectedIndex==0)
            {
                label_bc_nv_nhap1.Text = "Nhập tháng";
                DateTime date = DateTime.Today;
                comboBox_bc_nv_nhap1.Items.Clear();
                comboBox_bc_nv_nhap1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                comboBox_bc_nv_nhap1.Text = date.Month.ToString();
                textBox_bc_nv_nhap2.Text = date.Year.ToString();
                event_bc_nv_TheoThang();
            }    
            else if(comboBox_bc_Nv_kieutinh.SelectedIndex==1)
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
            cmd.CommandText = "SELECT CT_LAMVIEC.NVID, HOTEN, CV, CAID, CHEDO FROM CT_LAMVIEC INNER JOIN NHANVIEN ON CT_LAMVIEC.NVID = NHANVIEN.NVID WHERE NGAYLAM = '"+mon_nv_phancong_lich.SelectionRange.Start.ToString("d")+"' "
                                +"UNION "
                                +"SELECT CT_LAMVIEC_HANGTUAN.NVID, HOTEN, CV, CT_LAMVIEC_HANGTUAN.CAID, CHEDO = 'Lap lai' "
                                +"FROM CT_LAMVIEC_HANGTUAN, NHANVIEN, CALAMVIEC "
                                +"WHERE CT_LAMVIEC_HANGTUAN.NVID = NHANVIEN.NVID AND CT_LAMVIEC_HANGTUAN.CAID = CALAMVIEC.CAID AND THU = 'Wednesday' "
                                +"order by NVID";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            lbl_nv_phancong_lich.Text = mon_nv_phancong_lich.SelectionRange.Start.DayOfWeek.ToString();
            dgv_nv_phancong_lich.Rows.Clear();
            
            for(int i =0; i<table.Rows.Count; i++)
            {
                dgv_nv_phancong_lich.Rows.Add(table.Rows[i]["NVID"], table.Rows[i]["HOTEN"], table.Rows[i]["CV"], false, false, false, table.Rows[i]["CHEDO"]);
                string NVID = table.Rows[i]["NVID"].ToString();
                
                while(table.Rows[i]["NVID"].ToString()==NVID)
                {
                    switch (table.Rows[i]["CAID"].ToString().Substring(2))
                    {
                        case "S":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count-2].Cells[3].Value = true;
                            break;
                        case "C":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count-2].Cells[4].Value = true;
                            break;
                        case "T":
                            dgv_nv_phancong_lich.Rows[dgv_nv_phancong_lich.Rows.Count-2].Cells[5].Value = true;
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
            if(tab_nv.SelectedIndex==0)
            {

            }   
            else if(tab_nv.SelectedIndex==1)
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
            cmd.CommandText = "DELETE FROM CT_LAMVIEC WHERE NGAYLAM = '" + mon_nv_phancong_lich.SelectionRange.Start.ToString()+"'";
            cmd.ExecuteNonQuery();
            for(int i =0; i<dgv_nv_phancong_lich.Rows.Count-1; i++)
            {
                if(dgv_nv_phancong_lich.Rows[i].Cells[6].Value.ToString()=="Lap lai")
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
    }
}
