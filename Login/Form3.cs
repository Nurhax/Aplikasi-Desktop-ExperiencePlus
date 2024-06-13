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
        private static readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7102/") };
        private List<Lowongan> jobs = new List<Lowongan>();

        public Form3()
        {
            InitializeComponent();
            buttonLoad.Click += buttonLoad_Click; // Event handler for the Load button
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged; // Event handler for item selection
        }

        // Event handler for the Load button
        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            await LoadJobsFromApi("api/Lowongan"); // Pass the API endpoint to the method
        }

        // Method to load jobs from the API
        private async Task LoadJobsFromApi(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl); // Send GET request
                response.EnsureSuccessStatusCode(); // Ensure the request was successful

                string jsonData = await response.Content.ReadAsStringAsync(); // Read the response content
                jobs = JsonConvert.DeserializeObject<List<Lowongan>>(jsonData); // Deserialize JSON to list of jobs

                // Bind the data to the ListBox
                listBox1.Items.Clear(); // Clear any existing items
                foreach (var job in jobs)
                {
                    listBox1.Items.Add(job.Nama); // Add each job's name to the ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from API: {ex.Message}");
            }
        }

        // Event handler for item selection in the ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < jobs.Count) // Check if a valid item is selected
            {
                var selectedJob = jobs[listBox1.SelectedIndex]; // Get the selected job based on the index
                labelNama.Text = selectedJob.Nama;
                labelDeskripsi.Text = selectedJob.Deskripsi;
                labelSyarat.Text = selectedJob.Syarat;
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            /*EditLowongan edit = new EditLowongan();
            edit.Tag = this;
            edit.Show();
            Hide();*/
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Syarat { get; set; }
            public string Deskripsi { get; set; }
            public int Status { get; set; }
            public string Periode { get; set; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}