using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using NimbusSync.Server.Domain;
using System.Security.Claims;
using System.Text;

namespace NimbusSync.Server.Repositories
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration configuration;

        public TokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task<string> CreateTokenAsync(Account account)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, account.FullName),
                new Claim(ClaimTypes.Email, account.Email)
            };

            account.Privileges.ForEach(privilege =>
            {
                claims.Add(new Claim(ClaimTypes.Role, privilege.ToString()));
            });

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
                );

            return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}
