using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using System.Numerics;
using Sagep.Domain.Enums;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IFormularioLeituraDicaEscritaRepository : IRepository<FormularioLeituraDicaEscrita>
    {
        Task<FormularioLeituraDicaEscrita> GetAsync(Guid id);
    }
}