using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static TubesKelompok5.ListCV_1302223050;

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
        private List<CV> listcvMahasiswa = new List<CV>();

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

            public CV() { }
            public CV(string nama, string pengalaman, string edukasi, string email)
            {
                Nama = nama;
                Pengalaman = pengalaman;
                Edukasi = edukasi;
                Email = email;
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
            Debug.Assert(listcvMahasiswa != null);
            for (int i = 0; i < listcvMahasiswa.Count; i++)
            {
                Console.WriteLine($"Nama : {listcvMahasiswa[i].getNama()} ");
                Console.WriteLine($"Pengalaman : {listcvMahasiswa[i].getEdukasi()}");
                Console.WriteLine($"Edukasi Terakhir : {listcvMahasiswa[i].getEdukasi()}");
                Console.WriteLine($"Email : {listcvMahasiswa[i].getEmail()} ");
            }
        }
        public void showCV()
        {
            for (int i = 0; i < listcvMahasiswa.Count; i++)
            {
                Console.WriteLine($"Nama : {listcvMahasiswa[i].getNama()} ");
                Console.WriteLine($"Email : {listcvMahasiswa[i].getEmail()} ");
            }
        }

        //buat
        public void addCVMahasiswa(CV CVMahasiswa, bool telahApply)
        {
            //Buat nambahin CV mahasiswa setiap kali mahasiswa apply ke suatu lowongan
            Debug.Assert(CVMahasiswa != null);

            if (telahApply)
            {
                listcvMahasiswa.Add(CVMahasiswa);
            }
        }

        //method agar user dapat memasukkan inputan untuk upload CV
        public CV uploadCV2()
        {
            CV tempCV = new CV();
            Console.Write("Nama : ");
            var nama = Console.ReadLine();
            Debug.Assert(tempCV.setNama != null && nama.Length > 0);
            tempCV.setNama(nama);
            Console.Write("E-mail : ");
            var email = Console.ReadLine();
            Debug.Assert(tempCV.setEmail != null && email.Length > 0);
            tempCV.setEmail(email);
            Console.Write("Edukasi : ");
            var edukasi = Console.ReadLine();
            Debug.Assert(tempCV.setEdukasi != null && edukasi.Length > 0);
            tempCV.setEdukasi(edukasi);
            Console.Write("pengalaman :");
            var pengalaman = Console.ReadLine();
            Debug.Assert(tempCV.setPengalaman != null && edukasi.Length > 0);
            tempCV.setPengalaman(pengalaman);
            return tempCV;
        }
        public void seleksiCV()
        {
            showCV();
            int cvIndex = int.Parse(Console.ReadLine());

            if (cvIndex >= 0 && cvIndex < listcvMahasiswa.Count)
            {

                CV selectedCv = listcvMahasiswa[cvIndex + 1];
                showALLCVMahasiswa();

                Console.Write("Masukkan penilaian CV (Layak/Tidak Layak): ");
                string penilaian = Console.ReadLine();

                // Memproses penilaian
                if (penilaian.ToLower() == "tidak layak")
                {
                    // Hapus CV dari list
                    listcvMahasiswa.RemoveAt(cvIndex + 1);
                    Console.WriteLine("CV telah dihapus dari lowongan.");
                }
                else
                {
                    Console.WriteLine("CV dinyatakan lulus.");
                }

            }
            else
            {
                Console.WriteLine("Index CV tidak valid.");
            }
        }
        public ListCV_1302223050.CV testuploadCV2(string nama, string email, string edukasi, string pengalaman)
        {
            CV tempCV = new CV();
            Console.Write("Nama : ");

            Debug.Assert(tempCV.setNama != null && nama.Length > 0);
            tempCV.setNama(nama);
            Console.Write("E-mail : ");

            Debug.Assert(tempCV.setEmail != null && email.Length > 0);
            tempCV.setEmail(email);
            Console.Write("Edukasi : ");

            Debug.Assert(tempCV.setEdukasi != null && edukasi.Length > 0);
            tempCV.setEdukasi(edukasi);
            Console.Write("pengalaman :");

            Debug.Assert(tempCV.setPengalaman != null && edukasi.Length > 0);
            tempCV.setPengalaman(pengalaman);
            return tempCV;
        }

    }
}
