using HelpDeskApi.Domain.Enums;
using HelpDeskApi.Domain.ValueObjects;

namespace HelpDeskApi.Data.DTOs.Chamado
{
    public class ChamadoDTO
    {
        public Descricao Descricao { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid LocalId { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public DateTime DataEncerramento { get; private set; }
        public ESituacao Situacao { get; private set; }
        public Detalhes Detalhes { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        public DateTime CriadoEm { get; protected set; }
        public DateTime AtualizadoEm { get; protected set; }
        public bool Status { get; protected set; }

    }
}
