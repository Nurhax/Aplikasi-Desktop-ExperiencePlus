using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginDaftar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Nama", 150);
            listView1.Columns.Add("Syarat", 150);
            listView1.Columns.Add("Deskripsi", 250);
            listView1.Columns.Add("Periode", 100);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Path ke file JSON
            string jsonFilePath = Path.Combine(Application.StartupPath, "D:\\KPLFinal\\APIforGUI\\lowongan.json");

            // Baca isi file JSON
            string jsonData = File.ReadAllText(jsonFilePath);

            // Deserialisasi JSON ke list of objects
            List<Job> jobs = JsonConvert.DeserializeObject<List<Job>>(jsonData);

            // Misalkan kita ambil data pekerjaan pertama untuk ditampilkan
            var job = jobs[0];

            // Tampilkan data di Label
            labelNama.Text = job.Nama;
            labelDeskripsi.Text = job.Deskripsi;
            labelSyarat.Text = job.Syarat;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditLowongan edit = new EditLowongan();
            edit.Tag = this;
            edit.Show();
            Hide();
        }
    }

    // Kelas untuk merepresentasikan data JSON
    public class Job
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Syarat { get; set; }
        public string Deskripsi { get; set; }
        public int Status { get; set; }
        public string Periode { get; set; }
    }
}
