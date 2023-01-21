using System;
using System.Collections.Generic;
using Sagep.Domain.Models;

namespace Sagep.Application.ViewModels
{
    public class InfracaoAdministrativaDisciplinarViewModel
    {
        public Guid? Id { get; set; }
        public string Falta { get; set; }
        public string DataInfracao { get; set; }
        public string DescricaoCurta { get; set; }
        public string OficioNumero  { get; set; }
        public string Qualificacao  { get; set; }

        public Guid? TenantId { get; set;}
        public bool IsDeleted { get; set; }

        public List<InfracaoAdministrativaDisciplinarDetentoViewModel> Infratores { get; set; }
    }

    public class InfracaoAdministrativaDisciplinarDetentoViewModel
    {
        public string DetentoRegimeNaDataDaInfracao { get; set; }
        public Guid? InfracaoAdministrativaDisciplinarId { get; set; }
        public Guid DetentoId { get; set; }
        public Detento Detento { get; set; }
    }
}