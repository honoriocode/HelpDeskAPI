using AutoMapper;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs.Equipamento;

public class EquipamentoService : IEquipamentoService
{
    private readonly IRepository<Equipamento> _equipamentoRepository;
    private readonly IMapper _mapper;

    public EquipamentoService(IRepository<Equipamento> equipamentoRepository, IMapper mapper)
    {
        _equipamentoRepository = equipamentoRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EquipamentoDTO>> GetAll()
    {
        var equipamentos = await _equipamentoRepository.GetAll();
        var equipamentosMapped = _mapper.Map<IEnumerable<EquipamentoDTO>>(equipamentos);

        return equipamentosMapped;
    }

    public async Task<EquipamentoDTO> GetById(Guid id)
    {
        var equipamento = await _equipamentoRepository.GetOneWhere(e => e.Id == id);
        var equipamentoMapped = _mapper.Map<EquipamentoDTO>(equipamento);

        return equipamentoMapped;
    }

    public async Task<EquipamentoDTO> Add(EquipamentoDTO EquipamentoDTO)
    {
        var equipamentoMapped = _mapper.Map<Equipamento>(EquipamentoDTO);
        var equipamento = await _equipamentoRepository.Add(equipamentoMapped);
        var equipamentoResponse = _mapper.Map<EquipamentoDTO>(equipamento);

        return equipamentoResponse;
    }

    public async Task Update(Guid id, EquipamentoDTO EquipamentoDTO)
    {
        var equipamentoExistente = await _equipamentoRepository.GetOneWhere
            (e => e.Id == id);

        if (equipamentoExistente is null)
            throw new InvalidOperationException($"Não existe nenhum equipamento com o Id {id}");

        var equipamentoUpdate = _mapper.Map<Equipamento>(EquipamentoDTO);
        var equipamentoMapped = _mapper.Map(equipamentoUpdate, equipamentoExistente);

        _equipamentoRepository.Update(equipamentoMapped);
    }

    public async Task Delete(Guid id)
    {
        var equipamentoExistente = await _equipamentoRepository.GetOneWhere
            (e => e.Id == id);

        if (equipamentoExistente is null)
            throw new InvalidOperationException($"Não existe nenhum equipamento com o Id {id}");

        _equipamentoRepository.Remove(equipamentoExistente);
    }

}