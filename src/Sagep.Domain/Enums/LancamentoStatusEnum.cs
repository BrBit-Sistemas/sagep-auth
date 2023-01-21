using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum LancamentoStatusEnum
    {
        [Display(Name = "Pendente")]
        PENDENTE = 1,
        [Display(Name = "Liquidado")]
        LIQUIDADO = 2,
        [Display(Name = "Cancelado")]
        CANCELADO = 3
    }
}