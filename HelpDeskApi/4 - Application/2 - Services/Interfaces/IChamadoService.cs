using HelpDeskApi.Data.DTOs.Chamado;

namespace System.Linq;

public interface IChamadoService
{
    Task<IEnumerable<ChamadoDTO>> GetAll();
    Task<ChamadoDTO> GetById(Guid id);

    Task<ChamadoDTO> Add(ChamadoDTO chamadoDTO);
    Task Update(Guid id, ChamadoDTO chamadoDTO);
    Task Delete(Guid id);
}
