using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(string username, string password){
            //Validate request

            username = username.ToLower();

            if(await _repo.UserExists(username)){
                return BadRequest("Username Already Exists");
            }

            var userToCreat = new User{
                Username = username
            };

            var createdUser = await _repo.Register(userToCreat, password);

            return StatusCode(201);
        }
    }
}