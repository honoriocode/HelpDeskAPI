using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

public class Local : Entidade
{
    private Local()
    { }

    public Local(Guid id, Descricao descricao, Endereco endereco) : base(id)
    {
        Descricao = descricao;
        Endereco = endereco;

        AddNotifications(Descricao, Endereco);
    }

    [Required]
    public Descricao Descricao { get; private set; } = null!;

    [Required]
    public Endereco Endereco { get; private set; } = null!;

    public IList<Equipamento> Equipamentos { get; private set; }
    public IList<Chamado> Chamados { get; private set; }
}