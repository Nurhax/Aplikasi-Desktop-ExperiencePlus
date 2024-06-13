using APIforGUI.Controllers;
using LibraryTubes.Hashing;
using Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKelompok5;

namespace LoginDaftar
{
    public partial class Form2 : Form
    {
        private readonly string apiUrl = "https://localhost:7102/api/Perusahaan";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            PerusahaanController userVerification = new PerusahaanController();

            try
            {
                // validasi input
                if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text)) 
                {
                    throw new ArgumentException("Semua kolom harus diisi!");
                }
                else if (textUsername.Text.Length < 8)
                {
                    throw new ArgumentException("Username Harus Lebih dari 8 Karakter");
                }
                else if (textUsername.Text.Length > 20)
                {
                    throw new ArgumentException("Username Harus Kurang dari 20 Karakter");
                }
                else if (textUsername.TextLength > 8 && textUsername.TextLength < 20)
                {
                    string hashedPassword = HashingPassword.HashPassword(textPassword.Text);
                }

                // validasi jika memiliki username yang sudah tersedia
                bool chekAccount = false;
                for (int i = 0; i < userVerification.GetUsers().Count; i++)
                {
                    if (textUsername.Text == userVerification.GetUsers()[i].Username)
                    {
                        throw new ArgumentException("Username Sudah Tersedia");
                    }
                    else
                    {
                        chekAccount = true;
                        break;
                    }
                }

                // buat objek akun baru
                User_1302223025 newUser = new User_1302223025
                {
                    Username = textUsername.Text,
                    Password = textPassword.Text
                };

                // Serialize akun menjadi JSON 
                string jsonAkun = JsonConvert.SerializeObject(newUser);

                // Buat client HTTP untuk mengirim permintaan ke API
                using (HttpClient client = new HttpClient())
                {
                    // Set header Content-Type untuk JSON
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Kirim permintaan POST ke API
                    HttpResponseMessage response = await client.PostAsync(apiUrl + "/register/", new StringContent(jsonAkun, Encoding.UTF8, "application/json"));

                    // Tanggapi hasil dari API
                    if (response.IsSuccessStatusCode) 
                    {
                        Form1 BackToLogin = new Form1();
                        BackToLogin.Tag = this;
                        BackToLogin.Show();
                        Dispose();
                    }
                }
                
            } 
            catch (ArgumentException ex)
            {
                warningMessage.Text = ex.Message;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dummyUploadCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
