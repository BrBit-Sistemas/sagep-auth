using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IContabilEventoAppService : IDisposable
    {
        Task<ValidationResult> Add(ContabilEventoViewModel contabilEventoViewModel);
        Task<ValidationResult> Update(ContabilEventoViewModel contabilEventoViewModel);
        IEnumerable<ContabilEventoViewModel> GetAll();
        int GetTotalActiveRecords();
        Task<IEnumerable<ContabilEventoViewModel>> GetAllAsync();
        Task<ValidationResult> Remove(Guid id);

        Task<DataTableServerSideResultViewModel<ContabilEventoViewModel>> GetAllWithDataTableResultAsync(DataTableServerSideRequest request);
    }
}