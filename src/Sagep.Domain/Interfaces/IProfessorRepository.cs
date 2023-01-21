using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using System.Numerics;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IProfessorRepository : IRepository<Professor>
    {
        Task<Professor> GetAtivoInativoAsync(string cpf);
        Task<Int64> GetTotalInativosAsync(Guid tenantId);
        Task<IEnumerable<Professor>> GetAllAsync(Guid tenantId);
        Task<IEnumerable<string>> GetAllNomesAsync(Guid tenantId);
        Task<DataTableServerSideResult<Professor>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        Task<List<Professor>> GetInfoCardsAsync(Guid tenantId);
        Int64 GetTotalAtivos();
        Int64 GetTotalWithIgnoreQueryFilter();
        Task<Professor> GetByNomeAsync(Guid tenantId, string nome);
        Guid GetIdByNome(string nome);
        bool AlreadySameUserId(string applicationUserId);
        Task<bool> AlreadySameUserIdAsync(string applicationUserId, Guid id);
        Task<bool> AlreadyAtivoSameCPFAsync(string cpf, Guid id);
    }
}