using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.ValueObjects;

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

    public Descricao Descricao { get; private set; } = null!;
    public Endereco Endereco { get; private set; } = null!;

    public IList<Equipamento> Equipamentos { get; private set; }
    public IList<Chamado> Chamados { get; private set; }
}