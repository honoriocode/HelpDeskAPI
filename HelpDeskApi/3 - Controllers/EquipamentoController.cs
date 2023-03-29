using HelpDeskApi.Data.DTOs.Equipamento;
using HelpDeskApi.Data.DTOs.Local;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("equipamentos")]
public class EquipamentoController : ControllerBase
{
    private readonly IEquipamentoService _equipamentoService;

    public EquipamentoController(IEquipamentoService equipamentoService)
    {
        _equipamentoService = equipamentoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var equipamentosDTO = await _equipamentoService.GetAll();
        return Ok(equipamentosDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var equipamentoDTO = await _equipamentoService.GetById(id);
        return Ok(equipamentoDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EquipamentoDTO equipamentoDTO)
    {
        try
        {
            await _equipamentoService.Add(equipamentoDTO);
            return CreatedAtAction(nameof(GetById), new { id = equipamentoDTO.Id }, equipamentoDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] EquipamentoDTO equipamentoDTO)
    {
        try
        {
            await _equipamentoService.Update(id, equipamentoDTO);
            return Ok("O equipamento foi atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _equipamentoService.Delete(id);
            return Ok("O equipamento foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
