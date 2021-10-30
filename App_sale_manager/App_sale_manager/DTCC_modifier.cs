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

namespace App_sale_manager
{
    public partial class DTCC_modifier : Form
    {
        public string filepath = "";
        public static string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=QUANLYBANHANG_LTTQ;Integrated Security=True";
        SqlConnection con = new SqlConnection(strCon);
        private void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public event EventHandler RefreshData;
        private void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        public DTCC_modifier()
        {
            InitializeComponent();
            dateTimePicker_NGDT_z.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NGDT_z.CustomFormat = "yyyy/MM/dd";
        }

        private void DTCC_modifier_Load(object sender, EventArgs e)
        {
        }

        private void button_Image_import_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog Open1 = new OpenFileDialog();
            Open1.Filter = " Image file (*.BMP,*.JPG,*.JPEG)|*.bmp;*.jpg;*.jpeg ";
            Open1.Multiselect = false;
            if (Open1.ShowDialog() == DialogResult.OK)
            {
                filepath = Open1.FileName;
                pictureBox_image_import.Image = Image.FromFile(filepath);
                this.label_image_name.Text = filepath;
            }
        }

        private void button_DTCC_Accept_Click(object sender, EventArgs e)
        {
            if (exedata("Update DTCC set TENDT = '" + textBox_TENDT_z.Text + "', SDT = '" + textBox_SDT_z.Text + "', NGDT = '" + dateTimePicker_NGDT_z.Value + "', DIACHI = '" + textBox_DIACHI_z.Text + "' where DTID = '"+textBox_ID_z.Text+"'") == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                SaveFileDialog Save = new SaveFileDialog();
                if (filepath!="")
                {
                    Save.FileName = @"Image samples for testing\" + textBox_TENDT_z.Text + ".jpg";
                    pictureBox_image_import.Image.Save(Save.FileName);
                }
                RefreshData(this, new EventArgs());
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
    }
}
