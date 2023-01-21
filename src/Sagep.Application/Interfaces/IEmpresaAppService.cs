using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface IEmpresaAppService : IDisposable
    {
        void Add(EmpresaViewModel empresaViewModel);
        void Update(EmpresaViewModel empresaViewModel);
        IEnumerable<EmpresaViewModel> GetAll();
        IEnumerable<EmpresaViewModel> GetAllSoftDeleted();
        Task<IEnumerable<EmpresaViewModel>> GetAllAsync();
        Task<IEnumerable<EmpresaViewModel>> GetAllAsyncDapper();
        void Remove(Guid id);
    }
}