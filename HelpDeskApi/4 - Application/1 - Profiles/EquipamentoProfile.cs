using AutoMapper;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Equipamento;
using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Profiles
{
    public class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<EquipamentoDTO, Equipamento>();
        }

    }
}
