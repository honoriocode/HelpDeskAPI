using HelpDeskApi._4___Application._2___Services;
using HelpDeskApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers
{
    [ApiController]
    [Route("equipamentos")]
    public class EquipamentoController : ControllerBase
    {
        private readonly EquipamentoService equipamentoService;

        public EquipamentoController(EquipamentoService equipamentoService)
        {
            this.equipamentoService = equipamentoService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] Equipamento equipamento)
        {
            equipamentoService.AdicionaEquipamento(equipamento);

            return CreatedAtAction(nameof(Adiciona), equipamento);
        }
    }

}
