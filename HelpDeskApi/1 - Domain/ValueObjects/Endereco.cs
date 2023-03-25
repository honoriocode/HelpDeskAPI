using Flunt.Validations;
using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Helpers;

namespace HelpDeskApi.Domain.ValueObjects;

public sealed class Endereco : ValueObject
{
    private Endereco()
    { }

    public Endereco(
        string cidade,
        Cep cep,
        string bairro,
        string rua,
        string numero,
        string complemento
        )
    {
        Cidade = cidade;
        CEP = cep;
        Bairro = bairro;
        Rua = rua;
        Numero = numero;
        Complemento = complemento;

        AddNotifications(CEP, new Contract<Endereco>()
            .Requires()
            .IsTrue(Cidade.IsEmpty(), "Endereco.Cidade", "Cidade inválida.")
            .IsTrue(Bairro.IsEmpty(), "Endereco.Bairro", "Bairro inválido.")
            .IsTrue(Rua.IsEmpty(), "Endereco.Rua", "Rua inválida.")
            .IsTrue(Numero.IsEmpty(), "Endereco.Numero", "Número inválido.")
            .IsTrue(Numero.IsNumber(), "Endereco.Numero", "Número inválido.")
            .IsTrue(Complemento.IsEmpty(), "Endereco.Complemento", "Complemento inválido.")
            );
    }

    public string Cidade { get; private set; }
    public Cep CEP { get; private set; }
    public string Bairro { get; private set; }
    public string Rua { get; private set; }
    public string Numero { get; private set; }
    public string Complemento { get; private set; } = string.Empty;
}