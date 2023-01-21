using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IEdiRepository : IRepository<Edi>
    {
        new Task<IEnumerable<Edi>> GetAllAsync();
        Task<List<Edi>> GetInfoCardsAsync();
        Task<DataTableServerSideResult<Edi>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
    }
}