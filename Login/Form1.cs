using APIforGUI.Controllers;
using LoginDaftar;
using System.Windows.Forms;
using TubesKelompok5;

namespace Login
{
    public partial class Form1 : Form
    {

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
            Form2 form = new Form2();
            form.Tag = this;
            form.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            //Verifikasi login dengan secure code
            try
            {
                PerusahaanController UserVerification = PerusahaanController.Instance;


                if (string.IsNullOrEmpty(usernameLogin.Text) && string.IsNullOrEmpty(passwordLogin.Text))
                {
                    throw new ArgumentException("Username dan Password harus diisi terlebih dahulu!");
                }

                //Searching kredensial user yang sesuai
                bool isUserVerified = false;
                for (int i = 0; i < UserVerification.GetUsers().Count; i++)
                {
                    if (usernameLogin.Text == UserVerification.GetUsers()[i].Username && passwordLogin.Text == UserVerification.GetUsers()[i].Password)
                    {
                        isUserVerified = true;
                        break;
                    }
                }

                if (isUserVerified)
                {
                    Homepage Homepage = new Homepage();
                    Homepage.Tag = this;
                    Homepage.Show();
                    Hide();
                }
                else
                {
                    throw new ArgumentException("Username atau Password salah!");
                }
            }
            catch (ArgumentException EX)
            {
                ErrorPlaceHolder.Text = EX.Message;
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
