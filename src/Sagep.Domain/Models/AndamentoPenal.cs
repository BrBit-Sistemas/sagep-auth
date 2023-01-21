using System.ComponentModel.DataAnnotations.Schema;
using System;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Models
{
    public class AndamentoPenal : EntityAuditTenant
    {
        public AndamentoPenal(DateTime dataEventoPrincipal, AndamentoPenalStatusEnum status,
                              string historico, string pec,
                              string enderecoCompleto, string telefone)
        {
            DataEventoPrincipal = dataEventoPrincipal;
            Status = status;
            Historico = historico;
            Pec = pec;
            EnderecoCompleto = enderecoCompleto;
            Telefone = telefone;
        }   

        // Construtor vazio para o EF
        public AndamentoPenal() {}

        public DateTime DataEventoPrincipal { get; set; }
        public AndamentoPenalStatusEnum Status { get; set; }
        public string Historico { get; set; }
        public string Observacao { get; set; }
        public string Pec { get; set; }
        
        //Campos criados em 08/04/2022 - Para atender a demanda de criação de ofício
        //de informação de endereço para VEP
        public string EnderecoCompleto { get; set; }
        public string Telefone { get; set; }


        //Relacionamentos
        [ForeignKey("DetentoId")]
        public Guid DetentoId { get; set; }
        public Detento Detento { get; set; }

         public Tenant Tenant { get; set; }
    }
}