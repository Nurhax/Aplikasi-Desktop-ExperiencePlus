using TubesKelompok5;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
}