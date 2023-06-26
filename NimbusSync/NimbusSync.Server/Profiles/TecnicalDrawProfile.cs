using AutoMapper;

namespace NimbusSync.Server.Profiles
{
    public class TecnicalDrawProfile : Profile
    {
        public TecnicalDrawProfile()
        {
            CreateMap<NimbusSync.Models.DTO.PostTecnicalDrawRequest, NimbusSync.Models.Domain.TecnicalDraw>();
            CreateMap<NimbusSync.Models.DTO.UpdateTecnicalDrawRequest, NimbusSync.Models.Domain.TecnicalDraw>();
            CreateMap<NimbusSync.Models.DTO.PatchTecnicalDrawRequest, NimbusSync.Models.Domain.TecnicalDraw>();
            CreateMap<NimbusSync.Models.Domain.TecnicalDraw, NimbusSync.Models.DTO.TecnicalDrawDTO >();
        }
    }
}
