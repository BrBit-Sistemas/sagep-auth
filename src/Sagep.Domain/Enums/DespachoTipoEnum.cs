using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum DespachoTipoEnum
    {
        [Display(Name = "Não informado")]
        NAO_INFORMADO = 0,

        [Display(Name = "Troca de conselheiro")]
        TROCA_CONSELHEIRO = 1,

        [Display(Name = "Nomeação de conselheiro")]
        NOMEACAO_CONSELHEIRO = 2
    }
}