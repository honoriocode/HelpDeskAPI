using HelpDeskApi.Data.DTOs.TipoUsuario;

namespace System.Linq;

public interface ITipoUsuarioService
{
    Task<IEnumerable<TipoUsuarioDTO>> GetAll();
    Task<TipoUsuarioDTO> GetById(Guid id);

    Task<TipoUsuarioDTO> Add(TipoUsuarioDTO tipoUsuarioDTO);
    Task Update(Guid id, TipoUsuarioDTO TipoUsuarioDTO);
    Task Delete(Guid id);

}


