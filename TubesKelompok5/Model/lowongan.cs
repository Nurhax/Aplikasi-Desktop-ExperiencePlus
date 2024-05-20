using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5.Model
{
    public class Lowongan_1302223025
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Syarat { get; set; }
        public string Deskripsi { get; set; }
        public StatusLowongan.statusState Status { get; set; }
        public string Periode { get; set; }
        public Lowongan_1302223025() { }

        public Lowongan_1302223025(int id, string nama, string syarat, string deskripsi, StatusLowongan.statusState status, string periode)
        {
            Id = id;
            Nama = nama;
            Syarat = syarat;
            Deskripsi = deskripsi;
            Status = status;
            Periode = periode;
        }
    }
}
