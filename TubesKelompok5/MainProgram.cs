using TubesKelompok5;
using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        //Disini kita nyatuin semua modul yang telah dibuat ygy
        // Console.WriteLine("Testing");
        CVConfig config = new CVConfig();
        ListCV_1302223050 list = new ListCV_1302223050();
        ListCV_1302223050.CV list2 = new ListCV_1302223050.CV();
        
        if (list2 == null)
        {
            config.readConfig();
            config.writeConfig();
        }
        else
        {
            config.readConfig();
            config.rewriteConfig();
        }


    }
}