using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class Database
    {
        private List<UserRole> _mahasiswaUsers = new List<UserRole>();
        private List<UserRole> _perusahaanUsers = new List<UserRole>();

        public void AddMahasiswaUser(UserRole user)
        {
            _mahasiswaUsers.Add(user);
        }

        public void AddPerusahaanUser(UserRole user)
        {
            _perusahaanUsers.Add(user);
        }

        public void CheckUsernameExists(UserRole user)
        {
            _mahasiswaUsers.Contains(user);
            _perusahaanUsers.Contains(user);

        }
        public void CheckEmailExists(UserRole email)
        {
            _mahasiswaUsers.Contains(email);
            _perusahaanUsers.Contains(email);

        }
    }
}
