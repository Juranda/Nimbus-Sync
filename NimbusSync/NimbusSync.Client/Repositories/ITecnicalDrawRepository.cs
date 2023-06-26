using NimbusSync.Client;

namespace NimbusSync.Server.Repositories
{
    public interface ITecnicalDrawRepository
    {
        public Task<TecnicalDraw> DeleteDrawAsync(string code);
        public Task<TecnicalDraw> GetTecnicalDrawAsync(string code);
        public Task<List<TecnicalDraw>> GetTecnicalDrawsAsync(TecnicalDraw tecnicalDraw);
        public Task<TecnicalDraw> PostTecnicalDrawAsync(TecnicalDraw tecnicalDraw);
        public Task<TecnicalDraw> PutTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw);
        public Task<TecnicalDraw> PatchTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw);
    }
}
