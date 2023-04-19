using HelpDeskApi.Domain.Models;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Data.DTOs.TipoUsuario
{
    public class TipoUsuarioDTO
    {
        [Required]
        public Descricao Descricao { get; private set; }
        [Required]
        public bool PodeLer { get; private set; }
        [Required]
        public bool PodeEscrever { get; private set; }
        [Required]
        public bool PodeAtualizar { get; private set; }
        [Required]
        public bool PodeDeletar { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        [Required]
        public DateTime CriadoEm { get; protected set; }
        [Required]
        public DateTime AtualizadoEm { get; protected set; }
        public bool Status { get; protected set; }
        public object Id { get; internal set; }
    }
}
