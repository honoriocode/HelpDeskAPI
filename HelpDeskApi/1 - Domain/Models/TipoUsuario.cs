using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;

public class TipoUsuario : Entidade
{
    public Descricao Descricao { get; private set; }
    public bool PodeLer { get; private set; }
    public bool PodeEscrever { get; private set; }
    public bool PodeAtualizar { get; private set; }
    public bool PodeDeletar { get; private set; }

    public IList<Usuario> Usuarios { get; private set; }
}
