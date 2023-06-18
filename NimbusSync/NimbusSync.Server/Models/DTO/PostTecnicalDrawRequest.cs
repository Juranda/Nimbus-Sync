using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Models.DTO
{
    public record PostTecnicalDrawRequest(
            string? Id,
            string Name,
            string Description,
            byte[] File,
            List<string> Materials,
            string AuthorId
        );
}
