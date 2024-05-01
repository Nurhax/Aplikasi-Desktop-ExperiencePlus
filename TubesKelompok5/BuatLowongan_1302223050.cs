using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class BuatLowongan_1302223050
    {
        //Constructor
        public BuatLowongan_1302223050() { }

        public BuatLowongan_1302223050(List<Lowongan> listLowonganPerusahaan)
        {
            this.listLowonganPerusahaan = listLowonganPerusahaan;
        }   

        public List<Lowongan> listLowonganPerusahaan;

        public class Lowongan
        {
            public string deskripsiPekerjaan;
            public string syaratLowongan;
            public string periodeLowongan;
            public string posisiKerja;

            public Lowongan() { }

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

            public string getPosisi()
            {
                return posisiKerja;
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

            public void setPosisi(string posisi)
            {
                posisiKerja = posisi;
            }
        }

        public List<Lowongan> getlowonganPerusahaan()
        {
            return listLowonganPerusahaan;
        }

        public void CreateLowongan()
        {
            string setDeskripsi;
            string setSyarat;
            string setPeriode;
            string setPosisi;
            string konfirmasi;

            //Mengisi deskripsi
            Console.WriteLine("Masukkan deskripsi dari lowongan ini (gunakan underscore untuk spasi) : ");
            setDeskripsi = Console.ReadLine();

            Console.WriteLine("Masukkan syarat dari lowongan ini:");
            setSyarat = Console.ReadLine();

            Console.WriteLine("Masukkan tanggal dari lowongan terakhir dibuka (contoh 24/04/2024");
            setPeriode = Console.ReadLine();

            Console.WriteLine("Masukan Posisi lowongan yang dicari: ");
            setPosisi = Console.ReadLine(); 

            Console.WriteLine("Apakah kamu yakin?");
            Console.WriteLine("1. iya");
            Console.WriteLine("2. tidak");
            konfirmasi = Console.ReadLine();

            MenuEnum_1302223050.Konfirmasi Menu = (MenuEnum_1302223050.Konfirmasi)Convert.ToInt32(konfirmasi);

            if (MenuEnum_1302223050.GetKonfirmasi(Menu) == 1)
            {
                List<Lowongan> data = new List<Lowongan>();
                BuatLowongan_1302223050.Lowongan lowongan = new BuatLowongan_1302223050.Lowongan();
                lowongan.setsyarat(setSyarat);
                lowongan.setperiodeLowongan(setPeriode);
                lowongan.setdeskripsiPekerjaan(setDeskripsi);
                lowongan.setPosisi(setPosisi);
                getlowonganPerusahaan().Add(lowongan);
            }
        }

        public void searchingLowongan()
        {
            BuatLowongan_1302223050.Lowongan lowongan = new BuatLowongan_1302223050.Lowongan();

            Console.WriteLine("Masukan posisi lowongan yang dicari: ");
            string posisi = Console.ReadLine();

            foreach (Lowongan data in listLowonganPerusahaan)
            {
                if (posisi == data.posisiKerja)
                {
                    Console.WriteLine(lowongan.getdeskripsiPekerjaan());
                    Console.WriteLine(lowongan.getsyarat());
                    Console.WriteLine(lowongan.getPeriode());
                }
            }
        }
    }
}