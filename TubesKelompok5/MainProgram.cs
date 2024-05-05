using TubesKelompok5;
using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        //Disini kita nyatuin semua modul yang telah dibuat ygy
        Console.WriteLine("Testing");
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}