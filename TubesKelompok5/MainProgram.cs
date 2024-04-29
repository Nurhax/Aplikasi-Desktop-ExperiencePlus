using TubesKelompok5;
using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        CVConfig config = new CVConfig();
        ListCV_1302223050.CV list = config.readConfig();
        Console.WriteLine("NAMA : "+ list.getNama());
        Console.WriteLine("Email : " + list.getEmail());
        config.CV.setNama("bg jago");
        config.CV.setEmail("blabla@gmail.com");
        config.writeConfig();
    }
}