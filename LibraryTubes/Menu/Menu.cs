using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTubes.Menu
{
    internal class Menu
    {
        public void MenuUtama()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("             Experience Plus             ");
            Console.WriteLine("       Aplikasi Mencari Pekerjaan        ");
            Console.WriteLine("                   ***                   ");
            Console.WriteLine("             Login Sebagai               ");
            Console.WriteLine("             1. Mahasiswa                ");
            Console.WriteLine("             2. Perusahaan               ");
            Console.WriteLine("=========================================");
        }

        public void PilihMetodeLogin()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("             Experience Plus             ");
            Console.WriteLine("       Aplikasi Mencari Pekerjaan        ");
            Console.WriteLine("                   ***                   ");
            Console.WriteLine("             Pilih Cara Login            ");
            Console.WriteLine("               1. SignUp                 ");
            Console.WriteLine("               2. LogIn                  ");
            Console.WriteLine("               3. Guest                  ");
            Console.WriteLine("=========================================");
        }
    }
}
