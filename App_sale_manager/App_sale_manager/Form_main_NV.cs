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
        DataTable table = new DataTable();


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
        Timer timer = new Timer();
        private void tabctrl_Nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabctrl_Nhanvien.SelectedIndex==0)
            {
                load_tongquan();
            }   
            else if(tabctrl_Nhanvien.SelectedIndex==3)
            {
                timer.Tick += Timer_Tick;
                timer.Start();
                timer.Interval = 1000;
                load_lich();
            }
            else if (tabctrl_Nhanvien.SelectedIndex == 1)
            {
                this.Refresh_data_GD();
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
        TimeSpan GIO_BD = new TimeSpan();
        TimeSpan GIO_KT = new TimeSpan();
        void load_lich_calamHienTai()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            DateTime date = DateTime.Now;
            cmd.CommandText = "SELECT CAID, GIO_BD, GIO_NGHI FROM CALAMVIEC WHERE GIO_BD<'"+date.ToString("HH:mm:ss")+ "' AND GIO_NGHI>'" + date.ToString("HH:mm:ss") + "' AND SUBSTRING(CAID,2,1)='" + ((int)date.DayOfWeek).ToString()+"'";
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
                lbl_lich_BD.Text = reader.GetTimeSpan(1).ToString();
                GIO_BD = reader.GetTimeSpan(1);
                lbl_lich_KT.Text = reader.GetTimeSpan(2).ToString();
                GIO_KT = reader.GetTimeSpan(2);
            }
            lbl_lich_ngaylam.Text = date.ToString("d");
            sqlCon.Close();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_lich_dongho.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.TimeOfDay > GIO_BD || DateTime.Now.TimeOfDay > GIO_KT)
                load_lich_calamHienTai();
        }
        private void btn_lich_diemdanh_Click(object sender, EventArgs e)
        {
            if (lbl_lich_buoi.Text == "<trống>")
                MessageBox.Show("Vẫn chưa đến ca làm");
            else
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                String CAID = "C" + ((int)DateTime.Today.DayOfWeek);
                switch(lbl_lich_buoi.Text)
                {
                    case "Sáng":
                        CAID = CAID + "S";
                        break;
                    case "Chiều":
                        CAID = CAID + "C";
                        break;
                    case "Tối":
                        CAID = CAID + "T";
                        break;
                }
                cmd.CommandText = "SELECT TIEUDE, TRANGTHAI FROM CT_LAMVIEC WHERE NVID = '" + NVID + "' AND CAID = '"+CAID+"'";
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                if(table.Rows.Count==0)
                {
                    cmd.CommandText = "SELECT TIEUDE FROM CT_LAMVIEC_HANGTUAN WHERE NVID = '" + NVID + "' AND CAID = '" + CAID + "'";
                    adapter.SelectCommand = cmd;
                    table.Rows.Clear();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                        MessageBox.Show("Bạn không có ca làm ngày hôm nay");
                    cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('"+NVID+"', '"+CAID+"', '"+DateTime.Today.ToString("d")+"', N'Đã điểm danh', N'Lặp lại', '"+table.Rows[0]["TIEUDE"].ToString()+"')";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (table.Rows[0]["TRANGTHAI"].ToString() == "Đẫ điểm danh")
                    {
                        MessageBox.Show("Bạn đã điểm danh rồi");
                        return;
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE CT_LAMVIEC TRANGTHAI = N'Đã điểm danh";
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Điểm danh thành công");
                sqlCon.Close();
            } 
                
        }
        void week(DateTime today, ref DateTime finish, ref DateTime begin)
        {
            finish = today;
            while(finish.DayOfWeek != DayOfWeek.Sunday)
            {
                finish = finish.AddDays(1);
            }
            begin = today;
            while(begin.DayOfWeek!=DayOfWeek.Monday)
            {
                begin = begin.AddDays(-1);
            }
        }
        struct caID
        {
            public string TIEUDE;
            public string CAID;
        };
        void load_lich_banglichhangtuan(DateTime today)
        {
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            cmd.CommandText = "SELECT DISTINCT GIO_BD, GIO_NGHI FROM CALAMVIEC ";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgv_lich_tuan.Rows.Clear();
            dgv_lich_tuan.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            dgv_lich_tuan.Rows.Add("Sáng \n(" + table.Rows[0]["GIO_BD"] + " - " + table.Rows[0]["GIO_NGHI"] + ")");
            dgv_lich_tuan.Rows[0].Height = 80;
            dgv_lich_tuan.Rows.Add("Nghỉ trưa \n(" + table.Rows[0]["GIO_NGHI"] + " - " + table.Rows[1]["GIO_BD"] + ")");
            dgv_lich_tuan.Rows[1].Height = 40;
            dgv_lich_tuan.Rows.Add("Chiều \n(" + table.Rows[1]["GIO_BD"] + " - " + table.Rows[1]["GIO_NGHI"] + ")");
            dgv_lich_tuan.Rows[2].Height = 80;
            dgv_lich_tuan.Rows.Add("Tối \n(" + table.Rows[2]["GIO_BD"] + " - " + table.Rows[2]["GIO_NGHI"] + ")");
            dgv_lich_tuan.Rows[3].Height = 80;
            DateTime finish = new DateTime();
            DateTime begin = new DateTime();
            week(today, ref finish, ref begin);
            cmd.CommandText = "SELECT CAID, TIEUDE"
                            +" FROM CT_LAMVIEC"
                            + " WHERE NGAYLAM >="+begin.ToString("d")+"AND NGAYLAM <= "+finish.ToString("d")+" AND NVID = '" + NVID+"'"
                            +" UNION"
                            +" SELECT CAID, TIEUDE"
                            +" FROM CT_LAMVIEC_HANGTUAN"
                            +" WHERE NVID = '"+NVID+"'";
            var reader = cmd.ExecuteReader();
            List<caID> caid = new List<caID>();
            while (reader.Read())
            {
                caID ca = new caID();
                ca.CAID = reader.GetString(0);
                ca.TIEUDE = reader.GetString(1);
                caid.Add(ca);
            }
            reader.Close();
            for(int i =0; i<caid.Count; i++)
            {
                if(caid[i].CAID.Substring(1,1)=="0")
                {
                    switch(caid[i].CAID.Substring(2,1))
                    {
                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[8].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[0].Cells[8].Value = caid[i].TIEUDE;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[8].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[2].Cells[8].Value = caid[i].TIEUDE;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[8].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[3].Cells[8].Value = caid[i].TIEUDE;
                            break;
                    }
                }
                else
                {
                    int temp = Convert.ToInt32(caid[i].CAID.Substring(1, 1));
                    switch (caid[i].CAID.Substring(2, 1))
                    {
                        
                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[temp].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[0].Cells[temp].Value = caid[i].TIEUDE;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[temp].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[2].Cells[temp].Value = caid[i].TIEUDE;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[temp].Style.BackColor = Color.White;
                            dgv_lich_tuan.Rows[3].Cells[temp].Value = caid[i].TIEUDE;
                            break;
                    }
                } 
                    
            }
            reader.Close();
            // tô màu cho ngày đã làm và ngày nghỉ
            List<string> CAIDS = new List<string>();
            cmd.CommandText = "SELECT CAID FROM CT_LAMVIEC WHERE NVID ='"+NVID+ "' AND TRANGTHAI = N'Đã điểm danh' AND NGAYLAM >='"+begin.ToString("d")+"' AND NGAYLAM <='"+today.ToString("d")+"'";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                CAIDS.Add(reader.GetString(0));
            }
            for (int i = 0; i < CAIDS.Count; i++)
            {
                if (CAIDS[i].Substring(1, 1) == "0")
                {
                    switch (CAIDS[i].Substring(2, 1))
                    {
                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[8].Style.BackColor = Color.SpringGreen;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[8].Style.BackColor = Color.SpringGreen;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[8].Style.BackColor = Color.SpringGreen;
                            break;
                    }
                }
                else
                {
                    int temp = Convert.ToInt32(caid[i].CAID.Substring(1, 1));
                    switch (CAIDS[i].Substring(2, 1))
                    {

                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[temp].Style.BackColor = Color.SpringGreen;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[temp].Style.BackColor = Color.SpringGreen;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[temp].Style.BackColor = Color.SpringGreen;
                            break;
                    }
                }

            }
            reader.Close();
            CAIDS.Clear();
            cmd.CommandText = "SELECT CAID FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Chưa điểm danh' AND NGAYLAM >='" + begin.ToString("d") + "' AND NGAYLAM <='" + today.ToString("d") + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CAIDS.Add(reader.GetString(0));
            }
            for (int i = 0; i < CAIDS.Count; i++)
            {
                if (CAIDS[i].Substring(1, 1) == "0")
                {
                    switch (CAIDS[i].Substring(2, 1))
                    {
                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[8].Style.BackColor = Color.OrangeRed;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[8].Style.BackColor = Color.OrangeRed;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[8].Style.BackColor = Color.OrangeRed;
                            break;
                    }
                }
                else
                {
                    int temp = Convert.ToInt32(caid[i].CAID.Substring(1, 1));
                    switch (CAIDS[i].Substring(2, 1))
                    {

                        case "S":
                            dgv_lich_tuan.Rows[0].Cells[temp].Style.BackColor = Color.OrangeRed;
                            break;
                        case "C":
                            dgv_lich_tuan.Rows[2].Cells[temp].Style.BackColor = Color.OrangeRed;
                            break;
                        case "T":
                            dgv_lich_tuan.Rows[3].Cells[temp].Style.BackColor = Color.OrangeRed;
                            break;
                    }
                }

            }
            reader.Close();
            sqlCon.Close();
        }
        void load_lich_songayDiemDanh()
        {
            // update lại bảng CT_LAMVIEC
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            DateTime i = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            for(; i<= DateTime.Today; i = i.AddDays(1))
            {
                cmd.CommandText = "SELECT NVID, CAID, TIEUDE FROM CT_LAMVIEC_HANGTUAN WHERE NVID = '"+NVID+"'AND SUBSTRING(CAID,2,1) = '"+((int)i.DayOfWeek)+"'"
                                + " EXCEPT"
                                + " SELECT NVID, CAID, TIEUDE FROM CT_LAMVIEC WHERE NVID='"+NVID+"' AND NGAYLAM = '"+i.ToString("d")+"'";
                DataTable table = new DataTable();
                table.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                for(int j =0; j<table.Rows.Count; j++)
                {
                    cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + NVID + "', '" + table.Rows[j]["CAID"] + "', '" + i.ToString("d") + "', N'Chưa điểm danh',N'Lặp lại',N'" + table.Rows[j]["TIEUDE"] + "')";
                    cmd.ExecuteNonQuery();
                }    
            }
            cmd.CommandText = "SELECT COUNT(*) FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Đã điểm danh' AND MONTH(NGAYLAM) =" +DateTime.Today.Month;
            txt_ngaylam.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT COUNT(*) FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Chưa điểm danh' AND MONTH(NGAYLAM) =" + DateTime.Today.Month;
            txt_ngaynghi.Text = cmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }    
        void load_lich()
        {
            load_lich_calamHienTai();
            load_lich_songayDiemDanh();
            load_lich_banglichhangtuan(DateTime.Today);
        }

        private void btn_lich_xemCT_Click(object sender, EventArgs e)
        {
            Form_NV_chamcong frm = new Form_NV_chamcong(NVID);
            frm.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            load_lich_banglichhangtuan((sender as MonthCalendar).SelectionStart.Date);
        }



        //     ////////////////////    Tabpage Ban hang //////
        private void BNT_TaoHoaDon_Click(object sender, EventArgs e)
        {
            Form_GiaoDich F_GD = new Form_GiaoDich(NVID);
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

            cmd.CommandText = "set dateformat dmy";
            adapter.UpdateCommand = cmd;

            cmd.CommandText = "select SOHD_BH,CONVERT(varchar,NGHD,21) as [DD-MM-YYYY HH:MM:SS],KHID,NVID , REPLACE(CONVERT(varchar(20),TRIGIA, 1), '.00','') , LOAIHD,TRANGTHAI from HDBH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();

            GridView_Data_GiaoDich.Columns[0].HeaderText = "Mã hóa đơn";
            GridView_Data_GiaoDich.Columns[1].HeaderText = "Ngày tạo";
            GridView_Data_GiaoDich.Columns[2].HeaderText = "Mã khách hàng";
            GridView_Data_GiaoDich.Columns[3].HeaderText = "Mã nhân viên";
            GridView_Data_GiaoDich.Columns[4].HeaderText = "Trị giá (VNĐ)";
            GridView_Data_GiaoDich.Columns[5].HeaderText = "Loại hóa đơn";
            GridView_Data_GiaoDich.Columns[6].HeaderText = "Trạng thái";


            CLB_GD_TrangThai.SetItemChecked(0, true);
            CLB_GD_TrangThai.SetItemChecked(1, true);
            CLB_GD_TrangThai.SetItemChecked(2, true);
            CLB_GD_LoaiDon.SetItemChecked(0, true);
            CLB_GD_LoaiDon.SetItemChecked(1, true);
            Box_GD_MaHoaDon.Text = "";
            Box_GD_MaKhachHang.Text = "";
            BOX_GD_MaNhanVien.Text = "";
            CB_GD_HDCB.Checked = false;
        }

        private void bnt_Timkiem_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd.CommandText = "select SOHD_BH,CONVERT(varchar,NGHD,21) as [DD-MM-YYYY HH:MM:SS],KHID,NVID , REPLACE(CONVERT(varchar(20),TRIGIA, 1), '.00','') , LOAIHD,TRANGTHAI from HDBH where (SOHD_BH like '%" + Box_GD_MaHoaDon.Text + "%' and KHID like '%" + Box_GD_MaKhachHang.Text + "%'AND NVID like '%" + BOX_GD_MaNhanVien.Text + "%'  ";
            if (CLB_GD_LoaiDon.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and LOAIHD != N'Đơn đặt hàng'";
            }
            if (CLB_GD_LoaiDon.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and LOAIHD != N'Đơn trực tiếp'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(0) == false)
            {
                cmd.CommandText += " and TRANGTHAI != N'Nhận đơn'";
            }
            if (CLB_GD_TrangThai.CheckedIndices.Contains(1) == false)
            {
                cmd.CommandText += " and TRANGTHAI != N'Đang giao'";
            }

            if (CLB_GD_TrangThai.CheckedIndices.Contains(2) == false)
            {
                cmd.CommandText += " and TRANGTHAI != N'Hoàn thành'";
            }

            if (CB_GD_HDCB.Checked == true)
            {
                cmd.CommandText += "and NVID = '"+NVID+"' ";
            }

            cmd.CommandText += ") ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            GridView_Data_GiaoDich.DataSource = table;
            sqlCon.Close();

            GridView_Data_GiaoDich.Columns[0].HeaderText = "Mã hóa đơn";
            GridView_Data_GiaoDich.Columns[1].HeaderText = "Ngày tạo";
            GridView_Data_GiaoDich.Columns[2].HeaderText = "Mã khách hàng";
            GridView_Data_GiaoDich.Columns[3].HeaderText = "Mã nhân viên";
            GridView_Data_GiaoDich.Columns[4].HeaderText = "Trị giá (VNĐ)";
            GridView_Data_GiaoDich.Columns[5].HeaderText = "Loại hóa đơn";
            GridView_Data_GiaoDich.Columns[6].HeaderText = "Trạng thái";
        }

        private void GridView_Data_GiaoDich_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GridView_Data_GiaoDich.CurrentRow.Index == GridView_Data_GiaoDich.NewRowIndex)
                return;

            Form_CTHD cthd = new Form_CTHD((string)GridView_Data_GiaoDich.CurrentRow.Cells[0].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[2].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[3].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[5].Value, (string)GridView_Data_GiaoDich.CurrentRow.Cells[6].Value, Convert.ToString(GridView_Data_GiaoDich.CurrentRow.Cells[4].Value));
            cthd.Show();
        }

        Bitmap bmp;
        private void bnt_inDS_Click(object sender, EventArgs e)
        {
            if (GridView_Data_GiaoDich.RowCount > 0)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel WorkBook|*.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {

                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Exported from gridview";

                    for (int i = 1; i < GridView_Data_GiaoDich.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = GridView_Data_GiaoDich.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < GridView_Data_GiaoDich.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < GridView_Data_GiaoDich.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = GridView_Data_GiaoDich.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(save.FileName);
                    app.Quit();
                }
            }
        }
    }
}
