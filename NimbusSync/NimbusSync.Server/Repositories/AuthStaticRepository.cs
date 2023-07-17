using NimbusSync.Models.Domain;

namespace NimbusSync.Server.Repositories
{
    public class AuthStaticRepository : IAuthRepository
    {
        private readonly List<Account> accounts;
        private readonly ITokenHandler tokenHandler;

        public AuthStaticRepository(ITokenHandler tokenHandler)
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
            this.tokenHandler = tokenHandler;
        }

        public async Task<string?> AuthenticateAsync(string email, string password)
        {
            var authenticatedAccount = accounts
                .FirstOrDefault(a => a.Email == email && a.Password == password);

            if(authenticatedAccount == default)
            {
                return await Task.FromResult<string?>(null);
            }

            string token = await tokenHandler.CreateTokenAsync(authenticatedAccount);

            return await Task.FromResult(token);
        }

        public async Task<string?> RegisterAsync(string fullName, string email, string password, List<Account.PrivilageTypes> privileges)
        {
            if(accounts.FirstOrDefault(a => a.Email == email) != null)
            {
                return await Task.FromResult<string?>(null);
            }

            var account = new Account {
                Id = Guid.NewGuid().ToString(),
                FullName = fullName,
                Email = email,
                Password = password,
                Privileges = privileges
            };

            accounts.Add(account);

            string token = await tokenHandler.CreateTokenAsync(account);

            return await Task.FromResult(token);
        }
    }
}
