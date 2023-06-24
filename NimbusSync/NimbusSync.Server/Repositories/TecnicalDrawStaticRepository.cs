using NimbusSync.Server.Domain;
using NimbusSync.Server.Models.DTO;
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
                    CreationDate = DateTime.Now.AddDays(-1),
                    RegistrationDate = DateTime.Now,
                    File = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 },
                    Author = new Account
                    {
                        FullName = "Felipe"
                    },
                    AuthorId = "meuid"
                },
                new TecnicalDraw
                {
                    Code = "43214321",
                    Name = "Desenho Incrivel",
                    Description = "Quase tao incrivel quanto o anterior",
                    CreationDate = DateTime.Now.AddDays(-5),
                    RegistrationDate = DateTime.Now.AddMonths(-1),
                    File = new byte[] { 22, 21, 20, 19, 18, 17, 16, 15, 14 },
                    Author = new Account
                    {
                        FullName = "Bruno"
                    },
                    AuthorId = "seuid"
                }
            };
        }

        public Task<TecnicalDraw> GetTecnicalDrawAsync(string code)
        {
            var tecnicalDraw = tecnicalDraws.FirstOrDefault(x => x.Code == code);

            return Task.FromResult(tecnicalDraw);
        }

        public Task<List<TecnicalDraw>> GetTecnicalDrawsAsync(TecnicalDrawQuery tecnicalDrawQuery)
        {
            if(tecnicalDrawQuery.AllPropetiesAreNull())
            {
                return Task.FromResult(tecnicalDraws);
            }

            var filteredDraws = tecnicalDraws
            .Where(draw =>
            (string.IsNullOrEmpty(tecnicalDrawQuery.Name) || draw.Name.ToLower().Contains(tecnicalDrawQuery.Name)) &&
            (string.IsNullOrEmpty(tecnicalDrawQuery.AuthorName) || draw.Author.FullName.ToLower().Contains(tecnicalDrawQuery.AuthorName)) &&
            (string.IsNullOrEmpty(tecnicalDrawQuery.Description) || draw.Description.Contains(tecnicalDrawQuery.Description)))
            .ToList();

            return Task.FromResult(filteredDraws);
        }

        public Task<TecnicalDraw> PostTecnicalDrawAsync(TecnicalDraw tecnicalDraw)
        {
            if(string.IsNullOrEmpty(tecnicalDraw.Code))
            {
                TecnicalDraw.GenerateCode(tecnicalDraw);
            }

            tecnicalDraws.Add(tecnicalDraw);

            return Task.FromResult(tecnicalDraw);
        }

        public Task<TecnicalDraw> PutTecnicalDrawAsync(string code, TecnicalDraw tecnicalDraw)
        {
            var tD = tecnicalDraws.FirstOrDefault(x => x.Code == code);

            if(tD == null || tD.AllPropetiesAreNull())
            {
                return null;
            }

            tD.Name = tecnicalDraw.Name;
            tD.Description = tecnicalDraw.Description;
            tD.File = tecnicalDraw.File;
            tD.CreationDate = tecnicalDraw.CreationDate;
            tD.RegistrationDate = tecnicalDraw.RegistrationDate;
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

            if (tecDraw == null) return null;

            List<PropertyInfo> notNullOrEmptyProps = tecnicalDraw.GetNotNullProperties();
            Type tecDrawType = tecDraw.GetType();

            notNullOrEmptyProps.ForEach(newPropertie =>
            {
                PropertyInfo tecDrawPropertyInfo = tecDrawType.GetProperty(newPropertie.Name);

                tecDrawPropertyInfo.SetValue(tecDraw, newPropertie.GetValue(tecnicalDraw));
            });

            return Task.FromResult(tecDraw);
        }
    }
}
