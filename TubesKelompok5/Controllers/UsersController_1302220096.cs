using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TubesKelompok5
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController_1302220096 : ControllerBase
    {
        private readonly Service_1302220096 _authService;
        private readonly Service_1302220096 _userService;
        public UsersController_1302220096()
        {
            _authService = _authService;
            _userService = _userService;
        }
        public class ServiceResponse<T>
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
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
            var result = await _userService.CreateUserAsync(model);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);

            if (!result.Success)
            {
                return NotFound();
            }

            return Ok(result.Data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserModel_1302220096 model)
        {
            //update data user
            var result = await _userService.UpdateUserAsync(id, model);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            //hapus user pake ID
            var result = await _userService.DeleteUserAsync(id);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Data);
        }

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
