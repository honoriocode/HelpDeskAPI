using HelpDeskApi._4___Application._2___Services;
using HelpDeskApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers
{
    [ApiController]
    [Route("equipamentos")]
    public class EquipamentoController : ControllerBase
    {
        private readonly EquipamentoService _equipamentoService;

        public EquipamentoController(EquipamentoService equipamentoService)
        {
            _equipamentoService = equipamentoService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] Equipamento equipamento)
        {
            _equipamentoService.AdicionaEquipamento(equipamento);

            return CreatedAtAction(nameof(Adiciona), equipamento);
        }
    }

}
