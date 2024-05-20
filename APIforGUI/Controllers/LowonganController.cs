using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TubesKelompok5.Model;

namespace APIforGUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LowonganController : ControllerBase
    {
        private List<Lowongan_1302223025> _lowonganList = new List<Lowongan_1302223025>();

        public LowonganController () 
        { 
            try
            {
                LoadLowonganListFromFile();
            } catch (Exception ex) 
            { 
                Console.WriteLine($"Error data : {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult GetAllLowongan()
        {
            // Postcondition: Jumlah data tidak boleh negatif
            System.Diagnostics.Debug.Assert(_lowonganList.Count >= 0);
            if (_lowonganList.Count == 0)
            {
                return Ok("Belum ada data");
            }
            return Ok(_lowonganList);
        }

        [HttpGet("{name}")]
        public IActionResult GetUserbyName(string name)
        {
            if (_lowonganList.Count == 0)
            {
                return Ok("Belum ada data");
            }

            foreach (Lowongan_1302223025 low in _lowonganList)
            {
                if (low.Nama == name)
                {
                    return Ok(low);
                }
            }
            return Ok("Data tidak ada");
        }

        [HttpGet("search")]
        public IActionResult SearchLowongan(string nama)
        {
            // Precondition: Nama tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(nama));

            var result = _lowonganList.Where(l => l.Nama.ToLower().Contains(nama.ToLower())).ToList();
            if (result.Count == 0)
            {
                return NotFound("Lowongan tidak ditemukan");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateLowongan(Lowongan_1302223025 low)
        {
            // Precondition: Lowongan tidak boleh null
            System.Diagnostics.Debug.Assert(low != null);

            // Precondition: Nama tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Nama));

            // Precondition: Alamat tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Syarat));

            // Precondition: Deskripsi tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Deskripsi));
            // Cek apakah ada ID yang kosong (0)
            low.Id = new int();
            var emptyId = _lowonganList.FirstOrDefault(l => l.Id == 0);
            if (emptyId != null)
            {
                // Gunakan ID yang kosong
                low.Id = emptyId.Id;
                emptyId.Nama = low.Nama;
                emptyId.Syarat = low.Syarat;
                emptyId.Deskripsi = low.Deskripsi;
                emptyId.Status = low.Status;
                emptyId.Periode = low.Periode;
            }
            else
            {
                // Cari ID yang belum digunakan
                int newId = 1;
                while (_lowonganList.Any(l => l.Id == newId))
                {
                    newId++;
                }
                low.Id = newId;
                _lowonganList.Add(low);
            }

            SaveLowonganListToFile(); // Simpan data ke file setelah ditambahkan
            return Ok("Lowongan berhasil ditambahkan");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLowongan(int id, Lowongan_1302223025 low)
        {
            // Precondition: ID harus positif
            System.Diagnostics.Debug.Assert(id > 0);

            // Precondition: Lowongan tidak boleh null
            System.Diagnostics.Debug.Assert(low != null);

            // Precondition: Nama tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Nama));

            // Precondition: Alamat tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Syarat));

            // Precondition: Deskripsi tidak boleh kosong
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(low.Deskripsi));
            var existingLow = _lowonganList.FirstOrDefault(l => l.Id == id);
            if (existingLow == null)
            {
                return NotFound("Lowongan tidak ditemukan");
            }

            existingLow.Nama = low.Nama;
            existingLow.Syarat = low.Syarat;
            existingLow.Syarat = low.Deskripsi;
            existingLow.Status = low.Status;
            existingLow.Periode = low.Periode;
            SaveLowonganListToFile(); // Simpan data ke file setelah diperbarui
            return Ok("Lowongan berhasil diperbarui");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLowongan(int id)
        {
            // Precondition: ID harus positif
            System.Diagnostics.Debug.Assert(id > 0);

            var existingLow = _lowonganList.FirstOrDefault(l => l.Id == id);
            if (existingLow == null)
            {
                return NotFound("Lowongan tidak ditemukan");
            }

            _lowonganList.Remove(existingLow);
            SaveLowonganListToFile(); // Simpan data ke file setelah dihapus
            return Ok("Lowongan berhasil dihapus");
        }

        private void SaveLowonganListToFile()
        {
            string json = JsonConvert.SerializeObject(_lowonganList);
            System.IO.File.WriteAllText("lowongan.json", json);
        }

        private void LoadLowonganListFromFile()
        {
            if (System.IO.File.Exists("lowongan.json"))
            {
                string json = System.IO.File.ReadAllText("lowongan.json");
                _lowonganList = JsonConvert.DeserializeObject<List<Lowongan_1302223025>>(json);
            }
        }
    }
}
