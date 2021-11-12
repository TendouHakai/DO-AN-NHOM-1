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
    public partial class Form_main_NV : Form
    {
        string NVID;
        string Ten;
        SqlConnection sqlCon = null;
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        bool canExit=true;
        public string nvid
        {
            set { NVID = value; }
        }    
        public Form_main_NV()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
        }
        public Form_main_NV(string NVID, string Ten)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            this.NVID = NVID;
            this.Ten = Ten;
        }
        public event EventHandler Thoat;

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            canExit = false;
            Thoat(this, new EventArgs());
        }
        private void Form_main_NV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (canExit == true)
                Application.Exit();
        }
        private void Form_main_NV_Load(object sender, EventArgs e)
        {
            tabctrl_Nhanvien_SelectedIndexChanged(this, new EventArgs());
        }
        // TABPAGE TỔNG QUAN.
        private void tabctrl_Nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabctrl_Nhanvien.SelectedIndex==0)
            {
                load_tongquan();
            }   
            else if(tabctrl_Nhanvien.SelectedIndex==3)
            {
                load_lich();
            }    
        }
        void load_tongquan_dsNgay()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT COUNT(SOHD_BH) AS SL, SUM(TRIGIA) AS TRIGIA"
                                +" FROM HDBH"
                                +" WHERE LOAIHD = 'DTT' AND NVID = '"+NVID+"' AND NGHD = '"+date.ToString("d")+"'"
                                +" UNION"
                                +" SELECT COUNT(SOHD_BH), SUM(TRIGIA)"
                                +" FROM HDBH"
                                +" WHERE LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT' AND NVID = '"+NVID+"' AND NGHD = '"+date.ToString("d")+"'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            try
            {
                txt_tongquan_slhdbh.Text = table.Rows[0]["SL"].ToString();
                txt_tongquan_trigiabh.Text = table.Rows[0]["TRIGIA"].ToString();
                if (txt_tongquan_trigiabh.Text == "")
                    txt_tongquan_trigiabh.Text = "0";
            }
            catch(Exception)
            {
                txt_tongquan_slhdbh.Text = "0";
                txt_tongquan_trigiabh.Text = "0";
            }
            try
            {
                txt_tongquan_slhddh.Text = table.Rows[1]["SL"].ToString();
                txt_tongquan_trigiadh.Text = table.Rows[1]["TRIGIA"].ToString();
                if (txt_tongquan_trigiadh.Text == "")
                    txt_tongquan_trigiadh.Text = "0";
            }
            catch
            {
                txt_tongquan_slhddh.Text = "0";
                txt_tongquan_trigiadh.Text = "0";
            }
            txt_tongquan_dsNgay.Text = (Convert.ToDouble(txt_tongquan_trigiabh.Text) + Convert.ToDouble(txt_tongquan_trigiadh.Text)).ToString();
            sqlCon.Close();
        }
        void load_tongquan_dsThang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT NGHD , SUM(TRIGIA) as TRIGIA"
                                + " FROM HDBH"
                                + " WHERE NVID = '" + NVID + "' AND(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)=" + date.Month.ToString()
                                +" GROUP BY NGHD"
                                +" ORDER BY NGHD ASC";

            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_tongquan.Titles["Title1"].Text = "Doanh số tháng " + date.Month.ToString();
            chart_tongquan.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_tongquan.ChartAreas["ChartArea1"].AxisY.Title = "Triệu đồng";
            chart_tongquan.Series["DoanhSo"].Points.Clear();
            for(int i=0; i<table.Rows.Count; i++)
            {
                chart_tongquan.Series["DoanhSo"].Points.AddXY(table.Rows[i]["NGHD"], Convert.ToDouble(table.Rows[i]["TRIGIA"])/1000000);
            }
            cmd.CommandText = "SELECT SUM(TRIGIA)"
                                + " FROM HDBH"
                                + " WHERE NVID = '"+NVID+"' AND(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)= "+date.Month.ToString();
            txt_tongquan_dsThang.Text = cmd.ExecuteScalar().ToString();
            if (txt_tongquan_dsThang.Text == "")
                txt_tongquan_dsThang.Text = "0";
            sqlCon.Close();
        }
        void load_tongquan_xephang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT TOP 3 HDBH.NVID, HOTEN, SUM(TRIGIA) AS DOANHSO"
                                + " FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID"
                                + " WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)= "+date.Month.ToString()+""
                                + " GROUP BY HDBH.NVID, HOTEN"
                                + " ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            try
            {
                lbl_tongquan_ten1.Text = table.Rows[0]["HOTEN"].ToString();
                txt_tongquan_ds1.Text = Convert.ToDouble(table.Rows[0]["DOANHSO"]).ToString();
                lbl_tongquan_ten2.Text = table.Rows[1]["HOTEN"].ToString();
                txt_tongquan_ds2.Text = Convert.ToDouble(table.Rows[1]["DOANHSO"]).ToString();
                lbl_tongquan_ten3.Text = table.Rows[2]["HOTEN"].ToString();
                txt_tongquan_ds3.Text = Convert.ToDouble(table.Rows[1]["DOANHSO"]).ToString();
            }
            catch(Exception)
            {
                
            }
            cmd.CommandText = "SELECT HANG, DOANHSO"
                              + " FROM("
                              + " SELECT DENSE_RANK() OVER(ORDER BY DOANHSO DESC) AS HANG, NVID, DOANHSO"
                                + " FROM("
                                + " SELECT NVID, SUM(TRIGIA) AS DOANHSO"
                                + " FROM HDBH"
                                + " WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD) = " + (date.Month - 1).ToString() + ""
                                + " GROUP BY NVID"
                                + " ) AS K"
                                + ") AS H"
                                + " WHERE NVID = '" + NVID + "'";
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                lbl_tongquan_ten0.Text = reader.GetString(0);
                txt_tongquan_ds0.Text = reader.GetString(1);
            }
            reader.Close();
            sqlCon.Close();
        }
        void load_tongquan_danhsachdoanhso()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT HDBH.NVID, HOTEN, SUM(TRIGIA) AS DOANHSO"
                                + " FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID"
                                + " WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND NGHD = '" + date.ToString("d") + "'"
                                + " GROUP BY HDBH.NVID, HOTEN"
                                + " ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_tongquan.DataSource = table;
            dgv_tongquan.Columns[0].Width = 50;
            sqlCon.Close();
        }
        void load_tongquan()
        {
            load_tongquan_dsNgay();
            load_tongquan_dsThang();
            load_tongquan_xephang();
            load_tongquan_danhsachdoanhso();
        }
        //TABPAGE LỊCH LÀM VIỆC
        void load_lich_calamHienTai()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            DateTime date = DateTime.Now;
            cmd.CommandText = "SELECT CAID, GIO_BD, GIO_NGHI FROM CALAMVIEC WHERE GIO_BD<'"+date.ToString("HH:mm:ss")+ "' AND GIO_NGHI>'" + date.ToString("HH:mm:ss") + "' AND SUBSTRING(CAID,2,1)='" + ((int)date.DayOfWeek).ToString()+"'";
            MessageBox.Show(cmd.CommandText);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string caid = reader.GetString(0);
                switch (caid.Substring(2))
                {
                    case "S":
                        lbl_lich_buoi.Text = "Sáng";
                        break;
                    case "C":
                        lbl_lich_buoi.Text = "Chiều";
                        break;
                    case "T":
                        lbl_lich_buoi.Text = "Tối";
                        break;
                }
                lbl_lich_BD.Text = reader.GetString(1);
                lbl_lich_KT.Text = reader.GetString(2);
                 
            }
            lbl_lich_ngaylam.Text = date.ToString("d");
            sqlCon.Close();
        }    
        void load_lich()
        {
            load_lich_calamHienTai();
        }

        
    }
}
