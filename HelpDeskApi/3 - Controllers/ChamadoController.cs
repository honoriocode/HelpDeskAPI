using HelpDeskApi._4___Application._2___Services;
using HelpDeskApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers
{
    [ApiController]
    [Route("chamados")]
    public class ChamadoController : ControllerBase
    {
        private readonly ChamadoService chamadoService;

        public ChamadoController(ChamadoService chamadoService)
        {
            this.chamadoService = chamadoService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] Chamado chamado)
        {
            chamadoService.AdicionaChamado(chamado);

            return CreatedAtAction(nameof(Adiciona), chamado);
        }
    }

}
