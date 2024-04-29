using Newtonsoft.Json;
using TubesKelompok5;

public class MainProgram
{
    public static void Main(string[] args)
    {
        StatusLowongan statusLowongan = new StatusLowongan();

        config[] configs = statusLowongan.ReadJSON();

        foreach (var config in configs)
        {
            // Parse periode untuk mendapatkan bulan
            string[] periodeParts = config.periode.Split('/');
            int bulan = int.Parse(periodeParts[1]);

            // Mengubah nilai enum statusState berdasarkan bulan
            config.Status = (bulan == (int)DateTime.Now.Month) ? StatusLowongan.statusState.TERSEDIA : StatusLowongan.statusState.TIDAK_TERSEDIA;

            Console.WriteLine($"Nama: {config.nama}");
            Console.WriteLine($"Edukasi: {config.edukasi}");
            Console.WriteLine($"Status: {config.Status}");
            Console.WriteLine($"Periode: {config.periode}");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
