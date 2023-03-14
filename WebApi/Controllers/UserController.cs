using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.Abstract;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;

        public UserController(IUserService user)
        {
            _user = user;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response =  await _user.GetAll();
            return Ok(response);

        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLogin user)
        {
            var res = await _user.UserLogin(user);

            return Ok(res);
        }
    }
}
