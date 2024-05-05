using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class BuatLowongan_1302223050
    {
        //Constructor
        public BuatLowongan_1302223050() { }

        private List<Lowongan> listLowonganPerusahaan = new List<Lowongan>();

        public class Lowongan
        {
            private string namaLowongan;
            private string deskripsiPekerjaan;
            private string syaratLowongan;
            private string periodeLowongan;


            public Lowongan(string namaLowongan, string deskripsiPekerjaan, string syaratLowongan,string periodeLowongan) 
            {
                this.namaLowongan = namaLowongan;
                this.deskripsiPekerjaan = deskripsiPekerjaan;
                this.syaratLowongan = syaratLowongan;  
                this.periodeLowongan = periodeLowongan;
            }

            public string getdeskripsiPekerjaan()
            {
                return deskripsiPekerjaan;
            }

            public string getsyarat()
            {
                return syaratLowongan;
            }

            public string getPeriode()
            {
                return periodeLowongan;
            }

            public string getNamaLowongan()
            {
                return namaLowongan;
            }


            public void setdeskripsiPekerjaan(string deskripsi)
            {
                deskripsiPekerjaan = deskripsi;
            }

            public void setsyarat(string syarat)
            {
                syaratLowongan = syarat;
            }

            public void setperiodeLowongan(string periode)
            {
                periodeLowongan = periode;
            }

            public void setNamaLowongan(string nama)
            {
                namaLowongan = nama;
            }
        }

        public List<Lowongan> getlowonganPerusahaan()
        {
            return listLowonganPerusahaan;
        }

        public void CreateLowongan()
        {
            string setNamaLowongan;
            string setDeskripsi;
            string setSyarat;
            string setPeriode;
            string konfirmasi;

            //Mengisi deskripsi lowongan
            Console.WriteLine("Masukkan judul/nama dari lowongan : ");
            setNamaLowongan = Console.ReadLine();

            Console.WriteLine("Masukkan deskripsi dari lowongan ini (gunakan underscore untuk spasi) : ");
            setDeskripsi = Console.ReadLine();

            Console.WriteLine("Masukkan syarat dari lowongan ini:");
            setSyarat = Console.ReadLine();

            Console.WriteLine("Masukkan tanggal dari lowongan terakhir dibuka (gunakan waktu per bulan)");
            setPeriode = Console.ReadLine();

            Debug.Assert(setDeskripsi != null);
            Debug.Assert(setSyarat != null);
            Debug.Assert(setPeriode != null);
            Debug.Assert(setNamaLowongan != null);



            Console.WriteLine("Apakah kamu yakin?");
            Console.WriteLine("1. iya");
            Console.WriteLine("2. tidak");
            konfirmasi = Console.ReadLine();
            Debug.Assert(konfirmasi != null);
            Debug.Assert(konfirmasi == "1" || konfirmasi == "2");

            MenuEnum_1302223050.Konfirmasi Menu = (MenuEnum_1302223050.Konfirmasi)Convert.ToInt32(konfirmasi) - 1;

            if (MenuEnum_1302223050.GetKonfirmasi(Menu) == 1)
            {
                Lowongan lowongan = new Lowongan(setNamaLowongan, setDeskripsi, setSyarat, setPeriode);
                lowongan.setNamaLowongan(setNamaLowongan);
                lowongan.setsyarat(setSyarat);
                lowongan.setperiodeLowongan(setPeriode);
                lowongan.setdeskripsiPekerjaan(setDeskripsi);
                listLowonganPerusahaan.Add(lowongan);
            }
            else
            {
                Console.WriteLine("Lowongan tidak jadi ditambahkan!");
            }
        }

        public void ShowAllLowongan()
        {
            Debug.Assert(listLowonganPerusahaan != null);
            foreach (Lowongan data in listLowonganPerusahaan)
            {
                Console.WriteLine($"Nama Lowongan       : {data.getNamaLowongan()}");
                Console.WriteLine($"Deskripsi Lowongan  : {data.getdeskripsiPekerjaan()}");
                Console.WriteLine($"Syarat Lowongan     : {data.getsyarat()}");
                Console.WriteLine($"Periode Lowongan    : {data.getPeriode()}");
            }   
        }

        public void searchingLowongan()
        {
            /*BuatLowongan_1302223050.Lowongan lowongan = new BuatLowongan_1302223050.Lowongan();*/

            Console.WriteLine("Masukan posisi lowongan yang dicari: ");
            string posisi = Console.ReadLine();
            Debug.Assert(posisi != null);
            Debug.Assert(!string.IsNullOrEmpty(posisi));    

            foreach (Lowongan data in listLowonganPerusahaan)
            { 
                if (posisi.ToLower() == data.getNamaLowongan().ToLower())
                { 
                    Console.WriteLine($"Nama Lowongan       : {data.getNamaLowongan()}");
                    Console.WriteLine($"Deskripsi Lowongan  : {data.getdeskripsiPekerjaan()}");
                    Console.WriteLine($"Syarat Lowongan     : {data.getsyarat()}");
                    Console.WriteLine($"Periode Lowongan    : {data.getPeriode()}");
                }
                else
                {
                    Console.WriteLine("Lowongan Tidak Ditemukan!");
                }
            }
        }

        public void searchingLowonganTesting()
        {
            /*BuatLowongan_1302223050.Lowongan lowongan = new BuatLowongan_1302223050.Lowongan();*/

            Console.WriteLine("Masukan posisi lowongan yang dicari: ");
            string posisi = "Web Developer";
            Debug.Assert(posisi != null);
            Debug.Assert(!string.IsNullOrEmpty(posisi));

            foreach (Lowongan data in listLowonganPerusahaan)
            {
                if (posisi.ToLower() == data.getNamaLowongan().ToLower())
                {
                    Console.WriteLine($"Nama Lowongan       : {data.getNamaLowongan()}");
                    Console.WriteLine($"Deskripsi Lowongan  : {data.getdeskripsiPekerjaan()}");
                    Console.WriteLine($"Syarat Lowongan     : {data.getsyarat()}");
                    Console.WriteLine($"Periode Lowongan    : {data.getPeriode()}");
                }
                else
                {
                    Console.WriteLine("Lowongan Tidak Ditemukan!");
                }
            }
        }
    }
}

