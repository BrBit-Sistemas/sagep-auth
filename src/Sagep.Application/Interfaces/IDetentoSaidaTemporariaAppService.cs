using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Detentos;
using Sagep.Application.ViewModels.Reports;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface IDetentoSaidaTemporariaAppService : IDisposable
    {
        IEnumerable<DetentoSaidaTemporariaViewModel> GetAllByFilterReportSaidasPrevistas(ListaAmarelaFilterReportSaidasPrevistasViewModel listaAmarelaFilterReportSaidasPrevistasViewModel);
    }
}