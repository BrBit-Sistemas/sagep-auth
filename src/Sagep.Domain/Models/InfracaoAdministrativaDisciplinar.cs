using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Models
{
    public class InfracaoAdministrativaDisciplinar : EntityAudit
    {
        public InfracaoAdministrativaDisciplinar(FaltaTipoEnum falta,
                                                 DateTime dataInfracao,
                                                 string oficioNumero,
                                                 string qualificacao)
        {
            Falta = falta;
            DataInfracao = dataInfracao;
            OficioNumero = oficioNumero;
            Qualificacao = qualificacao;
        }

        // Constructor empty to EFCore
        public InfracaoAdministrativaDisciplinar() {}

        public FaltaTipoEnum Falta { get; set; }
        public DateTime DataInfracao { get; set; }
        public string OficioNumero { get; set; }
        public string Qualificacao { get; set; }

        
        // Relationship
        [ForeignKey("TenantId")] 
        public Guid? TenantId { get; set; }
        public Tenant Tenant { get; set; }

        public ICollection<InfracaoAdministrativaDisciplinarDetento> Infratores { get; set; }
    }
}