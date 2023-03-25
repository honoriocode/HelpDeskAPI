using HelpDeskApi.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    // GET api/usuario
    [HttpGet]
    public IActionResult Get()
    {
        var usuariosDTO = _usuarioService.GetAllUsuarios();
        return Ok(usuariosDTO);
    }

    // GET api/usuario/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var usuarioDTO = _usuarioService.GetUsuarioById(id);
        return Ok(usuarioDTO);
    }

    // POST api/usuario
    [HttpPost]
    public IActionResult Post([FromBody] UsuarioDTO usuarioDTO)
    {
        _usuarioService.AddUsuario(usuarioDTO, _usuarioService.Get_usuarioRepository());
        return CreatedAtAction(nameof(GetById), new { id = usuarioDTO.Id }, usuarioDTO);
    }

    // PUT api/usuario/{id}
    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] UsuarioDTO usuarioDTO)
    {
        _usuarioService.UpdateUsuario(id, usuarioDTO);

    }

}


