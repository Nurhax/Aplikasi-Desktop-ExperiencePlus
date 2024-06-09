using LoginDaftar;
using System.Windows.Forms;

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
                Homepage homepage = new Homepage();
                homepage.Tag = this;
                homepage.Show();
                Hide();
            }
            catch(ArgumentException EX)
            {

            }
            
        }

        private void usernameLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
