/*using System.Threading.Tasks;

namespace TubesKelompok5
{
    public enum UserRole
    {
        Mahasiswa,
        Perusahaan
    }

    public class UserModel_1302220096
    {
        // Informasi otentikasi
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        // Informasi profil
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string Address { get; set; }

        // Role pengguna
        public UserRole Role { get; set; }

        public bool Success { get; set; }
        public string Message { get; set; }

        public ProfileMahasiswa_1302220096 ProfileMHS { get; set; }
        public ProfilePerusahaan_1302220096 ProfileCompany { get; set; }

        // Metode untuk registrasi dan login
        public async Task<UserModel_1302220096> RegisterAsync(UserModel_1302220096 model)
        {
            bool usernameExists = await CheckUsernameExistsAsync(model.Username);
            bool emailExists = await CheckEmailExistsAsync(model.Email);

            if (usernameExists || emailExists)
            {
                return new UserModel_1302220096 { Success = false, Message = "Username atau email sudah terdaftar." };
            }
            return new UserModel_1302220096 { Success = true, Message = "Registrasi berhasil." };
        }

        public async Task<UserModel_1302220096> LoginAsync(UserModel_1302220096 model)
        {
            bool isAuthenticated = await AuthenticateUserAsync(model.Username, model.Password);

            if (!isAuthenticated)
            {
                return new UserModel_1302220096 { Success = false, Message = "Username atau password salah." };
            }
            return new UserModel_1302220096 { Success = true, Message = "Login berhasil." };
        }

        private async Task<bool> CheckUsernameExistsAsync(string username)
        {
            bool usernameExists = await Database.CheckUsernameExistsAsync(username);
            return usernameExists;
        }

        private async Task<bool> CheckEmailExistsAsync(string email)
        {
            bool emailExists = await Database.CheckEmailExistsAsync(email);
            return emailExists;
        }

        private async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            bool isAuthenticated = (username == "admin" && password == "admin");
            return isAuthenticated;
        }

    }
}
*/