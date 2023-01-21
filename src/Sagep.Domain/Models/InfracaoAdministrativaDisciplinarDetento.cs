using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sagep.Domain.Models
{
    public class InfracaoAdministrativaDisciplinarDetento
    {
        public InfracaoAdministrativaDisciplinarDetento(string detentoRegimeNaDataDaInfracao) 
        {
            DetentoRegimeNaDataDaInfracao = detentoRegimeNaDataDaInfracao;
        }


        // Constructor empty to EFCore
        public InfracaoAdministrativaDisciplinarDetento() {}

        public string DetentoRegimeNaDataDaInfracao { get; set; }


        // Relationship
        [ForeignKey("InfracaoAdministrativaDisciplinarId")]
        public Guid InfracaoAdministrativaDisciplinarId { get; set; }
        public InfracaoAdministrativaDisciplinar InfracaoAdministrativaDisciplinar { get; set; }

        [ForeignKey("DetentoId")]
        public Guid DetentoId { get; set; }
        public Detento Detento { get; set; }
    }
}