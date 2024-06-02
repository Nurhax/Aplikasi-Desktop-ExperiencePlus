using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TubesKelompok5.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TubesKelompok5
{
    public class BuatLowongan_1302223050
    {
        //Constructor
        public BuatLowongan_1302223050() { }

        private List<Lowongan_1302223025> listLowonganPerusahaan = new List<Lowongan_1302223025>();
        public List<Lowongan_1302223025> getlowonganPerusahaan()
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
                Random random = new Random();
                int IDLowongan = random.Next(9999, 100000);
                //int IDLowongan = listLowonganPerusahaan.Count;
                Lowongan_1302223025 lowongan = new Lowongan_1302223025();
                lowongan.Nama = setNamaLowongan;
                lowongan.Deskripsi = setDeskripsi;
                lowongan.Syarat = setSyarat;
                lowongan.Periode = setPeriode;
                listLowonganPerusahaan.Add(lowongan);
                Console.WriteLine("Lowongan berhasil dibuat!");
            }
            else
            {
                Console.WriteLine("Lowongan tidak jadi ditambahkan!");
            }
        }

        public void TestCreateLowongan()
        {
            string setNamaLowongan;
            string setDeskripsi;
            string setSyarat;
            string setPeriode;
            string konfirmasi;


            //Mengisi deskripsi lowongan
            Console.WriteLine("Masukkan judul/nama dari lowongan : ");
            setNamaLowongan = "Software Engineering - Business Analyst";

            Console.WriteLine("Masukkan deskripsi dari lowongan ini (gunakan underscore untuk spasi) : ");
            setDeskripsi = "Bekerja sebagai business analyst untuk menjabarkan requirements yang didapatkan";

            Console.WriteLine("Masukkan syarat dari lowongan ini:");
            setSyarat = "Mahasiswa S1 RPL, Memiliki pengalaman 3 bulan dengan projek serupa";

            Console.WriteLine("Masukkan tanggal dari lowongan terakhir dibuka (gunakan waktu per bulan)");
            setPeriode = "03/06/2024";

            Debug.Assert(setDeskripsi != null);
            Debug.Assert(setSyarat != null);
            Debug.Assert(setPeriode != null);
            Debug.Assert(setNamaLowongan != null);
            Console.WriteLine("Apakah kamu yakin?");
            Console.WriteLine("1. iya");
            Console.WriteLine("2. tidak");
            konfirmasi = "1";
            Debug.Assert(konfirmasi != null);
            Debug.Assert(konfirmasi == "1" || konfirmasi == "2");

            MenuEnum_1302223050.Konfirmasi Menu = (MenuEnum_1302223050.Konfirmasi)Convert.ToInt32(konfirmasi) - 1;

            if (MenuEnum_1302223050.GetKonfirmasi(Menu) == 1)
            {
                Random random = new Random();
                //int IDLowongan = random.Next(9999, 100000);
                int Id = listLowonganPerusahaan.Count;
                Lowongan_1302223025 lowongan = new Lowongan_1302223025();
                lowongan.Nama = setNamaLowongan;
                lowongan.Deskripsi = setDeskripsi;
                lowongan.Syarat = setSyarat;
                lowongan.Periode = setPeriode;
                listLowonganPerusahaan.Add(lowongan);
                Console.WriteLine("Lowongan berhasil dibuat!");

            }
            else
            {
                Console.WriteLine("Lowongan tidak jadi ditambahkan!");

            }
        }

        public void ShowAllLowongan()
        {
            Debug.Assert(listLowonganPerusahaan != null);
            foreach (Lowongan_1302223025 data in listLowonganPerusahaan)
            {
                Console.WriteLine($"Nama Lowongan       : {data.Nama}");
                Console.WriteLine($"Deskripsi Lowongan  : {data.Deskripsi}");
                Console.WriteLine($"Syarat Lowongan     : {data.Syarat}");
                Console.WriteLine($"Periode Lowongan    : {data.Periode}");
                Console.WriteLine("");
            }
        }

        public void searchingLowongan()
        {

            Console.WriteLine("Masukan posisi lowongan yang dicari: ");
            string posisi = Console.ReadLine();
            Debug.Assert(posisi != null);
            Debug.Assert(!string.IsNullOrEmpty(posisi));

            foreach (Lowongan_1302223025 data in listLowonganPerusahaan)
            {
                if (posisi.ToLower() == data.Nama.ToLower())
                {
                    Console.WriteLine($"Nama Lowongan       : {data.Nama}");
                    Console.WriteLine($"Deskripsi Lowongan  : {data.Deskripsi}");
                    Console.WriteLine($"Syarat Lowongan     : {data.Syarat}");
                    Console.WriteLine($"Periode Lowongan    : {data.Periode}");
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

            foreach (Lowongan_1302223025 data in listLowonganPerusahaan)
            {
                if (posisi.ToLower() == data.Nama.ToLower())
                {
                    Console.WriteLine($"Nama Lowongan       : {data.Nama}");
                    Console.WriteLine($"Deskripsi Lowongan  : {data.Deskripsi}");
                    Console.WriteLine($"Syarat Lowongan     : {data.Syarat}");
                    Console.WriteLine($"Periode Lowongan    : {data.Periode}");
                }
            }
        }
    }
}

