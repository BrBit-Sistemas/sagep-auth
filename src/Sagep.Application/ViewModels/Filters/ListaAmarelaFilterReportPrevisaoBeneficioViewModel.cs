using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaFilterReportPrevisaoBeneficioViewModel
    {
        public string Regime { get;set; }

        public string DataPrevisaoBeneficioInicio { get;set; }
        public string DataPrevisaoBeneficioFim { get;set; }
        public string DataPrevisaoBeneficioPeriodo { get; set; }
        public string DataSaidaPrevistaInicio { get; set; }
        public string DataSaidaPrevistaFim { get; set; }
    }
}