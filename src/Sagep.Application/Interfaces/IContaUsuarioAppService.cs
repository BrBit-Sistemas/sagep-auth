using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;

namespace Sagep.Application.Interfaces
{
    public interface IContaUsuarioAppService : IDisposable
    {
        Task<ContaUsuarioViewModel> GetByIdAsync(Guid id);
        ContaUsuarioViewModel GetById(Guid id);
        ContaUsuarioViewModel GetByUserId(string userId);
        void Add(ContaUsuarioViewModel contaUsuarioViewModel);
        ValidationResult Update(ContaUsuarioViewModel contaUsuarioViewModel);
        Task<IEnumerable<ContaUsuarioViewModel>> GetAll();
        void Remove(Guid id);
    }
}