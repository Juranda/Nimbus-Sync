using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Models.DTO
{
    public class TecnicalDrawDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Material> Materials { get; set; }
        public byte[] File { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Account Author { get; set; }
    }
}
