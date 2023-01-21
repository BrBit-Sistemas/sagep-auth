using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface ILancamentoAppService : IDisposable
    {
        ValidationResult Add(LancamentoViewModel lancamentoViewModel);
        ValidationResult Update(LancamentoViewModel lancamentoViewModel);
        IEnumerable<LancamentoViewModel> GetAll();
        IEnumerable<LancamentoViewModel> GetAllForFC();
        Task<IEnumerable<LancamentoViewModel>> GetAllAsync();
        Task<IEnumerable<LancamentoViewModel>> GetAllAsyncWithInclude();
        ValidationResult Remove(Guid id);
    }
}