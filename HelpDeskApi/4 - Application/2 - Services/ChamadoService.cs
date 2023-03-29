using AutoMapper;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs.Chamado;

public class ChamadoService : IChamadoService
{
    private readonly IRepository<Chamado> _chamadoRepository;
    private readonly IMapper _mapper;

    public 
        ChamadoService(IRepository<Chamado> chamadoRepository, IMapper mapper)
    {
        _chamadoRepository = chamadoRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ChamadoDTO>> GetAll()
    {
        var chamados = await _chamadoRepository.GetAll();
        var chamadosMapped = _mapper.Map<IEnumerable<ChamadoDTO>>(chamados);

        return chamadosMapped;
    }

    public async Task<ChamadoDTO> GetById(Guid id)
    {
        var chamado = await _chamadoRepository.GetOneWhere(c => c.Id == id);
        var chamadoMapped = _mapper.Map<ChamadoDTO>(chamado);

        return chamadoMapped;
    }

    public async Task<ChamadoDTO> Add(ChamadoDTO ChamadoDTO)
    {
        var chamadoMapped = _mapper.Map<Chamado>(ChamadoDTO);
        var chamado = await _chamadoRepository.Add(chamadoMapped);
        var chamadoResponse = _mapper.Map<ChamadoDTO>(chamado);

        return chamadoResponse;
    }

    public async Task Update(Guid id, ChamadoDTO ChamadoDTO)
    {
        var chamadoExistente = await _chamadoRepository.GetOneWhere
            (c => c.Id == id);

        if (chamadoExistente is null)
            throw new InvalidOperationException($"Não existe nenhum chamado com o Id {id}");

        var chamadoUpdate = _mapper.Map<Chamado>(ChamadoDTO);
        var chamadoMapped = _mapper.Map(chamadoUpdate, chamadoExistente);

        _chamadoRepository.Update(chamadoMapped);
    }

    public async Task Delete(Guid id)
    {
        var chamadoExistente = await _chamadoRepository.GetOneWhere
            (c => c.Id == id);

        if (chamadoExistente is null)
            throw new InvalidOperationException($"Não existe nenhum chamado com o Id {id}");

        _chamadoRepository.Remove(chamadoExistente);
    }

}
