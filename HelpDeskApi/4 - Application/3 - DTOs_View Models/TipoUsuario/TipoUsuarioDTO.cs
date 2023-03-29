using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;

namespace HelpDeskApi.Data.DTOs.TipoUsuario
{
    public class TipoUsuarioDTO
    {
        public Descricao Descricao { get; private set; }
        public bool PodeLer { get; private set; }
        public bool PodeEscrever { get; private set; }
        public bool PodeAtualizar { get; private set; }
        public bool PodeDeletar { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        public DateTime CriadoEm { get; protected set; }
        public DateTime AtualizadoEm { get; protected set; }
        public bool Status { get; protected set; }
        public object Id { get; internal set; }
    }
}
