using Flunt.Validations;
using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Helpers;

namespace HelpDeskApi.Domain.ValueObjects;

public sealed class Detalhes : ValueObject
{
    private Detalhes()
    { }

    public Detalhes(
        string substituidoPor,
        string localAnterior,
        string equipamento,
        string qualTecnico,
        string solucao
        )
    {
        SubstituidoPor = substituidoPor;
        LocalAnterior = localAnterior;
        Equipamento = equipamento;
        QualTecnico = qualTecnico;
        Solucao = solucao;

        AddNotifications(new Contract<Detalhes>()
            .Requires()
            .IsTrue(SubstituidoPor.IsEmpty(), "Detalhes.SubstituidoPor", "Campo inválido.")
            .IsTrue(LocalAnterior.IsEmpty(), "Detalhes.LocalAnterior", "Campo inválido.")
            .IsTrue(Equipamento.IsEmpty(), "Detalhes.Equipamento", "Equipamento inválido.")
            .IsTrue(QualTecnico.IsEmpty(), "Detalhes.QualTecnico", "Técnico inválido.")
            .IsTrue(Solucao.IsEmpty(), "Detalhes.Solucao", "Solução inválida.")
            );
    }


    public string SubstituidoPor { get; private set; }
    public string LocalAnterior { get; private set; }
    public string Equipamento { get; private set; }
    public string QualTecnico { get; private set; }
    public string Solucao { get; private set; } = string.Empty;
}
