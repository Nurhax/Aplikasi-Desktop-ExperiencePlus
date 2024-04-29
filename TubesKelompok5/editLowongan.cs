using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class editLowongan
    {
        private const string filepath = "D:\\Tel U\\Semester 4\\KPL\\TUBES\\TubesKelompok5\\lowongan.json";

        public List<config> readLowongan()
        {
            string jsonData = File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<List<config>>(jsonData);   
        }
        public void writeLowongan(List<config> lowongan)
        {
            string jsonData = JsonConvert.SerializeObject(lowongan, Formatting.Indented);
            File.WriteAllText(filepath, jsonData);
        }
        public void EditLowongan(string nama, config newData)
        {
            List<config> lowongan = readLowongan();
            for(int i = 0; i < lowongan.Count; i++)
            {
                if (lowongan[i].nama == nama) 
                {
                    lowongan[i] = newData;
                }
            }
            writeLowongan(lowongan);
        }
    }
}
