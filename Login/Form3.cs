using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIforGUI.Controllers;
using Newtonsoft.Json;
using TubesKelompok5;
using TubesKelompok5.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginDaftar
{
    public partial class Form3 : Form
    {
        private List<Lowongan_1302223025> jobs;

        public Form3()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7102/api/Perusahaan";
            await LoadJobsFromApi(apiUrl);
        }

        private async Task LoadJobsFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string jsonData = await response.Content.ReadAsStringAsync();
                    jobs = JsonConvert.DeserializeObject<List<Lowongan_1302223025>>(jsonData);

                    listBox1.DataSource = jobs;
                    listBox1.DisplayMember = "Nama";
                    listBox1.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data from API: {ex.Message}");
                }
            }
        }

        private void listBox1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var selectedJob = (Lowongan)e.Item.Tag;
                labelNama.Text = selectedJob.Nama;
                labelDeskripsi.Text = selectedJob.Deskripsi;
                labelSyarat.Text = selectedJob.Syarat;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditLowongan edit = new EditLowongan(listBox1.SelectedIndex);
            edit.Tag = this;
            edit.Show();
            Hide();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDeskripsi_Click(object sender, EventArgs e)
        {

        }

        private void labelLowongan_Click(object sender, EventArgs e)
        {
            var selectedJob = new Lowongan_1302223025();
            labelNama.Text = selectedJob.Nama;
            labelDeskripsi.Text = selectedJob.Deskripsi;
            labelSyarat.Text = selectedJob.Syarat;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
