using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IContabilEventoRepository : IRepository<ContabilEvento>
    {
        int GetTotalActiveRecords();
        Task<DataTableServerSideResult<ContabilEvento>> GetAllWithDataTableResultAsync(DataTableServerSideRequest request);
        ContabilEvento GetByEspecificacao (string especificacao);
    }
}