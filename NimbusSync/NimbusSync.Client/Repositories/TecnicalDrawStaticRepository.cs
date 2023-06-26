using NimbusSync.Client;
using System.Reflection;

namespace NimbusSync.Server.Repositories
{
    public class TecnicalDrawStaticRepository : ITecnicalDrawRepository
    {
        private readonly List<TecnicalDraw> tecnicalDraws;
        public TecnicalDrawStaticRepository()
        {
            tecnicalDraws = new List<TecnicalDraw>
            {
                new TecnicalDraw
                {
                    Code = "12341234",
                    Name = "Desenho de Rele",
                    Description = "Um desenho de um rele",
                    CreationDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),
                    FilePath = "",
                    Author = "Felipe"
                },
                new TecnicalDraw
                {
                    Code = "ddddddd",
                    Name = "Desenho de Porta",
                    Description = "Um d2311231 le",
                    CreationDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),
                    FilePath = "",
                    Author = "Carlos"
                }
            };
        }

        public Task<TecnicalDraw> GetTecnicalDrawAsync(string code)
        {
            var tecnicalDraw = tecnicalDraws.FirstOrDefault(x => x.Code == code);

            return Task.FromResult(tecnicalDraw);
        }

        public Task<List<TecnicalDraw>> GetTecnicalDrawsAsync(TecnicalDraw tecnicalDrawQuery)
        {
            var filteredDraws = tecnicalDraws
            .Where(draw =>
            (string.IsNullOrEmpty(tecnicalDrawQuery.Name) || draw.Name.ToLower().Contains(tecnicalDrawQuery.Name)) &&
            (string.IsNullOrEmpty(tecnicalDrawQuery.Author) || draw.Author.ToLower().Contains(tecnicalDrawQuery.Name)) &&
            (string.IsNullOrEmpty(tecnicalDrawQuery.Description) || draw.Description.Contains(tecnicalDrawQuery.Description)))
            .ToList();

            return Task.FromResult(filteredDraws);
        }

        public Task<TecnicalDraw> PostTecnicalDrawAsync(TecnicalDraw tecnicalDraw)
        {
            tecnicalDraws.Add(tecnicalDraw);

            return Task.FromResult(tecnicalDraw);
        }

        public Task<TecnicalDraw> PutTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw)
        {
            var tD = tecnicalDraws.FirstOrDefault(x => x.Code == code);

            if (tD == null) return Task.FromResult(tD);

            tD.Name = tecnicalDraw.Name;
            tD.Description = tecnicalDraw.Description;
            tD.FilePath = tecnicalDraw.FilePath;
            tD.CreationDate = tecnicalDraw.CreationDate;
            tD.CreationDate = tecnicalDraw.CreationDate;
            tD.Author = tecnicalDraw.Author;

            return Task.FromResult(tD);
        }

        public Task<TecnicalDraw> DeleteDrawAsync(string code)
        {
            var tecDrawToRemove = tecnicalDraws.FirstOrDefault(t => t.Code == code);

            if (tecDrawToRemove == null) return null;

            tecnicalDraws.Remove(tecDrawToRemove);

            return Task.FromResult(tecDrawToRemove);
        }

        public Task<TecnicalDraw> PatchTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw)
        {
            var tecDraw = tecnicalDraws.FirstOrDefault(tD => tD.Code == code);

            //if (tecDraw == null) return null;

            //List<PropertyInfo> notNullOrEmptyProps = tecnicalDraw.GetNotNullProperties();
            //Type tecDrawType = tecDraw.GetType();

            //notNullOrEmptyProps.ForEach(newPropertie =>
            //{
            //    PropertyInfo tecDrawPropertyInfo = tecDrawType.GetProperty(newPropertie.Name);

            //    tecDrawPropertyInfo.SetValue(tecDraw, newPropertie.GetValue(tecnicalDraw));
            //});

            return Task.FromResult(tecDraw);
        }
    }
}
