﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.RegularExpressions;
using TubesKelompok5;
using TubesKelompok5.Model;

namespace APIforGUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerusahaanController : ControllerBase
    {
        private const string filePath = "D:\\Tel U\\Semester 4\\KPL\\TubesV3 - Copy\\APIforGUI\\perusahaan.json";

        private List<User_1302223025> _users;
        public List<Lowongan_1302223025> _lowongan = new List<Lowongan_1302223025>();
        // Properti untuk menyimpan pengguna yang sedang login
        public User_1302223025 CurrentUser { get; set; }

        public PerusahaanController()
        {
            try
            {
                _users = LoadUsersFromFile(); // Load data dari file saat aplikasi dimulai
                _lowongan = LoadLowonganFromFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error load data: {ex.Message}");
            }
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
        private static List<User_1302223025> LoadUsersFromFile()
        {
            if (!System.IO.File.Exists(filePath))
            {
                return new List<User_1302223025>();
            }

            string json = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<User_1302223025>>(json) ?? new List<User_1302223025>();
        }

        internal void SetUsers(List<User_1302223025> users)
        {
            _users = users;
        }

        private void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(_users);
            System.IO.File.WriteAllText(filePath, json);
        }

        private void SaveLowonganListToFile()
        {
            string json = JsonConvert.SerializeObject(_lowongan);
            System.IO.File.WriteAllText("D:\\Tel U\\Semester 4\\KPL\\TubesV3 - Copy\\APIforGUI\\lowongan.json", json);
        }

        private static List<Lowongan_1302223025> LoadLowonganFromFile()
        {
            if (!System.IO.File.Exists("D:\\Tel U\\Semester 4\\KPL\\TubesV3 - Copy\\APIforGUI\\lowongan.json"))
            {
                return new List<Lowongan_1302223025>();
            }

            string json = System.IO.File.ReadAllText("D:\\Tel U\\Semester 4\\KPL\\TubesV3 - Copy\\APIforGUI\\lowongan.json");
            return JsonConvert.DeserializeObject<List<Lowongan_1302223025>>(json) ?? new List<Lowongan_1302223025>();
        }

        private bool PeriodeFormat(string periode)
        {
            // Regex untuk format ../../..
            var regex1 = new Regex(@"^\d{2}/\d{2}/\d{4}$");
            return regex1.IsMatch(periode);
        }

        // Metode untuk mendapatkan semua lowongan
        [HttpGet("lowongan")]
        public List<Lowongan_1302223025> GetLowongan()
        {
            return _lowongan;
        }

        // Metode untuk mendapatkan semua pengguna
        [HttpGet("users")]
        public List<User_1302223025> GetUsers()
        {
            return _users;
        }

        [HttpPost("register")]
        public IActionResult Register(User_1302223025 user)
        {
            // Precondition: User tidak boleh null
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Precondition: Username harus valid
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Username tidak boleh kosong", nameof(user.Username));
            }

            // Precondition: Password harus valid
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password tidak boleh kosong", nameof(user.Password));
            }

            // Precondition: Username harus unik
            if (_users.Any(u => u.Username == user.Username))
            {
                return Conflict("Username sudah terdaftar");
            }

            // Menangani Lowongan
            if (user.Lowongan != null)
            {
                foreach (var lowongan in user.Lowongan)
                {
                    // Cek apakah ada lowongan dengan ID yang sama
                    if (_lowongan.Any(l => l.Id == lowongan.Id))
                    {
                        return Conflict($"Lowongan dengan ID {lowongan.Id} sudah ada");
                    }

                    // Pencarian ID kosong
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
                }
            }
            else
            {
                user.Lowongan = new List<Lowongan_1302223025>();
            }

            // Menambahkan pengguna baru ke daftar pengguna
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

            PerusahaanController.Instance.CurrentUser = existingUser;

            return Ok(new { message = "Login berhasil" });
        }

        [HttpPost("create-lowongan/{username}")]
        public IActionResult CreateLowongan(string username, Lowongan_1302223025 newLowongan)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return BadRequest("Username tidak boleh kosong");
            }

            if (newLowongan == null)
            {
                return BadRequest("Lowongan tidak boleh null");
            }

            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return NotFound("User tidak ditemukan");
            }

            // Validasi periode format
            if (!PeriodeFormat(newLowongan.Periode))
            {
                return BadRequest("Format periode tidak valid. Format yang benar: dd/MM/yyyy");
            }

            // Pengecekan lowongan null dan ID yang sudah ada di daftar pengguna
            if (user.Lowongan == null)
            {
                user.Lowongan = new List<Lowongan_1302223025>();
            }

            // Menghindari duplikasi ID di daftar pengguna
            if (user.Lowongan.Any(l => l.Id == newLowongan.Id))
            {
                return Conflict("Lowongan dengan ID yang sama sudah ada");
            }

            // Pengaturan ID baru
            newLowongan.Id = _lowongan.Any() ? _lowongan.Max(l => l.Id) + 1 : 1;

            // Tambahkan Lowongan baru ke daftar pengguna
            user.Lowongan.Add(newLowongan);

            // Tambahkan lowongan baru ke daftar global lowongan
            _lowongan.Add(newLowongan);

            SaveLowonganListToFile();
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

            if (user.Lowongan == null)
            {
                return NotFound("User tidak memiliki lowongan");
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

            SaveLowonganListToFile();
            SaveUsers();

            return Ok("Lowongan berhasil diperbarui");
        }

    }
}