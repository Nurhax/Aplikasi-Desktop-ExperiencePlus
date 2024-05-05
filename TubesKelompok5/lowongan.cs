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

        public lowongan() { }
        public lowongan(string nama, string syarat, string deskripsi, StatusLowongan.statusState Status, string periode)
        {
            this.nama = nama;
            this.syarat = syarat;
            this.deskripsi = deskripsi;
            this.Status = Status;
            this.periode = periode;
        }


        public string getdeskripsiPekerjaan()
        {
            return deskripsi;
        }

        public string getsyarat()
        {
            return syarat;
        }

        public string getPeriode()
        {
            return periode;
        }

        public string getNamaLowongan()
        {
            return nama;
        }


        public int getIDLowongan()
        {
            return IDLowongan;
        }


        public void setdeskripsiPekerjaan(string deskripsi2)
        {
            deskripsi = deskripsi2;
        }

        public void setsyarat(string syarat2)
        {
            syarat = syarat2;
        }

        public void setperiodeLowongan(string periode2)
        {
            periode = periode2;
        }

        public void setNamaLowongan(string nama2)
        {
            nama = nama2;
        }


        public void setIDLowongan(int id)
        {
            IDLowongan = id;
        }

    }
}
