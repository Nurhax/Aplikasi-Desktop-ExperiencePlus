using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController_1302220096 : ControllerBase
    {
        private readonly IAuthService_1302220096 _authService;

        public UsersController_1302220096(IAuthService_1302220096 authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserModel_1302220096 model)
        {
            var result = await _authService.RegisterAsync(model);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserModel_1302220096 model)
        {
            var result = await _authService.LoginAsync(model);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserModel_1302220096 model)
        {
            //nambah user baru
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            //get user pake ID
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserModel_1302220096 model)
        {
            //update data user
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            //hapus user pake ID
        }
    }
}
