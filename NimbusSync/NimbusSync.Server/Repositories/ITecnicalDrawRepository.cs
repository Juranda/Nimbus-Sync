using NimbusSync.Server.Domain;
using NimbusSync.Server.Models.DTO;

namespace NimbusSync.Server.Repositories
{
    public interface ITecnicalDrawRepository
    {
        public Task<TecnicalDraw> DeleteDrawAsync(string code);
        public Task<TecnicalDraw> GetTecnicalDrawAsync(string code);
        public Task<List<TecnicalDraw>> GetTecnicalDrawsAsync(TecnicalDrawQuery tecnicalDraw);
        public Task<TecnicalDraw> PostTecnicalDrawAsync(TecnicalDraw tecnicalDraw);
        public Task<TecnicalDraw> PutTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw);
    }
}
