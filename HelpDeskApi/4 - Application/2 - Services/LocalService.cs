using AutoMapper;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs.Local;

public class LocalService : ILocalService
{
    private readonly IRepository<Local> _localRepository;
    private readonly IMapper _mapper;

    public LocalService(IRepository<Local> localRepository, IMapper mapper)
    {
        _localRepository = localRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LocalDTO>> GetAll()
    {
        var locais = await _localRepository.GetAll();
        var locaisMapped = _mapper.Map<IEnumerable<LocalDTO>>(locais);

        return locaisMapped;
    }

    public async Task<LocalDTO> GetById(Guid id)
    {
        var local = await _localRepository.GetOneWhere(l => l.Id == id);
        var localMapped = _mapper.Map<LocalDTO>(local);

        return localMapped;
    }

    public async Task<LocalDTO> Add(LocalDTO localDTO)
    {
        var localMapped = _mapper.Map<Local>(localDTO);
        var local = await _localRepository.Add(localMapped);
        var localResponse = _mapper.Map<LocalDTO>(local);

        return localResponse;
    }

    public async Task Update(Guid id, LocalDTO localDTO)
    {
        var localExistente = await _localRepository.GetOneWhere
            (l => l.Id == id);

        if (localExistente is null)
            throw new InvalidOperationException($"Não existe nenhum local com o Id {id}");

        var localUpdate = _mapper.Map<Local>(localDTO);
        var localMapped = _mapper.Map(localUpdate, localExistente);

        _localRepository.Update(localMapped);
    }

    public async Task Delete(Guid id)
    {
        var localExistente = await _localRepository.GetOneWhere
            (l => l.Id == id);

        if (localExistente is null)
            throw new InvalidOperationException($"Não existe nenhum local com o Id {id}");

        _localRepository.Remove(localExistente);
    }

}
