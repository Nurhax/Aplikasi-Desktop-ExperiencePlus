using System;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Selamat datang!");
            Console.WriteLine("Silakan pilih opsi:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.Write("Pilihan Anda: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await Register();
                    break;
                case "2":
                    await Login();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }

        static async Task Register()
        {
            Console.WriteLine("\nRegister");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Pilih Role:");
            Console.WriteLine("1. Mahasiswa");
            Console.WriteLine("2. Perusahaan");
            Console.Write("Pilihan Anda: ");
            string roleChoice = Console.ReadLine();

            string role;
            switch (roleChoice)
            {
                case "1":
                    role = "Mahasiswa";
                    break;
                case "2":
                    role = "Perusahaan";
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    return;
            }

            UserModel_1302220096 userModel = new UserModel_1302220096
            {
                Username = username,
                Password = password,
                Email = email,
                Role = role
            };

            var result = await userModel.RegisterAsync(userModel);
            if (result.Success)
            {
                Console.WriteLine("Registrasi berhasil: " + result.Message);
            }
            else
            {
                Console.WriteLine("Registrasi gagal: " + result.Message);
            }
        }

        static async Task Login()
        {
            Console.WriteLine("\nLogin");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Buat instance UserModel untuk login
            UserModel_1302220096 userModel = new UserModel_1302220096
            {
                Username = username,
                Password = password
            };

            // Lakukan login
            var result = await userModel.LoginAsync(userModel);
            if (result.Success)
            {
                Console.WriteLine("Login berhasil: " + result.Message);
                switch (userModel.Role?.ToLower())
                {
                    case "mahasiswa":
                        var mahasiswaProfile = userModel.ProfileMHS;
                        if (mahasiswaProfile != null)
                        {
                            Console.WriteLine($"Full Name: {mahasiswaProfile.FullName}");
                            Console.WriteLine($"Age: {mahasiswaProfile.Age}");
                            Console.WriteLine($"Phone Number: {mahasiswaProfile.PhoneNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Profile data for mahasiswa is missing.");
                        }
                        break;
                    case "perusahaan":
                        var perusahaanProfile = userModel.ProfileCompany;
                        if (perusahaanProfile != null)
                        {
                            Console.WriteLine($"Company Name: {perusahaanProfile.CompanyName}");
                            Console.WriteLine($"Company Type: {perusahaanProfile.CompanyType}");
                            Console.WriteLine($"Address: {perusahaanProfile.Address}");
                            Console.WriteLine($"Phone Number: {perusahaanProfile.PhoneNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Profile data for perusahaan is missing.");
                        }
                        break;
                    default:
                        Console.WriteLine("Peran pengguna tidak valid.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Login gagal: " + result.Message);
            }

        }
    }
}
