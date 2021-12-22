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
    public partial class DTCC_guest_modifier : Form
    {
        public string filepath = "";
        public static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["stringDatabase"].ConnectionString;
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
        public DTCC_guest_modifier()
        {
            InitializeComponent();
            dateTimePicker_NGDT_z.Format = DateTimePickerFormat.Custom;
            dateTimePicker_NGDT_z.CustomFormat = "yyyy/MM/dd";
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
            string loaiKH = "";
            if (string.IsNullOrEmpty(comboBox_loaiKH.Text)!=true)
                if (comboBox_loaiKH.Text == "Khách thường")
                    loaiKH = "NOR";
                else
                    loaiKH = "VIP";
            if (exedata("Update KHACHHANG set HOTEN = N'" + textBox_TENDT_z.Text + "', SDT = '" + textBox_SDT_z.Text + "', NGDK = '"
                + dateTimePicker_NGDT_z.Value + "', DIACHI = N'" + textBox_DIACHI_z.Text + "', DOANHSO = '" + textBox_budget_z.Text + "', LOAIID = '"
                + loaiKH + "' where KHID = '" + textBox_ID_z.Text + "'") == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                SaveFileDialog Save = new SaveFileDialog();
                if (filepath != "")
                {
                    Save.FileName = @"Image samples for testing\KHDK\" + textBox_ID_z.Text + ".jpg";
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

        private void button_DTCC_Reject_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
