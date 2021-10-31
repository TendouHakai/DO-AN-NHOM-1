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
    public partial class Form_GiaoDich : Form
    {
        string strcon = "Data Source=DESKTOP-BQASASP;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection AAA;
        SqlCommand command;
        SqlDataAdapter ADT = new SqlDataAdapter();
        DataTable table;
        public Form_GiaoDich()
        {
            InitializeComponent();            
                      
        }

        public Form_GiaoDich(string Manv)
        {
            InitializeComponent();

            Box_IDNV.Text = Manv;

            AAA = new SqlConnection(strcon);
            AAA.Open();
            command = AAA.CreateCommand();

            table = new DataTable();
            command.CommandText = "select * from HDBH";
            ADT.SelectCommand = command;
            table.Clear();
            ADT.Fill(table);
            Box_IDHD.Text = "hd" + Convert.ToString(table.Rows.Count + 1);

            command.CommandText = "Select SPID, GIABAN from SANPHAM";
            ADT.SelectCommand = command;
            table = new DataTable();
            ADT.Fill(table);
            DGV_LuaChon.DataSource = table;


        }

        private void CT_HD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int sum = 0;
            foreach(DataGridViewRow i in CT_HD.Rows)
            {
              sum+= 10000*Convert.ToInt32(i.Cells[1].Value) *Convert.ToInt32( i.Cells[2].Value);
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
                        temp.Cells[2].Value = numericUpDown1.Value + Convert.ToInt32(temp.Cells[2].Value);
                        return;
                    }

                }
                DataGridViewRow row = (DataGridViewRow)CT_HD.Rows[0].Clone();
                row.Cells[0].Value = DGV_LuaChon.CurrentRow.Cells[0].Value;
                row.Cells[1].Value = DGV_LuaChon.CurrentRow.Cells[1].Value;
                row.Cells[2].Value = numericUpDown1.Value;
                CT_HD.Rows.Add(row);
                
            }
            else
                MessageBox.Show("Phai lua chon san pham truoc");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Combobox_sp_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            command.CommandText = "Select SPID, GIABAN from SANPHAM WHERE (SPID like '%"+Box_SP.Text+"%')";
            ADT.SelectCommand = command;
            table.Clear();
            ADT.Fill(table);
            DGV_LuaChon.DataSource = table;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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
            int sum = 0;
            foreach (DataGridViewRow i in CT_HD.Rows)
            {
               sum += 10000* Convert.ToInt32(i.Cells[1].Value) * Convert.ToInt32(i.Cells[2].Value);
            }
            Box_Tong.Text = Convert.ToString(sum);
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

                DateTime dt = dateTimePicker1.Value;
            string x = dt.ToShortDateString();
            command.CommandText = "set dateformat dmy";
            ADT.SelectCommand = command;
            try
            { 
                command.CommandText = "insert into HDBH values ('" + Box_IDHD.Text + "','" + x + "','" + Box_IDKH.Text + "','" + Box_IDNV.Text + "','" + Box_Tong.Text + "','" + Box_LoaiHD.Text + "','" + Box_TrangThai.Text + "') ";
                command.ExecuteNonQuery();
                foreach (DataGridViewRow i in CT_HD.Rows)
                {
                    command.CommandText = "insert into CTHDBH values ('" + Box_IDHD.Text + "','" + i.Cells[0].Value + "','" + i.Cells[2].Value + "')";
                    command.ExecuteNonQuery();
                }
            }
            catch(SqlException )
            {
                MessageBox.Show("nhap dung du lieu");
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

        private void Box_IDKH_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            command.CommandText = "Select KHID from KHACHHANG WHERE (KHID like '%" + Box_IDKH.Text + "%')";
            ADT.SelectCommand = command;
            table.Clear();
            if (ADT != null)
            {
                ADT.Fill(table);
                Box_IDKH.ValueMember = Convert.ToString(table);
            }
        }
    }
}
