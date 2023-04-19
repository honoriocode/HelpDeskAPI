using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Data.DTOs.Local
{
    public class LocalDTO
    {
        [Required]
        public Descricao Descricao { get; private set; }
        [Required]
        public Endereco Endereco { get; private set; }

        //Classe da Entidade sem o id pois é um DTO
        [Required]
        public DateTime CriadoEm { get; protected set; }
        [Required]
        public DateTime AtualizadoEm { get; protected set; }
        [Required]
        public bool Status { get; protected set; }
        public object Id { get; internal set; }
    }
}
