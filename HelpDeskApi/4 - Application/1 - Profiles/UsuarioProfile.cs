using AutoMapper;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
        }
        
    }
}
