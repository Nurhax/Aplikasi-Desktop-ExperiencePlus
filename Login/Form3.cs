using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LoginDaftar
{
    public partial class Form3 : Form
    {
        // Menghubungkan dengan API
        private static readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7102/") };
        private List<Lowongan> jobs = new List<Lowongan>();

        // Merefresh konten listBox saat tombol 'refresh' diklik
        public Form3()
        {
            InitializeComponent();
            buttonLoad.Click += buttonLoad_Click;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        // Event handler untuk tombol 'Refresh'
        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            await LoadJobsFromApi("api/Lowongan");
        }

        // Method untuk mengambil data lowongan melalui API
        private async Task LoadJobsFromApi(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string jsonData = await response.Content.ReadAsStringAsync();
                jobs = JsonConvert.DeserializeObject<List<Lowongan>>(jsonData);


                listBox1.Items.Clear();
                foreach (var lowongan in jobs)
                {
                    listBox1.Items.Add(lowongan.Nama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Memuat Data Dari API: {ex.Message}");
            }
        }

        // Event Handler untuk nama lowongan yang dipilih pada listBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < jobs.Count)
            {
                // Memunculkan detail lowongan berdasarkan nama lowongan yang dipilih
                var lowonganKlik = jobs[listBox1.SelectedIndex];
                labelNama.Text = lowonganKlik.Nama;
                labelDeskripsi.Text = lowonganKlik.Deskripsi;
                labelSyarat.Text = lowonganKlik.Syarat;
            }
        }

        public class Lowongan
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Syarat { get; set; }
            public string Deskripsi { get; set; }
            public int Status { get; set; }
            public string Periode { get; set; }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditLowongan edit = new EditLowongan(listBox1.SelectedIndex);
            edit.Tag = this;
            edit.Show();
            Hide();
        }
    }
}