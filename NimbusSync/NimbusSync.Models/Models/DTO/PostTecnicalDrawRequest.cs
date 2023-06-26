namespace NimbusSync.Models.DTO
{
    public record PostTecnicalDrawRequest(
            string? Code,
            string Name,
            string Description,
            byte[] File,
            string AuthorName,
            string AuthorId
        );
}
