using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        Task<Empresa> GetByIdAsync(int id);

        Empresa GetByRazaoSocial(string razaoSocial);
    }
}