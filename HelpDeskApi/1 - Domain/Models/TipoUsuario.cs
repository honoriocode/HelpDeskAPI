using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

public class TipoUsuario : Entidade
{
    public TipoUsuario(Guid id) : base(id)
    {
    }

    public Descricao Descricao { get; private set; }
    public bool PodeLer { get; private set; }
    public bool PodeEscrever { get; private set; }
    public bool PodeAtualizar { get; private set; }
    public bool PodeDeletar { get; private set; }

    public Usuario UsuarioId { get; set; }
}
