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

        public BuatLowongan_1302223050(List<Lowongan> listLowongan)
        {
            lowonganPerusahaan = listLowongan;
        }
        public List<Lowongan> lowonganPerusahaan;
        public class Lowongan
        {
            private string deskripsiPekerjaan;
            private string syaratLowongan;
            private string periodeLowongan;

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

        }

        public List<Lowongan> getlowonganPerusahaan()
        {
            return lowonganPerusahaan;
        }

        public void CreateLowongan()
        {
            string setDeskripsi;
            string setSyarat;
            string setPeriode;
            string konfirmasi;

            BuatLowongan_1302223050.Lowongan listL = new BuatLowongan_1302223050.Lowongan();

            //Mengisi deskripsi
            Console.WriteLine("Masukkan deskripsi dari lowongan ini (gunakan underscore untuk spasi) : ");
            setDeskripsi = Console.ReadLine();
            
            Console.WriteLine("Masukkan syarat dari lowongan ini:");
            setSyarat = Console.ReadLine();
            
            Console.WriteLine("Masukkan tanggal dari lowongan terakhir dibuka (contoh 24/04/2024");
            setPeriode = Console.ReadLine();

            

            Console.WriteLine("Apakah kamu yakin?");
            Console.WriteLine("1. iya");
            Console.WriteLine("2. tidak");
            konfirmasi = Console.ReadLine();

            MenuEnum_1302223050.Konfirmasi Menu = (MenuEnum_1302223050.Konfirmasi)Convert.ToInt32(konfirmasi);

            if (MenuEnum_1302223050.GetKonfirmasi(Menu) == 1)
            {
                lowonganPerusahaan.Add(new lowongan());
                listL.setdeskripsiPekerjaan(setDeskripsi);
                listL.setsyarat(setSyarat);
                listL.setperiodeLowongan(setPeriode);
            }
        }
        public void showAllLowongan()
        {
            BuatLowongan_1302223050.Lowongan lowongan = new BuatLowongan_1302223050.Lowongan();

            for (int i = 0; i < lowonganPerusahaan.Count; i++)
            {
                Console.WriteLine($"Deskripsi {lowongan.getdeskripsiPekerjaan}");
                Console.WriteLine($"Syarat {lowongan.getsyarat}");
                Console.WriteLine($"Periode {lowongan.getPeriode}");
            }
        }
    }
}
