using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IServidorEstadoReforcoRegraRepository : IRepository<ServidorEstadoReforcoRegra>
    {
        Task<bool> AlreadyRuleSameMonthYear(Guid tenantId, DateTime dia1, Guid? id);
        Task<ServidorEstadoReforcoRegra> GetAsync(Guid servidorEstadoId);
        Task<ServidorEstadoReforcoRegra> GetAsync(Guid tenantId, MonthOfYearEnum mesRegra, int anoRegra);
        new Task<ServidorEstadoReforcoRegra> GetByIdAsync(Guid id);
        Task<DataTableServerSideResult<ServidorEstadoReforcoRegra>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
    }
}