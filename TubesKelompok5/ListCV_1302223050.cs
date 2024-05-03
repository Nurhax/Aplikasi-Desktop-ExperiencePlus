using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
        private List<CV> listcvMahasiswa = new List<CV>();

        public class CV
        {
            private string Nama;
            private string Pengalaman;
            private string Edukasi;
            private string Email;

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
            for(int i = 0; i <  listcvMahasiswa.Count; i++)
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
            Debug.Assert(CVMahasiswa != null);

            if (telahApply)
            {
                listcvMahasiswa.Add(CVMahasiswa);
            }
        }


    }
}
