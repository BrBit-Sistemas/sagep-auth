using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IEmpresaConvenioRepository : IRepository<EmpresaConvenio>
    {
        Task<EmpresaConvenio> GetByIdWithChildrensAsync(Guid id);
        EmpresaConvenio GetByIdWithInclude(Guid id);
        Task<IEnumerable<EmpresaConvenio>> GetAllWithIncludeAsync();
        IEnumerable<EmpresaConvenio> GetAllWithInclude();
        EmpresaConvenio GetByEmpresaCnpj(string cnpj);
    }
}