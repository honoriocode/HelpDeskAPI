using AutoMapper;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Chamado;
using HelpDeskApi.Domain.Models;

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
