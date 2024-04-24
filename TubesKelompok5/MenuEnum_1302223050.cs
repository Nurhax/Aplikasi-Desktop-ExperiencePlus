using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class MenuEnum_1302223050
    {
        public enum Konfirmasi
        {
            Iya = 1,
            Tidak
        }

        public static int GetKonfirmasi(Konfirmasi inputKonfirm)
        {
            int[] input = { 1, 2 };
            return input[(int)inputKonfirm];
        }
    }
}
