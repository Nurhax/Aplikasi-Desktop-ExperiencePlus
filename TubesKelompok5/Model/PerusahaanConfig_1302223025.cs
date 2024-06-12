using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesKelompok5.Model;

namespace TubesKelompok5
{

    public class User_1302223025 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Lowongan_1302223025> Lowongan { get; set; }

        public User_1302223025(string username, string password, List<Lowongan_1302223025> lowongan)
        {
            Username = username;
            Password = password;
            Lowongan = lowongan;
        }
        public List<Lowongan_1302223025> getLowongan()
        {
            return Lowongan;
        }
    }
}
