using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IAndamentoPenalRepository : IRepository<AndamentoPenal>
    {
        Task<DataTableServerSideResult<AndamentoPenal>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        AndamentoPenal GetByDetentoNome(string nome);
        AndamentoPenal GetByDetentoIpen(int ipen);
        AndamentoPenal GetByDetentoId(Guid id);
        Task<IEnumerable<AndamentoPenal>> GetAllOnlyIsDeletedTrue();      
        AndamentoPenal GetByIdWithIgnoreFilter(Guid id);
        IEnumerable<AndamentoPenal> GetAllWithIgnoreFilter();
        IEnumerable<AndamentoPenal> GetAllWithInclude();
        AndamentoPenal GetByIdWithInclude(Guid id);
        Int64 GetTotalByStatus(AndamentoPenalStatusEnum status);
        Int64 GetTotal();
        bool AlreadyAtivoByIpen(int ipen);
        AndamentoPenal RescueInactiveByIpen(int ipen);
        AndamentoPenal GetByIdWithouIncludes(Guid id);
    }
}