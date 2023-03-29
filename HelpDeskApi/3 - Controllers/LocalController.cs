using HelpDeskApi.Data.DTOs;
using HelpDeskApi.Data.DTOs.Local;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("locais")]
public class LocalController : ControllerBase
{
    private readonly ILocalService _localService;

    public LocalController(ILocalService localService)
    {
        _localService = localService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var locaisDTO = await _localService.GetAll();
        return Ok(locaisDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var localDTO = await _localService.GetById(id);
        return Ok(localDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] LocalDTO localDTO)
    {
        try
        {
            await _localService.Add(localDTO);
            return CreatedAtAction(nameof(GetById), new { id = localDTO.Id }, localDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] LocalDTO localDTO)
    {
        try
        {
            await _localService.Update(id, localDTO);
            return Ok("O local foi atualizado com sucesso!");
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
            await _localService.Delete(id);
            return Ok("O local foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
