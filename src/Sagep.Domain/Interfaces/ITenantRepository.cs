using System;
using System.Threading.Tasks;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface ITenantRepository : IRepository<Tenant>
    {
        Task <string> GetTenantIdAsync(Guid apiKey);
        Task <string> GetTenantIdAsync();
        string GetTenantId(Guid apiKey);
        string GetTenantId();
        Task<string> GetNomeAsync(Guid tenantId);
        Task<Tenant> GetForOficioLeituraAsync(Guid tenantId);
    }
}