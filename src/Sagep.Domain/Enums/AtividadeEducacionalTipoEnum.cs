using System.ComponentModel.DataAnnotations;

namespace Sagep.Domain.Enums
{
    public enum AtividadeEducacionalTipoEnum
    {

        [Display(Name = "Leitura")]
        LEITURA = 1,

        [Display(Name = "Estudo EJA")]
        ESTUDO_EJA = 2,

        [Display(Name = "Enem")]
        ENEM = 3,

        [Display(Name = "Encceja")]
        ENCCEJA = 4,

        [Display(Name = "Redação DPU")]
        REDACAO_DPU = 5,

        [Display(Name = "Projetos especiais")]
        PROJETOS_ESPECIAIS = 6
    }
}