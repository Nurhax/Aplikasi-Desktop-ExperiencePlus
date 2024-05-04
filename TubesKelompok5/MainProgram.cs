using TubesKelompok5;

public class MainProgram
{
    public static void Main(string[] args)
    {
        StatusLowongan statusLowongan = new StatusLowongan();
        editLowongan edit = new editLowongan();

        // Membaca lowongan dari file JSON menggunakan objek edit
        var lowongan = edit.readLowongan();
        statusLowongan.SetStatus(lowongan);
        foreach (var config in lowongan)
        {
            Console.WriteLine($"Nama: {config.nama}");
            Console.WriteLine($"Syarat: {config.syarat}");
            Console.WriteLine($"Deskripsi: {config.deskripsi}");
            Console.WriteLine($"Status: {config.Status}");
            Console.WriteLine($"Periode: {config.periode}");
            Console.WriteLine();
        }
        // Menampilkan nama daftar lowongan
        Console.WriteLine("Daftar Lowongan:");
        for (int i = 0; i < lowongan.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lowongan[i].nama}");
        }
        // Meminta pengguna memilih lowongan yang ingin diedit
        Console.Write("Pilih nomor lowongan yang ingin diedit: ");
        int pilihIndex;
        while (!int.TryParse(Console.ReadLine(), out pilihIndex) || pilihIndex < 1 || pilihIndex > lowongan.Count)
        {
            Console.WriteLine("Input tidak valid. Harap masukkan nomor lowongan yang benar.");
            Console.Write("Pilih nomor lowongan yang ingin diedit: ");
        }
        edit.EditNama(lowongan, pilihIndex);
        edit.EditDeskripsi(lowongan, pilihIndex);
        edit.EditSyarat(lowongan, pilihIndex);
        edit.EditPeriode(lowongan, pilihIndex);

    }
}
