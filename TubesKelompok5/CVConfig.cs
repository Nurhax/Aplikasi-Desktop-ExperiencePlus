using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static TubesKelompok5.BuatLowongan_1302223050;

namespace TubesKelompok5
{
    public class CVConfig
    {
        public ListCV_1302223050.CV CV = new ListCV_1302223050.CV();


        public CVConfig()
        {
            
                try
                {
                    readConfig();
                }
                catch (Exception)
                {
                    setDefault();
                    writeConfig();
                }
        }



        public void setDefault()
        {
            CV.setEmail("test");
            CV.setPengalaman("test");
            CV.setNama("test");
            CV.setEdukasi("test");
        }

        public void writeConfig()
        {
            string json =("C:\\Kuliah\\kpl\\tubes KPL 2\\TubesKelompok5\\CVConfig1.json");
            string jsonData = JsonConvert.SerializeObject(CV, Formatting.Indented);
            File.WriteAllText( json, jsonData);
        }

        public ListCV_1302223050.CV readConfig()
        {
            string json = File.ReadAllText("C:\\Kuliah\\kpl\\tubes KPL 2\\TubesKelompok5\\CVConfig1.json");
            ListCV_1302223050.CV Cv = JsonConvert.DeserializeObject<ListCV_1302223050.CV>(json);
            return Cv;
        }
    }
}
