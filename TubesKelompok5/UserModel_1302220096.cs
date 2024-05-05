using System.Threading.Tasks;

namespace TubesKelompok5
{
    public class UserModel_1302220096
    {
        //regsiter dan login
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public ProfileModel_1302220096 Profile { get; set; }

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
            return false;
        }

        private async Task<bool> CheckEmailExistsAsync(string email)
        {
            return false;
        }

        private async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            return false;
        }
    }
}
