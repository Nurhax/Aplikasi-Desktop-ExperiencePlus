using Newtonsoft.Json;
using TubesKelompok5;

public class MainProgram
{
    public static void Main(string[] args)
    {
        StatusLowongan statusLowongan = new StatusLowongan();
        editLowongan edit = new editLowongan();

        config[] configs = statusLowongan.ReadJSON();
        statusLowongan.SetStatus(configs);
        foreach (var config in configs)
        {
            Console.WriteLine($"Nama: {config.nama}");
            Console.WriteLine($"Deskripsi: {config.deskripsi}");
            Console.WriteLine($"Syarat: {config.syarat}");
            Console.WriteLine($"Status: {config.Status}");
            Console.WriteLine($"Periode: {config.periode}");
            Console.WriteLine();
        }

        // Membaca lowongan dari file JSON menggunakan objek edit
        var lowongan = edit.readLowongan();

        // Menampilkan nama daftar lowongan
        Console.WriteLine("Daftar Lowongan:");
        for (int i = 0; i < lowongan.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lowongan[i].nama}");
        }

        // Meminta pengguna memilih lowongan yang ingin diedit
        Console.Write("Pilih nomor lowongan yang ingin diedit: ");
        int selectedLowonganIndex;
        while (!int.TryParse(Console.ReadLine(), out selectedLowonganIndex) || selectedLowonganIndex < 1 || selectedLowonganIndex > lowongan.Count)
        {
            Console.WriteLine("Input tidak valid. Harap masukkan nomor lowongan yang benar.");
            Console.Write("Pilih nomor lowongan yang ingin diedit: ");
        }

        // Meminta deskripsi baru dari pengguna
        Console.Write("Masukkan deskripsi baru: ");
        string newDeskripsi = Console.ReadLine();

        // Mengedit deskripsi baru
        lowongan[selectedLowonganIndex - 1].deskripsi = newDeskripsi;

        // Menyimpan perubahan ke file JSON
        edit.writeLowongan(lowongan);

        Console.WriteLine("Deskripsi lowongan telah diperbarui.");
    }
}
