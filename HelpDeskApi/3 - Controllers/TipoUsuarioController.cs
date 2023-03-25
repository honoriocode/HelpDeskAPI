using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers
{
    [ApiController]
    [Route("tipoUsuarios")]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly TipoUsuarioService tipoUsuarioService;

        public TipoUsuarioController(TipoUsuarioService tipoUsuarioService)
        {
            this.tipoUsuarioService = tipoUsuarioService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] TipoUsuario tipoUsuario)
        {
            tipoUsuarioService.AdicionaTipoUsuario(tipoUsuario);
            return Ok();
        }
    }

}
