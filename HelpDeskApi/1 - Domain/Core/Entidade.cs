using Flunt.Notifications;

namespace HelpDeskApi.Domain.Core;

public abstract class Entidade : Notifiable<Notification>
{
    protected Entidade()
    { }

    protected Entidade(Guid id)
    {
        Id = id;
        CriadoEm = DateTime.Now;
        AtualizadoEm = DateTime.Now;
        Status = true;
    }

    public Guid Id { get; protected set; }
    public DateTime CriadoEm { get; protected set; }
    public DateTime AtualizadoEm { get; protected set; }
    public bool Status { get; protected set; }
    public bool IsValid { get; private set; }

    public void Atualizar(DateTime criadoEm)
        => CriadoEm = criadoEm;

    public void Ativar()
    {
        if (IsValid)
            Status = true;
    }

    public void Desativar()
    {
        if (IsValid)
            Status = false;
    }
}
