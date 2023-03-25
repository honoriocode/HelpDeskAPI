using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Enums;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;

public class Chamado : Entidade
{
    public Chamado(Guid id) : base(id)
    {
    }

    public Descricao Descricao { get; private set; }
    public Guid UsuarioId { get; private set; }
    public Guid LocalId { get; private set; }
    public DateTime DataAbertura { get; private set; }
    public DateTime DataEncerramento { get; private set; }
    public ESituacao Situacao{ get; private set; }
    public Detalhes Detalhes { get; private set; }

}