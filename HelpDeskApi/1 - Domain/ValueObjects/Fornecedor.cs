using HelpDeskApi.Domain.Core;

namespace HelpDeskApi.Domain.ValueObjects;

public sealed class Fornecedor : ValueObject
{
    private Fornecedor()
    { }

    public Fornecedor(string nome, Cnpj cnpj)
    {
        Nome = nome;
        CNPJ = cnpj;

        AddNotifications(CNPJ, Nome);
    }

    private void AddNotifications(Cnpj cNPJ, string nome)
    {
        throw new NotImplementedException();
    }

    public string Nome { get; private set; }
    public Cnpj CNPJ { get; private set; }
}