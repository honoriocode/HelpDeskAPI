using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskApi.Data.DTOs.Equipamento
{
    public class EquipamentoDTO
    {
        [Required]
        public Fornecedor Fornecedor { get; private set; }

        [Required(ErrorMessage = "Insira a data de emissão")]
        public DateTime DataEmissao { get; private set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Data { get; private set; }

        [Required(ErrorMessage = "Insira o número de serie do objeto")]
        public string NumeroSerie { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Insira a marca do objeto")]
        public string Marca { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Insira a memória")]
        public string Memoria { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Insira o HD ")]
        public string Hd { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Insira a memória")]
        public string Processador { get; private set; } = string.Empty;

        //Classe da Entidade sem o id pois é um DTO
        [Required(ErrorMessage = "Data que foi criado")]
        public DateTime CriadoEm { get; protected set; }
        [Required(ErrorMessage = "Data que foi atualizado")]
        public DateTime AtualizadoEm { get; protected set; }
        [Required]
        public bool Status { get; protected set; }
        [Required]
        public object Id { get; internal set; }
    }
}
