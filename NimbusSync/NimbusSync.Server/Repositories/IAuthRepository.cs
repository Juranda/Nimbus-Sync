using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Repositories
{
    public interface IAuthRepository
    {
        public Task<Account> AuthenticateAsync(string email, string password);
        public Task<Account> RegisterAsync(string fullName, string email, string password, List<Account.PrivilageTypes> privileges);
    }
}
