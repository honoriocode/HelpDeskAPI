using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Enums;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

public class Chamado : Entidade
{
    public Chamado(Guid id) : base(id)
    {
    }

    [Required]
    public Descricao Descricao { get; private set; }
    public Guid UsuarioId { get; private set; }
    [Required]
    public Usuario Usuario { get; private set; }
    public Guid LocalId { get; private set; }
    [Required]
    public Local Local { get; private set; }
    [Required]
    public DateTime DataAbertura { get; private set; }
    [Required]
    public DateTime DataEncerramento { get; private set; }
    [Required]
    public ESituacao Situacao{ get; private set; }
    [Required]
    public Detalhes Detalhes { get; private set; }
}