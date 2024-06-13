using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LibraryTubes.Hashing
{
    public class HashingPassword
    {
        public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[32];
                rng.GetBytes(salt);
                return salt;
            }
        }

        public static string HashPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] passByte = Encoding.UTF8.GetBytes(password);
            using (var SHA256 = new HMACSHA256(salt))
            {
                byte[] HashBytes = SHA256.ComputeHash(passByte);
                string hash = Convert.ToBase64String(HashBytes);
                string saltString = Convert.ToBase64String(salt);
                return $"{saltString};{hash}";
            }
        }
    }
}
