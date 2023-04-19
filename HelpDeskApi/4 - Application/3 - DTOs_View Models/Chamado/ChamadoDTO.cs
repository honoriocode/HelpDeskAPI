using HelpDeskApi.Domain.Enums;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Data.DTOs.Chamado
{
    public class ChamadoDTO
    {
        [Required]
        public Descricao Descricao { get; private set; }
        [Required]
        public Guid UsuarioId { get; private set; }
        [Required]
        public Guid LocalId { get; private set; }
        [Required]
        public DateTime DataAbertura { get; private set; }
        [Required]
        public DateTime DataEncerramento { get; private set; }
        [Required]
        public ESituacao Situacao { get; private set; }
        [Required]
        public Detalhes Detalhes { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        [Required]
        public DateTime CriadoEm { get; protected set; }
        [Required]
        public DateTime AtualizadoEm { get; protected set; }
        [Required]
        public bool Status { get; protected set; }
        [Required]
        public object Id { get; internal set; }
    }
}
