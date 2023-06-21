using AutoMapper;

namespace NimbusSync.Server.Models.Perfis
{
    public class TecnicalDrawProfile : Profile
    {
        public TecnicalDrawProfile()
        {
            CreateMap<DTO.PostTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<DTO.UpdateTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<DTO.PatchTecnicalDrawRequest, Domain.TecnicalDraw>();
            CreateMap<Domain.TecnicalDraw, DTO.TecnicalDrawDTO>();
                //.ForAllMembers(opt =>
                //{
                //    opt.Condition((src, dest, srcMember, destMember, context) =>
                //    {
                //        if (srcMember == null ||
                //            (srcMember.GetType() == typeof(DateTime) && (DateTime)srcMember == DateTime.MinValue) ||
                //            (srcMember.GetType() == typeof(string) && string.IsNullOrEmpty((string)srcMember)) ||
                //            (srcMember.GetType() == typeof(byte[]) && (byte[])srcMember == Array.Empty<byte>()))
                //        {
                //            destMember = null;
                //            return false;
                //        }

                //        return true;
                //    });
                //});
        }
    }
}
