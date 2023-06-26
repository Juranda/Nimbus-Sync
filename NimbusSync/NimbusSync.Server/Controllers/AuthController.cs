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
        private readonly ITokenHandler tokenHandler;

        public AuthController(IAuthRepository authRepository, ITokenHandler tokenHandler)
        {
            this.authRepository = authRepository;
            this.tokenHandler = tokenHandler;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginAccountRequest loginAccountRequest)
        {
            var account = await authRepository.AuthenticateAsync(loginAccountRequest.Email, loginAccountRequest.Password);

            if (account == null) return BadRequest("Usuário ou senha inválidos!");

            var token = await tokenHandler.CreateTokenAsync(account);

            return Ok(token);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterAccountRequest registerAccountRequest)
        {
            var account = await authRepository.RegisterAsync(
                registerAccountRequest.FullName, 
                registerAccountRequest.Email,
                registerAccountRequest.Password, 
                registerAccountRequest.Privileges);

            if (account == null) return BadRequest("Uma conta com esse email já existe!");

            var token = await tokenHandler.CreateTokenAsync(account);

            return Ok(token);
        }
    }
}
