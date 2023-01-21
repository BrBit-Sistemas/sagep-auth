using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaReportDataIngressoViewModel
    {
        public List<ListaAmarelaViewModel> ListasAmarela { get; set; }
        public int TotalRegistros { get; set; }
        public string DataIngressoPeriodo { get; set; }
        public string CategoriaNome1 { get; set; }
        public string CategoriaNome2 { get; set; }
    }
}