using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Models.DTO
{
    public record RegisterAccountRequest(
        string FullName,
        string Email,
        string Password,
        List<Account.PrivilageTypes> Privileges
        );
}
