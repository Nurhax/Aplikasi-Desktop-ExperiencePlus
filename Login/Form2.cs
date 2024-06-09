using Login;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 BackToLogin = new Form1();
            BackToLogin.Tag = this;
            BackToLogin.Show();
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
