namespace NimbusSync.Server.Models.DTO
{
    public record UpdateTecnicalDrawRequest(
        string? Name,
        string? Description,
        byte[]? File,
        DateTime? CreationDate
        );
}
