using TubesKelompok5;
using LibraryTubes;
using System;
using Microsoft.Extensions.DependencyModel;
using LibraryTubes.Menu;
using LibraryTubes.Perusahaan;



public class MainProgram
{
    public static void Main(string[] args)
    {
        Menu.MenuUtama();
        Console.Write("Pilih Menu : ");
        string pilih = Console.ReadLine();
        switch (pilih)
        {
            case "1":
                Menu.PilihMetodeLogin();

                Console.Write("Pilih Menu Login : ");
                string pilihMenu = Console.ReadLine();
                switch (pilihMenu)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine("Berikut adalah lowongan yang tersedia saat ini: ");
                        editLowongan edit = new editLowongan();
                        var lowonganTersedia = edit.readLowongan();
                        for (int i = 0; i < lowonganTersedia.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {lowonganTersedia[i].nama}");
                        }
                        Console.WriteLine("Untuk melamar pada lowongan tersebut silahkan login terlebih dahulu!");
                        break;
                }
                break;
            case "2":
                Menu.PilihMetodeLogin();
                Console.Write("Pilih Menu Login : ");
                pilihMenu = Console.ReadLine();
                switch (pilihMenu)
                {
                    case "1":

                        break;
                    case "2":
                        MenuPerusahaan.menuPerusahaan();
                        Console.Write("Silahkan Pilih : ");
                        string menuPerusahaan = Console.ReadLine();
                        switch (menuPerusahaan)
                        {
                            case "1":
                                BuatLowongan_1302223050 buat = new BuatLowongan_1302223050();
                                buat.CreateLowongan();
                                break;
                            case "2":
                                editLowongan edit = new editLowongan();
                                var lowongan = edit.readLowongan();
                                Console.WriteLine("Daftar Lowongan: ");
                                for (int i = 0; i < lowongan.Count; i++)
                                {
                                    Console.WriteLine($"{i+1}. {lowongan[i].nama}");
                                }
                                Console.Write("Pilih nomor lowongan yang ingin di edit : ");
                                int pilihIdx;
                                while (!int.TryParse(Console.ReadLine(), out pilihIdx) || pilihIdx < 1 || pilihIdx > lowongan.Count) 
                                { 
                                    Console.WriteLine("Input tidak valid, harap masukan nomor lowongan yang benar");
                                    Console.WriteLine("Pilih nomor lowongan yang ingin di edit : ");
                                }
                                EditLowongan.editLowongan();
                                Console.Write("Silahkan Pilih : ");
                                string pilihEdit = Console.ReadLine();
                                switch (pilihEdit)
                                {
                                    case "1":
                                        EditLowongan.editNamaLowongan();
                                        edit.EditNama(lowongan, pilihIdx);
                                        break;
                                    case "2":
                                        EditLowongan.editDeskripsiLowongan();
                                        edit.EditDeskripsi(lowongan, pilihIdx);
                                        break;
                                    case "3":
                                        EditLowongan.editSyaratLowongan();
                                        edit.EditSyarat(lowongan, pilihIdx);
                                        break;
                                    case "4":
                                        EditLowongan.editPeriodeLowongan();
                                        edit.EditPeriode(lowongan, pilihIdx);
                                        break;
                                    default:
                                        Console.WriteLine("Input pilihan yang valid");
                                        break;
                                }
                                break;
                            case "0":
                                MenuPerusahaan.menuPerusahaan();
                                break;
                            case "3":
                                Console.Write("Pilih lowongan yang ingin dilihat list CV nya");
                                editLowongan cekLowongan = new editLowongan();
                                var cekLowongan2 = cekLowongan.readLowongan();
                                Console.WriteLine("Daftar Lowongan: ");
                                for (int i = 0; i < cekLowongan2.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {cekLowongan2[i].nama}");
                                }
                                Console.Write("Pilih Lowongan:");
                                string cekLowongans = Console.ReadLine();
                                Console.WriteLine("Berikut adalah mahasiswa yang apply pada lowongan " + cekLowongan2[Convert.ToInt16(cekLowongans)].nama);
                                cekLowongan2[Convert.ToInt16(cekLowongans)].CVMahasiswa.getListCV().Add(new ListCV_1302223050.CV("Hafid","Chevalier Lab, Motion Lab","S1-Rekayasa Perangkat Lunak","Hafid123@Gmail.com"));
                                cekLowongan2[Convert.ToInt16(cekLowongans)].CVMahasiswa.getListCV().Add(new ListCV_1302223050.CV("Raga", "Chevalier Lab Mobile", "S1-Rekayasa Perangkat Lunak", "Ragadhitya@Gmail.com"));
                                cekLowongan2[Convert.ToInt16(cekLowongans)].CVMahasiswa.seleksiCV();
                                break;
                            default:
                                Console.WriteLine("Input pilihan yang valid");
                                break;
                        }
                        break;
                    case "3":
                        MenuPerusahaan.menuPerusahaan();
                        Console.WriteLine("Untuk bisa mengakses fitur tersebut silahkan login terlebih dahulu!");
                        break;
                    default:
                        Console.WriteLine("Input pilihan yang valid");
                        break;
                }
                break;
            default:
                Console.WriteLine("Input pilihan yang valid");
                break;
        }
    }
}