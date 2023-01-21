using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaFilterReportSaidasPrevistasViewModel
    {
        public string DataSaidaPrevistaSTInicio { get; set; }
        public string DataSaidaPrevistaSTFim { get; set; }
        public string OpcaoOrdenacaoSelect2 { get; set; }
    }
}