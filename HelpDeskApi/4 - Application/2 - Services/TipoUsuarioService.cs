
using AutoMapper;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs.TipoUsuario;

public class TipoUsuarioService : ITipoUsuarioService
{
    private readonly IRepository<TipoUsuario> _tipousuarioRepository;
    private readonly IMapper _mapper;

    public TipoUsuarioService(IRepository<TipoUsuario> tipousuarioRepository, IMapper mapper)
    {
        _tipousuarioRepository = tipousuarioRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TipoUsuarioDTO>> GetAll()
    {
        var tipousuarios = await _tipousuarioRepository.GetAll();
        var tipousuariosMapped = _mapper.Map<IEnumerable<TipoUsuarioDTO>>(tipousuarios);

        return tipousuariosMapped;
    }

    public async Task<TipoUsuarioDTO> GetById(Guid id)
    {
        var tipousuario = await _tipousuarioRepository.GetOneWhere(tu => tu.Id == id);
        var tipousuarioMapped = _mapper.Map<TipoUsuarioDTO>(tipousuario);

        return tipousuarioMapped;
    }

    public async Task<TipoUsuarioDTO> Add(TipoUsuarioDTO tipousuarioDTO)
    {
        var tipousuarioMapped = _mapper.Map<TipoUsuario>(tipousuarioDTO);
        var tipousuario = await _tipousuarioRepository.Add(tipousuarioMapped);
        var tipousuarioResponse = _mapper.Map<TipoUsuarioDTO>(tipousuario);

        return tipousuarioResponse;
    }

    public async Task Update(Guid id, TipoUsuarioDTO tipousuarioDTO)
    {
        var tipousuarioExistente = await _tipousuarioRepository.GetOneWhere
            (tu => tu.Id == id);

        if (tipousuarioExistente is null)
            throw new InvalidOperationException($"Não existe nenhum Tipo de usuário com o Id {id}");

        var tipousuarioUpdate = _mapper.Map<TipoUsuario>(tipousuarioDTO);
        var tipousuarioMapped = _mapper.Map(tipousuarioUpdate, tipousuarioExistente);

        _tipousuarioRepository.Update(tipousuarioMapped);
    }

    public async Task Delete(Guid id)
    {
        var tipousuarioExistente = await _tipousuarioRepository.GetOneWhere
            (tu => tu.Id == id);

        if (tipousuarioExistente is null)
            throw new InvalidOperationException($"Não existe nenhum tipo de usuário com o Id {id}");

        _tipousuarioRepository.Remove(tipousuarioExistente);
    }

    
}

