using NimbusSync.Models.Domain;

namespace NimbusSync.Server.Repositories
{
    public interface IAuthRepository
    {
        public Task<string?> AuthenticateAsync(string email, string password);
        public Task<string?> RegisterAsync(string fullName, string email, string password, List<Account.PrivilageTypes> privileges);
    }
}
