using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController_1302220096 : ControllerBase
    {
        
        private readonly List<UserModel_1302220096> _UserModelList = new List<UserModel_1302220096>();
        public UsersController_1302220096()
        {
            
        }
        public class ServiceResponse<T>
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
        }

        [HttpPost("register")]
        public IActionResult Register(UserModel_1302220096 model)
        {
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Username dan password harus diisi.");
            }

            return Ok("Registrasi berhasil.");
        }

        [HttpPost("login")]
        public IActionResult Login(UserModel_1302220096 model)
        {
            var user = _UserModelList.Find(u => u.Username == model.Username && u.Password == model.Password);

            if (user == null)
            {
                return BadRequest("Username atau password salah.");
            }

            return Ok("Login berhasil.");
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UserModel_1302220096 model)
        {
            if(User == null)
            {
                return BadRequest("Username Tidak Tersedia");
            }
            return Ok("Berhasil Membuat User");
        }

        
        //
        

        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile()
        {
            var user = HttpContext.Items["User"] as UserModel_1302220096;
            if (user == null)
            {
                return Unauthorized();
            }

            return Ok();
        }

        [HttpPut("profile")]
        public async Task<IActionResult> UpdateProfile(UserModel_1302220096 updatedProfile)
        {
            var user = HttpContext.Items["User"] as UserModel_1302220096;
            if (user == null)
            {
                return Unauthorized();
            }

            return Ok("Profile updated successfully.");
        }
    }
}
