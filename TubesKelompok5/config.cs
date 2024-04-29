using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class config
    {
        public string nama {  get; set; }
        public string edukasi { get; set; }
        public StatusLowongan.statusState Status {  get; set; }
        public string periode { get; set; }
        public config() { }
        public config(string nama, string edukasi, StatusLowongan.statusState Status, string periode) 
        {
            this.nama = nama;
            this.edukasi = edukasi;
            this.Status = Status;
            this.periode = periode;
        }
        
    }
}
