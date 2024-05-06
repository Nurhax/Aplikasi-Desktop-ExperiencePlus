using TubesKelompok5;
using System;
using System.Threading.Tasks;

public class MainProgram
{
    public static async Task Main(string[] args)
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

        // registrasi
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
            await Login(userModel);
        }
        else
        {
            Console.WriteLine("Registrasi gagal: " + result.Message);
        }
    }

    static async Task Login(UserModel_1302220096 registeredUser)
    {
        Console.WriteLine("\nLogin");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        // Memeriksa apakah username dan password yang dimasukkan sesuai dengan yang terdaftar
        if (username == registeredUser.Username && password == registeredUser.Password)
        {
            Console.WriteLine("Login berhasil. Selamat datang, " + registeredUser.Username + "!");

            // Menampilkan data dari user yang telah login 
            Console.WriteLine("");
            Console.WriteLine("Data Profil:");
            Console.WriteLine("Username: " + registeredUser.Username);
            Console.WriteLine("Email: " + registeredUser.Email);
            Console.WriteLine("Role: " + registeredUser.Role);
        }
        else
        {
            Console.WriteLine("Login gagal: Username atau password salah.");
            Console.WriteLine("Silakan Login kembali.");
        }
    }
}
