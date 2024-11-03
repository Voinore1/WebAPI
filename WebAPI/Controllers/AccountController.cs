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
        public IActionResult Register([FromBody] RegisterModel model)
        {
            accountservice.Register(model);
            return Ok();
        }
    }
}
