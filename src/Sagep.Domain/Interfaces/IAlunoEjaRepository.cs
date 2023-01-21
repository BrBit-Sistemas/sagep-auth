using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IAlunoEjaRepository : IRepository<AlunoEja>
    {
        Task<IEnumerable<AlunoEja>> GetAllAsync(Guid tenantId);
        IEnumerable<AlunoEja> GetAllWithIncludes();
        AlunoEja GetByIdIncludes(Guid id);
        Int64 GetTotalAtivos();
        Task<Int64> GetTotalInativosAsync(Guid tenantId);
        Int64 GetTotalWithIgnoreQueryFilter();
        Task<Int64> GetTotalByFaseStatusAsync(Guid tenantId, AlunoEjaFaseStatusEnum faseStatus);
        Task<Int64> GetTotalByCursoAsync(Guid tenantId, CursoEnum curso);
        Task<Int64> GetTotalByTurnoPeriodoAsync(Guid tenantId,TurnoEnum turno);
        bool AlreadyAlunoEjaAtivoByIpen(int ipen);
        AlunoEja GetByDetentoIpen(int ipen);
        AlunoEja GetInativoByDetentoIpen(int ipen);
        AlunoEja GetAtivoOrInativoByDetentoIpen(int ipen);
        Task<AlunoEja> GetAsync(int ipen);
    }
}