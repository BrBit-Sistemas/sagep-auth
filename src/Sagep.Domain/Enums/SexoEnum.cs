using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum SexoEnum
    {
        [Display(Name = "Other")]
        OTHER = 0,
        
        [Display(Name = "Female")]
        FEMALE = 1,

        [Display(Name = "Male")]
        MALE = 2
    }
}