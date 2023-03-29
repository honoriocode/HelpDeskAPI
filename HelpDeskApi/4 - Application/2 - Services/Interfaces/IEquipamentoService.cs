using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Equipamento;

namespace System.Linq;

public interface IEquipamentoService
{
    Task<IEnumerable<EquipamentoDTO>> GetAll();
    Task<EquipamentoDTO> GetById(Guid id);

    Task<EquipamentoDTO> Add(EquipamentoDTO equipamentoDTO);
    Task Update(Guid id, EquipamentoDTO equipamentoDTO);
    Task Delete(Guid id);
}
