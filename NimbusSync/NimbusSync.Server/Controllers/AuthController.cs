using Microsoft.AspNetCore.Mvc;
using NimbusSync.Models.DTO;
using NimbusSync.Server.Repositories;

namespace NimbusSync.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginAccountRequest loginAccountRequest)
        {
            string token = await authRepository.AuthenticateAsync(loginAccountRequest.Email, loginAccountRequest.Password);

            if (token == null) return BadRequest("Usuário ou senha inválidos!");

            return Ok(token);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterAccountRequest registerAccountRequest)
        {
            var token = await authRepository.RegisterAsync(
                registerAccountRequest.FullName, 
                registerAccountRequest.Email,
                registerAccountRequest.Password, 
                registerAccountRequest.Privileges);

            if (token == null) return BadRequest("Uma conta com esse email já existe!");

            return Ok(token);
        }
    }
}
