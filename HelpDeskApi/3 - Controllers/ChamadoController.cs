using HelpDeskApi._4___Application._2___Services;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers;

[ApiController]
[Route("chamados")]
public class ChamadoController : ControllerBase
{
    private readonly ChamadoService _chamadoService;

    public ChamadoController(ChamadoService chamadoService)
    {
        _chamadoService = chamadoService;
    }

    [HttpPost]
    public IActionResult Adiciona([FromBody] Chamado chamado)
    {
        _chamadoService.AdicionaChamado(chamado);

        return CreatedAtAction(nameof(Adiciona), chamado);
    }
}
