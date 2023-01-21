using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaReportTransferidosViewModel
    {
        public List<DetentoViewModel> DetentosTransferidos { get; set; }
        public int TotalRegistros { get; set; }
        public string DataSaidaInicio { get; set; }
        public string DataSaidaFim { get; set; }
        public string DataSaidaPeriodo { get; set; }
        public string DataRetornoPrevistoPeriodo { get; set; }
        public string DataRetornoPrevistoInicio { get; set; }
        public string DataRetornoPrevistoFim { get; set; }
        public string CategoriaNome1 { get; set; }
        public string CategoriaNome2 { get; set; }
    }
}