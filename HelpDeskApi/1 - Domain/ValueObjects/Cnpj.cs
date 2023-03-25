using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using HelpDeskApi.Domain.Core;

namespace HelpDeskApi.Domain.ValueObjects;

public sealed class Cnpj : ValueObject
{
    private Cnpj()
    { }

    public Cnpj(string numero)
    {
        Numero = numero;

        AddNotifications(new Contract<Cnpj>()
            .Requires()
            .IsCnpj(Numero, "Cnpj.Numero", "CNPJ inválido."));
    }

    private void AddNotifications(Contract<Cnpj> contract)
    {
        throw new NotImplementedException();
    }

    public string Numero { get; private set; }
}