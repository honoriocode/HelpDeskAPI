using AutoMapper;
using HelpDeskApi.Data.DTOs.Chamado;

namespace HelpDeskApi.Profiles
{
    public class ChamadoProfile : Profile
    {
        public ChamadoProfile()
        {
            CreateMap<ChamadoDTO, Chamado>();
        }
    }
}
