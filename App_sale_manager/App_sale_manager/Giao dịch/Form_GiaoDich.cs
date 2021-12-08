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
using System.Configuration;

namespace App_sale_manager
{
    public partial class Form_GiaoDich : Form
    {
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        DataTable Table_GiamGia;
        public Form_GiaoDich()
        {
            InitializeComponent();
            this.Size = new Size(1250, 770);
        }

        public Form_GiaoDich(string Manv)
        {
            InitializeComponent();
            this.Size = new Size(1250, 770);
            Box_IDNV.Text = Manv;

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            cmd = sqlCon.CreateCommand();

            table = new DataTable();
            cmd.CommandText = "select * from HDBH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            Box_IDHD.Text = "#" + Convert.ToString(table.Rows.Count + 1);

            table = new DataTable();
            cmd.CommandText = "Select KHID,HOTEN from KHACHHANG";
            adapter.SelectCommand = cmd;
            table.Clear();
            if (adapter != null)
            {
                adapter.Fill(table);
                DGV_LuaChon.DataSource = table;
                foreach(DataGridViewRow i in DGV_LuaChon.Rows)
                {
                    if (i.Cells[0].Value != null)
                    {
                        Box_IDKH.Items.Add(i.Cells[0].Value);
                        Box_TenKH.Items.Add(i.Cells[1].Value);
                    }
                }

            }

            cmd.CommandText = "Select SPID, TENSP ,REPLACE(CONVERT(varchar(20), GIABAN, 1), '.00','') from SANPHAM";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            DGV_LuaChon.DataSource = table;

            DGV_LuaChon.Columns[0].HeaderText = "Mã sản phẩm";
            DGV_LuaChon.Columns[1].HeaderText = "Tên sản phẩm";
            DGV_LuaChon.Columns[2].HeaderText = "Giá (VND)";

            Box_LoaiHD.Text = "Đơn trực tiếp";
            Box_TrangThai.Text = "Hoàn thành";


            Table_GiamGia = new DataTable();
            cmd.CommandText = "Select * from KHUYENMAI WHERE NGAYKT > '"+DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")+"' ";
            adapter.SelectCommand = cmd;
            Table_GiamGia.Clear();
            if (adapter != null)
            {
                adapter.Fill(Table_GiamGia);
                foreach (DataRow i  in Table_GiamGia.Rows)
                {
                    Box_TenUuDai.Items.Add(i.ItemArray[0]);
                }

            }
            Box_TenUuDai.Items.Add("<Trống>");
        }

        private void CT_HD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Update_Tong();
        }

        public void Update_Tong()
        {
            Double sum = 0;
            foreach (DataGridViewRow i in CT_HD.Rows)
            {
                if(i.Cells[2].Value != null)
                    sum += Convert.ToDouble(Convert.ToDouble(i.Cells[3].Value) * Convert.ToDouble(i.Cells[2].Value.ToString().Replace(",", string.Empty)));
            }
            Box_Tong.Text = String.Format("{0:0,0}", sum);
            Gia_Giam();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            if (DGV_LuaChon.CurrentRow != null)
            {
                foreach(DataGridViewRow temp in CT_HD.Rows)
                {
                    if (DGV_LuaChon.CurrentRow.Cells[0].Value == temp.Cells[0].Value)
                    {
                        temp.Cells[3].Value = numericUpDown1.Value + Convert.ToInt32(temp.Cells[3].Value);
                        Update_Tong();
                        return;
                    }

                }
                DataGridViewRow row = (DataGridViewRow)CT_HD.Rows[0].Clone();
                row.Cells[0].Value = DGV_LuaChon.CurrentRow.Cells[0].Value;
                row.Cells[1].Value = DGV_LuaChon.CurrentRow.Cells[1].Value;
                row.Cells[2].Value = DGV_LuaChon.CurrentRow.Cells[2].Value;
                row.Cells[3].Value = numericUpDown1.Value;
                CT_HD.Rows.Add(row);
                
            }
            else
                MessageBox.Show("Phai lua chon san pham truoc");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            cmd.CommandText = "Select SPID, TENSP ,REPLACE(CONVERT(varchar(20), GIABAN, 1), '.00','') from SANPHAM WHERE (SPID like '%" + Box_MASP.Text+ "%' and TENSP like '%" + Box_TenSP.Text + "%')";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_LuaChon.DataSource = table;

            DGV_LuaChon.Columns[0].HeaderText = "Mã sản phẩm";
            DGV_LuaChon.Columns[1].HeaderText = "Tên sản phẩm";
            DGV_LuaChon.Columns[2].HeaderText = "Giá (VND)";
        }
        private void bnt_xoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                CT_HD.Rows.Remove(CT_HD.CurrentRow);
            }
            catch(Exception)
            {
                MessageBox.Show("Khong co san pham nao");
            }
        }

        private void CT_HD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Update_Tong();
        }

        private void bnt_tao_Click(object sender, EventArgs e)
        {
            if (CT_HD.RowCount < 2)
            {
                MessageBox.Show("Khong co san pham nao trong gio hang");
                return;
            }

            if (Box_LoaiHD.Text == "" || Box_TrangThai.Text == "")
            {
                MessageBox.Show("vui long nhap day du du lieu");
                return;
            }
            string x = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            cmd.CommandText = "set dateformat dmy";
            adapter.SelectCommand = cmd;
            try
            {
                
                cmd.CommandText = "insert into HDBH values ('" + Box_IDHD.Text + "','" + x + "','" + Box_IDKH.Text + "','" + Box_IDNV.Text + "','" + Box_GiaDaGiam.Text + "',N'" + Box_LoaiHD.Text + "',N'" + Box_TrangThai.Text + "') ";
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow i in CT_HD.Rows)
                {

                    if (i.Index == CT_HD.RowCount - 1)
                    {
                        break;
                    }

                    cmd.CommandText = "insert into CTHDBH values ('" + Box_IDHD.Text + "','" + i.Cells[0].Value + "','" + i.Cells[3].Value + "')";
                    cmd.ExecuteNonQuery();
                }
                if (Box_LoaiHD.SelectedItem.ToString() == "Đơn trực tiếp")
                {
                    DialogResult dialogResult = MessageBox.Show("In hóa đơn không ?", "Yes/No ?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form_CTHD cthd = new Form_CTHD(Box_IDHD.Text ,Box_IDKH.Text, Box_IDNV.Text, Box_LoaiHD.Text, Box_TrangThai.Text, Box_GiaDaGiam.Text);
                        cthd.Show();
                    }
                }
            }
            catch(SqlException)
            {
                this.Close();
            }                      
            this.Close();
        }
        private void DGV_LuaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1_Click(sender, e);
        }

        private void CT_HD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bnt_xoaSP_Click(sender, e);
        }

        private void Box_LoaiHD_TextChanged(object sender, EventArgs e)
        {
            if(Box_LoaiHD.Text =="Đơn trực tiếp")
            {
                Box_TrangThai.Text = "Hoàn thành";
            }
            else
            {
                Box_TrangThai.Text = "Nhận đơn";
            }
        }
        private void Box_IDKH_TextChanged(object sender, EventArgs e)
        {

            table = new DataTable();
            cmd.CommandText = "Select KHID from KHACHHANG WHERE (KHID like '%" + Box_IDKH.Text + "%')";
            adapter.SelectCommand = cmd;
            table.Clear();
            if (adapter != null)
            {
                adapter.Fill(table);
                foreach (DataRow i in table.Rows)
                {

                }

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void Box_IDKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box_TenKH.SelectedIndex = Box_IDKH.SelectedIndex;
        }

        private void Box_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
             Box_IDKH.SelectedIndex = Box_TenKH.SelectedIndex ;
        }

        private void DGV_LuaChon_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_LuaChon.CurrentRow == null)
                return;

            try
            {
                PTX_SanPham.Image = Image.FromFile(@"..\..\HangHoa\" + DGV_LuaChon.CurrentRow.Cells[0].Value + ".jpg");
                PTX_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                PTX_SanPham.Image = Image.FromFile(@"..\..\HangHoa\No Image.jpg");
                PTX_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Box_TenUuDai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Box_TenUuDai.Text == "<Trống>")
            {
                Box_DoiTuong.Text = "";
                Box_Giam.Text = "";
                Box_QuaTang.Text = "";
                Label_Loai.Text = " ";
                Box_SP.Text = "";
            }
            else
            {

                Box_DoiTuong.Text = Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[1].ToString();
                Box_QuaTang.Text = Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[7].ToString();
                Box_Giam.Text = Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[10].ToString();
                Box_SP.Text = Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[4].ToString();
                if (Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[9].ToString() == "Giảm theo phần trăm")
                {
                    Label_Loai.Text = "%";
                }
                else
                {
                    Label_Loai.Text = "VNĐ";
                }
            }
            if (Box_QuaTang.Text == string.Empty)
                Box_QuaTang.Enabled = false;
            else
                Box_QuaTang.Enabled = true;

            if (Box_Giam.Text == string.Empty)
                Box_Giam.Enabled = false;
            else
                Box_Giam.Enabled = true;
            if (Box_DoiTuong.Text == string.Empty)
                Box_DoiTuong.Enabled = false;
            else
                Box_DoiTuong.Enabled = true;  
            if(Box_SP.Text == string.Empty)
            {
                Box_SP.Enabled = false;
            }
            else
            {
                Box_SP.Enabled = true;
            }

            Gia_Giam();
        }
        private void Gia_Giam()
        {
            Box_GiaDaGiam.Text = Box_Tong.Text;

            if (Box_SP.Text == string.Empty)
                return;

            //neu giam gia theo mat hang la mat hang
            if(Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[3].ToString() == "Mặt hàng")
            {
                cmd.CommandText = "select LOAIID FROM LOAISP WHERE TENLOAI = '" + Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[4].ToString() + "' ";
                adapter.SelectCommand = cmd;

                DataTable temp = new DataTable();
                
                adapter.Fill(temp);

                string x;

                try
                {
                    x = temp.Rows[0].ItemArray[0].ToString();
                }
                catch
                {
                    return;
                }


                for(int i = 0;i<CT_HD.RowCount - 1;i++)
                {
                    if(CT_HD.Rows[i].Cells[0].Value.ToString().Contains(x))
                    {
                        //kiem tra dieu kien giam gia
                        if( Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[4].ToString() == "1")
                        {
                            if( (int)CT_HD.Rows[i].Cells[3].Value < Convert.ToInt32( Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[11]) || Convert.ToDouble(Box_Tong.Text) < Convert.ToDouble(Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[12]) )
                            {
                                return;
                            }
                        }
                        if (Label_Loai.Text == "%")
                        {
                            Box_GiaDaGiam.Text = Convert.ToString(Convert.ToDouble(Box_GiaDaGiam.Text) - Convert.ToDouble(CT_HD.Rows[i].Cells[2].Value) * Convert.ToDouble(Box_Giam.Text) / 100 * Convert.ToDouble(CT_HD.Rows[i].Cells[3].Value));
                            Box_GiaDaGiam.Text = String.Format("{0:0,0}", Convert.ToDouble(Box_GiaDaGiam.Text));
                        }
                        else
                        {
                            Box_GiaDaGiam.Text = Convert.ToString(Convert.ToDouble(Box_GiaDaGiam.Text) - Convert.ToDouble(Box_Giam.Text) * Convert.ToDouble(CT_HD.Rows[i].Cells[3]));
                            Box_GiaDaGiam.Text = String.Format("{0:0,0}", Convert.ToDouble(Box_GiaDaGiam.Text));
                        }
                    }
                }


            }
            //giam theo nha sx
            if (Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[3].ToString() == "Nhà cung cấp")
            {
               

                for (int i = 0; i < CT_HD.RowCount - 1; i++)
                {
                    cmd.CommandText = "select HANGSX FROM SANPHAM WHERE SPID = '" + CT_HD.Rows[i].Cells[0].Value.ToString() + "' ";
                    adapter.SelectCommand = cmd;
                    if (adapter != null)
                    {

                        //kiem tra dieu kien giam gia
                        if (Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[4].ToString() == "1")
                        {
                            if ((int)CT_HD.Rows[i].Cells[3].Value < Convert.ToInt32(Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[11]) || Convert.ToDouble(Box_Tong.Text) < Convert.ToDouble(Table_GiamGia.Rows[Box_TenUuDai.SelectedIndex].ItemArray[12]))
                            {
                                return;
                            }
                        }
                        //giam gia
                        if (Label_Loai.Text == "%")
                        {
                            Box_GiaDaGiam.Text = Convert.ToString(Convert.ToDouble(Box_GiaDaGiam.Text) - Convert.ToDouble(CT_HD.Rows[i].Cells[2].Value) * Convert.ToDouble(Box_Giam.Text) / 100 * Convert.ToDouble(CT_HD.Rows[i].Cells[3].Value));
                            Box_GiaDaGiam.Text = String.Format("{0:0,0}", Convert.ToDouble(Box_GiaDaGiam.Text));
                        }
                        else
                        {
                            Box_GiaDaGiam.Text = Convert.ToString(Convert.ToDouble(Box_GiaDaGiam.Text) - Convert.ToDouble(Box_Giam.Text) * Convert.ToDouble(CT_HD.Rows[i].Cells[3]));
                            Box_GiaDaGiam.Text = String.Format("{0:0,0}", Convert.ToDouble(Box_GiaDaGiam.Text));
                        }
                    }
                }
            }

        }

        private void Box_LoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Box_LoaiHD.SelectedIndex == 0)
                Box_TrangThai.SelectedIndex = 0;
            else
                Box_TrangThai.SelectedIndex = 1;
        }

    }
}
