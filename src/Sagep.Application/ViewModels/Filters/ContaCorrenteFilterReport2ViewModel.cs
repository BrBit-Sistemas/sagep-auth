using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ContaCorrenteFilterReport2ViewModel
    {
        public List<string> ColaboradoresNomes { get;set; }

        [Required]
        public DateTime PeriodoInicioRel2 { get;set; }
        public DateTime PeriodoFimRel2 { get;set; }

        [Required]
        public bool Ativa { get;set; }
    }
}