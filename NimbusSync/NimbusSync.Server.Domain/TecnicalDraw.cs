using System.ComponentModel.DataAnnotations.Schema;

namespace NimbusSync.Server.Domain
{
    public class TecnicalDraw
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Material> Materials { get; set; }
        public byte[] File { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Account Author { get; set; }
        public string AuthorId { get; set; }

        //Criar usando os materiais
        public static string GenerateCode(TecnicalDraw tecnicalDraw)
        {
            string code = Guid.NewGuid().ToString();

            tecnicalDraw.Code = code;
            return code;
        }
    }
}
