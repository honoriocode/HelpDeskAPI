using HelpDeskApi.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Domain.Models;

//Class Done
public class Usuario : Entidade
{
    public Usuario(Guid id) : base(id)
    {
    }

    [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Insira um nome de usuário ou senha")]
    public string Login { get; set; }

    [Range(8, 40, ErrorMessage = "A senha deve conter no mínimo 8 caracteres")]
    public string Senha { get; set; }
    public Guid TipoUsuarioId { get; set; }

    [Required(ErrorMessage = "Insira um contato")]
    public int Contato { get; set; }


}