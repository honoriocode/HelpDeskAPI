using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

public class Equipamento : Entidade
{
    // private Equipamento() { }

    // CONSTRUTOR COM PARAMETROS

    public Guid LocalId { get; private set; }

    [Required]
    public Local Local { get; private set; }

    [Required(ErrorMessage = "Insira o fornecedor")]
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

}