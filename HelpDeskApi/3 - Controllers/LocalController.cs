using HelpDeskApi._4___Application._2___Services;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Controllers
{
    [ApiController]
    [Route("locais")]
    public class LocalController : ControllerBase
    {
        private readonly LocalService localService;

        public LocalController(LocalService localService)
        {
            this.localService = localService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var local = localService.GetLocalById(id);

            if (local == null)
            {
                return NotFound();
            }

            return Ok(local);
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] Local local)
        {
            var result = localService.AdicionaLocal(local, out var errors);

            if (result is BadRequestObjectResult)
            {
                return BadRequest(errors);
            }

            return result;
        }
    }

}
