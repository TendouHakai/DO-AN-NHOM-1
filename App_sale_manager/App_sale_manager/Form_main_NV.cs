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
using System.IO;

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
        bool canExit = true;

        DataTable table = new DataTable();


        public string nvid
        {
            set { NVID = value; }
        }
        public Form_main_NV()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            DTCC_guest_dataInitialize();
            pictureBox_dtcc_guestFace.Image = Image.FromFile(@"Image samples for testing\\Khách hàng đăng kí\No Image.jpg");
            this.Size = new Size(1275, 740);
        }
        public Form_main_NV(string NVID, string Ten, string username)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            this.NVID = NVID;
            this.Ten = Ten;
            tbtnUser.Text = username;
            DTCC_guest_dataInitialize();
            this.Size = new Size(1275, 740);
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
            if (tabctrl_Nhanvien.SelectedIndex == 0)
            {
                load_tongquan();
            }
            else if (tabctrl_Nhanvien.SelectedIndex == 3)
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
            else if (tabctrl_Nhanvien.SelectedIndex == 4)
            {
                LoadData_nv_infonv();
            }

        }



        void load_tongquan_dsNgay()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT COUNT(SOHD_BH) AS SL, SUM(TRIGIA) AS TRIGIA"
                                + " FROM HDBH"
                                + " WHERE LOAIHD = 'DTT' AND NVID = '" + NVID + "' AND NGHD = '" + date.ToString("MM/dd/yyyy") + "'"
                                + " UNION"
                                + " SELECT COUNT(SOHD_BH), SUM(TRIGIA)"
                                + " FROM HDBH"
                                + " WHERE LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT' AND NVID = '" + NVID + "' AND NGHD = '" + date.ToString("MM/dd/yyyy") + "'";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            try
            {
                txt_tongquan_slhdbh.Text = table.Rows[0]["SL"].ToString();
                if (table.Rows[0]["TRIGIA"].ToString() == "")
                    txt_tongquan_trigiabh.Text = "0";
                else txt_tongquan_trigiabh.Text = String.Format("{0:0,0}", table.Rows[0]["TRIGIA"]);

            }
            catch (Exception)
            {
                txt_tongquan_slhdbh.Text = "0";
                txt_tongquan_trigiabh.Text = "0";
            }
            try
            {
                txt_tongquan_slhddh.Text = table.Rows[1]["SL"].ToString();
                if (table.Rows[1]["TRIGIA"].ToString() == "")
                    txt_tongquan_trigiadh.Text = "0";
                else txt_tongquan_trigiadh.Text = string.Format("{0:0,0}", table.Rows[1]["TRIGIA"]);
            }
            catch
            {
                txt_tongquan_slhddh.Text = "0";
                txt_tongquan_trigiadh.Text = "0";
            }
            try
            {
                txt_tongquan_dsNgay.Text = string.Format("{0:0,0}", (Convert.ToDouble(table.Rows[0]["TRIGIA"]) + Convert.ToDouble(table.Rows[0]["TRIGIA"])));
            }
            catch (Exception)
            {
                txt_tongquan_dsNgay.Text = "0";
            }
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
                                + " GROUP BY NGHD"
                                + " ORDER BY NGHD ASC";

            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            chart_tongquan.Titles["Title1"].Text = "Doanh số tháng " + date.Month.ToString();
            chart_tongquan.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart_tongquan.ChartAreas["ChartArea1"].AxisY.Title = "Triệu đồng";
            chart_tongquan.Series["DoanhSo"].Points.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart_tongquan.Series["DoanhSo"].Points.AddXY(table.Rows[i]["NGHD"], Convert.ToDouble(table.Rows[i]["TRIGIA"]) / 1000000);
            }
            cmd.CommandText = "SELECT SUM(TRIGIA)"
                                + " FROM HDBH"
                                + " WHERE NVID = '" + NVID + "' AND(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)= " + date.Month.ToString();
            txt_tongquan_dsThang.Text = cmd.ExecuteScalar().ToString();
            if (txt_tongquan_dsThang.Text == "")
                txt_tongquan_dsThang.Text = "0";
            sqlCon.Close();
        }
        void load_tongquan_xephang()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT TOP 3 HDBH.NVID, HOTEN, SUM(TRIGIA) AS DOANHSO"
                                + " FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID"
                                + " WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND MONTH(NGHD)= " + date.Month.ToString() + ""
                                + " GROUP BY HDBH.NVID, HOTEN"
                                + " ORDER BY DOANHSO DESC";
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            try
            {
                lbl_tongquan_ten1.Text = table.Rows[0]["HOTEN"].ToString();
                txt_tongquan_ds1.Text = string.Format("{0:0,0}", Convert.ToDouble(table.Rows[0]["DOANHSO"]));
                lbl_tongquan_ten2.Text = table.Rows[1]["HOTEN"].ToString();
                txt_tongquan_ds2.Text = string.Format("{0:0,0}", Convert.ToDouble(table.Rows[1]["DOANHSO"]));
                lbl_tongquan_ten3.Text = table.Rows[2]["HOTEN"].ToString();
                txt_tongquan_ds3.Text = string.Format("{0:0,0}", Convert.ToDouble(table.Rows[1]["DOANHSO"]));
            }
            catch (Exception)
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
            while (reader.Read())
            {
                lbl_tongquan_ten0.Text = reader.GetString(0);
                txt_tongquan_ds0.Text = string.Format("{0:0,0}", Convert.ToDouble(reader.GetString(1)));
            }
            reader.Close();
            sqlCon.Close();
        }
        void load_tongquan_danhsachdoanhso()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Today;
            cmd.CommandText = "SELECT HDBH.NVID, HOTEN, SUM(TRIGIA) AS DOANHSO"
                                + " FROM HDBH INNER JOIN NHANVIEN ON HDBH.NVID = NHANVIEN.NVID"
                                + " WHERE(LOAIHD = 'DTT' OR(LOAIHD = 'DDH' AND TRANGTHAI = 'HOANTAT')) AND NGHD = '" + date.ToString("MM/dd/yyyy") + "'"
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
            cmd = sqlCon.CreateCommand();
            DateTime date = DateTime.Now;
            cmd.CommandText = "SELECT CAID, GIO_BD, GIO_NGHI FROM CALAMVIEC WHERE GIO_BD<'" + date.ToString("HH:mm:ss") + "' AND GIO_NGHI>'" + date.ToString("HH:mm:ss") + "' AND SUBSTRING(CAID,2,1)='" + ((int)date.DayOfWeek).ToString() + "'";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
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
            reader.Close();
            lbl_lich_ngaylam.Text = date.ToString("d");
            sqlCon.Close();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_lich_dongho.Text = DateTime.Now.ToString("HH:mm");
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
                cmd = sqlCon.CreateCommand();
                String CAID = "C" + ((int)DateTime.Today.DayOfWeek);
                switch (lbl_lich_buoi.Text)
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
                cmd.CommandText = "SELECT TIEUDE, TRANGTHAI FROM CT_LAMVIEC WHERE NVID = '" + NVID + "' AND CAID = '" + CAID + "'";
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    cmd.CommandText = "SELECT TIEUDE FROM CT_LAMVIEC_HANGTUAN WHERE NVID = '" + NVID + "' AND CAID = '" + CAID + "'";
                    adapter.SelectCommand = cmd;
                    table.Rows.Clear();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                        MessageBox.Show("Bạn không có ca làm ngày hôm nay");
                    cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + NVID + "', '" + CAID + "', '" + DateTime.Today.ToString("d") + "', N'Đã điểm danh', N'Lặp lại', '" + table.Rows[0]["TIEUDE"].ToString() + "')";
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
            while (finish.DayOfWeek != DayOfWeek.Sunday)
            {
                finish = finish.AddDays(1);
            }
            begin = today;
            while (begin.DayOfWeek != DayOfWeek.Monday)
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
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            cmd = sqlCon.CreateCommand();
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
                            + " WHERE NGAYLAM >='"+begin.ToString("MM/dd/yyyy")+"' AND NGAYLAM <= '"+finish.ToString("MM/dd/yyyy")+"' AND NVID = '" + NVID+"'"
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
            for (int i = 0; i < caid.Count; i++)
            {
                if (caid[i].CAID.Substring(1, 1) == "0")
                {
                    switch (caid[i].CAID.Substring(2, 1))
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
            cmd.CommandText = "SELECT CAID FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Đã điểm danh' AND NGAYLAM >='" + begin.ToString("MM/dd/yyyy") + "' AND NGAYLAM <='" + today.ToString("MM/dd/yyyy") + "'";
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
                    int temp = Convert.ToInt32(CAIDS[i].Substring(1, 1));
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
            cmd.CommandText = "SELECT CAID FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Chưa điểm danh' AND NGAYLAM >='" + begin.ToString("MM/dd/yyyy") + "' AND NGAYLAM <='" + today.ToString("MM/dd/yyyy") + "'";
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
                    int temp = Convert.ToInt32(CAIDS[i].Substring(1, 1));
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
            for (; i <= DateTime.Today; i = i.AddDays(1))
            {
                cmd.CommandText = "SELECT NVID, CAID, TIEUDE FROM CT_LAMVIEC_HANGTUAN WHERE NVID = '" + NVID + "'AND SUBSTRING(CAID,2,1) = '" + ((int)i.DayOfWeek) + "'"
                                + " EXCEPT"
                                + " SELECT NVID, CAID, TIEUDE FROM CT_LAMVIEC WHERE NVID='" + NVID + "' AND NGAYLAM = '" + i.ToString("MM/dd/yyyy") + "'";
                DataTable table = new DataTable();
                table.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    cmd.CommandText = "INSERT INTO CT_LAMVIEC VALUES('" + NVID + "', '" + table.Rows[j]["CAID"] + "', '" + i.ToString("MM/dd/yyyy") + "', N'Chưa điểm danh',N'Lặp lại',N'" + table.Rows[j]["TIEUDE"] + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            cmd.CommandText = "SELECT COUNT(*) FROM CT_LAMVIEC WHERE NVID ='" + NVID + "' AND TRANGTHAI = N'Đã điểm danh' AND MONTH(NGAYLAM) =" + DateTime.Today.Month;
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


        private void dataGridView_dtcc_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_dtcc_guest.Rows[e.RowIndex];
                DateTime Date = new DateTime();
                string loaiKH = row.Cells[6].Value.ToString();
                if (string.IsNullOrEmpty(loaiKH) != true)
                    if (loaiKH == "NOR")
                        label_guestSpec_Text.Text = "Khách thường";
                    else
                        label_guestSpec_Text.Text = "Khách vip";
                label_guestID_Text.Text = row.Cells[0].Value.ToString();
                label_guestName_Text.Text = row.Cells[1].Value.ToString();
                label_guestSDT_Text.Text = row.Cells[3].Value.ToString();
                Date = Convert.ToDateTime(row.Cells[4].Value.ToString());
                label_guestReg_Text.Text = Date.ToString("MM/dd/yyyy HH:mm:ss");
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
        public void Guest_DataRefresh(object sender, EventArgs e)
        {
            DTCC_guest_dataInitialize();
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
            A.dateTimePicker_NGDT_z.Value = Convert.ToDateTime(label_guestReg_Text.Text);
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
                textBox_guest_search.Focus();
                return;
            }
            if (comboBox_guest_filter.Text == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn trường cần tìm.");
                comboBox_guest_filter.Focus();
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

        private void textBox_guest_search_Click(object sender, EventArgs e)
        {
            textBox_guest_search.SelectAll();
            this.AcceptButton = button_guest_search;
        }

        private void button_sale_Click(object sender, EventArgs e)
        {
            Sale_viewer A = new Sale_viewer();
            A.Show();
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
        // cài đặt UI
        void tbtn_click(object sender, EventArgs e)
        {

            foreach (var item in toolStripMainNV.Items)
            {
                (item as ToolStripDropDownButton).BackColor = Color.FromArgb(61, 135, 255);
            }
            (sender as ToolStripDropDownButton).BackColor = Color.Blue;
        }

        private void tbtnUser_DropDownOpening(object sender, EventArgs e)
        {
            tbtnUser.Image = Image.FromFile("../../icon/icons8-male-user-30 (1).png");
            tbtnUser.ForeColor = Color.FromArgb(61, 135, 255);
            tbtnUser.ImageScaling = ToolStripItemImageScaling.None;
        }

        private void tbtnUser_DropDownClosed(object sender, EventArgs e)
        {
            tbtnUser.Image = Image.FromFile("../../icon/icons8-male-user-30 (2).png");
            tbtnUser.ForeColor = Color.White;
            tbtnUser.ImageScaling = ToolStripItemImageScaling.None;
        }

        private void tbtnTongquan_Click(object sender, EventArgs e)
        {
            tabctrl_Nhanvien.TabPages.Clear();
            tabctrl_Nhanvien.TabPages.Add(tabP_Tongquan);
            load_tongquan();
            tbtn_click(sender, new EventArgs());
        }

        private void tbtnKhachhang_Click(object sender, EventArgs e)
        {
            tabctrl_Nhanvien.TabPages.Clear();
            tabctrl_Nhanvien.TabPages.Add(tabP_Khachhang);
            tbtn_click(sender, new EventArgs());
        }

        private void tbtnGiaodich_Click(object sender, EventArgs e)
        {
            tabctrl_Nhanvien.TabPages.Clear();
            tabctrl_Nhanvien.TabPages.Add(tabP_Banhang);
            this.Refresh_data_GD();
            tbtn_click(sender, new EventArgs());
        }

        private void tbtnLich_Click(object sender, EventArgs e)
        {
            tabctrl_Nhanvien.TabPages.Clear();
            tabctrl_Nhanvien.TabPages.Add(tabP_lichlamviec);
            timer.Tick += Timer_Tick;
            timer.Start();
            timer.Interval = 1000;
            load_lich();
            tbtn_click(sender, new EventArgs());
        }

        private void btnGiaodich_Tim_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnGiaodich_Tim.Tag) == 0)
            {
                btnGiaodich_Tim.Image = Image.FromFile("../../icon/icons8-triangle-arrow-24 (1).png");
                btnGiaodich_Tim.ImageAlign = ContentAlignment.MiddleRight;
                btnGiaodich_Tim.Tag = 1;
                pnGiaodich_Tim.Visible = false;
            }
            else
            {
                btnGiaodich_Tim.Image = Image.FromFile("../../icon/icons8-triangle-24.png");
                btnGiaodich_Tim.ImageAlign = ContentAlignment.MiddleRight;
                btnGiaodich_Tim.Tag = 0;
                pnGiaodich_Tim.Visible = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canExit = false;
            Thoat(this, new EventArgs());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //NHÓM HÀM TABPAGE CÁ NHÂN
        void LoadData_nv_infonv()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT NVID,HOTEN,SDT,NGSINH,NGVL,CV,LUONG,THUONG,HESO,USERNAME FROM NHANVIEN WHERE NVID='" + this.NVID.ToString() + "'";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tb_MaNV_nv_infonv.Text = reader.GetString(0);
                tb_Hoten_nv_infonv.Text = reader.GetString(1);
                tb_sdt_nv_infonv.Text = reader.GetString(2);
                tb_ngaysinh_nv_infonv.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                tb_ngayvaolam_nv_infonv.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                tb_chucvu_nv_infonv.Text = reader.GetString(5);
                tb_Luong_nv_infonv.Text = reader.GetValue(6).ToString();
                tb_Thuong_nv_infonv.Text = reader.GetValue(7).ToString();
                tb_Heso_nv_infonv.Text = reader.GetValue(8).ToString();
                tb_username_nv_infonv.Text = reader.GetString(9);
                sqlCon.Close();
            }


            if (File.Exists(@"Image samples for testing\CN\" + tb_MaNV_nv_infonv.Text + ".jpg"))
            {
                Image image1 = null;
                using (FileStream stream = new FileStream(@"Image samples for testing\CN\" + this.NVID + ".jpg", FileMode.Open))
                {
                    image1 = Image.FromStream(stream);
                }

                pictureBox_image_anhnv.Image = image1;
            }
            else
            {
                Image image1 = null;
                using (FileStream stream = new FileStream(@"Image samples for testing\CN\No Image.jpg", FileMode.Open))
                {
                    image1 = Image.FromStream(stream);
                }
                pictureBox_image_anhnv.Image = image1;
            }

        }
        private void bt_Them_nv_infonv_Click(object sender, EventArgs e)
        {
            Form_UpdateNV_NV frm = new Form_UpdateNV_NV(NVID);
            frm.Thoat += Thoat_Form_UpdateNV_NV;
            frm.Show();
            this.Hide();
        }
        private void bt_doipass_nv_infonv_Click(object sender, EventArgs e)
        {
            Form_doipass_nv frm = new Form_doipass_nv(this.NVID.ToString());
            frm.Thoat += Thoat_Form_doipass_NV;
            frm.Show();
            this.Hide();
        }
        private void Thoat_Form_UpdateNV_NV(object sender, EventArgs e)
        {
            this.Show();
            LoadData_nv_infonv();
        }
        private void Thoat_Form_doipass_NV(object sender, EventArgs e)
        {
            this.Show();
        }


        

        
        private void Thoat_Form_selectphoto_nv(object sender, EventArgs e)
        {
            this.Show();
            LoadData_nv_infonv();
        }


       

        private void bt_doipass_nv_infonv_Click_1(object sender, EventArgs e)
        {
            Form_doipass_nv frm = new Form_doipass_nv(this.NVID.ToString());
            frm.Thoat += Thoat_Form_doipass_NV;
            frm.Show();
            this.Hide();
        }

        private void pictureBox_image_anhnv_Click_1(object sender, EventArgs e)
        {
            var pictureBox_Position = this.PointToScreen(new Point(pictureBox_image_anhnv.Location.X, pictureBox_image_anhnv.Location.Y + pictureBox_image_anhnv.Size.Height));
            contextMenuStrip_anh_nv.Show(pictureBox_Position);
        }

        private void chonAnhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Open1 = new OpenFileDialog();
            Open1.Multiselect = false;
            if (Open1.ShowDialog() == DialogResult.OK)
            {

                var filepath = Open1.FileName;
                Bitmap bmp = new Bitmap(filepath);
                Form_selectphoto_nv frm = new Form_selectphoto_nv(filepath, tb_MaNV_nv_infonv.Text, tb_Hoten_nv_infonv.Text);
                if (bmp.Width < (frm.panel1.Width + SystemInformation.VerticalScrollBarWidth) * 2 || bmp.Height < (frm.panel1.Height + SystemInformation.HorizontalScrollBarHeight) * 2)
                {
                    MessageBox.Show("Ảnh bạn phải có kích thước tối thiểu " + ((frm.panel1.Width + SystemInformation.VerticalScrollBarWidth) * 2).ToString() + "x" + ((frm.panel1.Height + SystemInformation.HorizontalScrollBarHeight) * 2).ToString());
                    frm.Close();
                }
                else
                {
                    frm.Thoat += Thoat_Form_selectphoto_nv;
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void xoaAnhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa ảnh", MessageBoxButtons.YesNo);
            var filepath = @"Image samples for testing\CN\" + tb_MaNV_nv_infonv.Text + ".jpg";
            if (Result == DialogResult.Yes)
            {
                pictureBox_image_anhnv.Image = null;
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                    Image image1 = null;
                    using (FileStream stream = new FileStream(@"Image samples for testing\CN\No Image.jpg", FileMode.Open))
                    {
                        image1 = Image.FromStream(stream);
                    }
                    pictureBox_image_anhnv.Image = image1;
                    MessageBox.Show("Đã xoá thành công!");
                }
                else MessageBox.Show("Không có ảnh để xoá!");
            }
        }
    }
   
}
