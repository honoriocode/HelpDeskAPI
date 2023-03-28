using AutoMapper;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Domain.Models;

namespace System.Linq;

public class UsuarioService : IUsuarioService
{
    private readonly IRepository<Usuario> _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IRepository<Usuario> usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UsuarioDTO>> GetAll()
    {
        var usuarios = await _usuarioRepository.GetAll();
        var usuariosMapped = _mapper.Map<IEnumerable<UsuarioDTO>>(usuarios);

        return usuariosMapped;
    }

    public async Task<UsuarioDTO> GetById(Guid id)
    {
        var usuario = await _usuarioRepository.GetOneWhere(u => u.Id == id);
        var usuarioMapped = _mapper.Map<UsuarioDTO>(usuario);

        return usuarioMapped;
    }

    public async Task<UsuarioDTO> Add(UsuarioDTO usuarioDTO)
    {
        var usuarioExistente = await _usuarioRepository.GetOneWhere
            (u => u.Login == usuarioDTO.Login);

        if (usuarioExistente is not null)
            throw new InvalidOperationException("Já existe um usuário com o mesmo Login.");

        var usuarioMapped = _mapper.Map<Usuario>(usuarioDTO);
        var usuario = await _usuarioRepository.Add(usuarioMapped);
        var usuarioResponse = _mapper.Map<UsuarioDTO>(usuario);

        return usuarioResponse;
    }

    public async Task Update(Guid id, UsuarioDTO usuarioDTO)
    {
        var usuarioExistente = await _usuarioRepository.GetOneWhere
            (u => u.Id == id);

        if (usuarioExistente is null)
            throw new InvalidOperationException($"Não existe nenhum usuário com o Id {id}");

        if (await _usuarioRepository.GetOneWhere
                    (u => u.Login == usuarioDTO.Login
                    && u.Id != id) is not null)
            throw new InvalidOperationException("Já existe um usuário com o mesmo Login.");

        var usuarioUpdate = _mapper.Map<Usuario>(usuarioDTO);
        var usuarioMapped = _mapper.Map(usuarioUpdate, usuarioExistente);

        _usuarioRepository.Update(usuarioMapped);
    }

    public async Task Delete(Guid id)
    {
        var usuarioExistente = await _usuarioRepository.GetOneWhere
            (u => u.Id == id);

        if (usuarioExistente is null)
            throw new InvalidOperationException($"Não existe nenhum usuário com o Id {id}");

        _usuarioRepository.Remove(usuarioExistente);
    }
}