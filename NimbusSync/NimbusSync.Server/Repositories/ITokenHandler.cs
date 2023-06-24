using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(Account account);
    }
}
