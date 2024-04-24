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

        private Lowongan lowonganPerusahaan;

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

        public Lowongan getlowonganPerusahaan()
        {
            return lowonganPerusahaan;
        }

        public void CreateLowongan()
        {
            string setDeskripsi;
            string setSyarat;
            string setPeriode;
            int konfirmasi;

            //Mengisi deskripsi
            Console.WriteLine("Masukkan deskripsi dari lowongan ini (gunakan underscore untuk spasi) : ");
            setDeskripsi = Console.ReadLine();
            
            Console.WriteLine("Masukkan syarat dari lowongan ini:");
            setSyarat = Console.ReadLine();
            
            Console.WriteLine("Masukkan periode dari lowongan (contoh 24/04/2024");
            setPeriode = Console.ReadLine();

            

            Console.WriteLine("Apakah kamu yakin?");
            Console.WriteLine("1. Iya");
            Console.WriteLine("2. Tidak");
            konfirmasi = Console.Read();

            if(konfirmasi == 1)
            {
                getlowonganPerusahaan().setdeskripsiPekerjaan(setDeskripsi);
                getlowonganPerusahaan().setsyarat(setSyarat);
                getlowonganPerusahaan().setperiodeLowongan(setPeriode);
            }
        }
    }
}
