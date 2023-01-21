using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface IEmpresaConvenioAppService : IDisposable
    {
        void Add(EmpresaConvenioViewModel empresaConvenioViewModel);
        void Update(EmpresaConvenioViewModel empresaConvenioViewModel);
        Task<IEnumerable<EmpresaConvenioViewModel>> GetAllAsync();
        IEnumerable<EmpresaConvenioViewModel> GetAll();
        IEnumerable<EmpresaConvenioViewModel> GetAllSoftDeleted();
        void Remove(Guid id);
        EmpresaConvenioViewModel GetByEmpresaCnpj(string cnpj);
    }
}