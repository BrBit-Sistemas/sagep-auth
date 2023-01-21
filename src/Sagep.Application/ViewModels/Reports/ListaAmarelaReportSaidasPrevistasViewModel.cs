using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaReportSaidasPrevistasViewModel
    {
        public List<DetentoViewModel> Detentos { get; set; }
        public List<DetentoSaidaTemporariaViewModel> DetentosST { get; set; }
        public int TotalRegistros { get; set; }
        public string SaidaTemporariaDataSaidaPrevista { get; set; }
        public string SaidaTemporariaDataRetornoPrevisto { get; set; }
        public string SaidaTemporariaDataSaidaPeriodo { get; set; }
        public string CategoriaNome1 { get; set; }
        public string CategoriaNome2 { get; set; }
    }
}