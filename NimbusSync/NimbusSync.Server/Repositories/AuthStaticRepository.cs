using NimbusSync.Server.Domain;
using System.Security.Principal;

namespace NimbusSync.Server.Repositories
{
    public class AuthStaticRepository : IAuthRepository
    {
        private readonly List<Account> accounts;

        public AuthStaticRepository()
        {
            accounts = new List<Account>
            {
                new Account
                {
                    Id = "1234",
                    FullName = "Felca",
                    Email = "felipin@gmail.com",
                    Password = "senha",
                    Privileges = new List<Account.PrivilageTypes>
                    {
                        Account.PrivilageTypes.ReadFile,
                        Account.PrivilageTypes.WriteFile,
                        Account.PrivilageTypes.UpdateFile,
                        Account.PrivilageTypes.DeleteFile
                    },
                },
                new Account
                {
                    Id = "0000",
                    FullName = "adm",
                    Email = "adm@geral.com",
                    Password = "0000",
                    Privileges = new List<Account.PrivilageTypes>
                    {
                        Account.PrivilageTypes.ReadFile,
                        Account.PrivilageTypes.WriteFile,
                        Account.PrivilageTypes.UpdateFile,
                        Account.PrivilageTypes.DeleteFile,
                        Account.PrivilageTypes.CreateAccount,
                        Account.PrivilageTypes.UpdateAccount,
                        Account.PrivilageTypes.DeleteAccont
                    }
                }
            };
        }

        public async Task<Account> AuthenticateAsync(string email, string password)
        {
            var authenticatedAccount = accounts
                .FirstOrDefault(a => a.Email == email && a.Password == password);

            return await Task.FromResult(authenticatedAccount);
        }

        public Task<Account> RegisterAsync(string fullName, string email, string password, List<Account.PrivilageTypes> privileges)
        {
            if(accounts.Find(a => a.Email == email) != null)
            {
                return null;
            }

            var account = new Account {
                Id = Guid.NewGuid().ToString(),
                FullName = fullName,
                Email = email,
                Password = password,
                Privileges = privileges
            };

            accounts.Add(account);

            return Task.FromResult(account);
        }
    }
}
