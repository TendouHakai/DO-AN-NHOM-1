﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_sale_manager
{
    public partial class Form_main_NV : Form
    {
        public Form_main_NV()
        {
            InitializeComponent();
        }
        public event EventHandler Thoat;

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Thoat(this, new EventArgs());
        }
    }
}