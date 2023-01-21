using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum AlunoEjaDisciplinaConceitoEnum
    {
        [Display(Name = "Pendente")]
        PENDENTE = 0,

        [Display(Name = "Aprovado")]
        APROVADO = 1,

        [Display(Name = "Reprovado")]
        REPROVADO = 2
    }
}