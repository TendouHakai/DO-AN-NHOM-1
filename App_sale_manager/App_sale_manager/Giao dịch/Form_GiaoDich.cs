﻿using System;
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
        public Form_GiaoDich()
        {
            InitializeComponent();            
                      
        }

        public Form_GiaoDich(string Manv)
        {
            InitializeComponent();

            Box_IDNV.Text = Manv;

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            cmd = sqlCon.CreateCommand();

            table = new DataTable();
            cmd.CommandText = "select * from HDBH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            Box_IDHD.Text = "hd" + Convert.ToString(table.Rows.Count + 1);

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

            DTP_NGHD.Value = DateTime.Today;
            cmd.CommandText = "Select SPID, TENSP ,GIABAN from SANPHAM";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            DGV_LuaChon.DataSource = table;

            Box_LoaiHD.Text = "DTT";
            Box_TrangThai.Text = "HOANTAT";

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
                sum += Convert.ToDouble(i.Cells[2].Value) * Convert.ToDouble(i.Cells[3].Value);
            }
            Box_Tong.Text = Convert.ToString(sum);
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
            cmd.CommandText = "Select SPID, TENSP ,GIABAN from SANPHAM WHERE (SPID like '%"+Box_MASP.Text+ "%' and TENSP like '%" + Box_TenSP.Text + "%')";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_LuaChon.DataSource = table;
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

            DateTime dt = DTP_NGHD.Value;
            string x = dt.ToShortDateString();
            cmd.CommandText = "set dateformat dmy";
            adapter.SelectCommand = cmd;
            try
            {
                
                cmd.CommandText = "insert into HDBH values ('" + Box_IDHD.Text + "','" + x + "','" + Box_IDKH.Text + "','" + Box_IDNV.Text + "','" + Box_Tong.Text + "','" + Box_LoaiHD.Text + "','" + Box_TrangThai.Text + "') ";
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
                if (Box_LoaiHD.SelectedItem.ToString() == "DTT")
                {
                    DialogResult dialogResult = MessageBox.Show("In hóa đơn không ?", "Yes/No ?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form_CTHD cthd = new Form_CTHD(Box_IDHD.Text, Box_IDKH.Text, Box_IDNV.Text, Box_LoaiHD.Text, Box_TrangThai.Text, Box_Tong.Text);
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
            if(Box_LoaiHD.Text =="DTT")
            {
                Box_TrangThai.Text = "HOANTAT";
            }
            else
            {
                Box_TrangThai.Text = "NHANDON";
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
            PTX_SanPham.Image = Image.FromFile(@"..\..\HangHoa\" + DGV_LuaChon.CurrentRow.Cells[0].Value + ".jpg");
            PTX_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
