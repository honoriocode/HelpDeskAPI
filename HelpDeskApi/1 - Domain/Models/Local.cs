using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.ValueObjects;
using System.Text.Json.Serialization;

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

}