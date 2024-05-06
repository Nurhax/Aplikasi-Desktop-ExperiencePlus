using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class editLowongan
    {
        private const string filepath = "C:\\Kuliah\\kpl\\tubeskpl\\TubesKelompok5\\lowongan.json";

        public List<lowongan> readLowongan()
        {
            string jsonData = File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<List<lowongan>>(jsonData);   
        }
        public void writeLowongan(List<lowongan> lowongan)
        {
            string jsonData = JsonConvert.SerializeObject(lowongan, Formatting.Indented);
            File.WriteAllText(filepath, jsonData);
        }
        public void EditDeskripsi(List<lowongan> lowongan, int idx)
        {   
            // Meminta deskripsi baru dari pengguna
            string newDeskripsi = Console.ReadLine();
            Debug.Assert(newDeskripsi.Length <= 300, "Deskripsi lowongan tidak boleh lebih dari 300 karakter");
            Debug.Assert(newDeskripsi != "", "Deskripsi lowongan tidak boleh kosong");
            // Mengedit deskripsi baru
            lowongan[idx - 1].deskripsi = newDeskripsi;

            // Menyimpan perubahan ke file JSON
            writeLowongan(lowongan);

            Console.WriteLine("Deskripsi lowongan telah diperbarui.");
        }

        public void EditNama(List<lowongan> lowongan, int idx)
        {
            // Meminta nama baru dari pengguna
            string newNama = Console.ReadLine();
            Debug.Assert(newNama.Length <= 45, "Nama lowongan tidak boleh lebih dari 45 karakter");
            Debug.Assert(newNama != "", "Nama lowongan tidak boleh kosong");
            // Mengedit nama baru
            lowongan[idx - 1].nama = newNama;

            // Menyimpan perubahan ke file JSON
            writeLowongan(lowongan);

            Console.WriteLine("Nama lowongan telah diperbarui.");
        }
        public void EditSyarat(List<lowongan> lowongan, int idx)
        {
            // Meminta syarat baru dari pengguna
            string newSyarat = Console.ReadLine();
            Debug.Assert(newSyarat.Length <= 300, "Syarat lowongan tidak boleh lebih dari 300 karakter");
            Debug.Assert(newSyarat != "", "Syarat lowongan tidak boleh kosong");

            // Mengedit syarat baru
            lowongan[idx - 1].syarat = newSyarat;

            // Menyimpan perubahan ke file JSON
            writeLowongan(lowongan);

            Console.WriteLine("Syarat lowongan telah diperbarui.");
        }
        public void EditPeriode(List<lowongan> lowongan, int idx)
        {
            // Meminta periode baru dari pengguna
            string newPeriode = Console.ReadLine();
            Debug.Assert(periodeFormat(newPeriode), "Format periode tidak valid. Format yang benar: 01/01/2000");

            // Mengedit periode baru
            lowongan[idx - 1].periode = newPeriode;

            // Menyimpan perubahan ke file JSON
            writeLowongan(lowongan);

            Console.WriteLine("Periode lowongan telah diperbarui.");
        }
        private bool periodeFormat(string periode)
        {
            // Regex untuk format ../../..
            var regex1 = new Regex(@"^\d{2}/\d{2}/\d{4}$");

            return regex1.IsMatch(periode);
        }
    }
}
