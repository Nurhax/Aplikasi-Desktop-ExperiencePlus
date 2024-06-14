using APIforGUI.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKelompok5.Model;
using TubesKelompok5;

namespace LoginDaftar
{
    public partial class BuatLowongan : Form
    {
        private readonly string ApiUrl = "https://localhost:7102/api/Perusahaan";
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
        private bool PeriodeFormat(string periode)
        {
            // Regex untuk format ../../..
            var regex1 = new Regex(@"^\d{2}/\d{2}/\d{4}$");

            return regex1.IsMatch(periode);
        }

        private void ClearForm()
        {
            textBoxNama.Clear();
            textBoxDeskripsi.Clear();
            textBoxSyarat.Clear();
            textBoxPeriode.Clear();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDeskripsi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSyarat.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPeriode.Text))
                {
                    throw new ArgumentException("Semua kolom harus diisi!");
                }

                // Validasi format periode
                if (!PeriodeFormat(textBoxPeriode.Text))
                {
                    throw new ArgumentException("Format periode tidak valid. Format yang benar: dd/MM/yyyy");
                }

                // Dapatkan pengguna yang sedang login
                PerusahaanController UserVerification = PerusahaanController.Instance;
                var currentUser = UserVerification.CurrentUser;

                if (currentUser == null)
                {
                    throw new InvalidOperationException("Pengguna tidak ditemukan. Silakan login terlebih dahulu.");
                }

                // Buat objek Lowongan baru
                Lowongan_1302223025 newLowongan = new Lowongan_1302223025
                {
                    Nama = textBoxNama.Text,
                    Syarat = textBoxSyarat.Text,
                    Deskripsi = textBoxDeskripsi.Text,
                    Status = 0, 
                    Periode = textBoxPeriode.Text
                };

                // Serialize lowongan menjadi JSON
                string jsonLowongan = JsonConvert.SerializeObject(newLowongan);

                // Buat client HTTP untuk mengirim permintaan ke API
                using (HttpClient client = new HttpClient())
                {
                    // Set header Content-Type untuk JSON
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Kirim permintaan POST ke API
                    HttpResponseMessage response = await client.PostAsync(ApiUrl + "/create-lowongan/" + currentUser.Username, new StringContent(jsonLowongan, Encoding.UTF8, "application/json"));

                    // Tanggapi hasil dari API
                    if (response.IsSuccessStatusCode)
                    {
                        ClearForm(); // Bersihkan formulir setelah berhasil membuat lowongan
                        MessageBox.Show("Lowongan berhasil dibuat!");
                        Homepage BackToHomepage = new Homepage();
                        BackToHomepage.Tag = this;
                        BackToHomepage.Show();
                        Dispose();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Gagal membuat lowongan. Error: {errorMessage}");
                    }
                }
            } 
            catch (ArgumentException ex) 
            { 
                ErrorHandlingLabel.Text = ex.Message;
            }
            catch (InvalidOperationException ex)
            {
                ErrorHandlingLabel.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrorHandlingLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSyarat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPeriode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
