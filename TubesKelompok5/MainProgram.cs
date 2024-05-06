using TubesKelompok5;
using System;

public class MainProgram
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Selamat datang!");
        Console.WriteLine("Silakan pilih Role:");
        Console.WriteLine("1. Mahasiswa");
        Console.WriteLine("2. Perusahaan");
        Console.Write("Pilihan Anda: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                await Register(UserRole.Mahasiswa);
                break;
            case "2":
                await Register(UserRole.Perusahaan);
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                break;
        }
    }

    static async Task Register(UserRole userRole)
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

        UserModel_1302220096 userModel = new UserModel_1302220096()
        {
            Username = username,
            Password = password,
            Email = email,
            Role = userRole
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
        string roleChoice = Console.ReadLine();

        BuatLowongan_1302223050 lowongan = new BuatLowongan_1302223050();
        lowongan.CreateLowongan();

    }
}

