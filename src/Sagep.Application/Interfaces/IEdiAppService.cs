using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Cards;
using Sagep.Application.ViewModels.Detentos;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IEdiAppService : IDisposable
    {
        Task<EdiCardViewModel> GetInfoCardsAsync();
        Task<DataTableServerSideResult<EdiViewModel>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
    }
}