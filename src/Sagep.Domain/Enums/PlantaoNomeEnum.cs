using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum PlantaoNomeEnum
    {
        [Display(Name = "Nenhum")]
        NENHUM = 0,

        [Display(Name = "Alpha")]
        ALPHA = 1,
        
        [Display(Name = "Bravo")]
        BRAVO = 2,

        [Display(Name = "Charlie")]
        CHARLIE = 3,

        [Display(Name = "Delta")]
        DELTA = 4
    }
}