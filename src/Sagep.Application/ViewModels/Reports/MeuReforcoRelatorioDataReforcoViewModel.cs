using System.Collections.Generic;
using Sagep.Domain.Models;

namespace Sagep.Application.ViewModels.Reports
{
    public class MeuReforcoRelatorioDataReforcoViewModel
    {
        public List<ServidorEstadoReforco> Reforcos { get; set; }
        public int TotalRegistros { get; set; }
        public string DataReforcoPeriodo { get; set; }
    }
}