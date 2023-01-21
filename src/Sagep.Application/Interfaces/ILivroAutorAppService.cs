using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Detentos;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface ILivroAutorAppService : IDisposable
    {
        Task<LivroAutorViewModel> GetByIdAsync(int id);
        Task<LivroAutorViewModel> GetByIdAsyncIncludes(int id);
        LivroAutorViewModel GetByIdIncludes(string id);
        Task<IEnumerable<LivroAutorViewModel>> GetAllAsync();
        Task<IEnumerable<LivroAutorViewModel>> GetAllAsyncIncludes();
        IEnumerable<LivroAutorViewModel> GetAll();
        ValidationResult Add(LivroAutorViewModel livroViewModel);
        ValidationResult Remove(Guid id);
        ValidationResult Update(LivroAutorViewModel livroViewModel);
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalWithIgnoreQueryFilter();
    }
}