using AutoMapper;
using FluentResults;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
    private UsuarioRepository respAtualizar;

    private readonly IMapper _mapper;

    public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
    {
        _usuarioService = usuarioService;
        _mapper = mapper;
    }

    // GET api/usuario
    [HttpGet("find/{name?}")]
    public async Task<IActionResult> Get(int id)
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

    public IUsuarioService Get_usuarioService()
    {
        return _usuarioService;
    }

    // PUT api/usuario/{id}
    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] UsuarioDTO usuarioDTO)
    {
        respAtualizar = new UsuarioRepository();

        if (respAtualizar.IsFailed)
        {
            return NotFound();
        }

        return NoContent();

    }
}