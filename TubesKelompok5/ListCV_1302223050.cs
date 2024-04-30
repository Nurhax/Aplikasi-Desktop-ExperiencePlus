using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class ListCV_1302223050
    {
        //Constructor buat inisiasi list cv awal
        public ListCV_1302223050() { }
        //Constructor untuk dipakai jika ada update cv yang diperlukan
        public ListCV_1302223050(List<CV> listCVMahasiswa)
        {
            listcvMahasiswa = listCVMahasiswa;
        }
        //variabel list buat naro data mahasiswa
        private List<CV> listcvMahasiswa;

        public class CV
        {
            [JsonPropertyName("Nama")]
            public string Nama { get; set; }

            [JsonPropertyName("Pengalaman")]
            public string Pengalaman { get; set; }

            [JsonPropertyName("Edukasi")]
            public string Edukasi { get; set; }

            [JsonPropertyName("Email")]
            public string Email { get; set; }

            public CV()
            {
                this.Nama = Nama;
                this.Pengalaman = Pengalaman;
                this.Edukasi = Edukasi;
                this.Email = Email;
            }

            public string getNama()
            {
                return Nama;
            }

            public string getPengalaman()
            {
                return Pengalaman;
            }

            public string getEdukasi()
            {
                return Edukasi;
            }

            public string getEmail()
            {
                return Email;
            }


            public void setNama(string nama)
            {
                this.Nama = nama;
            }

            public void setPengalaman(string pengalaman)
            {
                this.Pengalaman = pengalaman;
            }

            public void setEdukasi(string edukasi)
            {
                this.Edukasi = edukasi;
            }

            public void setEmail(string email)
            {
                this.Email = email;
            }
        }
        //buat ngedapetin list mahasiswa terkini
        public List<CV> getListCV()
        {
            return listcvMahasiswa;
        }

        //buat nunjukin semua CV mahasiswa di jobListing tertentu
        public void showALLCVMahasiswa()
        {
            for (int i = 0; i < listcvMahasiswa.Count; i++)
            {
                Console.WriteLine($"Nama : {listcvMahasiswa[i].getNama()} ");
                Console.WriteLine($"Pengalaman : {listcvMahasiswa[i].getEdukasi()}");
                Console.WriteLine($"Edukasi Terakhir : {listcvMahasiswa[i].getEdukasi()}");
                Console.WriteLine($"Email : {listcvMahasiswa[i].getEmail()} ");
            }
        }

        //buat
        public void addCVMahasiswa(CV CVMahasiswa, bool telahApply)
        {
            //Buat nambahin CV mahasiswa setiap kali mahasiswa apply ke suatu lowongan
            if (telahApply)
            {
                listcvMahasiswa.Add(CVMahasiswa);
            }
        }

        //method agar user dapat memasukkan inputan untuk upload CV
        public ListCV_1302223050.CV uploadCV2()
        {
            ListCV_1302223050.CV tempCV = new ListCV_1302223050.CV();
            Console.Write("Nama : ");
            tempCV.setNama(Console.ReadLine());
            Console.Write("E-mail : ");
            tempCV.setEmail(Console.ReadLine());
            Console.Write("Edukasi : ");
            tempCV.setEdukasi(Console.ReadLine());
            Console.Write("pengalaman :");
            tempCV.setPengalaman(Console.ReadLine());

            return tempCV;
        }

    }
}
