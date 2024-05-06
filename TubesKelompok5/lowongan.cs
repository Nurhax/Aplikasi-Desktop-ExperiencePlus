using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class lowongan
    {
        public string nama { get; set; }
        public string syarat { get; set; }
        public string deskripsi { get; set; }
        public StatusLowongan.statusState Status { get; set; }
        public string periode { get; set; }
        public int IDLowongan { get; set; }

        public ListCV_1302223050 CVMahasiswa = new ListCV_1302223050();

        public lowongan() { }
        public lowongan(string nama, string syarat, string deskripsi, StatusLowongan.statusState Status, string periode)
        {
            this.nama = nama;
            this.syarat = syarat;
            this.deskripsi = deskripsi;
            this.Status = Status;
            this.periode = periode;
        }
    }
}
