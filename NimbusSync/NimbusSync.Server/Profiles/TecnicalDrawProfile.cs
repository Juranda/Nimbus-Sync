using AutoMapper;

namespace NimbusSync.Server.Profiles
{
    public class TecnicalDrawProfile : Profile
    {
        public TecnicalDrawProfile()
        {
            CreateMap<Models.DTO.PostTecnicalDrawRequest, Models.Domain.TecnicalDraw>();
            CreateMap<Models.DTO.UpdateTecnicalDrawRequest, Models.Domain.TecnicalDraw>();
            CreateMap<Models.DTO.PatchTecnicalDrawRequest, Models.Domain.TecnicalDraw>();
            CreateMap<Models.Domain.TecnicalDraw, Models.DTO.TecnicalDrawDTO >();
        }
    }
}
