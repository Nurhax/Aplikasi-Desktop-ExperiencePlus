using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TubesKelompok5.StatusLowongan;
using TubesKelompok5.Model;
using System.Text.RegularExpressions;
using APIforGUI.Controllers;
using TubesKelompok5;

namespace LoginDaftar
{
    public partial class EditLowongan : Form
    {
        private int indexList = 0;
        public EditLowongan(int indexList)
        {
            InitializeComponent();
            this.indexList = indexList;
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
            PerusahaanController editLowongan = new PerusahaanController();
            Lowongan_1302223025 hasilEdit = new Lowongan_1302223025();
            //Message lowongan berhasil diedit
            if (textNama.Text.Length >= 45)
            {
                throw new Exception("Nama lowongan lebih dari 45 karakter!");
            }
            if(String.IsNullOrEmpty(textSyarat.Text) && String.IsNullOrEmpty(textNama.Text) && String.IsNullOrEmpty(textDeskripsi.Text) && String.IsNullOrEmpty(textPeriode.Text) )
            {
                throw new Exception("Kolom tidak boleh kosong!");
            }
            if(textSyarat.Text.Length >= 300)
            {
                throw new Exception("syarat tidak boleh lebih dari 300 karakter!");
            }
            if(textDeskripsi.Text.Length >= 300)
            {
                throw new Exception("Deskripsi tidak boleh lebih dari 300 karakter!");
            }
            if (periodeFormat(textPeriode.Text))
            {
                throw new Exception("Format periode tidak valid. Format yang benar: dd/mm/yyyy!");
            }

            /*var edit = editLowongan.GetUsers();
            if (indexList >= 0 && indexList < edit.Count)
            {
                if(textNama.Text != edit[indexList].getLowongan()[indexList].Nama || textDeskripsi.Text != edit[indexList].getLowongan()[indexList].Deskripsi || textSyarat.Text != edit[indexList].getLowongan()[indexList].Syarat || textPeriode.Text != edit[indexList].getLowongan()[indexList].Periode)
                {
                    editLowongan.EditLowongan(edit[indexList].Username,indexList,hasilEdit);
                }else
                {
                    throw new Exception("Kolom tidak boleh sama");
                }
            }*/


            Homepage BackToHomePage = new Homepage();
            BackToHomePage.Tag = this;
            BackToHomePage.Show();
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool periodeFormat(string periode)
        {
            // Regex untuk format ../../..
            var regex1 = new Regex(@"^\d{2}/\d{2}/\d{4}$");

            return regex1.IsMatch(periode);
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSyarat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPeriode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
