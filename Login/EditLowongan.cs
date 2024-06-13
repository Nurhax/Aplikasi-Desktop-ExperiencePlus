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
using Newtonsoft.Json;
using LoginDaftar;
using LibraryTubes.Perusahaan;

namespace LoginDaftar
{
    public partial class EditLowongan : Form
    {
        private int indexList = 0;
        private readonly string apiUrl = "https://localhost:7102";
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

        private async void button1_Click(object sender, EventArgs e)
        {
            PerusahaanController editLowongan = new PerusahaanController();

            try
            {
                // Validasi input
                if (textNama.Text.Length >= 45)
                {
                    throw new ArgumentException("Nama lowongan lebih dari 45 karakter!");
                }
                if (string.IsNullOrEmpty(textSyarat.Text) || string.IsNullOrEmpty(textNama.Text) || string.IsNullOrEmpty(textDeskripsi.Text) || string.IsNullOrEmpty(textPeriode.Text))
                {
                    throw new ArgumentException("Kolom tidak boleh kosong!");
                }
                if (textSyarat.Text.Length >= 300)
                {
                    throw new ArgumentException("Syarat tidak boleh lebih dari 300 karakter!");
                }
                if (textDeskripsi.Text.Length >= 300)
                {
                    throw new ArgumentException("Deskripsi tidak boleh lebih dari 300 karakter!");
                }
                if (!PeriodeFormat(textPeriode.Text))
                {
                    throw new ArgumentException("Format periode tidak valid. Format yang benar: dd/mm/yyyy!");
                }


                // Validasi apakah nilai input sama dengan nilai yang ada
                if (textNama.Text == editLowongan.GetLowongan()[indexList].Nama && textDeskripsi.Text == editLowongan.GetLowongan()[indexList].Deskripsi && textSyarat.Text == editLowongan.GetLowongan()[indexList].Syarat && textPeriode.Text == editLowongan.GetLowongan()[indexList].Periode)
                {
                    throw new ArgumentException("Tidak ada perubahan pada kolom.");
                }

                // Membuat objek untuk lowongan yang mau diedit
                Lowongan_1302223025 editLowonganTersedia = new Lowongan_1302223025
                {
                    Id = editLowongan.GetLowongan()[indexList].Id,  // Pastikan ID tetap sama
                    Nama = textNama.Text,
                    Syarat = textSyarat.Text,
                    Deskripsi = textDeskripsi.Text,
                    Periode = textPeriode.Text
                };

                // Serialize lowongan menjadi JSON
                string jsonLowongan = JsonConvert.SerializeObject(editLowonganTersedia);

                // Buat client HTTP untuk mengirim permintaan ke API
                using (HttpClient client = new HttpClient())
                {
                    // Set header Content-Type untuk JSON
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    
                    // Kirim permintaan PUT ke API
                    HttpResponseMessage response = await client.PutAsync(apiUrl + "/edit/" + editLowongan.GetLowongan()[indexList].Id, new StringContent(jsonLowongan, Encoding.UTF8, "application/json"));

                    // Tanggapi hasil dari API
                    if (response.IsSuccessStatusCode)
                    {
                        ClearForm();
                        MessageBox.Show("Lowongan berhasil diedit!");
                        Form3 backToListLowongan = new Form3();
                        backToListLowongan.Tag = this;
                        backToListLowongan.Show();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show($"{editLowongan.GetLowongan().Count}");
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Gagal mengedit lowongan. Error: {errorMessage}");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{editLowongan.GetLowongan().Count}");
                errorMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool PeriodeFormat(string periode)
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
        private void ClearForm()
        {
            textNama.Clear();
            textDeskripsi.Clear();
            textSyarat.Clear();
            textPeriode.Clear();
        }
    }
}
/*
private async void button1_Click(object sender, EventArgs e)
{
    try
    {
        // Validasi input
        if (textNama.Text.Length >= 45)
        {
            throw new ArgumentException("Nama lowongan lebih dari 45 karakter!");
        }
        if (string.IsNullOrEmpty(textSyarat.Text) || string.IsNullOrEmpty(textNama.Text) || string.IsNullOrEmpty(textDeskripsi.Text) || string.IsNullOrEmpty(textPeriode.Text))
        {
            throw new ArgumentException("Kolom tidak boleh kosong!");
        }
        if (textSyarat.Text.Length >= 300)
        {
            throw new ArgumentException("Syarat tidak boleh lebih dari 300 karakter!");
        }
        if (textDeskripsi.Text.Length >= 300)
        {
            throw new ArgumentException("Deskripsi tidak boleh lebih dari 300 karakter!");
        }
        if (!PeriodeFormat(textPeriode.Text))
        {
            throw new ArgumentException("Format periode tidak valid. Format yang benar: dd/mm/yyyy!");
        }

        // Dapatkan indeks lowongan yang dipilih
        int selectedIndex = listBox1.SelectedIndex;
        if (selectedIndex < 0 || selectedIndex >= jobs.Count)
        {
            throw new ArgumentException("Pilih lowongan yang valid dari daftar.");
        }

        var selectedJob = jobs[selectedIndex];

        // Validasi apakah nilai input sama dengan nilai yang ada
        if (textNama.Text == selectedJob.Nama && textDeskripsi.Text == selectedJob.Deskripsi && textSyarat.Text == selectedJob.Syarat && textPeriode.Text == selectedJob.Periode)
        {
            throw new ArgumentException("Tidak ada perubahan pada kolom.");
        }

        // Membuat objek untuk lowongan yang mau diedit
        Lowongan_1302223025 editLowonganTersedia = new Lowongan_1302223025
        {
            Id = selectedJob.Id,  // Pastikan ID tetap sama
            Nama = textNama.Text,
            Syarat = textSyarat.Text,
            Deskripsi = textDeskripsi.Text,
            Periode = textPeriode.Text
        };

        // Serialize lowongan menjadi JSON
        string jsonLowongan = JsonConvert.SerializeObject(editLowonganTersedia);

        // Buat client HTTP untuk mengirim permintaan ke API
        using (HttpClient client = new HttpClient())
        {
            // Set header Content-Type untuk JSON
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // Kirim permintaan PUT ke API
            HttpResponseMessage response = await client.PutAsync(apiUrl + "/edit/" + selectedJob.Id, new StringContent(jsonLowongan, Encoding.UTF8, "application/json"));

            // Tanggapi hasil dari API
            if (response.IsSuccessStatusCode)
            {
                ClearForm();
                MessageBox.Show("Lowongan berhasil diedit!");
                Homepage backToHomepage = new Homepage();
                backToHomepage.Tag = this;
                backToHomepage.Show();
                Dispose();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Gagal mengedit lowongan. Error: {errorMessage}");
            }
        }
    }
    catch (ArgumentException ex)
    {
        errorMessage.Text = ex.Message;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
*/