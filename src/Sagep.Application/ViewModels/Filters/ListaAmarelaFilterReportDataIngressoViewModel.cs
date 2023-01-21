using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaFilterReportDataIngressoViewModel
    {
        public string Regime { get;set; }

        public string DataIngressoInicio { get;set; }
        public string DataIngressoFim { get;set; }
        public string DataIngressoPeriodo { get; set; }
    }
}