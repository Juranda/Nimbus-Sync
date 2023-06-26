using NimbusSync.Models.Domain;

namespace NimbusSync.Server.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(Account account);
    }
}
