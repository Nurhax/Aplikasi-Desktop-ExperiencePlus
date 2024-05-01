namespace TubesKelompok5
{
    public interface IUserRepository
    {
        Task<User_1302220096> GetUserByIdAsync(int userId);
        Task<bool> UserExists(string username);
        Task<bool> EmailExists(string email);
        Task AddAsync(User_1302220096 user);
    }

    public interface IUser_1302220096
    {
        Task<ServiceResponse<string>> RegisterAsync(User_1302220096 model);
    }

    public class UserService : IUser_1302220096
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ServiceResponse<string>> RegisterAsync(User_1302220096 model)
        {
            // Memvalidasi username password
            if (await _userRepository.UserExists(model.username) || await _userRepository.EmailExists(model.Email))
            {
                return new ServiceResponse<string>("Username Atau Email Sudah Terdaftar.");
            }

            // Meng-hash password
            var hashedPassword = HashPassword(model.passwordHashed);

            // Bikin entitas user baru
            var user = new User_1302220096
            {
                username = model.username,
                email = model.email,
                passwordHashed = hashedPassword
            };

            // Menambah user ke db
            await _userRepository.AddAsync(user);

            return new ServiceResponse<string>("User Berhasil Mendaftar");
        }

        private string HashPassword(string password)
        {
            // Meng-hash password supaya aman dgn bcrypt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}