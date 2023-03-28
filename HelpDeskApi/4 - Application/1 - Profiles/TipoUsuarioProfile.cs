using AutoMapper;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.TipoUsuario;
using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Profiles
{
    public class TipoUsuarioProfile : Profile
    {
        public TipoUsuarioProfile()
        {
            CreateMap<TipoUsuarioDTO, TipoUsuario>();
        }

    }
}
