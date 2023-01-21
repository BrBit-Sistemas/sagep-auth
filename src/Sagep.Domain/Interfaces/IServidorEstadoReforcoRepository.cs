using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IServidorEstadoReforcoRepository : IRepository<ServidorEstadoReforco>
    {
        bool AlreadyReforcoForDate(Guid tenantId, DateTime date);
        Task<bool> AlreadyRuleSameMonthYear(Guid tenantId, int mesRegra, int anoRegra);
    }
}