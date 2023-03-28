using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using HelpDeskApi.Domain.Core;

namespace HelpDeskApi.Domain.ValueObjects
{
    public sealed class Cep : ValueObject
    {
        private Cep()
        { }

        public Cep(string numero)
        {
            Numero = numero;

            AddNotifications(new Contract<Cep>()
                .Requires()
                .IsZipCode(Numero, "Cep.Numero", "CEP inválido.")
                );
        }

        public string Numero { get; private set; }

    }

}