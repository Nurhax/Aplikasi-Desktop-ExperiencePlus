using Microsoft.AspNetCore.Mvc;

namespace TubesKelompok5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController_1302220096 : ControllerBase
    {
        private readonly IUser_1302220096 _userService;

        public UserController_1302220096(IUser_1302220096 userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User_1302220096 model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.RegisterAsync(model);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok("Berhasil Mendaftar");
        }
    }

}
