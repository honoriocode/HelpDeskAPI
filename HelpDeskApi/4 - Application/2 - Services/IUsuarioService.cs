using HelpDeskApi.Data.DTOs;

namespace System.Linq;

public interface IUsuarioService
{
    Task<IEnumerable<UsuarioDTO>> GetAll();
    Task<UsuarioDTO> GetById(Guid id);

    Task<UsuarioDTO> Add(UsuarioDTO usuarioDTO);
    Task Update(Guid id, UsuarioDTO usuarioDTO);
    Task Delete(Guid id);
}

