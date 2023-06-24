using AutoMapper;

namespace NimbusSync.Server.Models.Profiles
{
    public class TecnicalDrawProfile : Profile
    {
        public TecnicalDrawProfile()
        {
            CreateMap<DTO.PostTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<DTO.UpdateTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<DTO.PatchTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<Domain.TecnicalDraw, DTO.TecnicalDrawDTO>();
        }
    }
}
