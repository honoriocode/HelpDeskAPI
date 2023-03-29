using HelpDeskApi.Domain.ValueObjects;

namespace HelpDeskApi.Data.DTOs.Local
{
    public class LocalDTO
    {
        public Descricao Descricao { get; private set; }
        public Endereco Endereco { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        public DateTime CriadoEm { get; protected set; }
        public DateTime AtualizadoEm { get; protected set; }
        public bool Status { get; protected set; }
        public object Id { get; internal set; }
    }
}
