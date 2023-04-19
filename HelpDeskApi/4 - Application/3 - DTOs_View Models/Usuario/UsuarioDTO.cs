using HelpDeskApi.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Data.DTOs;

public class UsuarioDTO
{
    [Required]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Insira um nome")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "Insira o seu Login")]
    public string Login { get; set; }
    [Required(ErrorMessage = "Insira a senha")]
    public string Senha { get; set; }
    [Required(ErrorMessage = "Insira o tipo de usuário")]
    public Guid TipoUsuarioId { get; set; }
    [Required(ErrorMessage = "Insira o seu contato")]
    public string Contato { get; set; }

    public UsuarioDTO(Usuario usuario)
    {
        Id = usuario.Id;
        Nome = usuario.Nome;
        Login = usuario.Login;
        Senha = usuario.Senha;
        TipoUsuarioId = usuario.TipoUsuarioId;
        Contato = usuario.Contato;
    }
}
