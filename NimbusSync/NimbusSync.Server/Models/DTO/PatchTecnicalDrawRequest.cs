namespace NimbusSync.Server.Models.DTO
{
    public record PatchTecnicalDrawRequest(
        string? Name,
        string? Description,
        byte[]? File,
        DateTime? CreationDate
        );
}
