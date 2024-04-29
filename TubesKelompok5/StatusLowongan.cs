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
        private const string filepath = "D:\\Tel U\\Semester 4\\KPL\\TUBES\\TubesKelompok5\\lowongan.json";
        public enum statusState { TERSEDIA, TIDAK_TERSEDIA };

        public statusState currentState = statusState.TERSEDIA;

        public config[] ReadJSON()
        {
            string jsonData = File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<config[]>(jsonData);
        }
        public void SetStatus(config[] configs)
        {
            foreach (var config in configs)
            {
                // Parse periode untuk mendapatkan bulan
                string[] periodeParts = config.periode.Split('/');
                int bulan = int.Parse(periodeParts[1]);
                // Mengubah nilai enum statusState berdasarkan bulan
                config.Status = (bulan == (int)DateTime.Now.Month) ? statusState.TERSEDIA : statusState.TIDAK_TERSEDIA;
            }
        }
    }
}
