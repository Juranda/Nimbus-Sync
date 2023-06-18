namespace NimbusSync.Server.Models.DTO
{
    public record UpdateTecnicalDrawRequest(
        string? Name,
        string? Description,
        List<string>? Materials,
        byte[]? File,
        DateTime? CreationDate
        );
}
