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

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, "D:\\KPLFinal\\APIforGUI\\lowongan.json");

            string jsonData = File.ReadAllText(jsonFilePath);
            List<Job> jobs = JsonConvert.DeserializeObject<List<Job>>(jsonData);
            listBox1.Items.Clear();
            foreach (var job in jobs)
            {
                ListViewItem item = new ListViewItem(job.Nama);
                item.Tag = job;
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var selectedJob = (Job)e.Item.Tag;
                labelNama.Text = selectedJob.Nama;
                labelDeskripsi.Text = selectedJob.Deskripsi;
                labelSyarat.Text = selectedJob.Syarat;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditLowongan edit = new EditLowongan();
            edit.Tag = this;
            edit.Show();
            Hide();
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
    }

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
