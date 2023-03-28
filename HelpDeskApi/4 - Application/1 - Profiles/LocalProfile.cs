using AutoMapper;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Local;
using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Profiles
{
    public class LocalProfile : Profile
    {
        public LocalProfile()
        {
            CreateMap<LocalDTO, Local>();
        }

    }
}
