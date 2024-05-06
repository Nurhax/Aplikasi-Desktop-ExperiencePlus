using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class StatusLowongan
    {
        public enum statusState { TERSEDIA, TIDAK_TERSEDIA };

        public void SetStatus(List<lowongan> list)
        {
            foreach (var config in list)
            {
                // Parse periode untuk mendapatkan bulan
                string[] periodeParts = config.periode.Split('/');
                int bulan = int.Parse(periodeParts[1]);
                int tahun = int.Parse(periodeParts[2]);
                // Mengubah nilai enum statusState berdasarkan bulan
                config.Status = (bulan == (int)DateTime.Now.Month) && (tahun == (int)DateTime.Now.Year) 
                    ? statusState.TERSEDIA : statusState.TIDAK_TERSEDIA;
            }
        }
    }
}
