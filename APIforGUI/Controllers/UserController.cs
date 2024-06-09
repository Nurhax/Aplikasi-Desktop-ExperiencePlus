using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TubesKelompok5;
using TubesKelompok5.Model;

namespace APIforGUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerusahaanController : ControllerBase
    {
        private const string filePath = "perusahaan.json";
        private List<User_1302223025> _users;
        private List<Lowongan_1302223025> _lowongan = new List<Lowongan_1302223025>();

        public PerusahaanController()
        {
            try
            {
                LoadUsers(); // Load data dari file saat aplikasi dimulai
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error load data: {ex.Message}");
            }
        }

        //Getuser non API untuk login
        public List<User_1302223025> GetUsers()
        {
            return _users;
        }
        

        // Singleton Instance.
        private static PerusahaanController _instance;

        // Public static method to get the instance.
        public static PerusahaanController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PerusahaanController();
                }
                return _instance;
            }
        }

        private void LoadUsers()
        {
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                _users = JsonSerializer.Deserialize<List<User_1302223025>>(json);
            }
            else
            {
                _users = new List<User_1302223025>();
            }
        }

        internal void SetUsers(List<User_1302223025> users)
        {
            _users = users;
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(_users);
            System.IO.File.WriteAllText(filePath, json);
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            if (_users.Count == 0)
            {
                return Ok("Belum ada data");
            }

            return Ok(_users);
        }

        [HttpPost("register")]
        public IActionResult Register(User_1302223025 user)
        {
            // Precondition: User tidak boleh null
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Precondition: Email harus valid
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Username tidak boleh kosong", nameof(user.Username));
            }

            // Precondition: Password harus valid
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password tidak boleh kosong", nameof(user.Password));
            }
                       
            // Precondition: Email harus unik
            if (_users.Any(u => u.Username == user.Username))
            {
                return Conflict("Email sudah terdaftar");
            }

            // Operasi registrasi berhasil
            _users.Add(user);
            SaveUsers();

            // Postcondition: User terdaftar dalam daftar user
            if (!_users.Contains(user))
            {
                throw new Exception("Registrasi gagal");
            }

            return Ok("Registrasi berhasil");
        }

        [HttpPost("login")]
        public IActionResult Login(User_1302223025 user)
        {
            // Precondition: User tidak boleh null
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Precondition: Email harus valid
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Email tidak boleh kosong", nameof(user.Username));
            }

            // Precondition: Password harus valid
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password tidak boleh kosong", nameof(user.Password));
            }

            var existingUser = _users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (existingUser == null)
            {
                return Unauthorized("Email atau password salah");
            }

            return Ok(new { message = "Login berhasil"});
        }

        [HttpPost("create-lowongan/{username}")]
        public IActionResult CreateLowongan(string username, Lowongan_1302223025 lowongan)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return BadRequest("Username tidak boleh kosong");
            }

            if (lowongan == null)
            {
                return BadRequest("Lowongan tidak boleh null");
            }

            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return NotFound("User tidak ditemukan");
            }

            if (user.Lowongan == null)
            {
                user.Lowongan = new List<Lowongan_1302223025>();
            }

            if (user.Lowongan.Any(l => l.Id == lowongan.Id))
            {
                return Conflict("Lowongan dengan ID yang sama sudah ada");
            }

            lowongan.Id = new int();
            var emptyId = _lowongan.FirstOrDefault(l => l.Id == 0);
            if (emptyId != null)
            {
                // Gunakan ID yang kosong
                lowongan.Id = emptyId.Id;
                emptyId.Nama = lowongan.Nama;
                emptyId.Syarat = lowongan.Syarat;
                emptyId.Deskripsi = lowongan.Deskripsi;
                emptyId.Status = lowongan.Status;
                emptyId.Periode = lowongan.Periode;
            }
            else
            {
                // Cari ID yang belum digunakan
                int newId = 1;
                while (_lowongan.Any(l => l.Id == newId))
                {
                    newId++;
                }
                lowongan.Id = newId;
                _lowongan.Add(lowongan);
            }
            SaveUsers();

            return Ok("Lowongan berhasil dibuat");
        }

        [HttpPut("edit-lowongan/{username}/{lowonganId}")]
        public IActionResult EditLowongan(string username, int lowonganId, Lowongan_1302223025 updatedLowongan)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return BadRequest("Username tidak boleh kosong");
            }

            if (updatedLowongan == null)
            {
                return BadRequest("Lowongan tidak boleh null");
            }

            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return NotFound("User tidak ditemukan");
            }

            var lowongan = user.Lowongan.FirstOrDefault(l => l.Id == lowonganId);
            if (lowongan == null)
            {
                return NotFound("Lowongan tidak ditemukan");
            }
                        
            lowongan.Nama = updatedLowongan.Nama;
            lowongan.Syarat = updatedLowongan.Syarat;
            lowongan.Deskripsi = updatedLowongan.Deskripsi;
            lowongan.Status = updatedLowongan.Status;
            lowongan.Periode = updatedLowongan.Periode;

            SaveUsers();

            return Ok("Lowongan berhasil diperbarui");
        }

    }
}