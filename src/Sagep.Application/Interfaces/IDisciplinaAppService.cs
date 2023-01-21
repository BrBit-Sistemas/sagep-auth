using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Reports;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IDisciplinaAppService : IDisposable
    {
        ValidationResult Add(DisciplinaViewModel disciplinaViewModel);
        ValidationResult Update(DisciplinaViewModel disciplinaViewModel);
        ValidationResult Remove(Guid id);
        IEnumerable<DisciplinaViewModel> GetAllWithInclude();
        IEnumerable<DisciplinaViewModel> GetAll();
        Task<DisciplinaViewModel> GetByIdAsync(string id);
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalWithIgnoreQueryFilter();
    }
}