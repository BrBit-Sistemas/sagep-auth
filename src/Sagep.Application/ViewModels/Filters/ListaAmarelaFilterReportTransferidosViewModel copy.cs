using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Application.ViewModels.Selects;
using System.ComponentModel.DataAnnotations;

namespace Sagep.Application.ViewModels.Reports
{
    public class ListaAmarelaFilterReportTransferidosViewModel
    {
        public string TransferenciaTipo { get;set; }

        public string DataSaidaPeriodoInicioReportTransferidos { get;set; }
        public string DataSaidaPeriodoFimReportTransferidos { get;set; }
        public string DataRetornoPrevistoPeriodoInicioReportTransferidos { get;set; }
        public string DataRetornoPrevistoPeriodoFimReportTransferidos { get;set; }
    }
}