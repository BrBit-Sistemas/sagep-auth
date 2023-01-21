using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ContaCorrenteFilterReportViewModel
    {
        [Required]
        public string ColaboradorNome { get;set; }

        [Required]
        public DateTime PeriodoInicioRel1 { get;set; }
        public DateTime PeriodoFimRel1 { get;set; }
    }
}