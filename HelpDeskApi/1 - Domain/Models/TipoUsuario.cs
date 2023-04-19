using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

public class TipoUsuario : Entidade
{
    [Required]
    public Descricao Descricao { get; private set; }
    [Required]
    public bool PodeLer { get; private set; }
    [Required]
    public bool PodeEscrever { get; private set; }
    [Required]
    public bool PodeAtualizar { get; private set; }
    [Required]
    public bool PodeDeletar { get; private set; }

    public IList<Usuario> Usuarios { get; private set; }
}
