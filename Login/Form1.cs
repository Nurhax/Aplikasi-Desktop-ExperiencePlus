using APIforGUI.Controllers;
using LoginDaftar;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using TubesKelompok5;
using TubesKelompok5.Model;

namespace Login
{
    public partial class Form1 : Form
    {
        private readonly string apiUrl = "https://localhost:7102/api/Perusahaan";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.Tag = this;
            Form.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            //Verifikasi login dengan secure code
            try
            {
                PerusahaanController UserVerification = PerusahaanController.Instance;


                if (string.IsNullOrEmpty(usernameLogin.Text) && string.IsNullOrEmpty(passwordLogin.Text))
                {
                    throw new ArgumentException("Username dan Password harus diisi terlebih dahulu!");
                }

                // Buat objek user dari inputan
                User_1302223025 user = PerusahaanController.Instance.GetUsers().FirstOrDefault(u => u.Username == usernameLogin.Text && u.Password == passwordLogin.Text);

                if (user == null)
                {
                    throw new ArgumentException("Username atau Password salah!");
                }


                // Serialize user ke JSON
                string jsonUser = JsonConvert.SerializeObject(user);

                // Buat client HTTP untuk mengirim permintaan ke API
                using (HttpClient client = new HttpClient())
                {
                    // Set header Content-Type untuk JSON
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Kirim permintaan POST ke API
                    HttpResponseMessage response = await client.PostAsync(apiUrl + "/login/", new StringContent(jsonUser, Encoding.UTF8, "application/json"));

                    // Tanggapi hasil dari API
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        dynamic result = JsonConvert.DeserializeObject(responseBody);
                        // Ambil data pengguna dari API dan simpan sebagai CurrentUser
                        PerusahaanController.Instance.CurrentUser = user;
                        MessageBox.Show(result.message.ToString());
                        // Pindah ke Homepage
                        Homepage homepage = new Homepage();
                        homepage.Tag = this;
                        homepage.Show();
                        Hide();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Login gagal. Error: {errorMessage}");
                    }
                Debug.WriteLine($"API URL: {apiUrl}");
                Debug.WriteLine($"JSON User: {jsonUser}");
                Debug.WriteLine($"Response Status Code: {response.StatusCode}");
                Debug.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (ArgumentException EX)
            {
                ErrorPlaceHolder.Text = EX.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void usernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLogin_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
