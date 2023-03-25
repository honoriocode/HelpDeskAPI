using Flunt.Validations;
using HelpDeskApi.Domain.Core;

namespace HelpDeskApi.Domain.ValueObjects;

public sealed class Descricao : ValueObject
{
    private Descricao()
    { }

    public Descricao(string texto)
    {
        Texto = texto;

        AddNotifications(new Contract<Descricao>()
            .Requires()
            .IsLowerThan(3, Texto.Length, "Descricao.Texto", "A descrição precisa conter mais de 3 caracteres.")
            .IsGreaterThan(150, Texto.Length, "Descricao.Texto", "A descrição precisa conter menos de 150 caracteres.")
            );
    }

    public string Texto { get; private set; }
}
