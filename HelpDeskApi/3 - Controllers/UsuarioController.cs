using HelpDeskApi.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("usuarios")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var usuariosDTO = await _usuarioService.GetAll();
        return Ok(usuariosDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var usuarioDTO = await _usuarioService.GetById(id);
        return Ok(usuarioDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UsuarioDTO usuarioDTO)
    {
        try
        {
            await _usuarioService.Add(usuarioDTO);
            return CreatedAtAction(nameof(GetById), new { id = usuarioDTO.Id }, usuarioDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UsuarioDTO usuarioDTO)
    {
        try
        {
            await _usuarioService.Update(id, usuarioDTO);
            return Ok("O usuário foi atualizado com sucesso!");
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
            await _usuarioService.Delete(id);
            return Ok("O usuário foi deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}