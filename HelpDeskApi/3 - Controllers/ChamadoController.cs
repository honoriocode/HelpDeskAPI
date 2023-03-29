using HelpDeskApi.Data.DTOs.Chamado;
using HelpDeskApi.Data.DTOs.Equipamento;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("chamados")]
public class ChamadoController : ControllerBase
{
    private readonly IChamadoService _chamadoService;

    public ChamadoController(ChamadoService chamadoService)
    {
        _chamadoService = chamadoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var chamadosDTO = await _chamadoService.GetAll();
        return Ok(chamadosDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var chamadoDTO = await _chamadoService.GetById(id);
        return Ok(chamadoDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ChamadoDTO chamadoDTO)
    {
        try
        {
            await _chamadoService.Add(chamadoDTO);
            return CreatedAtAction(nameof(GetById), new { id = chamadoDTO.Id }, chamadoDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] ChamadoDTO chamadoDTO)
    {
        try
        {
            await _chamadoService.Update(id, chamadoDTO);
            return Ok("O chamado foi atualizado com sucesso!");
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
            await _chamadoService.Delete(id);
            return Ok("O chamado foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}