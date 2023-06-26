using NimbusSync.Models.Domain;

namespace NimbusSync.Models.DTO
{
    public record RegisterAccountRequest(
        string FullName,
        string Email,
        string Password,
        List<Account.PrivilageTypes> Privileges
        );
}
