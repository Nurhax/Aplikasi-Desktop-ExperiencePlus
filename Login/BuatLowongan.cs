﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDaftar
{
    public partial class BuatLowongan : Form
    {
        public BuatLowongan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Message buatlowongan berhasil dibuat
            Homepage BackToHomepage = new Homepage();
            BackToHomepage.Tag = this;
            BackToHomepage.Show();
            Dispose();
        }
    }
}
