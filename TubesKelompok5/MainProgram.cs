using TubesKelompok5;

public class MainProgram
{
    public static void Main(string[] args)
    {
        //Disini kita nyatuin semua modul yang telah dibuat ygy
        BuatLowongan_1302223050 lowongan= new BuatLowongan_1302223050();
        lowongan.CreateLowongan();
        lowongan.CreateLowongan();

        lowongan.showAllLowongan();
    }
}