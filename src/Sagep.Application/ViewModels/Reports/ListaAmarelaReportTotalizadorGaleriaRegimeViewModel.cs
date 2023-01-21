using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaReportTotalizadorGaleriaRegimeViewModel
    {
        public List<Totalizador> Totalizadores { get; set; }
        public int TotalRegistros { get; set; }
        public string CategoriaNome1 { get; set; }
        public string CategoriaNome2 { get; set; }
    }

    public class Totalizador
    {
        public string Regime { get; set; }
        public string Galeria { get; set; }
        public int Total { get; set; }
    }
}