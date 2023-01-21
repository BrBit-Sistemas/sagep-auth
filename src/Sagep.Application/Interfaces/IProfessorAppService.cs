using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Cards;
using Sagep.Application.ViewModels.Detentos;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IProfessorAppService : IDisposable
    {
        Task<Int64> GetTotalInativosAsync();
        Task<IEnumerable<ProfessorViewModel>> GetAllAsync();
        Task<IEnumerable<string>> GetAllNomesAsync();
        Task<DataTableServerSideResult<ProfessorViewModel>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        Task<ProfessorCardViewModel> GetInfoCardsAsync();
        Task AddAsync(ProfessorViewModel professorViewModel);
        Task UpdateAsync(ProfessorViewModel professorViewModel);
        ValidationResult Remove(Guid id);
        Int64 GetTotalAtivos();
        Int64 GetTotalWithIgnoreQueryFilter();        
    }
}