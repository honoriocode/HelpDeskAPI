using HelpDeskApi.Data.DTOs.TipoUsuario;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("tipoUsuarios")]
public class TipoUsuarioController : ControllerBase
{
    private readonly ITipoUsuarioService _tipousuarioService;

    public TipoUsuarioController(ITipoUsuarioService tipousuarioService)
    {
        _tipousuarioService = tipousuarioService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tipousuariosDTO = await _tipousuarioService.GetAll();
        return Ok(tipousuariosDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var tipousuarioDTO = await _tipousuarioService.GetById(id);
        return Ok(tipousuarioDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] TipoUsuarioDTO tipousuarioDTO)
    {
        try
        {
            await _tipousuarioService.Add(tipousuarioDTO);
            return CreatedAtAction(nameof(GetById), new { id = tipousuarioDTO.Id }, tipousuarioDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] TipoUsuarioDTO tipousuarioDTO)
    {
        try
        {
            await _tipousuarioService.Update(id, tipousuarioDTO);
            return Ok("O Tipo de usuário foi atualizado com sucesso!");
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
            await _tipousuarioService.Delete(id);
            return Ok("O Tipo de usuário foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
