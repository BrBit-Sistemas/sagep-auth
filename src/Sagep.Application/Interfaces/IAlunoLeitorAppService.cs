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
    public interface IAlunoLeitorAppService : IDisposable
    {
        Task<IEnumerable<AlunoLeitorViewModel>> GetAllAsync();
        Task<IEnumerable<AlunoLeitorESViewModel>> GetAllForAddAsync();
        Task<ValidationResult> AddAsync(AlunoLeitorViewModel alunoLeitorViewModel);
        Task<ValidationResult> UpdateAsync(AlunoLeitorViewModel alunoLeitorViewModel);
        ValidationResult Remove(Guid id);
        IEnumerable<AlunoLeitorViewModel> GetAllWithInclude();
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalWithIgnoreQueryFilter();
        AlunoLeitorViewModel GetByDetentoIpen(int ipen);
        IEnumerable<AlunoLeitorViewModel> GetAllByDetentoNome(string nome);
        Task<DataTableServerSideResult<AlunoLeitorViewModel>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
    }
}