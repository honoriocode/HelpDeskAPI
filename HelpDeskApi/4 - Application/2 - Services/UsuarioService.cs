using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Domain.Models;

namespace System.Linq;

public interface IUsuarioService
{
    IEnumerable<UsuarioDTO> GetAllUsuarios();
    UsuarioDTO GetUsuarioById(Guid id);
    void AddUsuario(UsuarioDTO usuarioDTO, object v);
    void UpdateUsuario(Guid id, UsuarioDTO usuarioDTO);
    void RemoveUsuario(Guid id);
    object Get_usuarioRepository();
}

public class UsuarioService : IUsuarioService
{
    private readonly IRepository<Usuario> _usuarioRepository;

    public UsuarioService(IRepository<Usuario> usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public IEnumerable<UsuarioDTO> GetAllUsuarios()
    {
        List<Usuario> usuarios = (List<Usuario>)_usuarioRepository.GetAll();
        return usuarios.Select(u => new UsuarioDTO(u));
    }

    public UsuarioDTO GetUsuarioById(Guid id)
    {
        var usuario = _usuarioRepository.GetById(id);

        if (usuario == null)
            throw new Exception("Usuário não encontrado");

        return new UsuarioDTO(usuario);
    }

    public IRepository<Usuario> Get_usuarioRepository()
    {
        return _usuarioRepository;
    }

    public void AddUsuario(UsuarioDTO usuarioDTO, UsuarioRepository _usuarioRepository)
    {
        if (usuarioDTO == null)
            throw new Exception("Dados inválidos");

        var usuario = new Usuario(Guid.NewGuid());
        usuario.Nome = usuarioDTO.Nome;
        usuario.Login = usuarioDTO.Login;
        usuario.Senha = usuarioDTO.Senha;
        usuario.TipoUsuarioId = usuarioDTO.TipoUsuarioId;
        usuario.Contato = usuarioDTO.Contato;
        _usuarioRepository.Add(usuario);
    }



    public void UpdateUsuario(Guid id, UsuarioDTO usuarioDTO)
    {
        if (usuarioDTO == null || usuarioDTO.Id != id)
            throw new Exception("Dados inválidos");

        var usuarioRep = new UsuarioRepository();

        if (usuarioDTO == null)
            throw new Exception("Usuário não encontrado");

        usuarioDTO.Nome = usuarioDTO.Nome;
        usuarioDTO.Login = usuarioDTO.Login;
        usuarioDTO.Senha = usuarioDTO.Senha;
        usuarioDTO.TipoUsuarioId = usuarioDTO.TipoUsuarioId;
        usuarioDTO.Contato = usuarioDTO.Contato;

        usuarioRep.Update(usuarioDTO);
    }

    public void RemoveUsuario(Guid id)
    {
        var usuario = _usuarioRepository.GetById(id);

        if (usuario == null)
            throw new Exception("Usuário não encontrado");

        _usuarioRepository.Remove(usuario);
    }

    public void AddUsuario(UsuarioDTO usuarioDTO, object v)
    {
        throw new NotImplementedException();
    }

    object IUsuarioService.Get_usuarioRepository()
    {
        throw new NotImplementedException();
    }
}

