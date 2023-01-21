using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Reports;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IAlunoLeituraCronogramaAppService : IDisposable
    {
        IEnumerable<AlunoLeituraCronogramaViewModel> GetAll();
        Task<IEnumerable<AlunoLeituraCronogramaViewModel>> GetAllForSelect2Async();
        Task<AlunoLeituraCronogramaViewModel> GetByIdAsync(string id);
        AlunoLeituraCronogramaViewModel GetByIdIncludes(string id);
        Task<IEnumerable<AlunoLeituraCronogramaViewModel>> GetAllWithIncludeAsync();
        Task<ValidationResult> AddAsync(AlunoLeituraCronogramaViewModel alunoLeituraCronogramaViewModel);
        Task<ValidationResult> UpdateAsync(AlunoLeituraCronogramaViewModel alunoLeituraCronogramaViewModel);
        ValidationResult Remove(Guid id);
        Task<Int64> GetTotalAtivosAsync();
        Task<Int64> GetTotalInativosAsync();
        Task<Int64> GetTotalWithIgnoreQueryFilterAsync();
    }
}