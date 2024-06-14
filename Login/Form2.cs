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
        private readonly string ApiUrl = "https://localhost:7102/api/Perusahaan";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            PerusahaanController userVerification = PerusahaanController.Instance;

            try
            {
                // validasi input
                if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text))
                {
                    throw new ArgumentException("Semua kolom harus diisi!");
                }
                if (textUsername.Text.Length < 8)
                {
                    throw new ArgumentException("Username Harus Lebih dari 8 Karakter");
                }
                if (textUsername.Text.Length > 20)
                {
                    throw new ArgumentException("Username Harus Kurang dari 20 Karakter");
                }

                // Hashing password
                string hashedPassword = HashingPassword.HashPassword(textPassword.Text);

                // buat objek akun baru
                User_1302223025 newUser = new User_1302223025(textUsername.Text, textPassword.Text, new List<TubesKelompok5.Model.Lowongan_1302223025>())
                {
                    Username = textUsername.Text,
                    Password = textPassword.Text,
                    Lowongan = new List<TubesKelompok5.Model.Lowongan_1302223025> { }
                };

                // Serialize akun menjadi JSON 
                string jsonAkun = JsonConvert.SerializeObject(newUser);

                // Buat client HTTP untuk mengirim permintaan ke API
                using (HttpClient client = new HttpClient())
                {
                    // Set header Content-Type untuk JSON
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Kirim permintaan POST ke API
                    HttpResponseMessage response = await client.PostAsync(ApiUrl + "/register/", new StringContent(jsonAkun, Encoding.UTF8, "application/json"));

                    // Tanggapi hasil dari API
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registrasi berhasil");
                        Form1 BackToLogin = new Form1();
                        BackToLogin.Tag = this;
                        BackToLogin.Show();
                        Dispose();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Gagal Registrasi. Error: {errorMessage}");
                    }
                }

            }
            catch (ArgumentException ex)
            {
                warningMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
