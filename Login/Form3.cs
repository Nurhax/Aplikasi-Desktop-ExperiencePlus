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
using TubesKelompok5.Model;
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
            List<Lowongan_1302223025> jobs = JsonConvert.DeserializeObject<List<Lowongan_1302223025>>(jsonData);
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
                var selectedJob = (Lowongan_1302223025)e.Item.Tag;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
