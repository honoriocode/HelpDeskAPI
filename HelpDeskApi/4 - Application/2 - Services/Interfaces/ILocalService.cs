using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Local;

namespace System.Linq;

public interface ILocalService
{
    Task<IEnumerable<LocalDTO>> GetAll();
    Task<LocalDTO> GetById(Guid id);

    Task<LocalDTO> Add(LocalDTO localDTO);
    Task Update(Guid id, LocalDTO localDTO);
    Task Delete(Guid id);
}
