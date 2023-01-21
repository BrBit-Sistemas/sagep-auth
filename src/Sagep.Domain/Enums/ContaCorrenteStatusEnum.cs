using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum ContaCorrenteStatusEnum
    {
        [Display(Name = "ATIVA")]
        ATIVA = 1,

        [Display(Name = "ENCERRADA")]
        ENCERRADA = 2,

        [Display(Name = "BLOQUEADA")]
        BLOQUEADA = 3
    }
}