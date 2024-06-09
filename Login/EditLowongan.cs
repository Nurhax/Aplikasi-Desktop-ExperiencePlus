using System;
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
    public partial class EditLowongan : Form
    {
        public EditLowongan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditLowongan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Message lowongan berhasil diedit
            Homepage BackToHomePage = new Homepage();
            BackToHomePage.Tag = this;
            BackToHomePage.Show();
            Dispose();
        }
    }
}
