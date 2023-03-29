using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using HelpDeskApi.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Domain.Models;

public class Usuario : Entidade
{
    private Usuario()
    { }

    public Usuario(
        Guid id,
        string nome,
        string login,
        string senha,
        string contato
        ) : base(id)
    {
        Nome = nome;
        Login = login;
        Senha = senha;
        Contato = contato;

        AddNotifications(new Contract<Usuario>()
            .Requires()
            .IsPhoneNumber(Contato, "Usuario.Contato", "Contato inválido.")
            );
    }


    public Guid TipoUsuarioId { get; private set; }

    [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
    public string Nome { get; private set; } = string.Empty;

    [Required(ErrorMessage = "Insira um nome de usuário ou senha")]
    public string Login { get; private set; } = string.Empty;

    [Range(8, 40, ErrorMessage = "A senha deve conter no mínimo 8 caracteres")]
    public string Senha { get; private set; } = string.Empty;

    [Required(ErrorMessage = "Insira um contato")]
    public string Contato { get; private set; } = string.Empty;

    public TipoUsuario TipoUsuario { get; private set; } = null!;
    public IList<Chamado> Chamados { get; private set; } = null!;
}