using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum LancamentoTipoEnum
    {
        [Display(Name = "Crédito")]
        CREDITO = 1,
        
        [Display(Name = "Débito")]
        DEBITO = 2
    }
}