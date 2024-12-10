using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(IAccountService accountservice) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            return Ok(await accountservice.Register(model));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        { 
            return Ok(await accountservice.Login(model));
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await accountservice.Logout();
            return Ok();
        }
    }
}
